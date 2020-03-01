Imports System.Data.OleDb

Public Class frmLogin
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DSS_db.accdb")

#Region "Form Dragable"
    'Form Dragable
    Dim bDrag As Boolean
    Dim iMouseX As Integer
    Dim iMouseY As Integer

    Private Sub frmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        bDrag = True
        iMouseX = Windows.Forms.Cursor.Position.X - Me.Left
        iMouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub frmLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If bDrag = True Then
            Me.Left = Windows.Forms.Cursor.Position.X - iMouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - iMouseY
        End If
    End Sub
    Private Sub frmLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
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

    Private Sub vCheckLoggedInUser()
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
                Me.txtLUsername.Text = rdr("Username").ToString()
                Me.txtLPassword.Text = rdr("Password").ToString()

                Me.cbStayLogin.Checked = True
                frmMain.LoginAsToolStripStatusLabel.Text = "Login As : " & Me.txtLUsername.Text.ToString()
                frmMain.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + vbNewLine + vbNewLine + ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'http://forum.codecall.net/topic/51741-playing-sounds-in-vbnet/
        'My.Computer.Audio.Play("Z:\Personal\Music\Yiruma - First Love - River Flows In You.wav", AudioPlayMode.Background
    End Sub
    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        vCheckLoggedInUser()
    End Sub

#Region "Register"
    Private Sub vRegister()
        Try
            If txtRUsername.Text = Nothing Or txtRPassword.Text = Nothing Or txtRVerifyPassword.Text = Nothing Or txtREmail.Text = Nothing Or txtRSecurityQuestion.Text = Nothing Or txtRSecurityAnswer.Text = Nothing Then
                MessageBox.Show("Username, Password, Verify Password, Email, Question and Answer cannot be blank.", "Fill Require to fill in", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If txtRPassword.Text <> txtRVerifyPassword.Text Then
                    MessageBox.Show("Password and Verify Password does not match.", "Password not match", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    Dim sql_statement As String = "INSERT INTO tblUser ([Username],[Password],[SecurityQuestion],[SecurityAnswer],[Email])VALUES(@Username,@Password,@SecurityQuestion,@SecurityAnswer,@Email)"
                    Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)

                    With cmd.Parameters
                        .AddWithValue("@Username", txtRUsername.Text)
                        .AddWithValue("@Password", txtRPassword.Text)
                        .AddWithValue("@SecurityQuestion", txtRSecurityQuestion.Text)
                        .AddWithValue("@SecurityPassword", txtRSecurityAnswer.Text)
                        .AddWithValue("@Email", txtREmail.Text)
                    End With
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MessageBox.Show("Register Successfully.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtRUsername.Clear()
                    txtRPassword.Clear()
                    txtRVerifyPassword.Clear()
                    txtRSecurityQuestion.Clear()
                    txtRSecurityAnswer.Clear()
                    txtLUsername.Focus()
                    CloudGroup2.IsOpen = False
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
    Private Sub btnRSignUp_Click(sender As Object, e As EventArgs) Handles btnRSignUp.Click
        vRegister()
    End Sub
    Private Sub txtRSecurityQuestion_Enter(sender As Object, e As EventArgs) Handles txtRSecurityQuestion.Enter
        lblRSecurityQuestionHelp.Hide()
    End Sub
    Private Sub txtRSecurityQuestion_Leave(sender As Object, e As EventArgs) Handles txtRSecurityQuestion.Leave
        lblRSecurityQuestionHelp.Show()
    End Sub
    Private Sub txtRSecurityAnswer_Enter(sender As Object, e As EventArgs) Handles txtRSecurityAnswer.Enter
        lblRSecurityAnswerHelp.Hide()
    End Sub
    Private Sub txtRSecurityAnswer_Leave(sender As Object, e As EventArgs) Handles txtRSecurityAnswer.Leave
        lblRSecurityAnswerHelp.Show()
    End Sub
    Private Sub btnRClearAll_Click(sender As Object, e As EventArgs) Handles btnRClearAll.Click
        txtRUsername.Clear()
        txtRPassword.Clear()
        txtRVerifyPassword.Clear()
        txtRSecurityQuestion.Clear()
        txtRSecurityAnswer.Clear()
        txtRUsername.Focus()
    End Sub
#End Region
#Region "Login"
    Private Sub vLogin()
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            If txtLUsername.Text = Nothing Or txtLPassword.Text = Nothing Then
                MessageBox.Show("Invalid Username Or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                Dim sql_statement As String = "SELECT * FROM tblUser WHERE Username = '" & txtLUsername.Text & "' AND Password = '" & txtLPassword.Text & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)

                'Database Reader
                Dim rdr As OleDbDataReader = cmd.ExecuteReader
                rdr.Read()

                'Database Username|Password Verify
                If rdr.HasRows = True Then
                    Dim Username As String = rdr("Username").ToString()
                    Dim Password As String = rdr("Password").ToString()

                    'MessageBox.Show("Login Successfully." & vbNewLine & "Welcome, " & txtLUsername.Text & ".", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmMain.LoginAsToolStripStatusLabel.Text = "Login As : " & txtLUsername.Text
                    frmMain.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                'StayLoggedIn
                Dim sql_statement1 As String = "UPDATE tblUser SET [LoggedIn] = @LoggedIn WHERE [Username] = @Username"
                Dim cmd1 As OleDbCommand = New OleDbCommand(sql_statement1, conn)
                With cmd1.Parameters
                    .AddWithValue("@LogggedIn", cbStayLogin.Checked.ToString())
                    .AddWithValue("@Username", Me.txtLUsername.Text)
                End With
                cmd1.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & vbNewLine & ex.StackTrace)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLLogin.Click
        vLogin()
    End Sub
#End Region
    
#Region "Forgot Password"
    Private Sub vForgotPassword()
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim strAskUsername As String = InputBox("Please enter your Username.", "Retrieve Password").ToString()

            Dim sql_statement As String = "SELECT * FROM tblUser WHERE Username = @Username"
            Dim cmd As OleDbCommand = New OleDbCommand(sql_statement, conn)
            cmd.Parameters.AddWithValue("@Username", strAskUsername)

            Dim rdr As OleDbDataReader = cmd.ExecuteReader()
            rdr.Read()

            If rdr.HasRows() Then
                strAskUsername = rdr("Username").ToString()
                Dim strAskSecurityAnswer As String = InputBox("Security Question: " & rdr("SecurityQuestion").ToString(), "Please Enter Security Answer")
                If strAskSecurityAnswer = rdr("SecurityAnswer").ToString() Then
                    MessageBox.Show("Password Retrieve Successfully." & vbNewLine & "Your Password is: " & rdr("Password").ToString(), "Retrieve Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Incorrect Security Answer", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Username not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub linklblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblForgotPassword.LinkClicked
        vForgotPassword()
    End Sub
    Private Sub lblForgotPassword_MouseHover(sender As Object, e As EventArgs)
        linklblForgotPassword.ForeColor = Color.Yellow
        linklblForgotPassword.Cursor = Cursors.Hand
    End Sub
    Private Sub lblForgotPassword_MouseLeave(sender As Object, e As EventArgs)
        linklblForgotPassword.ForeColor = Color.DodgerBlue
    End Sub
#End Region

    Private Sub cbStayLogin_CheckedChanged(sender As Object, e As EventArgs) Handles cbStayLogin.CheckedChanged
        If cbStayLogin.Checked = True Then
            cbStayLogin.ForeColor = Color.Green
        Else
            cbStayLogin.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub btnLClearAll_Click(sender As Object, e As EventArgs) Handles btnLClearAll.Click
        txtLUsername.Clear()
        txtLPassword.Clear()
        txtLUsername.Focus()
        cbStayLogin.Checked = False
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure want to exit? Schedule will not alert on time.", "Confirm Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        ElseIf DialogResult.No Then
            txtLUsername.Focus()
        End If
    End Sub
End Class