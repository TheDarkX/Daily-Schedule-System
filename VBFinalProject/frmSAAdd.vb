Imports System.Data.OleDb

Public Class frmSAAdd
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DSS_db.accdb")

#Region "Form Dragable"
    'Form Dragable
    Dim bDrag As Boolean
    Dim iMouseX As Integer
    Dim iMouseY As Integer

    Private Sub frmSAAdd_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        bDrag = True
        iMouseX = Windows.Forms.Cursor.Position.X - Me.Left
        iMouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub frmSAAdd_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If bDrag = True Then
            Me.Left = Windows.Forms.Cursor.Position.X - iMouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - iMouseY
        End If
    End Sub
    Private Sub frmSAAdd_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
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

    Public Sub vInstantUpdate_lvScheduleAlert()
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim DT As New DataTable("tblScheduleAlert")
            Dim DA As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM tblScheduleAlert WHERE Username='" & frmLogin.txtLUsername.Text & "'", conn)
            DA.Fill(DT)

            Dim i As Integer
            frmMain.lvScheduleAlert.Items.Clear()
            For i = 0 To DT.Rows.Count - 1
                Dim lv As New ListViewItem
                lv.Text = DT.Rows(i).Item(1) 'Subject
                lv.SubItems.Add(DT.Rows(i).Item(2)) 'Note
                lv.SubItems.Add(DT.Rows(i).Item(3)) 'Date
                lv.SubItems.Add(DT.Rows(i).Item(4)) 'Time
                frmMain.lvScheduleAlert.Items.Add(lv)
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
            If txtSubject.Text = Nothing Or txtNote.Text = Nothing Then
                MessageBox.Show("Please fill in all the blank", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Not conn.State = ConnectionState.Open Then
                    conn.Open()
                End If

                Dim sql_statement As String = "INSERT INTO tblScheduleAlert([Username], [Subject], [Note], [Date], [Time]) VALUES (@Username, @Subject, @Note, @Date, @Time)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
                With cmd.Parameters
                    .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                    .AddWithValue("@Subject", txtSubject.Text)
                    .AddWithValue("@Note", txtNote.Text)
                    .AddWithValue("@Date", DatePicker.Text)
                    .AddWithValue("@Time", TimePicker.Text)
                End With
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Successfully Added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                vInstantUpdate_lvScheduleAlert()

                txtSubject.Clear()
                txtNote.Clear()
                txtSubject.Focus()
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

            Dim mysql_statement As String = "SELECT * FROM tblScheduleAlert WHERE Username = @Username AND Subject = @Subject AND Note = @Note"
            Dim cmd As OleDbCommand = New OleDbCommand(mysql_statement, conn)
            With cmd.Parameters
                .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                .AddWithValue("@Subject", frmMain.tmpSASubject)
                .AddWithValue("@Note", frmMain.tmpSANote)
            End With

            Dim rdr As OleDbDataReader = cmd.ExecuteReader
            rdr.Read()

            If rdr.HasRows = True Then
                Dim mysql_statement1 As String = "UPDATE tblScheduleAlert SET [Subject] = @Subject, [Note] = @Note, [Date] = @Date, [Time] = @Time WHERE [Username] = @Username AND [Subject] = @refSubject AND [Note] = @refNote"
                Dim cmd1 As OleDbCommand = New OleDbCommand(mysql_statement1, conn)
                With cmd1.Parameters
                    .AddWithValue("@Subject", Me.txtSubject.Text)
                    .AddWithValue("@Note", txtNote.Text)
                    .AddWithValue("@Date", DatePicker.Text)
                    .AddWithValue("@Time", TimePicker.Text)
                    .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                    .AddWithValue("@refSubject", frmMain.tmpSASubject)
                    .AddWithValue("@refNote", frmMain.tmpSANote)
                End With
                cmd1.ExecuteNonQuery()

                MessageBox.Show("Data Successfully Edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information)
                vInstantUpdate_lvScheduleAlert()

                txtSubject.Clear()
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
            txtSubject.Clear()
            txtNote.Clear()
        End If
    End Sub
End Class