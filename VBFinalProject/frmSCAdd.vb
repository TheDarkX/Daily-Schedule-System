Imports System.Data.OleDb

Public Class frmSCAdd
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DSS_db.accdb")
    Dim strType, strDay As String

#Region "Form Dragable"
    'Form Dragable
    Dim bDrag As Boolean
    Dim iMouseX As Integer
    Dim iMouseY As Integer

    Private Sub frmTMAdd_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        bDrag = True
        iMouseX = Windows.Forms.Cursor.Position.X - Me.Left
        iMouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub frmTMAdd_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If bDrag = True Then
            Me.Left = Windows.Forms.Cursor.Position.X - iMouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - iMouseY
        End If
    End Sub
    Private Sub frmTMAdd_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        bDrag = False
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        bDrag = True
        iMouseX = Windows.Forms.Cursor.Position.X - Me.Left
        iMouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If bDrag = True Then
            Me.Left = Windows.Forms.Cursor.Position.X - iMouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - iMouseY
        End If
    End Sub
    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        bDrag = False
    End Sub
#End Region

    Private Sub frmSCAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cmbType.SelectedIndex = 0
        'cmbDay.SelectedIndex = 0
    End Sub

    Public Sub vInstantUpdate_lvScheduleClass()
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim DT As New DataTable("tblScheduleClass")
            Dim DA As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM tblScheduleClass WHERE Username='" & frmLogin.txtLUsername.Text & "'", conn)
            DA.Fill(DT)

            Dim i As Integer
            frmMain.lvScheduleClass.Items.Clear()
            For i = 0 To DT.Rows.Count - 1
                Dim lv As New ListViewItem
                lv.Text = DT.Rows(i).Item(1) 'Type
                lv.SubItems.Add(DT.Rows(i).Item(2)) 'Course
                lv.SubItems.Add(DT.Rows(i).Item(3)) 'Venue
                lv.SubItems.Add(DT.Rows(i).Item(4)) 'Day
                lv.SubItems.Add(DT.Rows(i).Item(5)) 'StartTime
                lv.SubItems.Add(DT.Rows(i).Item(6)) 'EndTime
                frmMain.lvScheduleClass.Items.Add(lv)
            Next
            DA.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub vAdd()
        Try
            If cmbType.SelectedIndex = -1 Or txtCourse.Text = Nothing Or txtVenue.Text = Nothing Or cmbDay.SelectedIndex = -1 Then
                MessageBox.Show("Please fill in all the blank", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Not conn.State = ConnectionState.Open Then
                    conn.Open()
                End If

                If cmbType.SelectedItem = "Other..." Then
                    strType = txtType.Text.ToString()
                Else
                    strType = cmbType.SelectedItem
                End If

                Dim sql_statement As String = "INSERT INTO tblScheduleClass([Username],[Type], [Course], [Venue], [Day], [StartTime], [EndTime]) VALUES (@Username, @Type, @Course, @Venue, @Day, @StartTime, @EndTime)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
                With cmd.Parameters
                    .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                    .AddWithValue("@Type", strType)
                    .AddWithValue("@Course", txtCourse.Text)
                    .AddWithValue("@Venue", txtVenue.Text)
                    .AddWithValue("@Day", strDay)
                    .AddWithValue("@StartTime", FromTimePicker.Text)
                    .AddWithValue("@EndTime", ToTimePicker.Text)
                End With
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Successfully Added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                vInstantUpdate_lvScheduleClass()

                cmbType.SelectedIndex = 0
                cmbDay.SelectedIndex = 0
                txtType.Clear()
                txtCourse.Clear()
                txtVenue.Clear()
                cmbType.Focus()
            End If
        Catch ex As OleDbException
            MessageBox.Show("[Duplicate Record Found]" & vbNewLine & vbNewLine & ex.Message(), "Error")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub vEdit()
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim mysql_statement As String = "SELECT * FROM tblScheduleClass WHERE Username = @Username AND Type = @Type AND Course = @Course AND Venue = @Venue AND Day = @Day"
            Dim cmd As OleDbCommand = New OleDbCommand(mysql_statement, conn)
            With cmd.Parameters
                .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                .AddWithValue("@Type", frmMain.tmpSCType)
                .AddWithValue("@Course", frmMain.tmpSCCourse)
                .AddWithValue("@Venue", frmMain.tmpSCVenue)
                .AddWithValue("@Day", frmMain.tmpSCDay)
            End With

            Dim rdr As OleDbDataReader = cmd.ExecuteReader()
            rdr.Read()

            If cmbType.SelectedItem = "Other..." Then
                strType = txtType.Text
            Else
                strType = cmbType.SelectedItem
            End If

            If rdr.HasRows = True Then
                Dim mysql_statement1 As String = "UPDATE tblScheduleClass SET [Type] = @Type, [Course] = @Course, [Venue] = @Venue, [Day] = @Day, [StartTime] = @StartTime, [EndTime] = @EndTime WHERE [Username] = @Username AND [Type] = @refType AND [Course] = @refCourse AND [Venue] = @refVenue AND [Day] = @refDay"
                Dim cmd1 As OleDbCommand = New OleDbCommand(mysql_statement1, conn)
                With cmd1.Parameters
                    .AddWithValue("@Type", strType)
                    .AddWithValue("@Course", Me.txtCourse.Text)
                    .AddWithValue("@Venue", Me.txtVenue.Text)
                    .AddWithValue("@Day", Me.cmbDay.SelectedItem)
                    .AddWithValue("@StartTime", Me.FromTimePicker.Text)
                    .AddWithValue("@EndTime", Me.ToTimePicker.Text)
                    .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                    .AddWithValue("@refType", frmMain.tmpSCType)
                    .AddWithValue("@refCourse", frmMain.tmpSCCourse)
                    .AddWithValue("@refVenue", frmMain.tmpSCVenue)
                    .AddWithValue("@refDay", frmMain.tmpSCDay)
                End With
                cmd1.ExecuteNonQuery()

                MessageBox.Show("Data Successfully Edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information)
                vInstantUpdate_lvScheduleClass()

                txtType.Clear()
                txtCourse.Clear()
                txtVenue.Clear()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.SelectedItem = "Other..." Then
            txtType.Visible = True
            txtType.Enabled = True
            txtType.BackColor = Color.Black
        Else
            txtType.Visible = False
            txtType.Enabled = False
            txtType.BackColor = Color.Tomato
        End If
    End Sub
    Private Sub cmbDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDay.SelectedIndexChanged
        strDay = cmbDay.SelectedItem
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.btnAdd.Text = "Add" Then
            vAdd()
        ElseIf Me.btnAdd.Text = "Edit" Then
            vEdit()
        Else
            MessageBox.Show("Unknown error occurred")
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result = MessageBox.Show("No data will be added." & vbNewLine & "Confirm Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            cmbType.SelectedIndex = 0
            cmbDay.SelectedIndex = 0
            txtType.Clear()
            txtCourse.Clear()
            txtVenue.Clear()
        End If
    End Sub

End Class