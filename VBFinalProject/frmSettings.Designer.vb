<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnCPSubmit = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtVerifyNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnCSSubmit = New System.Windows.Forms.Button()
        Me.txtNewSA = New System.Windows.Forms.TextBox()
        Me.txtNewSQ = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnCMSubmit = New System.Windows.Forms.Button()
        Me.txtCurrentEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.txtNewEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Settings"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(12, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(374, 247)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.btnCPSubmit)
        Me.TabPage1.Controls.Add(Me.txtVerifyNewPassword)
        Me.TabPage1.Controls.Add(Me.txtNewPassword)
        Me.TabPage1.Controls.Add(Me.txtOldPassword)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(366, 220)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Change Password"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(55, 126)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(55, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(55, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btnCPSubmit
        '
        Me.btnCPSubmit.BackColor = System.Drawing.Color.Black
        Me.btnCPSubmit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCPSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCPSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnCPSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCPSubmit.ForeColor = System.Drawing.Color.White
        Me.btnCPSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCPSubmit.ImageIndex = 2
        Me.btnCPSubmit.ImageList = Me.ImageList1
        Me.btnCPSubmit.Location = New System.Drawing.Point(3, 188)
        Me.btnCPSubmit.Name = "btnCPSubmit"
        Me.btnCPSubmit.Size = New System.Drawing.Size(360, 29)
        Me.btnCPSubmit.TabIndex = 6
        Me.btnCPSubmit.Text = "Submit"
        Me.btnCPSubmit.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Key.png")
        Me.ImageList1.Images.SetKeyName(1, "stock_lock_open.png")
        Me.ImageList1.Images.SetKeyName(2, "tick.png")
        Me.ImageList1.Images.SetKeyName(3, "Email.png")
        '
        'txtVerifyNewPassword
        '
        Me.txtVerifyNewPassword.BackColor = System.Drawing.Color.Black
        Me.txtVerifyNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVerifyNewPassword.ForeColor = System.Drawing.Color.White
        Me.txtVerifyNewPassword.Location = New System.Drawing.Point(122, 154)
        Me.txtVerifyNewPassword.Name = "txtVerifyNewPassword"
        Me.txtVerifyNewPassword.Size = New System.Drawing.Size(192, 20)
        Me.txtVerifyNewPassword.TabIndex = 5
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.Black
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPassword.ForeColor = System.Drawing.Color.White
        Me.txtNewPassword.Location = New System.Drawing.Point(122, 100)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(192, 20)
        Me.txtNewPassword.TabIndex = 4
        '
        'txtOldPassword
        '
        Me.txtOldPassword.BackColor = System.Drawing.Color.Black
        Me.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldPassword.ForeColor = System.Drawing.Color.White
        Me.txtOldPassword.Location = New System.Drawing.Point(122, 46)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Size = New System.Drawing.Size(192, 20)
        Me.txtOldPassword.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(117, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Verify New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(117, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(117, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Old Password"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.PictureBox5)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Controls.Add(Me.btnCSSubmit)
        Me.TabPage2.Controls.Add(Me.txtNewSA)
        Me.TabPage2.Controls.Add(Me.txtNewSQ)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(366, 220)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Change Security Q/A"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(44, 102)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(44, 38)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'btnCSSubmit
        '
        Me.btnCSSubmit.BackColor = System.Drawing.Color.Black
        Me.btnCSSubmit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCSSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCSSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnCSSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCSSubmit.ForeColor = System.Drawing.Color.White
        Me.btnCSSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCSSubmit.ImageIndex = 2
        Me.btnCSSubmit.ImageList = Me.ImageList1
        Me.btnCSSubmit.Location = New System.Drawing.Point(3, 188)
        Me.btnCSSubmit.Name = "btnCSSubmit"
        Me.btnCSSubmit.Size = New System.Drawing.Size(360, 29)
        Me.btnCSSubmit.TabIndex = 7
        Me.btnCSSubmit.Text = "Submit"
        Me.btnCSSubmit.UseVisualStyleBackColor = False
        '
        'txtNewSA
        '
        Me.txtNewSA.BackColor = System.Drawing.Color.Black
        Me.txtNewSA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewSA.ForeColor = System.Drawing.Color.White
        Me.txtNewSA.Location = New System.Drawing.Point(111, 130)
        Me.txtNewSA.Name = "txtNewSA"
        Me.txtNewSA.Size = New System.Drawing.Size(206, 20)
        Me.txtNewSA.TabIndex = 3
        '
        'txtNewSQ
        '
        Me.txtNewSQ.BackColor = System.Drawing.Color.Black
        Me.txtNewSQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewSQ.ForeColor = System.Drawing.Color.White
        Me.txtNewSQ.Location = New System.Drawing.Point(111, 66)
        Me.txtNewSQ.Name = "txtNewSQ"
        Me.txtNewSQ.Size = New System.Drawing.Size(206, 20)
        Me.txtNewSQ.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(106, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "New Security Answer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(106, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "New Security Question"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Black
        Me.TabPage3.Controls.Add(Me.btnCMSubmit)
        Me.TabPage3.Controls.Add(Me.txtCurrentEmail)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.PictureBox7)
        Me.TabPage3.Controls.Add(Me.txtNewEmail)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.PictureBox6)
        Me.TabPage3.ImageKey = "Email.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(366, 220)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Change Email"
        '
        'btnCMSubmit
        '
        Me.btnCMSubmit.BackColor = System.Drawing.Color.Black
        Me.btnCMSubmit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCMSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCMSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnCMSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCMSubmit.ForeColor = System.Drawing.Color.White
        Me.btnCMSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCMSubmit.ImageIndex = 2
        Me.btnCMSubmit.ImageList = Me.ImageList1
        Me.btnCMSubmit.Location = New System.Drawing.Point(3, 188)
        Me.btnCMSubmit.Name = "btnCMSubmit"
        Me.btnCMSubmit.Size = New System.Drawing.Size(360, 29)
        Me.btnCMSubmit.TabIndex = 15
        Me.btnCMSubmit.Text = "Submit"
        Me.btnCMSubmit.UseVisualStyleBackColor = False
        '
        'txtCurrentEmail
        '
        Me.txtCurrentEmail.BackColor = System.Drawing.Color.Black
        Me.txtCurrentEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentEmail.ForeColor = System.Drawing.Color.White
        Me.txtCurrentEmail.Location = New System.Drawing.Point(119, 64)
        Me.txtCurrentEmail.Name = "txtCurrentEmail"
        Me.txtCurrentEmail.ReadOnly = True
        Me.txtCurrentEmail.Size = New System.Drawing.Size(206, 20)
        Me.txtCurrentEmail.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(114, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 25)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Current Email"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(52, 36)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 12
        Me.PictureBox7.TabStop = False
        '
        'txtNewEmail
        '
        Me.txtNewEmail.BackColor = System.Drawing.Color.Black
        Me.txtNewEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewEmail.ForeColor = System.Drawing.Color.White
        Me.txtNewEmail.Location = New System.Drawing.Point(119, 142)
        Me.txtNewEmail.Name = "txtNewEmail"
        Me.txtNewEmail.Size = New System.Drawing.Size(206, 20)
        Me.txtNewEmail.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(114, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "New Email"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(52, 114)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.Location = New System.Drawing.Point(0, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(398, 31)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(398, 314)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtVerifyNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNewSA As System.Windows.Forms.TextBox
    Friend WithEvents txtNewSQ As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCPSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCSSubmit As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtNewEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCurrentEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnCMSubmit As System.Windows.Forms.Button
End Class
