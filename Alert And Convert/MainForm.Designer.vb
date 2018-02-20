<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnFolderToWatch = New System.Windows.Forms.Button
        Me.txtFolderToWatch = New System.Windows.Forms.TextBox
        Me.btnStart = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkCheckRecursive = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFilter = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnTwitterOptions = New System.Windows.Forms.Button
        Me.btnCurlLocation = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.chkEmail = New System.Windows.Forms.CheckBox
        Me.chkTwitter = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkProcessConcurrent = New System.Windows.Forms.CheckBox
        Me.chkSchedule = New System.Windows.Forms.CheckBox
        Me.chkPrompt = New System.Windows.Forms.CheckBox
        Me.chkKeepChecking = New System.Windows.Forms.CheckBox
        Me.chkOverwrite = New System.Windows.Forms.CheckBox
        Me.btnHandbrakeLocation = New System.Windows.Forms.Button
        Me.cboPresets = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtConversionString = New System.Windows.Forms.TextBox
        Me.chkConvert = New System.Windows.Forms.CheckBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.lblStatus = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartUpOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartMinimizedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BeginConversionsOnStartUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RunOnCompletionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddConvertedFilesToITunesLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DirectDownloadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.WebsiteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VisitTheWebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DonatePleaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSysTray = New System.Windows.Forms.Button
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SetAutomaticallyAddToItunesFolderLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFolderToWatch
        '
        Me.btnFolderToWatch.Location = New System.Drawing.Point(376, 48)
        Me.btnFolderToWatch.Name = "btnFolderToWatch"
        Me.btnFolderToWatch.Size = New System.Drawing.Size(75, 23)
        Me.btnFolderToWatch.TabIndex = 0
        Me.btnFolderToWatch.Text = "&Change"
        Me.btnFolderToWatch.UseVisualStyleBackColor = True
        '
        'txtFolderToWatch
        '
        Me.txtFolderToWatch.Location = New System.Drawing.Point(7, 22)
        Me.txtFolderToWatch.Name = "txtFolderToWatch"
        Me.txtFolderToWatch.Size = New System.Drawing.Size(445, 20)
        Me.txtFolderToWatch.TabIndex = 1
        Me.txtFolderToWatch.Text = "c:\temp"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(368, 396)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(101, 48)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCheckRecursive)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtFilter)
        Me.GroupBox1.Controls.Add(Me.txtFolderToWatch)
        Me.GroupBox1.Controls.Add(Me.btnFolderToWatch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 79)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Folder to Watch"
        '
        'chkCheckRecursive
        '
        Me.chkCheckRecursive.AutoSize = True
        Me.chkCheckRecursive.Location = New System.Drawing.Point(172, 53)
        Me.chkCheckRecursive.Name = "chkCheckRecursive"
        Me.chkCheckRecursive.Size = New System.Drawing.Size(145, 17)
        Me.chkCheckRecursive.TabIndex = 4
        Me.chkCheckRecursive.Text = "Check Recursive Folders"
        Me.chkCheckRecursive.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Filter (*.avi)"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(7, 51)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(44, 20)
        Me.txtFilter.TabIndex = 2
        Me.txtFilter.Text = "*.avi"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTwitterOptions)
        Me.GroupBox2.Controls.Add(Me.btnCurlLocation)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.chkEmail)
        Me.GroupBox2.Controls.Add(Me.chkTwitter)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 96)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alert Options"
        '
        'btnTwitterOptions
        '
        Me.btnTwitterOptions.Location = New System.Drawing.Point(77, 19)
        Me.btnTwitterOptions.Name = "btnTwitterOptions"
        Me.btnTwitterOptions.Size = New System.Drawing.Size(120, 19)
        Me.btnTwitterOptions.TabIndex = 8
        Me.btnTwitterOptions.Text = "Set Twitter Options"
        Me.btnTwitterOptions.UseVisualStyleBackColor = True
        '
        'btnCurlLocation
        '
        Me.btnCurlLocation.Enabled = False
        Me.btnCurlLocation.Location = New System.Drawing.Point(203, 19)
        Me.btnCurlLocation.Name = "btnCurlLocation"
        Me.btnCurlLocation.Size = New System.Drawing.Size(121, 20)
        Me.btnCurlLocation.TabIndex = 7
        Me.btnCurlLocation.Text = "Curl Location"
        Me.btnCurlLocation.UseVisualStyleBackColor = True
        Me.btnCurlLocation.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(77, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 19)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Set Email Options"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(9, 58)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(51, 17)
        Me.chkEmail.TabIndex = 5
        Me.chkEmail.Text = "Email"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'chkTwitter
        '
        Me.chkTwitter.AutoSize = True
        Me.chkTwitter.Location = New System.Drawing.Point(9, 19)
        Me.chkTwitter.Name = "chkTwitter"
        Me.chkTwitter.Size = New System.Drawing.Size(58, 17)
        Me.chkTwitter.TabIndex = 0
        Me.chkTwitter.Text = "Twitter"
        Me.chkTwitter.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkProcessConcurrent)
        Me.GroupBox3.Controls.Add(Me.chkSchedule)
        Me.GroupBox3.Controls.Add(Me.chkPrompt)
        Me.GroupBox3.Controls.Add(Me.chkKeepChecking)
        Me.GroupBox3.Controls.Add(Me.chkOverwrite)
        Me.GroupBox3.Controls.Add(Me.btnHandbrakeLocation)
        Me.GroupBox3.Controls.Add(Me.cboPresets)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtConversionString)
        Me.GroupBox3.Controls.Add(Me.chkConvert)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 214)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(456, 176)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Convert Options"
        '
        'chkProcessConcurrent
        '
        Me.chkProcessConcurrent.AutoSize = True
        Me.chkProcessConcurrent.Location = New System.Drawing.Point(226, 133)
        Me.chkProcessConcurrent.Name = "chkProcessConcurrent"
        Me.chkProcessConcurrent.Size = New System.Drawing.Size(150, 17)
        Me.chkProcessConcurrent.TabIndex = 16
        Me.chkProcessConcurrent.Text = "Process Files Concurrently"
        Me.chkProcessConcurrent.UseVisualStyleBackColor = True
        '
        'chkSchedule
        '
        Me.chkSchedule.AutoSize = True
        Me.chkSchedule.Location = New System.Drawing.Point(6, 110)
        Me.chkSchedule.Name = "chkSchedule"
        Me.chkSchedule.Size = New System.Drawing.Size(96, 17)
        Me.chkSchedule.TabIndex = 15
        Me.chkSchedule.Text = "Use Scheduler"
        Me.chkSchedule.UseVisualStyleBackColor = True
        '
        'chkPrompt
        '
        Me.chkPrompt.AutoSize = True
        Me.chkPrompt.Location = New System.Drawing.Point(6, 152)
        Me.chkPrompt.Name = "chkPrompt"
        Me.chkPrompt.Size = New System.Drawing.Size(180, 17)
        Me.chkPrompt.TabIndex = 14
        Me.chkPrompt.Text = "Prompt Before Batch Conversion"
        Me.chkPrompt.UseVisualStyleBackColor = True
        Me.chkPrompt.Visible = False
        '
        'chkKeepChecking
        '
        Me.chkKeepChecking.AutoSize = True
        Me.chkKeepChecking.Checked = True
        Me.chkKeepChecking.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKeepChecking.Location = New System.Drawing.Point(226, 110)
        Me.chkKeepChecking.Name = "chkKeepChecking"
        Me.chkKeepChecking.Size = New System.Drawing.Size(229, 17)
        Me.chkKeepChecking.TabIndex = 13
        Me.chkKeepChecking.Text = "Keep Checking Source Folder Every 5 Mins"
        Me.chkKeepChecking.UseVisualStyleBackColor = True
        '
        'chkOverwrite
        '
        Me.chkOverwrite.AutoSize = True
        Me.chkOverwrite.Location = New System.Drawing.Point(6, 131)
        Me.chkOverwrite.Name = "chkOverwrite"
        Me.chkOverwrite.Size = New System.Drawing.Size(171, 17)
        Me.chkOverwrite.TabIndex = 12
        Me.chkOverwrite.Text = "Overwrite Existing Conversions"
        Me.chkOverwrite.UseVisualStyleBackColor = True
        Me.chkOverwrite.Visible = False
        '
        'btnHandbrakeLocation
        '
        Me.btnHandbrakeLocation.Location = New System.Drawing.Point(329, 19)
        Me.btnHandbrakeLocation.Name = "btnHandbrakeLocation"
        Me.btnHandbrakeLocation.Size = New System.Drawing.Size(121, 25)
        Me.btnHandbrakeLocation.TabIndex = 11
        Me.btnHandbrakeLocation.Text = "Handbrake Location"
        Me.btnHandbrakeLocation.UseVisualStyleBackColor = True
        '
        'cboPresets
        '
        Me.cboPresets.FormattingEnabled = True
        Me.cboPresets.Location = New System.Drawing.Point(325, 60)
        Me.cboPresets.Name = "cboPresets"
        Me.cboPresets.Size = New System.Drawing.Size(121, 21)
        Me.cboPresets.TabIndex = 10
        Me.cboPresets.Text = "Iphone 2G"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Conversion Arguments (use %s for source %d for destination file)"
        '
        'txtConversionString
        '
        Me.txtConversionString.Location = New System.Drawing.Point(6, 84)
        Me.txtConversionString.Name = "txtConversionString"
        Me.txtConversionString.Size = New System.Drawing.Size(445, 20)
        Me.txtConversionString.TabIndex = 7
        Me.txtConversionString.Text = "-i %s -o %d  -e x264 -q 0.589999973773956 -a 1 -E faac -B 128 -R 48 -6 dpl2 -f mp" & _
            "4 -X 480 -m -x level=30:cabac=0:ref=2:mixed-refs:analyse=all:me=umh:no-fast-pski" & _
            "p=1"
        '
        'chkConvert
        '
        Me.chkConvert.AutoSize = True
        Me.chkConvert.Checked = True
        Me.chkConvert.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConvert.Location = New System.Drawing.Point(6, 28)
        Me.chkConvert.Name = "chkConvert"
        Me.chkConvert.Size = New System.Drawing.Size(168, 17)
        Me.chkConvert.TabIndex = 6
        Me.chkConvert.Text = "Convert File Using Handbrake"
        Me.chkConvert.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 300000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(9, 427)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(472, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator, Me.toolStripSeparator1, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(89, 6)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(89, 6)
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(89, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartUpOptionsToolStripMenuItem, Me.RunOnCompletionToolStripMenuItem, Me.AddConvertedFilesToITunesLibraryToolStripMenuItem, Me.SetAutomaticallyAddToItunesFolderLocationToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'StartUpOptionsToolStripMenuItem
        '
        Me.StartUpOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartMinimizedToolStripMenuItem, Me.BeginConversionsOnStartUpToolStripMenuItem})
        Me.StartUpOptionsToolStripMenuItem.Name = "StartUpOptionsToolStripMenuItem"
        Me.StartUpOptionsToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.StartUpOptionsToolStripMenuItem.Text = "Start-Up Options"
        '
        'StartMinimizedToolStripMenuItem
        '
        Me.StartMinimizedToolStripMenuItem.Name = "StartMinimizedToolStripMenuItem"
        Me.StartMinimizedToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.StartMinimizedToolStripMenuItem.Text = "Start Minimized"
        '
        'BeginConversionsOnStartUpToolStripMenuItem
        '
        Me.BeginConversionsOnStartUpToolStripMenuItem.Name = "BeginConversionsOnStartUpToolStripMenuItem"
        Me.BeginConversionsOnStartUpToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.BeginConversionsOnStartUpToolStripMenuItem.Text = "Begin Conversions on StartUp"
        '
        'RunOnCompletionToolStripMenuItem
        '
        Me.RunOnCompletionToolStripMenuItem.Name = "RunOnCompletionToolStripMenuItem"
        Me.RunOnCompletionToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.RunOnCompletionToolStripMenuItem.Text = "Run on Completion Options"
        '
        'AddConvertedFilesToITunesLibraryToolStripMenuItem
        '
        Me.AddConvertedFilesToITunesLibraryToolStripMenuItem.Name = "AddConvertedFilesToITunesLibraryToolStripMenuItem"
        Me.AddConvertedFilesToITunesLibraryToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.AddConvertedFilesToITunesLibraryToolStripMenuItem.Text = "Add Converted Files to ITunes Library"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.GetToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem, Me.VisitTheWebsiteToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.DonatePleaseToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Enabled = False
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Enabled = False
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'GetToolStripMenuItem
        '
        Me.GetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectDownloadToolStripMenuItem1, Me.WebsiteToolStripMenuItem1})
        Me.GetToolStripMenuItem.Name = "GetToolStripMenuItem"
        Me.GetToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.GetToolStripMenuItem.Text = "Get Handbrake"
        '
        'DirectDownloadToolStripMenuItem1
        '
        Me.DirectDownloadToolStripMenuItem1.Name = "DirectDownloadToolStripMenuItem1"
        Me.DirectDownloadToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.DirectDownloadToolStripMenuItem1.Text = "Direct Download"
        '
        'WebsiteToolStripMenuItem1
        '
        Me.WebsiteToolStripMenuItem1.Name = "WebsiteToolStripMenuItem1"
        Me.WebsiteToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.WebsiteToolStripMenuItem1.Text = "Website"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(170, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'VisitTheWebsiteToolStripMenuItem
        '
        Me.VisitTheWebsiteToolStripMenuItem.Name = "VisitTheWebsiteToolStripMenuItem"
        Me.VisitTheWebsiteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.VisitTheWebsiteToolStripMenuItem.Text = "Visit The Website"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check For Updates"
        '
        'DonatePleaseToolStripMenuItem
        '
        Me.DonatePleaseToolStripMenuItem.Name = "DonatePleaseToolStripMenuItem"
        Me.DonatePleaseToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.DonatePleaseToolStripMenuItem.Text = "Donate? Please?"
        '
        'Timer2
        '
        Me.Timer2.Interval = 20000
        '
        'btnSysTray
        '
        Me.btnSysTray.Location = New System.Drawing.Point(282, 396)
        Me.btnSysTray.Name = "btnSysTray"
        Me.btnSysTray.Size = New System.Drawing.Size(80, 48)
        Me.btnSysTray.TabIndex = 9
        Me.btnSysTray.Text = "To System Tray"
        Me.btnSysTray.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Alert And Convert"
        Me.NotifyIcon1.Visible = True
        '
        'SetAutomaticallyAddToItunesFolderLocationToolStripMenuItem
        '
        Me.SetAutomaticallyAddToItunesFolderLocationToolStripMenuItem.Name = "SetAutomaticallyAddToItunesFolderLocationToolStripMenuItem"
        Me.SetAutomaticallyAddToItunesFolderLocationToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.SetAutomaticallyAddToItunesFolderLocationToolStripMenuItem.Text = "Set ""Automatically Add to Itunes"" Folder Location"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 449)
        Me.Controls.Add(Me.btnSysTray)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Alert and Convert v1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFolderToWatch As System.Windows.Forms.Button
    Friend WithEvents txtFolderToWatch As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTwitter As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkEmail As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkConvert As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConversionString As System.Windows.Forms.TextBox
    Friend WithEvents cboPresets As System.Windows.Forms.ComboBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnHandbrakeLocation As System.Windows.Forms.Button
    Friend WithEvents chkCheckRecursive As System.Windows.Forms.CheckBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnTwitterOptions As System.Windows.Forms.Button
    Friend WithEvents chkOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents chkKeepChecking As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrompt As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectDownloadToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebsiteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonatePleaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkSchedule As System.Windows.Forms.CheckBox
    Friend WithEvents VisitTheWebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkProcessConcurrent As System.Windows.Forms.CheckBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnCurlLocation As System.Windows.Forms.Button
    Friend WithEvents btnSysTray As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartUpOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartMinimizedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeginConversionsOnStartUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunOnCompletionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddConvertedFilesToITunesLibraryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAutomaticallyAddToItunesFolderLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
