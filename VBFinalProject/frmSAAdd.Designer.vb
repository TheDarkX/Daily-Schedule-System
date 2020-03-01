<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSAAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSAAdd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSASubject = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblSAReminderNote = New System.Windows.Forms.Label()
        Me.lblSASelectDate = New System.Windows.Forms.Label()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblSATime = New System.Windows.Forms.Label()
        Me.TimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Add New Schedule"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSASubject
        '
        Me.lblSASubject.AutoSize = True
        Me.lblSASubject.BackColor = System.Drawing.Color.Black
        Me.lblSASubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSASubject.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSASubject.Location = New System.Drawing.Point(21, 56)
        Me.lblSASubject.Name = "lblSASubject"
        Me.lblSASubject.Size = New System.Drawing.Size(78, 25)
        Me.lblSASubject.TabIndex = 7
        Me.lblSASubject.Text = "Subject"
        '
        'txtSubject
        '
        Me.txtSubject.BackColor = System.Drawing.Color.Black
        Me.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubject.ForeColor = System.Drawing.Color.White
        Me.txtSubject.Location = New System.Drawing.Point(26, 84)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(275, 20)
        Me.txtSubject.TabIndex = 0
        '
        'lblSAReminderNote
        '
        Me.lblSAReminderNote.AutoSize = True
        Me.lblSAReminderNote.BackColor = System.Drawing.Color.Black
        Me.lblSAReminderNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSAReminderNote.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSAReminderNote.Location = New System.Drawing.Point(21, 120)
        Me.lblSAReminderNote.Name = "lblSAReminderNote"
        Me.lblSAReminderNote.Size = New System.Drawing.Size(141, 25)
        Me.lblSAReminderNote.TabIndex = 8
        Me.lblSAReminderNote.Text = "Reminder Note"
        '
        'lblSASelectDate
        '
        Me.lblSASelectDate.AutoSize = True
        Me.lblSASelectDate.BackColor = System.Drawing.Color.Black
        Me.lblSASelectDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSASelectDate.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSASelectDate.Location = New System.Drawing.Point(21, 301)
        Me.lblSASelectDate.Name = "lblSASelectDate"
        Me.lblSASelectDate.Size = New System.Drawing.Size(113, 25)
        Me.lblSASelectDate.TabIndex = 9
        Me.lblSASelectDate.Text = "Select Date"
        '
        'DatePicker
        '
        Me.DatePicker.Checked = False
        Me.DatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Location = New System.Drawing.Point(26, 329)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(275, 24)
        Me.DatePicker.TabIndex = 2
        '
        'lblSATime
        '
        Me.lblSATime.AutoSize = True
        Me.lblSATime.BackColor = System.Drawing.Color.Black
        Me.lblSATime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSATime.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSATime.Location = New System.Drawing.Point(21, 368)
        Me.lblSATime.Name = "lblSATime"
        Me.lblSATime.Size = New System.Drawing.Size(56, 25)
        Me.lblSATime.TabIndex = 10
        Me.lblSATime.Text = "Time"
        '
        'TimePicker
        '
        Me.TimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimePicker.Location = New System.Drawing.Point(26, 396)
        Me.TimePicker.Name = "TimePicker"
        Me.TimePicker.ShowUpDown = True
        Me.TimePicker.Size = New System.Drawing.Size(275, 38)
        Me.TimePicker.TabIndex = 3
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.Black
        Me.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNote.ForeColor = System.Drawing.Color.White
        Me.txtNote.Location = New System.Drawing.Point(26, 148)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(275, 150)
        Me.txtNote.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(174, 451)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 94)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(26, 451)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 94)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'frmSAAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(329, 557)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.TimePicker)
        Me.Controls.Add(Me.lblSATime)
        Me.Controls.Add(Me.DatePicker)
        Me.Controls.Add(Me.lblSASelectDate)
        Me.Controls.Add(Me.lblSAReminderNote)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lblSASubject)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSAAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSASubject As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblSAReminderNote As System.Windows.Forms.Label
    Friend WithEvents lblSASelectDate As System.Windows.Forms.Label
    Friend WithEvents DatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSATime As System.Windows.Forms.Label
    Friend WithEvents TimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
End Class
