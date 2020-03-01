Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Speech

'======================================================
'[CD209] Managing and Implementation Business Project
'UCSI University Jan-Apr 2014
'Edward Ho Ka Yung 1001231876
'======================================================

'TO-DO
'Enhance coding style to OOP
'Add Custome music when alert occur
'Notification icon appear in taskbar when alert

'Voice Output
'Voice Input (Control system with voice)
'Updater (Check for update/new version)
'SMS
'Check for internet connection (Email internet connection check)
'CheckBox for Email Alert (Enable/Disable)
'Register Email String Check

Public Class frmMain

    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DSS_db.accdb")
    'Dim fRebootModem As Boolean = False

#Region "Form Dragable"
    'Form Dragable
    Dim bDrag As Boolean
    Dim iMouseX As Integer
    Dim iMouseY As Integer

    Private Sub frmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        bDrag = True
        iMouseX = Windows.Forms.Cursor.Position.X - Me.Left
        iMouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub frmMain_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If bDrag = True Then
            Me.Left = Windows.Forms.Cursor.Position.X - iMouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - iMouseY
        End If
    End Sub
    Private Sub frmMain_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        bDrag = False
    End Sub

    Private Sub CloudPictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles CloudPictureBox1.MouseDown
        bDrag = True
        iMouseX = Windows.Forms.Cursor.Position.X - Me.Left
        iMouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub CloudPictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles CloudPictureBox1.MouseMove
        If bDrag = True Then
            Me.Left = Windows.Forms.Cursor.Position.X - iMouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - iMouseY
        End If
    End Sub
    Private Sub CloudPictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles CloudPictureBox1.MouseUp
        bDrag = False
    End Sub
#End Region
#Region "Tray ToolStripMenuItem"
    Private Sub TrayNotifyIcon_DoubleClick(sender As Object, e As EventArgs) Handles TrayNotifyIcon.DoubleClick
        If Me.Visible = False Then
            Me.Show()
        End If
    End Sub
    Private Sub TopMostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopMostToolStripMenuItem.Click
        If TopMostToolStripMenuItem.Checked = False Then
            TopMostToolStripMenuItem.Checked = True
            Me.TopMost = True
        Else
            TopMostToolStripMenuItem.Checked = False
            Me.TopMost = False
        End If
    End Sub
    Private Sub TrayShowSchedulerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrayShowHideToolStripMenuItem.Click
        If Me.Visible = False Then
            Me.Show()
        End If
    End Sub
    Private Sub TrayExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrayExitToolStripMenuItem.Click, ExitToolStripMenuItem.Click, btnExit.Click
        Dim ask = MessageBox.Show("Scheduler would not run at proper time." & vbNewLine & "Are you sure want to quit?", "Confirm Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If ask = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub
#End Region
#Region "Date and Time Timer"
    Private Sub DateTimeTimer_Tick(sender As Object, e As EventArgs) Handles DateTimeTimer.Tick
        Dim datenow As Date = Now
        Me.DateTimeToolStripStatusLabel.Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
    End Sub
#End Region

    Public Sub vShowBalloonTip(timeout As String, subject As String, text As String)
        TrayNotifyIcon.ShowBalloonTip(timeout, subject, text, ToolTipIcon.Info)
    End Sub
    Private Sub vLoadStickyNote()
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim strAskUsername As String = frmLogin.txtLUsername.Text.ToString()
            Dim sql_statement As String = "SELECT * FROM tblUser WHERE Username = @Username"
            Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
            With cmd.Parameters
                .AddWithValue("@Username", strAskUsername)
            End With
            Dim rdr As OleDbDataReader = cmd.ExecuteReader()
            rdr.Read()

            If rdr.HasRows() Then
                txtStickyNotes.Text = rdr("StickyNote").ToString()
            End If

            '// [LOAD] StickyNoteFont
            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Profile\" & frmLogin.txtLUsername.Text.ToString() & ".dat") Then
                Exit Sub
            Else
                Dim CReader As New StreamReader(Application.StartupPath & "\Profile\" & frmLogin.txtLUsername.Text.ToString() & ".dat")
                txtStickyNotes.Font = New Font(CReader.ReadLine(), CType(CReader.ReadLine(), Single), CType(CReader.ReadLine(), System.Drawing.FontStyle))
                txtStickyNotes.ForeColor = System.Drawing.Color.FromArgb(CReader.ReadLine())
                CReader.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub vSaveStickyNote()
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim sql_statement As String = "UPDATE tblUser SET StickyNote = @StickyNote WHERE Username = @Username"
            Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
            With cmd.Parameters
                .AddWithValue("@StickyNote", txtStickyNotes.Text.ToString())
                .AddWithValue("@Username", frmLogin.txtLUsername.Text.ToString())
            End With
            cmd.ExecuteNonQuery()

            '// [SAVE] StickyNoteFont
            If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Profile") Then
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Profile")
            End If
            Dim CWriter As New StreamWriter(Application.StartupPath & "\Profile\" & frmLogin.txtLUsername.Text.ToString() & ".dat")
            CWriter.WriteLine(txtStickyNotes.Font.Name)
            CWriter.WriteLine(txtStickyNotes.Font.Size)
            CWriter.WriteLine(txtStickyNotes.Font.Style)
            CWriter.WriteLine(txtStickyNotes.ForeColor.ToArgb.ToString)
            CWriter.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub vLoadChangedLog()
        Dim CWebClient As New WebClient()
        Dim content = CWebClient.DownloadString("https://dl.dropboxusercontent.com/u/95516314/DSS_ChangedLog.txt")
        txtChangedLog.Text = content
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vShowBalloonTip(8000, "Processing...", "Retrieving ChangedLog")
        If frmLogin.Visible = True Then
            frmLogin.Visible = False
        End If
        ScheduleAlertWatcherTimer.Start()
        ScheduleTaskWatcherTimer.Start()
        ScheduleClassWatcherTimer.Start()
        frmSAAdd.vInstantUpdate_lvScheduleAlert()
        frmSTAdd.vInstantUpdate_lvScheduleTask()
        frmSCAdd.vInstantUpdate_lvScheduleClass()
        vLoadStickyNote()
        'vLoadChangedLog()
    End Sub
    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        vSaveStickyNote()
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click, HideToolStripMenuItem.Click
        Me.Hide()
    End Sub
    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click, SettingsToolStripMenuItem.Click
        frmSettings.ShowDialog()
    End Sub
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click, AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click, LogoutToolStripMenuItem.Click
        Dim logout As String = MessageBox.Show("Scheduler would not run at proper time." & vbNewLine & "Logout from application?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If logout = DialogResult.Yes Then
            Try
                If Not conn.State = ConnectionState.Open Then
                    conn.Open()
                End If

                Dim sql_statement As String = "SELECT * FROM tblUser WHERE LoggedIn = @LoggedIn"
                Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
                cmd.Parameters.AddWithValue("@LoggedIn", "True")

                Dim rdr As OleDbDataReader = cmd.ExecuteReader
                rdr.Read()

                If rdr.HasRows = True Then
                    Dim sql_statement1 As String = "UPDATE tblUser SET [LoggedIn] = @LoggedIn WHERE [Username] = @Username"
                    Dim cmd1 As OleDbCommand = New OleDbCommand(sql_statement1, conn)
                    With cmd1.Parameters
                        .AddWithValue("@LoggedIn", "False")
                        .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                    End With
                    cmd1.ExecuteNonQuery()

                    Me.Close()
                    With frmLogin
                        .txtLUsername.Clear()
                        .txtLPassword.Clear()
                        .cbStayLogin.Checked = False
                        .Show()
                        .txtLUsername.Focus()
                    End With
                Else
                    Me.Close()
                    With frmLogin
                        .txtLUsername.Clear()
                        .txtLPassword.Clear()
                        .cbStayLogin.Checked = False
                        .Show()
                        .txtLUsername.Focus()
                    End With
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
            Finally
                If Not conn.State = ConnectionState.Closed Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub

#Region "Schedule Alert"
    Public tmpSASubject As String
    Public tmpSANote As String

    Private Sub AddSAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSAToolStripMenuItem.Click
        frmSAAdd.ShowDialog()
    End Sub
    Private Sub EditSAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSAToolStripMenuItem.Click
        If lvScheduleAlert.SelectedItems.Count > 0 Then
            With frmSAAdd
                .Label1.Text = "Edit Schedule"
                .txtSubject.Text = lvScheduleAlert.SelectedItems(0).SubItems(0).Text
                .txtNote.Text = lvScheduleAlert.SelectedItems(0).SubItems(1).Text
                .btnAdd.Text = "Edit"
            End With
            tmpSASubject = frmSAAdd.txtSubject.Text
            tmpSANote = frmSAAdd.txtNote.Text
            frmSAAdd.Show()
        Else
            MessageBox.Show("Please select a record before clicking edit", "Edit Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub DeleteSAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSAToolStripMenuItem.Click
        Try
            If lvScheduleAlert.SelectedItems.Count > 0 Then
                Dim a As String = MessageBox.Show("Delete Selected Item?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If a = DialogResult.Yes Then
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    Dim sql_statement As String = "DELETE FROM tblScheduleAlert WHERE Subject='" & lvScheduleAlert.SelectedItems.Item(0).SubItems(0).Text & "'"
                    Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Removed Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    System.Threading.Thread.Sleep(400)
                    frmSAAdd.vInstantUpdate_lvScheduleAlert()
                End If
            Else
                MessageBox.Show("Please select a record before clicking delete", "Delete Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            'Catch ex As ArgumentOutOfRangeException
            'MessageBox.Show("Please select a record before clicking delete", "Delete Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub ScheduleAlertWatcherTimer_Tick(sender As Object, e As EventArgs) Handles ScheduleAlertWatcherTimer.Tick
        If btnRebootModem.Text = "True" Then
            If dtpRebootModem.Text = DateTime.Now.ToLongTimeString Then
                RebootModem()
                tRebootModem.Enabled = True
                If tRebootModem.Enabled = True Then
                    lblRebootStatus.Text = True
                Else
                    lblRebootStatus.Text = False
                End If
            End If
        Else
            tRebootModem.Enabled = False
            lblRebootStatus.Text = False
        End If

        lblRebootStatus.Text = tRebootModem.Enabled

        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim DT As New DataTable("tblScheduleAlert")
            Dim DA As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM tblScheduleAlert WHERE Date='" & DateTime.Now.ToLongDateString & "'", conn)
            DA.Fill(DT)

            For i = 0 To DT.Rows.Count - 1
                If DT.Rows(i).Item(4) = DateTime.Now.ToLongTimeString Then
                    Dim CAlert As New frmAlert()

                    CAlert.lblSubject.Text = DT.Rows(i).Item(1)
                    CAlert.txtNote.Text = DT.Rows(i).Item(2)
                    CAlert.lblDate.Text = DT.Rows(i).Item(3)
                    CAlert.lblTime.Text = DT.Rows(i).Item(4)

                    CAlert.Show()
                    CAlert.Update()
                    Me.TabControl1.SelectTab(0)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub lvScheduleAlert_Enter(sender As Object, e As EventArgs) Handles lvScheduleAlert.Enter
        lblScheduleAlertHelp.Visible = False
    End Sub
    Private Sub lvScheduleAlert_Leave(sender As Object, e As EventArgs) Handles lvScheduleAlert.Leave
        lblScheduleAlertHelp.Visible = True
    End Sub
#End Region

#Region "Schedule Task"
    Public tmpSTType As String
    Public tmpSTNote As String
    Public tmpSTDay As String

    Private Sub AddSTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddSTToolStripMenuItem1.Click
        frmSTAdd.ShowDialog()
    End Sub
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If lvScheduleTask.SelectedItems.Count > 0 Then
            'Type [comboBox]
            If lvScheduleTask.SelectedItems(0).SubItems(0).Text <> "Event" And lvScheduleTask.SelectedItems(0).SubItems(0).Text <> "Task" Then
                frmSTAdd.cmbType.SelectedIndex = "2"
                frmSTAdd.txtType.Text = lvScheduleTask.SelectedItems(0).SubItems(0).Text
                tmpSTType = frmSTAdd.txtType.Text
            Else
                frmSTAdd.cmbType.SelectedItem = lvScheduleTask.SelectedItems(0).SubItems(0).Text
                tmpSTType = frmSTAdd.cmbType.SelectedItem
            End If

            With frmSTAdd
                .Label1.Text = "Edit Task"
                .txtNote.Text = lvScheduleTask.SelectedItems(0).SubItems(1).Text
                .cmbDay.SelectedItem = lvScheduleTask.SelectedItems(0).SubItems(2).Text
                .btnAdd.Text = "Edit"
            End With
            tmpSTNote = frmSTAdd.txtNote.Text
            tmpSTDay = frmSTAdd.cmbDay.SelectedItem
            frmSTAdd.Show()
        Else
            MessageBox.Show("Please select a record before clicking edit", "Edit Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub DeleteSTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSTToolStripMenuItem.Click
        Try
            If lvScheduleTask.SelectedItems.Count > 0 Then
                Dim a As String = MessageBox.Show("Delete Selected Item?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If a = DialogResult.Yes Then
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    Dim sql_statement As String = "DELETE FROM tblScheduleTask WHERE Note='" & lvScheduleTask.SelectedItems.Item(0).SubItems(1).Text & "'"
                    Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Removed Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    System.Threading.Thread.Sleep(400)
                    frmSTAdd.vInstantUpdate_lvScheduleTask()
                End If
            Else
                MessageBox.Show("Please select a record before clicking delete", "Delete Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            'Catch ex As ArgumentOutOfRangeException
            'MessageBox.Show("Please select a record before clicking delete", "Delete Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub ScheduleTaskWatcherTimer_Tick(sender As Object, e As EventArgs) Handles ScheduleTaskWatcherTimer.Tick
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim DT As New DataTable("tblScheduleTask")
            Dim DA As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM tblScheduleTask WHERE Day='" & Date.Today.DayOfWeek.ToString() & "'", conn)
            DA.Fill(DT)

            For i = 0 To DT.Rows.Count - 1
                If DT.Rows(i).Item(3) = Date.Today.DayOfWeek.ToString() And DT.Rows(i).Item(4) = DateTime.Now.ToLongTimeString Then
                    Dim CAlert As New frmAlert()

                    CAlert.lblSubject.Text = DT.Rows(i).Item(1)
                    CAlert.txtNote.Text = DT.Rows(i).Item(2)
                    CAlert.lblDate.Text = DT.Rows(i).Item(3)
                    CAlert.lblTime.Text = DT.Rows(i).Item(4)

                    CAlert.Show()
                    CAlert.Update()
                    Me.TabControl1.SelectTab(1)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub lvScheduleTask_Enter(sender As Object, e As EventArgs) Handles lvScheduleTask.Enter
        lblScheduleTaskHelp.Visible = False
    End Sub
    Private Sub lvScheduleTask_Leave(sender As Object, e As EventArgs) Handles lvScheduleTask.Leave
        lblScheduleTaskHelp.Visible = True
    End Sub
#End Region

#Region "Schedule Class"
    Public tmpSCType As String
    Public tmpSCCourse As String
    Public tmpSCVenue As String
    Public tmpSCDay As String

    Private Sub AddSCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSCToolStripMenuItem.Click
        frmSCAdd.ShowDialog()
    End Sub
    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        If lvScheduleClass.SelectedItems.Count > 0 Then
            'Type [comboBox]
            If lvScheduleClass.SelectedItems(0).SubItems(0).Text <> "Lecture" And lvScheduleClass.SelectedItems(0).SubItems(0).Text <> "Tutorial" And lvScheduleClass.SelectedItems(0).SubItems(0).Text <> "Lab" And lvScheduleClass.SelectedItems(0).SubItems(0).Text <> "Other..." Then
                frmSCAdd.cmbType.SelectedIndex = "3"
                frmSTAdd.txtType.Text = lvScheduleClass.SelectedItems(0).SubItems(0).Text
                tmpSCType = frmSCAdd.txtType.Text
            Else
                frmSCAdd.cmbType.SelectedItem = lvScheduleClass.SelectedItems(0).SubItems(0).Text
                tmpSCType = frmSCAdd.cmbType.SelectedItem
            End If

            With frmSCAdd
                .Label1.Text = "Edit Class"
                .txtCourse.Text = lvScheduleClass.SelectedItems(0).SubItems(1).Text
                .txtVenue.Text = lvScheduleClass.SelectedItems(0).SubItems(2).Text
                .cmbDay.SelectedItem = lvScheduleClass.SelectedItems(0).SubItems(3).Text
                .btnAdd.Text = "Edit"
            End With
            tmpSCCourse = frmSCAdd.txtCourse.Text
            tmpSCVenue = frmSCAdd.txtVenue.Text
            tmpSCDay = frmSCAdd.cmbDay.SelectedItem
            frmSCAdd.Show()
        Else
            MessageBox.Show("Please select a record before clicking edit", "Edit Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub DeleteSCToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DeleteSCToolStripMenuItem.Click
        Try
            If lvScheduleClass.SelectedItems.Count > 0 Then
                Dim a As String = MessageBox.Show("Delete Selected Item?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If a = DialogResult.Yes Then
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    Dim sql_statement As String = "DELETE FROM tblScheduleClass WHERE Venue='" & lvScheduleClass.SelectedItems.Item(0).SubItems(2).Text & "'"
                    Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Removed Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    System.Threading.Thread.Sleep(400)
                    frmSCAdd.vInstantUpdate_lvScheduleClass()
                End If
            Else
                MessageBox.Show("Please select a record before clicking delete", "Delete Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            'Catch ex As ArgumentOutOfRangeException
            'MessageBox.Show("Please select a record before clicking delete", "Delete Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.ToString() & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub ScheduleClassWatcherTimer_Tick(sender As Object, e As EventArgs) Handles ScheduleClassWatcherTimer.Tick
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim DT As New DataTable("tblScheduleClass")
            Dim DA As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM tblScheduleClass WHERE Day='" & Date.Today.DayOfWeek.ToString() & "'", conn)
            DA.Fill(DT)

            For i = 0 To DT.Rows.Count - 1
                If DT.Rows(i).Item(4) = Date.Today.DayOfWeek.ToString() And DT.Rows(i).Item(5) = DateTime.Now.ToLongTimeString Then
                    Dim CAlert As New frmAlert()

                    CAlert.lblSubject.Text = DT.Rows(i).Item(2) 'Course
                    CAlert.txtNote.Text = DT.Rows(i).Item(3) 'Venue
                    CAlert.lblDate.Text = DT.Rows(i).Item(4) 'Day
                    CAlert.lblTime.Text = DT.Rows(i).Item(5) 'StartTime

                    CAlert.Show()
                    CAlert.Update()
                    Me.TabControl1.SelectTab(2)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub lvScheduleClass_Enter(sender As Object, e As EventArgs) Handles lvScheduleClass.Enter
        lblScheduleClassHelp.Visible = False
    End Sub
    Private Sub lvScheduleClass_Leave(sender As Object, e As EventArgs) Handles lvScheduleClass.Leave
        lblScheduleClassHelp.Visible = True
    End Sub
#End Region

#Region "StickyNotes"
    Private Sub ChangeFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeFontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        txtStickyNotes.Font = FontDialog1.Font()
    End Sub
    Private Sub ChangeColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        txtStickyNotes.ForeColor = ColorDialog1.Color()
    End Sub
    Private Sub txtStickyNotes_Enter(sender As Object, e As EventArgs) Handles txtStickyNotes.Enter
        lblStickyNoteHelp.Visible = False
    End Sub
    Private Sub txtStickyNotes_Leave(sender As Object, e As EventArgs) Handles txtStickyNotes.Leave
        lblStickyNoteHelp.Visible = True
    End Sub
    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Dim answer As String = MessageBox.Show("Are you sure want to clear all content in sticky note?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            txtStickyNotes.Clear()
        End If
    End Sub
#End Region

    Private Sub btnRebootModem_Click(sender As Object, e As EventArgs) Handles btnRebootModem.Click
        If btnRebootModem.Text = "False" Then
            'Button
            btnRebootModem.Text = "True"
            btnRebootModem.ForeColor = Color.Green
            'Label
            'lblRebootStatus.Text = "Enable"
            lblRebootStatus.ForeColor = Color.Green
            'TextBox
            txtRebootTime.Enabled = False
            'DateTimePicker
            dtpRebootModem.Enabled = False

            'fRebootModem = True
            'tRebootModem.Start()
        Else
            'Button
            btnRebootModem.Text = "False"
            btnRebootModem.ForeColor = Color.Red
            'Label
            'lblRebootStatus.Text = "Disable"
            lblRebootStatus.ForeColor = Color.Red
            'TextBox
            txtRebootTime.Enabled = True
            'DateTimePicker
            dtpRebootModem.Enabled = True

            'fRebootModem = False
            'tRebootModem.Stop()
        End If
    End Sub
    Private Sub RebootModem()
        System.Diagnostics.Process.Start("C:\Users\E\Desktop\tst10\RebootPatch.bat")
    End Sub

    Private Sub tRebootModem_Tick(sender As Object, e As EventArgs) Handles tRebootModem.Tick
        RebootModem()
    End Sub
End Class