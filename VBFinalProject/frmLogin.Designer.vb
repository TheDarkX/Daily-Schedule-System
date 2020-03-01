<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CloudGroup1 = New CloudToolkitN6.CloudGroup()
        Me.cbStayLogin = New System.Windows.Forms.CheckBox()
        Me.linklblForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.btnLClearAll = New System.Windows.Forms.Button()
        Me.btnLLogin = New System.Windows.Forms.Button()
        Me.txtLPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtLUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CloudGroup2 = New CloudToolkitN6.CloudGroup()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtREmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblRSecurityAnswerHelp = New System.Windows.Forms.Label()
        Me.lblRSecurityQuestionHelp = New System.Windows.Forms.Label()
        Me.btnRClearAll = New System.Windows.Forms.Button()
        Me.btnRSignUp = New System.Windows.Forms.Button()
        Me.txtRSecurityAnswer = New System.Windows.Forms.TextBox()
        Me.txtRSecurityQuestion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRVerifyPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtRPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtRUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CloudGroup1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CloudGroup2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Daily Schedule System - Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'CloudGroup1
        '
        Me.CloudGroup1.AnimationEnabled = True
        Me.CloudGroup1.AnimationSpeed = 15
        Me.CloudGroup1.BackColor = System.Drawing.Color.Transparent
        Me.CloudGroup1.BorderColor = System.Drawing.Color.DarkGray
        Me.CloudGroup1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloudGroup1.BorderWidth = 1.0!
        Me.CloudGroup1.Controls.Add(Me.cbStayLogin)
        Me.CloudGroup1.Controls.Add(Me.linklblForgotPassword)
        Me.CloudGroup1.Controls.Add(Me.btnLClearAll)
        Me.CloudGroup1.Controls.Add(Me.btnLLogin)
        Me.CloudGroup1.Controls.Add(Me.txtLPassword)
        Me.CloudGroup1.Controls.Add(Me.Label3)
        Me.CloudGroup1.Controls.Add(Me.PictureBox2)
        Me.CloudGroup1.Controls.Add(Me.txtLUsername)
        Me.CloudGroup1.Controls.Add(Me.Label2)
        Me.CloudGroup1.Controls.Add(Me.PictureBox1)
        Me.CloudGroup1.FillColor1 = System.Drawing.Color.LightBlue
        Me.CloudGroup1.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup1.FillColor2_1 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup1.FillColor2_2 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup1.FontColorMouseOn = System.Drawing.Color.Yellow
        Me.CloudGroup1.FontColorNormal = System.Drawing.Color.Black
        Me.CloudGroup1.HeaderText = "          Login"
        Me.CloudGroup1.Icon = CType(resources.GetObject("CloudGroup1.Icon"), System.Drawing.Bitmap)
        Me.CloudGroup1.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Left
        Me.CloudGroup1.IconPadding = 5
        Me.CloudGroup1.ImageHeader = False
        Me.CloudGroup1.IsOpen = True
        Me.CloudGroup1.Location = New System.Drawing.Point(12, 78)
        Me.CloudGroup1.MaximumHeight = 425
        Me.CloudGroup1.Name = "CloudGroup1"
        Me.CloudGroup1.PanelColor = System.Drawing.Color.Black
        Me.CloudGroup1.Size = New System.Drawing.Size(309, 425)
        Me.CloudGroup1.TabIndex = 4
        '
        'cbStayLogin
        '
        Me.cbStayLogin.AutoSize = True
        Me.cbStayLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cbStayLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbStayLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStayLogin.ForeColor = System.Drawing.Color.Gray
        Me.cbStayLogin.Location = New System.Drawing.Point(79, 214)
        Me.cbStayLogin.Name = "cbStayLogin"
        Me.cbStayLogin.Size = New System.Drawing.Size(117, 21)
        Me.cbStayLogin.TabIndex = 20
        Me.cbStayLogin.Text = "&Stay Logged In?"
        Me.cbStayLogin.UseVisualStyleBackColor = True
        '
        'linklblForgotPassword
        '
        Me.linklblForgotPassword.ActiveLinkColor = System.Drawing.Color.Yellow
        Me.linklblForgotPassword.AutoSize = True
        Me.linklblForgotPassword.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linklblForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linklblForgotPassword.LinkColor = System.Drawing.Color.DodgerBlue
        Me.linklblForgotPassword.Location = New System.Drawing.Point(55, 374)
        Me.linklblForgotPassword.Name = "linklblForgotPassword"
        Me.linklblForgotPassword.Size = New System.Drawing.Size(214, 28)
        Me.linklblForgotPassword.TabIndex = 19
        Me.linklblForgotPassword.TabStop = True
        Me.linklblForgotPassword.Text = "Forgot your password?"
        '
        'btnLClearAll
        '
        Me.btnLClearAll.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLClearAll.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnLClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLClearAll.ForeColor = System.Drawing.Color.Black
        Me.btnLClearAll.Image = CType(resources.GetObject("btnLClearAll.Image"), System.Drawing.Image)
        Me.btnLClearAll.Location = New System.Drawing.Point(158, 253)
        Me.btnLClearAll.Name = "btnLClearAll"
        Me.btnLClearAll.Size = New System.Drawing.Size(134, 104)
        Me.btnLClearAll.TabIndex = 18
        Me.btnLClearAll.Text = "Clear All"
        Me.btnLClearAll.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnLClearAll.UseVisualStyleBackColor = False
        '
        'btnLLogin
        '
        Me.btnLLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnLLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLLogin.Image = CType(resources.GetObject("btnLLogin.Image"), System.Drawing.Image)
        Me.btnLLogin.Location = New System.Drawing.Point(12, 253)
        Me.btnLLogin.Name = "btnLLogin"
        Me.btnLLogin.Size = New System.Drawing.Size(134, 104)
        Me.btnLLogin.TabIndex = 17
        Me.btnLLogin.Text = "Login"
        Me.btnLLogin.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnLLogin.UseVisualStyleBackColor = False
        '
        'txtLPassword
        '
        Me.txtLPassword.BackColor = System.Drawing.Color.Black
        Me.txtLPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLPassword.ForeColor = System.Drawing.Color.White
        Me.txtLPassword.Location = New System.Drawing.Point(79, 174)
        Me.txtLPassword.Name = "txtLPassword"
        Me.txtLPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLPassword.Size = New System.Drawing.Size(213, 26)
        Me.txtLPassword.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(74, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 142)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'txtLUsername
        '
        Me.txtLUsername.BackColor = System.Drawing.Color.Black
        Me.txtLUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLUsername.ForeColor = System.Drawing.Color.White
        Me.txtLUsername.Location = New System.Drawing.Point(79, 95)
        Me.txtLUsername.Name = "txtLUsername"
        Me.txtLUsername.Size = New System.Drawing.Size(213, 26)
        Me.txtLUsername.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(74, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'CloudGroup2
        '
        Me.CloudGroup2.AnimationEnabled = True
        Me.CloudGroup2.AnimationSpeed = 15
        Me.CloudGroup2.BackColor = System.Drawing.Color.Transparent
        Me.CloudGroup2.BorderColor = System.Drawing.Color.DarkGray
        Me.CloudGroup2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloudGroup2.BorderWidth = 1.0!
        Me.CloudGroup2.Controls.Add(Me.Label9)
        Me.CloudGroup2.Controls.Add(Me.txtREmail)
        Me.CloudGroup2.Controls.Add(Me.Label4)
        Me.CloudGroup2.Controls.Add(Me.PictureBox6)
        Me.CloudGroup2.Controls.Add(Me.lblRSecurityAnswerHelp)
        Me.CloudGroup2.Controls.Add(Me.lblRSecurityQuestionHelp)
        Me.CloudGroup2.Controls.Add(Me.btnRClearAll)
        Me.CloudGroup2.Controls.Add(Me.btnRSignUp)
        Me.CloudGroup2.Controls.Add(Me.txtRSecurityAnswer)
        Me.CloudGroup2.Controls.Add(Me.txtRSecurityQuestion)
        Me.CloudGroup2.Controls.Add(Me.Label8)
        Me.CloudGroup2.Controls.Add(Me.txtRVerifyPassword)
        Me.CloudGroup2.Controls.Add(Me.Label5)
        Me.CloudGroup2.Controls.Add(Me.PictureBox5)
        Me.CloudGroup2.Controls.Add(Me.txtRPassword)
        Me.CloudGroup2.Controls.Add(Me.Label6)
        Me.CloudGroup2.Controls.Add(Me.PictureBox3)
        Me.CloudGroup2.Controls.Add(Me.txtRUsername)
        Me.CloudGroup2.Controls.Add(Me.Label7)
        Me.CloudGroup2.Controls.Add(Me.PictureBox4)
        Me.CloudGroup2.FillColor1 = System.Drawing.Color.LightBlue
        Me.CloudGroup2.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup2.FillColor2_1 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup2.FillColor2_2 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup2.FontColorMouseOn = System.Drawing.Color.Yellow
        Me.CloudGroup2.FontColorNormal = System.Drawing.Color.Black
        Me.CloudGroup2.HeaderText = "          Sign Up"
        Me.CloudGroup2.Icon = CType(resources.GetObject("CloudGroup2.Icon"), System.Drawing.Bitmap)
        Me.CloudGroup2.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Left
        Me.CloudGroup2.IconPadding = 5
        Me.CloudGroup2.ImageHeader = False
        Me.CloudGroup2.IsOpen = False
        Me.CloudGroup2.Location = New System.Drawing.Point(12, 41)
        Me.CloudGroup2.MaximumHeight = 514
        Me.CloudGroup2.Name = "CloudGroup2"
        Me.CloudGroup2.PanelColor = System.Drawing.Color.Black
        Me.CloudGroup2.Size = New System.Drawing.Size(309, 27)
        Me.CloudGroup2.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(69, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(235, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "*Schedule Alert Notification Purpose"
        '
        'txtREmail
        '
        Me.txtREmail.BackColor = System.Drawing.Color.Black
        Me.txtREmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtREmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtREmail.ForeColor = System.Drawing.Color.White
        Me.txtREmail.Location = New System.Drawing.Point(79, 278)
        Me.txtREmail.Name = "txtREmail"
        Me.txtREmail.Size = New System.Drawing.Size(213, 26)
        Me.txtREmail.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(74, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 28)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Email"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(12, 228)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(56, 76)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 19
        Me.PictureBox6.TabStop = False
        '
        'lblRSecurityAnswerHelp
        '
        Me.lblRSecurityAnswerHelp.AutoSize = True
        Me.lblRSecurityAnswerHelp.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblRSecurityAnswerHelp.Location = New System.Drawing.Point(232, 375)
        Me.lblRSecurityAnswerHelp.Name = "lblRSecurityAnswerHelp"
        Me.lblRSecurityAnswerHelp.Size = New System.Drawing.Size(51, 13)
        Me.lblRSecurityAnswerHelp.TabIndex = 18
        Me.lblRSecurityAnswerHelp.Text = "[Answer]"
        '
        'lblRSecurityQuestionHelp
        '
        Me.lblRSecurityQuestionHelp.AutoSize = True
        Me.lblRSecurityQuestionHelp.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblRSecurityQuestionHelp.Location = New System.Drawing.Point(225, 343)
        Me.lblRSecurityQuestionHelp.Name = "lblRSecurityQuestionHelp"
        Me.lblRSecurityQuestionHelp.Size = New System.Drawing.Size(61, 13)
        Me.lblRSecurityQuestionHelp.TabIndex = 17
        Me.lblRSecurityQuestionHelp.Text = "[Question]"
        '
        'btnRClearAll
        '
        Me.btnRClearAll.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRClearAll.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnRClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRClearAll.ForeColor = System.Drawing.Color.Black
        Me.btnRClearAll.Image = CType(resources.GetObject("btnRClearAll.Image"), System.Drawing.Image)
        Me.btnRClearAll.Location = New System.Drawing.Point(158, 397)
        Me.btnRClearAll.Name = "btnRClearAll"
        Me.btnRClearAll.Size = New System.Drawing.Size(134, 104)
        Me.btnRClearAll.TabIndex = 16
        Me.btnRClearAll.Text = "Clear All"
        Me.btnRClearAll.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnRClearAll.UseVisualStyleBackColor = False
        '
        'btnRSignUp
        '
        Me.btnRSignUp.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRSignUp.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnRSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRSignUp.ForeColor = System.Drawing.Color.Black
        Me.btnRSignUp.Image = CType(resources.GetObject("btnRSignUp.Image"), System.Drawing.Image)
        Me.btnRSignUp.Location = New System.Drawing.Point(12, 397)
        Me.btnRSignUp.Name = "btnRSignUp"
        Me.btnRSignUp.Size = New System.Drawing.Size(134, 104)
        Me.btnRSignUp.TabIndex = 15
        Me.btnRSignUp.Text = "Sign Up"
        Me.btnRSignUp.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnRSignUp.UseVisualStyleBackColor = False
        '
        'txtRSecurityAnswer
        '
        Me.txtRSecurityAnswer.BackColor = System.Drawing.Color.Black
        Me.txtRSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRSecurityAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRSecurityAnswer.ForeColor = System.Drawing.Color.White
        Me.txtRSecurityAnswer.Location = New System.Drawing.Point(12, 365)
        Me.txtRSecurityAnswer.Name = "txtRSecurityAnswer"
        Me.txtRSecurityAnswer.Size = New System.Drawing.Size(280, 26)
        Me.txtRSecurityAnswer.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtRSecurityAnswer, "Security Answer - Forgot Password Purpose")
        '
        'txtRSecurityQuestion
        '
        Me.txtRSecurityQuestion.BackColor = System.Drawing.Color.Black
        Me.txtRSecurityQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRSecurityQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRSecurityQuestion.ForeColor = System.Drawing.Color.White
        Me.txtRSecurityQuestion.Location = New System.Drawing.Point(12, 333)
        Me.txtRSecurityQuestion.Name = "txtRSecurityQuestion"
        Me.txtRSecurityQuestion.Size = New System.Drawing.Size(280, 26)
        Me.txtRSecurityQuestion.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.txtRSecurityQuestion, "Security Question - Forgot Password Purpose")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(7, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(262, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Set Your Security Question"
        '
        'txtRVerifyPassword
        '
        Me.txtRVerifyPassword.BackColor = System.Drawing.Color.Black
        Me.txtRVerifyPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRVerifyPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRVerifyPassword.ForeColor = System.Drawing.Color.White
        Me.txtRVerifyPassword.Location = New System.Drawing.Point(79, 196)
        Me.txtRVerifyPassword.Name = "txtRVerifyPassword"
        Me.txtRVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRVerifyPassword.Size = New System.Drawing.Size(213, 26)
        Me.txtRVerifyPassword.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(74, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 28)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Verify Password"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(12, 164)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(56, 58)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'txtRPassword
        '
        Me.txtRPassword.BackColor = System.Drawing.Color.Black
        Me.txtRPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPassword.ForeColor = System.Drawing.Color.White
        Me.txtRPassword.Location = New System.Drawing.Point(79, 132)
        Me.txtRPassword.Name = "txtRPassword"
        Me.txtRPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRPassword.Size = New System.Drawing.Size(213, 26)
        Me.txtRPassword.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(74, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 28)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Password"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 100)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 58)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'txtRUsername
        '
        Me.txtRUsername.BackColor = System.Drawing.Color.Black
        Me.txtRUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUsername.ForeColor = System.Drawing.Color.White
        Me.txtRUsername.Location = New System.Drawing.Point(79, 68)
        Me.txtRUsername.Name = "txtRUsername"
        Me.txtRUsername.Size = New System.Drawing.Size(213, 26)
        Me.txtRUsername.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(74, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 28)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Username"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 36)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(56, 58)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 1
        Me.ToolTip1.ReshowDelay = 1
        Me.ToolTip1.ToolTipTitle = "[Help]"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.Location = New System.Drawing.Point(0, 562)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(333, 32)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(333, 594)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.CloudGroup2)
        Me.Controls.Add(Me.CloudGroup1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CloudGroup1.ResumeLayout(False)
        Me.CloudGroup1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CloudGroup2.ResumeLayout(False)
        Me.CloudGroup2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CloudGroup1 As CloudToolkitN6.CloudGroup
    Friend WithEvents txtLUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CloudGroup2 As CloudToolkitN6.CloudGroup
    Friend WithEvents txtRPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRVerifyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRSecurityAnswer As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtRSecurityQuestion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnRSignUp As System.Windows.Forms.Button
    Friend WithEvents btnRClearAll As System.Windows.Forms.Button
    Friend WithEvents btnLClearAll As System.Windows.Forms.Button
    Friend WithEvents btnLLogin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents linklblForgotPassword As System.Windows.Forms.LinkLabel
    Friend WithEvents lblRSecurityAnswerHelp As System.Windows.Forms.Label
    Friend WithEvents lblRSecurityQuestionHelp As System.Windows.Forms.Label
    Friend WithEvents cbStayLogin As System.Windows.Forms.CheckBox
    Friend WithEvents txtREmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
