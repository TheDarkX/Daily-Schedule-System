<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TrayNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TopMostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayShowHideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrayExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScheduleAlertHelp = New System.Windows.Forms.Label()
        Me.lvScheduleAlert = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ScheduleAlertContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddSAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScheduleTaskHelp = New System.Windows.Forms.Label()
        Me.lvScheduleTask = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ScheduleTaskContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddSTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblScheduleClassHelp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvScheduleClass = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ScheduleClassContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddSCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloudGroup1 = New CloudToolkitN6.CloudGroup()
        Me.lblStickyNoteHelp = New System.Windows.Forms.Label()
        Me.txtStickyNotes = New System.Windows.Forms.TextBox()
        Me.StickyNotesPropertiesContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtChangedLog = New System.Windows.Forms.TextBox()
        Me.CloudDigitalClock1 = New CloudToolkitN6.CloudDigitalClock()
        Me.CloudPictureBox1 = New CloudToolkitN6.CloudPictureBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.FormContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LoginAsToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AppNameToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateTimeToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.ScheduleAlertWatcherTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ScheduleTaskWatcherTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ScheduleClassWatcherTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloudGroup2 = New CloudToolkitN6.CloudGroup()
        Me.CloudGroup3 = New CloudToolkitN6.CloudGroup()
        Me.btnRebootModem = New System.Windows.Forms.Button()
        Me.lblRebootStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRebootTime = New System.Windows.Forms.TextBox()
        Me.tRebootModem = New System.Windows.Forms.Timer(Me.components)
        Me.dtpRebootModem = New System.Windows.Forms.DateTimePicker()
        Me.TrayContextMenuStrip.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ScheduleAlertContextMenuStrip.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ScheduleTaskContextMenuStrip.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ScheduleClassContextMenuStrip.SuspendLayout()
        Me.CloudGroup1.SuspendLayout()
        Me.StickyNotesPropertiesContextMenuStrip.SuspendLayout()
        Me.FormContextMenuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.CloudGroup2.SuspendLayout()
        Me.CloudGroup3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Black
        Me.ImageList1.Images.SetKeyName(0, "ScheduleAlert.png")
        Me.ImageList1.Images.SetKeyName(1, "Actions-view-calendar-tasks-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "task-notes-icon.png")
        Me.ImageList1.Images.SetKeyName(3, "calender_alt.png")
        Me.ImageList1.Images.SetKeyName(4, "notes.png")
        Me.ImageList1.Images.SetKeyName(5, "Shopping-Price-tag-icon.png")
        Me.ImageList1.Images.SetKeyName(6, "red-tag-icon.png")
        Me.ImageList1.Images.SetKeyName(7, "Map-Marker-Marker-Outside-Azure-icon.png")
        '
        'TrayNotifyIcon
        '
        Me.TrayNotifyIcon.BalloonTipText = "Scheduler is runing"
        Me.TrayNotifyIcon.ContextMenuStrip = Me.TrayContextMenuStrip
        Me.TrayNotifyIcon.Icon = CType(resources.GetObject("TrayNotifyIcon.Icon"), System.Drawing.Icon)
        Me.TrayNotifyIcon.Text = "Scheduler is runing"
        Me.TrayNotifyIcon.Visible = True
        '
        'TrayContextMenuStrip
        '
        Me.TrayContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TopMostToolStripMenuItem, Me.TrayShowHideToolStripMenuItem, Me.ToolStripSeparator2, Me.TrayExitToolStripMenuItem})
        Me.TrayContextMenuStrip.Name = "ContextMenuStrip1"
        Me.TrayContextMenuStrip.Size = New System.Drawing.Size(159, 76)
        '
        'TopMostToolStripMenuItem
        '
        Me.TopMostToolStripMenuItem.Name = "TopMostToolStripMenuItem"
        Me.TopMostToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TopMostToolStripMenuItem.Text = "Top Most"
        '
        'TrayShowHideToolStripMenuItem
        '
        Me.TrayShowHideToolStripMenuItem.Image = CType(resources.GetObject("TrayShowHideToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TrayShowHideToolStripMenuItem.Name = "TrayShowHideToolStripMenuItem"
        Me.TrayShowHideToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TrayShowHideToolStripMenuItem.Text = "Show Scheduler"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(155, 6)
        '
        'TrayExitToolStripMenuItem
        '
        Me.TrayExitToolStripMenuItem.Image = CType(resources.GetObject("TrayExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TrayExitToolStripMenuItem.Name = "TrayExitToolStripMenuItem"
        Me.TrayExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.TrayExitToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TrayExitToolStripMenuItem.Text = "Exit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(12, 155)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(692, 349)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.ImageKey = "ScheduleAlert.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(684, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General Scheduler  "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblScheduleAlertHelp)
        Me.GroupBox1.Controls.Add(Me.lvScheduleAlert)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(668, 306)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(281, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Schedule Alert"
        '
        'lblScheduleAlertHelp
        '
        Me.lblScheduleAlertHelp.AutoSize = True
        Me.lblScheduleAlertHelp.BackColor = System.Drawing.Color.White
        Me.lblScheduleAlertHelp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduleAlertHelp.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblScheduleAlertHelp.Location = New System.Drawing.Point(244, 151)
        Me.lblScheduleAlertHelp.Name = "lblScheduleAlertHelp"
        Me.lblScheduleAlertHelp.Size = New System.Drawing.Size(150, 13)
        Me.lblScheduleAlertHelp.TabIndex = 13
        Me.lblScheduleAlertHelp.Text = "Right click for more options"
        '
        'lvScheduleAlert
        '
        Me.lvScheduleAlert.BackColor = System.Drawing.SystemColors.Window
        Me.lvScheduleAlert.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvScheduleAlert.ContextMenuStrip = Me.ScheduleAlertContextMenuStrip
        Me.lvScheduleAlert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvScheduleAlert.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvScheduleAlert.ForeColor = System.Drawing.Color.Black
        Me.lvScheduleAlert.FullRowSelect = True
        Me.lvScheduleAlert.GridLines = True
        Me.lvScheduleAlert.HideSelection = False
        Me.lvScheduleAlert.Location = New System.Drawing.Point(3, 16)
        Me.lvScheduleAlert.MultiSelect = False
        Me.lvScheduleAlert.Name = "lvScheduleAlert"
        Me.lvScheduleAlert.RightToLeftLayout = True
        Me.lvScheduleAlert.Size = New System.Drawing.Size(662, 287)
        Me.lvScheduleAlert.SmallImageList = Me.ImageList1
        Me.lvScheduleAlert.StateImageList = Me.ImageList1
        Me.lvScheduleAlert.TabIndex = 5
        Me.lvScheduleAlert.UseCompatibleStateImageBehavior = False
        Me.lvScheduleAlert.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "          Subject"
        Me.ColumnHeader1.Width = 122
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Note"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 193
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 188
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Time"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 152
        '
        'ScheduleAlertContextMenuStrip
        '
        Me.ScheduleAlertContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSAToolStripMenuItem, Me.EditSAToolStripMenuItem, Me.DeleteSAToolStripMenuItem})
        Me.ScheduleAlertContextMenuStrip.Name = "ScheduleAlertContextMenuStrip"
        Me.ScheduleAlertContextMenuStrip.Size = New System.Drawing.Size(132, 70)
        '
        'AddSAToolStripMenuItem
        '
        Me.AddSAToolStripMenuItem.Image = CType(resources.GetObject("AddSAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddSAToolStripMenuItem.Name = "AddSAToolStripMenuItem"
        Me.AddSAToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AddSAToolStripMenuItem.Text = "Add"
        '
        'EditSAToolStripMenuItem
        '
        Me.EditSAToolStripMenuItem.Image = CType(resources.GetObject("EditSAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditSAToolStripMenuItem.Name = "EditSAToolStripMenuItem"
        Me.EditSAToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EditSAToolStripMenuItem.Text = "Edit"
        '
        'DeleteSAToolStripMenuItem
        '
        Me.DeleteSAToolStripMenuItem.Image = CType(resources.GetObject("DeleteSAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteSAToolStripMenuItem.Name = "DeleteSAToolStripMenuItem"
        Me.DeleteSAToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteSAToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DeleteSAToolStripMenuItem.Text = "Delete"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.ImageKey = "Actions-view-calendar-tasks-icon.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(684, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Task Scheduler"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblScheduleTaskHelp)
        Me.GroupBox2.Controls.Add(Me.lvScheduleTask)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(668, 306)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Violet
        Me.Label2.Location = New System.Drawing.Point(281, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Schedule Task "
        '
        'lblScheduleTaskHelp
        '
        Me.lblScheduleTaskHelp.AutoSize = True
        Me.lblScheduleTaskHelp.BackColor = System.Drawing.Color.White
        Me.lblScheduleTaskHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduleTaskHelp.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblScheduleTaskHelp.Location = New System.Drawing.Point(244, 151)
        Me.lblScheduleTaskHelp.Name = "lblScheduleTaskHelp"
        Me.lblScheduleTaskHelp.Size = New System.Drawing.Size(135, 13)
        Me.lblScheduleTaskHelp.TabIndex = 14
        Me.lblScheduleTaskHelp.Text = "Right click for more options"
        '
        'lvScheduleTask
        '
        Me.lvScheduleTask.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvScheduleTask.ContextMenuStrip = Me.ScheduleTaskContextMenuStrip
        Me.lvScheduleTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvScheduleTask.FullRowSelect = True
        Me.lvScheduleTask.GridLines = True
        Me.lvScheduleTask.Location = New System.Drawing.Point(3, 16)
        Me.lvScheduleTask.MultiSelect = False
        Me.lvScheduleTask.Name = "lvScheduleTask"
        Me.lvScheduleTask.Size = New System.Drawing.Size(662, 287)
        Me.lvScheduleTask.SmallImageList = Me.ImageList1
        Me.lvScheduleTask.StateImageList = Me.ImageList1
        Me.lvScheduleTask.TabIndex = 6
        Me.lvScheduleTask.UseCompatibleStateImageBehavior = False
        Me.lvScheduleTask.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "          Type"
        Me.ColumnHeader5.Width = 112
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Note"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 186
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Day"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 194
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Time"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 165
        '
        'ScheduleTaskContextMenuStrip
        '
        Me.ScheduleTaskContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSTToolStripMenuItem1, Me.EditToolStripMenuItem, Me.DeleteSTToolStripMenuItem})
        Me.ScheduleTaskContextMenuStrip.Name = "ScheduleTaskContextMenuStrip"
        Me.ScheduleTaskContextMenuStrip.Size = New System.Drawing.Size(132, 70)
        '
        'AddSTToolStripMenuItem1
        '
        Me.AddSTToolStripMenuItem1.Image = CType(resources.GetObject("AddSTToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AddSTToolStripMenuItem1.Name = "AddSTToolStripMenuItem1"
        Me.AddSTToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.AddSTToolStripMenuItem1.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.VBFinalProject.My.Resources.Resources.Edit1
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteSTToolStripMenuItem
        '
        Me.DeleteSTToolStripMenuItem.Image = CType(resources.GetObject("DeleteSTToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteSTToolStripMenuItem.Name = "DeleteSTToolStripMenuItem"
        Me.DeleteSTToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteSTToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DeleteSTToolStripMenuItem.Text = "Delete"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Black
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.ImageKey = "calender_alt.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(684, 322)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Class Scheduler   "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblScheduleClassHelp)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lvScheduleClass)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(668, 306)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'lblScheduleClassHelp
        '
        Me.lblScheduleClassHelp.AutoSize = True
        Me.lblScheduleClassHelp.BackColor = System.Drawing.Color.White
        Me.lblScheduleClassHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduleClassHelp.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblScheduleClassHelp.Location = New System.Drawing.Point(244, 151)
        Me.lblScheduleClassHelp.Name = "lblScheduleClassHelp"
        Me.lblScheduleClassHelp.Size = New System.Drawing.Size(135, 13)
        Me.lblScheduleClassHelp.TabIndex = 15
        Me.lblScheduleClassHelp.Text = "Right click for more options"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Tomato
        Me.Label3.Location = New System.Drawing.Point(281, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Schedule Class"
        '
        'lvScheduleClass
        '
        Me.lvScheduleClass.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lvScheduleClass.ContextMenuStrip = Me.ScheduleClassContextMenuStrip
        Me.lvScheduleClass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvScheduleClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvScheduleClass.FullRowSelect = True
        Me.lvScheduleClass.GridLines = True
        Me.lvScheduleClass.Location = New System.Drawing.Point(3, 18)
        Me.lvScheduleClass.Name = "lvScheduleClass"
        Me.lvScheduleClass.Size = New System.Drawing.Size(662, 285)
        Me.lvScheduleClass.TabIndex = 7
        Me.lvScheduleClass.UseCompatibleStateImageBehavior = False
        Me.lvScheduleClass.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "     Type"
        Me.ColumnHeader9.Width = 84
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Course"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 165
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Venue"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 90
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Day"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 100
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "StartTime"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 109
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "EndTime"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 109
        '
        'ScheduleClassContextMenuStrip
        '
        Me.ScheduleClassContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSCToolStripMenuItem, Me.EditToolStripMenuItem1, Me.DeleteSCToolStripMenuItem})
        Me.ScheduleClassContextMenuStrip.Name = "ScheduleClassContextMenuStrip"
        Me.ScheduleClassContextMenuStrip.Size = New System.Drawing.Size(132, 70)
        '
        'AddSCToolStripMenuItem
        '
        Me.AddSCToolStripMenuItem.Image = CType(resources.GetObject("AddSCToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddSCToolStripMenuItem.Name = "AddSCToolStripMenuItem"
        Me.AddSCToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AddSCToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Image = Global.VBFinalProject.My.Resources.Resources.Edit1
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'DeleteSCToolStripMenuItem
        '
        Me.DeleteSCToolStripMenuItem.Image = CType(resources.GetObject("DeleteSCToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteSCToolStripMenuItem.Name = "DeleteSCToolStripMenuItem"
        Me.DeleteSCToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteSCToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DeleteSCToolStripMenuItem.Text = "Delete"
        '
        'CloudGroup1
        '
        Me.CloudGroup1.AnimationEnabled = True
        Me.CloudGroup1.AnimationSpeed = 10
        Me.CloudGroup1.BackColor = System.Drawing.Color.Transparent
        Me.CloudGroup1.BorderColor = System.Drawing.Color.DarkGray
        Me.CloudGroup1.BorderWidth = 1.0!
        Me.CloudGroup1.Controls.Add(Me.lblStickyNoteHelp)
        Me.CloudGroup1.Controls.Add(Me.txtStickyNotes)
        Me.CloudGroup1.FillColor1 = System.Drawing.Color.LightBlue
        Me.CloudGroup1.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup1.FillColor2_1 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup1.FillColor2_2 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloudGroup1.FontColorMouseOn = System.Drawing.Color.Yellow
        Me.CloudGroup1.FontColorNormal = System.Drawing.Color.Black
        Me.CloudGroup1.HeaderText = "                Sticky Notes"
        Me.CloudGroup1.Icon = CType(resources.GetObject("CloudGroup1.Icon"), System.Drawing.Bitmap)
        Me.CloudGroup1.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Left
        Me.CloudGroup1.IconPadding = 5
        Me.CloudGroup1.ImageHeader = False
        Me.CloudGroup1.IsOpen = False
        Me.CloudGroup1.Location = New System.Drawing.Point(710, 178)
        Me.CloudGroup1.MaximumHeight = 326
        Me.CloudGroup1.Name = "CloudGroup1"
        Me.CloudGroup1.PanelColor = System.Drawing.Color.Black
        Me.CloudGroup1.Size = New System.Drawing.Size(254, 27)
        Me.CloudGroup1.TabIndex = 14
        '
        'lblStickyNoteHelp
        '
        Me.lblStickyNoteHelp.AutoSize = True
        Me.lblStickyNoteHelp.BackColor = System.Drawing.Color.Black
        Me.lblStickyNoteHelp.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblStickyNoteHelp.Location = New System.Drawing.Point(58, 159)
        Me.lblStickyNoteHelp.Name = "lblStickyNoteHelp"
        Me.lblStickyNoteHelp.Size = New System.Drawing.Size(150, 13)
        Me.lblStickyNoteHelp.TabIndex = 10
        Me.lblStickyNoteHelp.Text = "Right click for more options"
        '
        'txtStickyNotes
        '
        Me.txtStickyNotes.BackColor = System.Drawing.Color.Black
        Me.txtStickyNotes.ContextMenuStrip = Me.StickyNotesPropertiesContextMenuStrip
        Me.txtStickyNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStickyNotes.ForeColor = System.Drawing.Color.White
        Me.txtStickyNotes.Location = New System.Drawing.Point(0, 27)
        Me.txtStickyNotes.Multiline = True
        Me.txtStickyNotes.Name = "txtStickyNotes"
        Me.txtStickyNotes.Size = New System.Drawing.Size(248, 296)
        Me.txtStickyNotes.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtStickyNotes, "Content Here Will Be Auto Saved.")
        '
        'StickyNotesPropertiesContextMenuStrip
        '
        Me.StickyNotesPropertiesContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeFontToolStripMenuItem, Me.ChangeColorToolStripMenuItem, Me.ClearAllToolStripMenuItem})
        Me.StickyNotesPropertiesContextMenuStrip.Name = "ImportantNotesPropertiesContextMenuStrip2"
        Me.StickyNotesPropertiesContextMenuStrip.Size = New System.Drawing.Size(148, 70)
        '
        'ChangeFontToolStripMenuItem
        '
        Me.ChangeFontToolStripMenuItem.Image = CType(resources.GetObject("ChangeFontToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeFontToolStripMenuItem.Name = "ChangeFontToolStripMenuItem"
        Me.ChangeFontToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ChangeFontToolStripMenuItem.Text = "Change Font"
        '
        'ChangeColorToolStripMenuItem
        '
        Me.ChangeColorToolStripMenuItem.Image = CType(resources.GetObject("ChangeColorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeColorToolStripMenuItem.Name = "ChangeColorToolStripMenuItem"
        Me.ChangeColorToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ChangeColorToolStripMenuItem.Text = "Change Color"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Image = CType(resources.GetObject("ClearAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 1
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipTitle = "[Help]"
        '
        'txtChangedLog
        '
        Me.txtChangedLog.BackColor = System.Drawing.Color.Black
        Me.txtChangedLog.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangedLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtChangedLog.Location = New System.Drawing.Point(3, 28)
        Me.txtChangedLog.Multiline = True
        Me.txtChangedLog.Name = "txtChangedLog"
        Me.txtChangedLog.ReadOnly = True
        Me.txtChangedLog.Size = New System.Drawing.Size(248, 260)
        Me.txtChangedLog.TabIndex = 13
        Me.txtChangedLog.Text = "ChangedLog here. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Retrieve From Online" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[If you see this, please check your in" & _
    "ternet connection]"
        Me.ToolTip1.SetToolTip(Me.txtChangedLog, "Content Here Retrieve from Online")
        '
        'CloudDigitalClock1
        '
        Me.CloudDigitalClock1.BackColor = System.Drawing.Color.Transparent
        Me.CloudDigitalClock1.ColorLower_1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.CloudDigitalClock1.ColorLower_2 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CloudDigitalClock1.ColorUpper_1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.CloudDigitalClock1.ColorUpper_2 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CloudDigitalClock1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloudDigitalClock1.DateColor = System.Drawing.Color.White
        Me.CloudDigitalClock1.DateFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CloudDigitalClock1.DrawDate = True
        Me.CloudDigitalClock1.Location = New System.Drawing.Point(707, 24)
        Me.CloudDigitalClock1.Name = "CloudDigitalClock1"
        Me.CloudDigitalClock1.NumberColor = System.Drawing.Color.Yellow
        Me.CloudDigitalClock1.NumberFont = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CloudDigitalClock1.Size = New System.Drawing.Size(254, 101)
        Me.CloudDigitalClock1.TabIndex = 4
        '
        'CloudPictureBox1
        '
        Me.CloudPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.CloudPictureBox1.BackColorStyle = CloudToolkitN6.CloudPictureBox.EnumBackColorStyle.LinearGradient
        Me.CloudPictureBox1.BackColorTransparency = 0
        Me.CloudPictureBox1.BackgroundimageStyle = CloudToolkitN6.CloudPictureBox.EnumBackgroundImageStyle.Stretch
        Me.CloudPictureBox1.BackgroundImageTransparency = 0
        Me.CloudPictureBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CloudPictureBox1.ControlBackgroundImage = CType(resources.GetObject("CloudPictureBox1.ControlBackgroundImage"), System.Drawing.Bitmap)
        Me.CloudPictureBox1.ControlOpacity = 255
        Me.CloudPictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CloudPictureBox1.DrawBorder = False
        Me.CloudPictureBox1.FirstGradientColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CloudPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.CloudPictureBox1.Name = "CloudPictureBox1"
        Me.CloudPictureBox1.SecondGradientColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CloudPictureBox1.Size = New System.Drawing.Size(974, 149)
        Me.CloudPictureBox1.TabIndex = 11
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.Image = CType(resources.GetObject("btnHide.Image"), System.Drawing.Image)
        Me.btnHide.Location = New System.Drawing.Point(92, 24)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(117, 101)
        Me.btnHide.TabIndex = 15
        Me.btnHide.Text = "[F1] Hide"
        Me.btnHide.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAbout.Location = New System.Drawing.Point(215, 24)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(117, 101)
        Me.btnAbout.TabIndex = 16
        Me.btnAbout.Text = "[F2] About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'FormContextMenuStrip
        '
        Me.FormContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ToolStripSeparator3, Me.SettingsToolStripMenuItem})
        Me.FormContextMenuStrip.Name = "FormContextMenuStrip"
        Me.FormContextMenuStrip.Size = New System.Drawing.Size(136, 126)
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Image = CType(resources.GetObject("HideToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.HideToolStripMenuItem.Text = "&Hide"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(132, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(132, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginAsToolStripStatusLabel, Me.AppNameToolStripStatusLabel, Me.DateTimeToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 507)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(974, 25)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LoginAsToolStripStatusLabel
        '
        Me.LoginAsToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.LoginAsToolStripStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.LoginAsToolStripStatusLabel.Image = CType(resources.GetObject("LoginAsToolStripStatusLabel.Image"), System.Drawing.Image)
        Me.LoginAsToolStripStatusLabel.Name = "LoginAsToolStripStatusLabel"
        Me.LoginAsToolStripStatusLabel.Size = New System.Drawing.Size(319, 20)
        Me.LoginAsToolStripStatusLabel.Spring = True
        Me.LoginAsToolStripStatusLabel.Text = "Login As : "
        '
        'AppNameToolStripStatusLabel
        '
        Me.AppNameToolStripStatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppNameToolStripStatusLabel.Name = "AppNameToolStripStatusLabel"
        Me.AppNameToolStripStatusLabel.Size = New System.Drawing.Size(319, 20)
        Me.AppNameToolStripStatusLabel.Spring = True
        Me.AppNameToolStripStatusLabel.Text = "Daily Schedule System"
        '
        'DateTimeToolStripStatusLabel
        '
        Me.DateTimeToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.DateTimeToolStripStatusLabel.Image = CType(resources.GetObject("DateTimeToolStripStatusLabel.Image"), System.Drawing.Image)
        Me.DateTimeToolStripStatusLabel.Name = "DateTimeToolStripStatusLabel"
        Me.DateTimeToolStripStatusLabel.Size = New System.Drawing.Size(319, 20)
        Me.DateTimeToolStripStatusLabel.Spring = True
        Me.DateTimeToolStripStatusLabel.Text = "Date and Time : "
        '
        'DateTimeTimer
        '
        Me.DateTimeTimer.Enabled = True
        Me.DateTimeTimer.Interval = 1000
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogout.Location = New System.Drawing.Point(338, 24)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(117, 101)
        Me.btnLogout.TabIndex = 18
        Me.btnLogout.Text = "[F3] Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'ScheduleAlertWatcherTimer
        '
        Me.ScheduleAlertWatcherTimer.Enabled = True
        Me.ScheduleAlertWatcherTimer.Interval = 1000
        '
        'ScheduleTaskWatcherTimer
        '
        Me.ScheduleTaskWatcherTimer.Enabled = True
        Me.ScheduleTaskWatcherTimer.Interval = 1000
        '
        'ScheduleClassWatcherTimer
        '
        Me.ScheduleClassWatcherTimer.Enabled = True
        Me.ScheduleClassWatcherTimer.Interval = 1000
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(461, 24)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 101)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "[F4] Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSetting
        '
        Me.btnSetting.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.Image = CType(resources.GetObject("btnSetting.Image"), System.Drawing.Image)
        Me.btnSetting.Location = New System.Drawing.Point(584, 24)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(117, 101)
        Me.btnSetting.TabIndex = 20
        Me.btnSetting.Text = "[F5] Setting"
        Me.btnSetting.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnSetting.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'CloudGroup2
        '
        Me.CloudGroup2.AnimationEnabled = True
        Me.CloudGroup2.AnimationSpeed = 10
        Me.CloudGroup2.BackColor = System.Drawing.Color.Transparent
        Me.CloudGroup2.BorderColor = System.Drawing.Color.DarkGray
        Me.CloudGroup2.BorderWidth = 1.0!
        Me.CloudGroup2.Controls.Add(Me.txtChangedLog)
        Me.CloudGroup2.FillColor1 = System.Drawing.Color.LightBlue
        Me.CloudGroup2.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup2.FillColor2_1 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup2.FillColor2_2 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup2.FontColorMouseOn = System.Drawing.Color.Yellow
        Me.CloudGroup2.FontColorNormal = System.Drawing.Color.Black
        Me.CloudGroup2.HeaderText = "                ChangedLog"
        Me.CloudGroup2.Icon = CType(resources.GetObject("CloudGroup2.Icon"), System.Drawing.Bitmap)
        Me.CloudGroup2.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Left
        Me.CloudGroup2.IconPadding = 5
        Me.CloudGroup2.ImageHeader = False
        Me.CloudGroup2.IsOpen = False
        Me.CloudGroup2.Location = New System.Drawing.Point(710, 212)
        Me.CloudGroup2.MaximumHeight = 292
        Me.CloudGroup2.Name = "CloudGroup2"
        Me.CloudGroup2.PanelColor = System.Drawing.Color.Black
        Me.CloudGroup2.Size = New System.Drawing.Size(254, 27)
        Me.CloudGroup2.TabIndex = 21
        '
        'CloudGroup3
        '
        Me.CloudGroup3.AnimationEnabled = True
        Me.CloudGroup3.AnimationSpeed = 4
        Me.CloudGroup3.BackColor = System.Drawing.Color.Transparent
        Me.CloudGroup3.BorderColor = System.Drawing.Color.DarkGray
        Me.CloudGroup3.BorderWidth = 1.0!
        Me.CloudGroup3.Controls.Add(Me.dtpRebootModem)
        Me.CloudGroup3.Controls.Add(Me.btnRebootModem)
        Me.CloudGroup3.Controls.Add(Me.lblRebootStatus)
        Me.CloudGroup3.Controls.Add(Me.Label4)
        Me.CloudGroup3.Controls.Add(Me.txtRebootTime)
        Me.CloudGroup3.FillColor1 = System.Drawing.Color.LightBlue
        Me.CloudGroup3.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup3.FillColor2_1 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup3.FillColor2_2 = System.Drawing.Color.DodgerBlue
        Me.CloudGroup3.FontColorMouseOn = System.Drawing.Color.Yellow
        Me.CloudGroup3.FontColorNormal = System.Drawing.Color.Black
        Me.CloudGroup3.HeaderText = "               RebootModem"
        Me.CloudGroup3.Icon = Nothing
        Me.CloudGroup3.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.CloudGroup3.IconPadding = 5
        Me.CloudGroup3.ImageHeader = False
        Me.CloudGroup3.IsOpen = True
        Me.CloudGroup3.Location = New System.Drawing.Point(710, 245)
        Me.CloudGroup3.MaximumHeight = 191
        Me.CloudGroup3.Name = "CloudGroup3"
        Me.CloudGroup3.PanelColor = System.Drawing.Color.Black
        Me.CloudGroup3.Size = New System.Drawing.Size(254, 259)
        Me.CloudGroup3.TabIndex = 22
        '
        'btnRebootModem
        '
        Me.btnRebootModem.BackColor = System.Drawing.Color.Black
        Me.btnRebootModem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRebootModem.ForeColor = System.Drawing.Color.Red
        Me.btnRebootModem.Location = New System.Drawing.Point(149, 129)
        Me.btnRebootModem.Name = "btnRebootModem"
        Me.btnRebootModem.Size = New System.Drawing.Size(75, 23)
        Me.btnRebootModem.TabIndex = 4
        Me.btnRebootModem.Text = "False"
        Me.btnRebootModem.UseVisualStyleBackColor = False
        '
        'lblRebootStatus
        '
        Me.lblRebootStatus.AutoSize = True
        Me.lblRebootStatus.ForeColor = System.Drawing.Color.White
        Me.lblRebootStatus.Location = New System.Drawing.Point(42, 134)
        Me.lblRebootStatus.Name = "lblRebootStatus"
        Me.lblRebootStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblRebootStatus.TabIndex = 3
        Me.lblRebootStatus.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(159, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "milesecond"
        '
        'txtRebootTime
        '
        Me.txtRebootTime.BackColor = System.Drawing.Color.Black
        Me.txtRebootTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRebootTime.Enabled = False
        Me.txtRebootTime.ForeColor = System.Drawing.Color.White
        Me.txtRebootTime.Location = New System.Drawing.Point(45, 83)
        Me.txtRebootTime.Name = "txtRebootTime"
        Me.txtRebootTime.Size = New System.Drawing.Size(108, 22)
        Me.txtRebootTime.TabIndex = 1
        Me.txtRebootTime.Text = "1800000"
        '
        'tRebootModem
        '
        Me.tRebootModem.Interval = 1800000
        '
        'dtpRebootModem
        '
        Me.dtpRebootModem.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpRebootModem.Location = New System.Drawing.Point(45, 43)
        Me.dtpRebootModem.Name = "dtpRebootModem"
        Me.dtpRebootModem.Size = New System.Drawing.Size(179, 22)
        Me.dtpRebootModem.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(974, 532)
        Me.ContextMenuStrip = Me.FormContextMenuStrip
        Me.Controls.Add(Me.CloudGroup3)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.CloudGroup1)
        Me.Controls.Add(Me.CloudDigitalClock1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CloudPictureBox1)
        Me.Controls.Add(Me.CloudGroup2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Schedule System"
        Me.TrayContextMenuStrip.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ScheduleAlertContextMenuStrip.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ScheduleTaskContextMenuStrip.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ScheduleClassContextMenuStrip.ResumeLayout(False)
        Me.CloudGroup1.ResumeLayout(False)
        Me.CloudGroup1.PerformLayout()
        Me.StickyNotesPropertiesContextMenuStrip.ResumeLayout(False)
        Me.FormContextMenuStrip.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.CloudGroup2.ResumeLayout(False)
        Me.CloudGroup2.PerformLayout()
        Me.CloudGroup3.ResumeLayout(False)
        Me.CloudGroup3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TrayNotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrayContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TrayShowHideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrayExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblStickyNoteHelp As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CloudDigitalClock1 As CloudToolkitN6.CloudDigitalClock
    Friend WithEvents CloudPictureBox1 As CloudToolkitN6.CloudPictureBox
    Friend WithEvents txtStickyNotes As System.Windows.Forms.TextBox
    Friend WithEvents StickyNotesPropertiesContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ChangeFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloudGroup1 As CloudToolkitN6.CloudGroup
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScheduleAlertHelp As System.Windows.Forms.Label
    Friend WithEvents ScheduleAlertContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddSAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents FormContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ScheduleTaskContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LoginAsToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AppNameToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DateTimeToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DateTimeTimer As System.Windows.Forms.Timer
    Private WithEvents AddSTToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblScheduleTaskHelp As System.Windows.Forms.Label
    Friend WithEvents lvScheduleAlert As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ScheduleAlertWatcherTimer As System.Windows.Forms.Timer
    Friend WithEvents DeleteSAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvScheduleTask As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeleteSTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScheduleTaskWatcherTimer As System.Windows.Forms.Timer
    Friend WithEvents lvScheduleClass As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ScheduleClassContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddSCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblScheduleClassHelp As System.Windows.Forms.Label
    Friend WithEvents ScheduleClassWatcherTimer As System.Windows.Forms.Timer
    Friend WithEvents TopMostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSetting As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditSAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloudGroup2 As CloudToolkitN6.CloudGroup
    Friend WithEvents txtChangedLog As System.Windows.Forms.TextBox
    Friend WithEvents CloudGroup3 As CloudToolkitN6.CloudGroup
    Friend WithEvents txtRebootTime As System.Windows.Forms.TextBox
    Friend WithEvents btnRebootModem As System.Windows.Forms.Button
    Friend WithEvents lblRebootStatus As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tRebootModem As System.Windows.Forms.Timer
    Friend WithEvents dtpRebootModem As System.Windows.Forms.DateTimePicker

End Class
