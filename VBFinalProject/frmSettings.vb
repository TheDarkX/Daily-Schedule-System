Imports System.Data.OleDb

Public Class frmSettings

    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DSS_db.accdb")

#Region "Form Dragable"
    'Form Dragable
    Dim bDrag As Boolean
    Dim iMouseX As Integer
    Dim iMouseY As Integer

    Private Sub frmSetting_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        bDrag = True
        iMouseX = Windows.Forms.Cursor.Position.X - Me.Left
        iMouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub frmSetting_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If bDrag = True Then
            Me.Left = Windows.Forms.Cursor.Position.X - iMouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - iMouseY
        End If
    End Sub
    Private Sub frmSetting_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
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

    Private Sub vChangePassword()
        Try
            If txtOldPassword.Text = Nothing Or txtNewPassword.Text = Nothing Or txtVerifyNewPassword.Text = Nothing Then
                MessageBox.Show("Please fill in the blank", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf txtNewPassword.Text <> txtVerifyNewPassword.Text Then
                MessageBox.Show("New Password & Verify Password not match", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Not conn.State = ConnectionState.Open Then
                    conn.Open()
                End If

                Dim sql_statement As String = "SELECT * FROM tblUser WHERE Username = @Username"
                Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
                cmd.Parameters.AddWithValue("@Username", frmLogin.txtLUsername.Text)

                Dim rdr As OleDbDataReader = cmd.ExecuteReader()
                rdr.Read()

                If rdr.HasRows = True Then
                    If txtOldPassword.Text = rdr("Password").ToString() Then
                        Dim sql_statement1 As String = "UPDATE tblUser SET [Password] = @Password WHERE [Username] = @Username"
                        Dim cmd1 As OleDbCommand = New OleDbCommand(sql_statement1, conn)
                        With cmd1.Parameters
                            .AddWithValue("@Password", txtNewPassword.Text)
                            .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                        End With
                        cmd1.ExecuteNonQuery()

                        MessageBox.Show("Password Updated Successfully", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtOldPassword.Clear()
                        txtNewPassword.Clear()
                        txtVerifyNewPassword.Clear()
                        txtOldPassword.Focus()
                    Else
                        MessageBox.Show("Old Password Incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub btnCPSubmit_Click(sender As Object, e As EventArgs) Handles btnCPSubmit.Click
        vChangePassword()
    End Sub

    Private Sub vChangeSecurityQA()
        Try
            If txtNewSQ.Text = Nothing Or txtNewSA.Text = Nothing Then
                MessageBox.Show("Please fill in the blank", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Not conn.State = ConnectionState.Open Then
                    conn.Open()
                End If

                Dim sql_statement As String = "SELECT * FROM tblUser WHERE Username = @Username"
                Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
                cmd.Parameters.AddWithValue("@Username", frmLogin.txtLUsername.Text)

                Dim rdr As OleDbDataReader = cmd.ExecuteReader()
                rdr.Read()

                If rdr.HasRows() = True Then
                    Dim sql_statement1 As String = "UPDATE tblUser SET [SecurityQuestion] = @SecurityQuestion, [SecurityAnswer] = @SecurityAnswer WHERE [Username] = @Username"
                    Dim cmd1 As OleDbCommand = New OleDbCommand(sql_statement1, conn)
                    With cmd1.Parameters
                        .AddWithValue("@SecurityQuestion", txtNewSQ.Text)
                        .AddWithValue("@SecurityAnswer", txtNewSA.Text)
                        .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                    End With
                    cmd1.ExecuteNonQuery()

                    MessageBox.Show("Security Question and Answer Updated Successfully", "Security Q/A Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNewSQ.Clear()
                    txtNewSA.Clear()
                    txtNewSQ.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub btnCSSubmit_Click(sender As Object, e As EventArgs) Handles btnCSSubmit.Click
        vChangeSecurityQA()
    End Sub

    Private Sub vCurrentEmail()
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim mysql_statement As String = "SELECT * FROM tblUser WHERE Username = @Username"
            Dim cmd As OleDbCommand = New OleDbCommand(mysql_statement, conn)
            cmd.Parameters.AddWithValue("@Username", frmLogin.txtLUsername.Text)

            Dim rdr As OleDbDataReader = cmd.ExecuteReader()
            rdr.Read()

            If rdr.HasRows = True Then
                txtCurrentEmail.Text = rdr("Email").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub vChangeEmail()
        Try
            If txtNewEmail.Text = Nothing Then
                MessageBox.Show("Please fill in the blank", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Not conn.State = ConnectionState.Open Then
                    conn.Open()
                End If

                Dim sql_statement As String = "SELECT * FROM tblUser WHERE Username = @Username"
                Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
                cmd.Parameters.AddWithValue("@Username", frmLogin.txtLUsername.Text)

                Dim rdr As OleDbDataReader = cmd.ExecuteReader
                rdr.Read()

                If rdr.HasRows = True Then
                    Dim sql_statement1 As String = "UPDATE tblUser SET [Email] = @Email WHERE [Username] = @Username"
                    Dim cmd1 As OleDbCommand = New OleDbCommand(sql_statement1, conn)
                    With cmd1.Parameters
                        .AddWithValue("@Email", Me.txtNewEmail.Text)
                        .AddWithValue("@Username", frmLogin.txtLUsername.Text)
                    End With
                    cmd1.ExecuteNonQuery()

                    MessageBox.Show("Email changed successfully", "Email Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNewEmail.Clear()
                    txtNewEmail.Focus()
                    Me.Close()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub btnCMSubmit_Click(sender As Object, e As EventArgs) Handles btnCMSubmit.Click
        vChangeEmail()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vCurrentEmail()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    
End Class