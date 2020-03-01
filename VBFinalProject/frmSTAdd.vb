Imports System.Data.OleDb

Public Class frmSTAdd
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

    Public Sub vInstantUpdate_lvScheduleTask()
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim DT As New DataTable("tblScheduleTask")
            Dim DA As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM tblScheduleTask WHERE Username='" & frmLogin.txtLUsername.Text & "'", conn)
            DA.Fill(DT)

            Dim i As Integer
            frmMain.lvScheduleTask.Items.Clear()
            For i = 0 To DT.Rows.Count - 1
                Dim lv As New ListViewItem
                lv.Text = DT.Rows(i).Item(1) 'Type
                lv.SubItems.Add(DT.Rows(i).Item(2)) 'Note
                lv.SubItems.Add(DT.Rows(i).Item(3)) 'Day
                lv.SubItems.Add(DT.Rows(i).Item(4)) 'Time
                frmMain.lvScheduleTask.Items.Add(lv)
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
            If cmbType.SelectedIndex = -1 Or txtNote.Text = Nothing Or cmbDay.SelectedIndex = -1 Then
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

                Dim sql_statement As String = "INSERT INTO tblScheduleTask([Username],[Type], [Note], [Day], [Time]) VALUES (@Username, @Type, @Note, @Day, @Time)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
                With cmd.Parameters
                    .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                    .AddWithValue("@Type", strType)
                    .AddWithValue("@Note", txtNote.Text)
                    .AddWithValue("@Day", strDay)
                    .AddWithValue("@Time", TimePicker.Text)
                End With
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Successfully Added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                vInstantUpdate_lvScheduleTask()

                cmbType.SelectedItem = "Event"
                cmbDay.SelectedItem = "Monday"
                txtType.Clear()
                txtNote.Clear()
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

            Dim mysql_statement As String = "SELECT * FROM tblScheduleTask WHERE Username = @Username AND Type = @Type AND Note = @Note AND Day = @Day"
            Dim cmd As OleDbCommand = New OleDbCommand(mysql_statement, conn)
            With cmd.Parameters
                .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                .AddWithValue("@Type", frmMain.tmpSTType)
                .AddWithValue("@Note", frmMain.tmpSTNote)
                .AddWithValue("@Day", frmMain.tmpSTDay)
            End With

            Dim rdr As OleDbDataReader = cmd.ExecuteReader()
            rdr.Read()

            If cmbType.SelectedItem = "Other..." Then
                strType = txtType.Text
            Else
                strType = cmbType.SelectedItem
            End If

            If rdr.HasRows = True Then
                Dim mysql_statement1 As String = "UPDATE tblScheduleTask SET [Type] = @Type, [Note] = @Note, [Day] = @Day, [Time] = @Time WHERE [Username] = @Username AND [Type] = @refType AND [Note] = @refNote AND [Day] = @refDay"
                Dim cmd1 As OleDbCommand = New OleDbCommand(mysql_statement1, conn)
                With cmd1.Parameters
                    .AddWithValue("@Type", strType)
                    .AddWithValue("@Note", Me.txtNote.Text)
                    .AddWithValue("@Day", Me.cmbDay.SelectedItem)
                    .AddWithValue("@Time", Me.TimePicker.Text)
                    .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                    .AddWithValue("@refType", frmMain.tmpSTType)
                    .AddWithValue("@refNote", frmMain.tmpSTNote)
                    .AddWithValue("@refDay", frmMain.tmpSTDay)
                End With
                cmd1.ExecuteNonQuery()

                MessageBox.Show("Data Successfully Edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information)
                vInstantUpdate_lvScheduleTask()

                txtType.Clear()
                txtNote.Clear()
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

            'strType = txtType.Text
        Else
            txtType.Visible = False
            txtType.Enabled = False
            txtType.BackColor = Color.Violet

            'strType = cmbType.SelectedItem
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
            cmbType.SelectedItem = "Event"
            txtType.Clear()
            txtNote.Clear()
        End If
    End Sub

End Class