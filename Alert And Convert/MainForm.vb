Imports Microsoft.Win32

Public Class MainForm

    Dim strHandbrakePath As String

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim RUSure As Integer
        Dim flgChecked As Boolean = False
        If btnStart.Text = "Start" Then

            strHandbrakePath = RegRead("strHandbrakePath")
            If strHandbrakePath = "" Or strHandbrakePath = "0" Then
                MsgBox("No Handbrake Location Set -- Please Set Handbrake Location.  You must download the command line version of HANDBRAKE to use this ap - Download available in HELP.")
                Exit Sub
            End If


            btnStart.Text = "Stop"
            btnStart.Update()
            Me.lblStatus.Text = "Process Started"
            Me.lblStatus.Update()
            MainCode.Main()
        ElseIf btnStart.Text = "Stop" Then
            Me.Timer1.Stop()
            Me.Timer1.Enabled = False

            btnStart.Text = "Start"
            Me.lblStatus.Text = "Process Stopped."

            Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("handbrakecli")
            For Each p As Process In pProcess
                If p.MainWindowTitle <> "" Then
                    If flgChecked = False Then
                        RUSure = MsgBox("Do you want to force close current conversions?", MsgBoxStyle.OkCancel, "Really?  Really?")
                        flgChecked = True
                    End If
                    If RUSure <> 2 Then
                        p.Kill()

                        RUSure = MsgBox("Do you want to delete parially converted file? - " & RegRead("LastActionedFile"), MsgBoxStyle.OkCancel, "Really?  Really?")
                        If RUSure <> 2 Then
                            Kill(RegRead("LastActionedFile"))
                        End If
                    End If

                End If
            Next
            frmListFiles.Close()
        End If

    End Sub

    Private Sub btnFolderToWatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFolderToWatch.Click
        Dim TheFolder As String
        TheFolder = MainCode.RegRead("strFolderName")
        If TheFolder <> "0" Then
            FolderBrowserDialog1.SelectedPath = TheFolder
        End If
        FolderBrowserDialog1.ShowDialog()
        txtFolderToWatch.Text = FolderBrowserDialog1.SelectedPath
        MainCode.RegWrite("strFolderName", txtFolderToWatch.Text)

    End Sub

    Private Sub mainform_closing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub



    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'frmListFiles.Show()

        'NotifyIcon1.Visible = False



        Me.Timer2.Stop()
        Me.Timer2.Enabled = False
        Me.Text = "Alert and Convert v" & MainCode.GetVersion
        Try

            Me.FormBorderStyle = FormBorderStyle.FixedSingle

            txtFolderToWatch.Text = MainCode.GetFolderToWatch
            If txtFolderToWatch.Text = "0" Then
                txtFolderToWatch.Text = "Please Set Source Folder"
            End If

            MainCode.RegWrite("HomePath", Application.ExecutablePath)
            MainCode.RegWrite("LastActionedFile", "")

            cboPresets.Items.Add("Iphone 2G")
            cboPresets.Items.Add("Iphone 3G")
            cboPresets.Items.Add("Apple iPad")
            cboPresets.Items.Add("AppleTV")
            cboPresets.Items.Add("Ipod Legacy")
            cboPresets.Items.Add("QuickTime High Quality")
            cboPresets.Items.Add("Ipod")
            cboPresets.Items.Add("Universal")
            cboPresets.Items.Add("PSP")
            cboPresets.Items.Add("PS3")
            cboPresets.Items.Add("XBOX360")
            cboPresets.Items.Add("Custom")
            If MainCode.RegRead("txtPreset") <> "0" Then
                cboPresets.Text = MainCode.RegRead("txtPreset")
            Else
                cboPresets.Text = ("Iphone 2G")
            End If


            If MainCode.RegRead("StartMinimized") = 1 Then
                StartMinimizedToolStripMenuItem.CheckState = CheckState.Checked
                btnSysTray_Click(sender, e)
                MainCode.Alert("Alert & Convert Started")
            Else
                StartMinimizedToolStripMenuItem.CheckState = CheckState.Unchecked
            End If

            Application.DoEvents()

            If MainCode.RegRead("flgTwitter") = "1" Then
                chkTwitter.CheckState = CheckState.Checked
            Else
                chkTwitter.CheckState = CheckState.Unchecked
            End If

            If MainCode.RegRead("flgEmail") = "1" Then
                chkEmail.CheckState = CheckState.Checked
            Else
                chkEmail.CheckState = CheckState.Unchecked
            End If


            If MainCode.RegRead("UseScheduler") = "1" Then
                chkSchedule.CheckState = CheckState.Checked
            Else
                chkSchedule.CheckState = CheckState.Unchecked
            End If

            If MainCode.RegRead("txtConversionString") <> "0" Then
                txtConversionString.Text = MainCode.RegRead("txtConversionString")
            End If


            If MainCode.RegRead("flgRecursive") = "1" Then
                chkCheckRecursive.CheckState = CheckState.Checked
            Else
                chkCheckRecursive.CheckState = CheckState.Unchecked
            End If

            If MainCode.RegRead("BeginAtStartup") = 1 Then
                BeginConversionsOnStartUpToolStripMenuItem.CheckState = CheckState.Checked
                ' Delay(5)
                btnStart_Click(sender, e)
            Else
                BeginConversionsOnStartUpToolStripMenuItem.CheckState = CheckState.Unchecked
            End If

            If MainCode.RegRead("AddToItunes") = 1 Then
                AddConvertedFilesToITunesLibraryToolStripMenuItem.CheckState = CheckState.Checked
            Else
                AddConvertedFilesToITunesLibraryToolStripMenuItem.CheckState = CheckState.Unchecked
            End If






        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub chkConvert_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConvert.CheckedChanged

    End Sub

    Private Sub btnHandbrakeLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHandbrakeLocation.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "HandbrakeCLI.exe|HandbrakeCLI.exe"

        OpenFileDialog1.ShowDialog()
        strHandbrakePath = OpenFileDialog1.FileName
        Dim regKey As RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\AlertAndConvert", True)
        regKey.SetValue("strHandbrakePath", strHandbrakePath)
        regKey.Close()
    End Sub

    Private Sub chkTwitter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTwitter.CheckedChanged
        'Dim regKey As RegistryKey
        'regKey = Registry.LocalMachine.OpenSubKey("Software\AlertAndConvert", True)
        'strHandbrakePath = regKey.GetValue("strCurlPath", 0.0)
        'regKey.Close()
        'If strHandbrakePath = "0" Then
        '    MsgBox("No Curl Location Set -- Please Set Curl Location")
        'End If

        If MainCode.RegRead("strTwitterUserName") = "0" Then
            frmTwitterDetails.Show()
        End If

        MainCode.RegWrite("flgTwitter", chkTwitter.CheckState)

    End Sub

    Private Sub btnCurlLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurlLocation.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Curl.exe|Curl.exe"

        OpenFileDialog1.ShowDialog()
        strHandbrakePath = OpenFileDialog1.FileName
        Dim regKey As RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\AlertAndConvert", True)
        regKey.SetValue("strCurlPath", strHandbrakePath)
        regKey.Close()
    End Sub

    Private Sub btnTwitterOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwitterOptions.Click
        frmTwitterDetails.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmEmailDetails.Show()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If chkKeepChecking.Checked = True Then
            MainCode.Main()
        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

  

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub GetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetToolStripMenuItem.Click
    End Sub

    Private Sub GetCurlForTwitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub WebsiteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebsiteToolStripMenuItem1.Click
        MsgBox("Remember - for this program you need the Command Line Interface (CLI) version of Handbrake")
        System.Diagnostics.Process.Start("http://handbrake.fr/downloads2.php")
    End Sub

    Private Sub DirectDownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("http://www.gknw.net/mirror/curl/win32/curl-7.19.5-devel-mingw32.zip")
    End Sub


    Private Sub DirectDownloadToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectDownloadToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("http://handbrake.fr/rotation.php?file=HandBrake-0.9.4-Win_CLI.zip")
    End Sub

    Private Sub DonatePleaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonatePleaseToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=karchibald%40gmail%2ecom&lc=US&item_name=Kevs%20Software&item_number=alertandconvert&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHostedGuest")
    End Sub

    Private Sub txtConversionString_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConversionString.TextChanged
        If cboPresets.Text = "Custom" Then
            MainCode.RegWrite("txtCustomString", txtConversionString.Text)
        End If
        MainCode.RegWrite("txtConversionString", txtConversionString.Text)

    End Sub

    Private Sub cboPresets_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPresets.SelectedIndexChanged
        If cboPresets.SelectedItem = "Iphone 2G" Then
            txtConversionString.Text = "-i %s -o %d  -e x264 -q 0.589999973773956 -a 1 -E faac -B 128 -R 48 -6 dpl2 -f mp4 -X 480 -m -x level=30:cabac=0:ref=2:mixed-refs:analyse=all:me=umh:no-fast-pskip=1"
        ElseIf cboPresets.SelectedItem = "Iphone 3G" Then
            txtConversionString.Text = "-i %s -o %d  -e x264 -q 0.589999973773956 -a 1 -E faac -B 128 -R 48 -6 dpl2 -f mp4 -X 480 -m -x level=30:cabac=0:ref=2:mixed-refs:analyse=all:me=umh:no-fast-pskip=1"
        ElseIf cboPresets.SelectedItem = "Apple iPad" Then
            txtConversionString.Text = "-i %s -o %d  -f mp4 -O  --crop 80:80:0:0 --strict-anamorphic  --decomb -e x264 -q 19 -r 25 -a 1,1 -E faac,ac3 -6 dpl2,auto -R Auto,Auto -B 160,auto -D 2,0.0 -m -x b-adapt=2:rc-lookahead=50:ref=6:b-pyramid=1:me=umh:subq=9:analyse=all:trellis=2 -v 1"
        ElseIf cboPresets.SelectedItem = "Ipod Legacy" Then
            txtConversionString.Text = "-i %s -o %d  -e x264 -b 1500 -a 1 -E faac -B 160 -R 48 -6 dpl2 -f mp4 -I -X 640 -m -x level=30:bframes=0:cabac=0:ref=1:vbv-maxrate=1500:vbv-bufsize=2000:analyse=all:me=umh:no-fast-pskip=1"
        ElseIf cboPresets.SelectedItem = "AppleTV" Then
            txtConversionString.Text = "-i %s -o %d  -e x264 -b 2500 -a 1,1 -E faac,ac3 -B 160,auto -R 48,Auto -6 dpl2,auto -f mp4 -4 -p -m -x bframes=3:ref=1:subme=5:me=umh:no-fast-pskip=1:trellis=1:cabac=0"
        ElseIf cboPresets.SelectedItem = "QuickTime High Quality" Then
            txtConversionString.Text = "-i %s -o %d  -e x264 -b 1800 -a 1 -E faac -B 160 -R Auto -6 dpl2 -f mp4 -p -m -2 -T -x ref=3:mixed-refs:bframes=3:weightb:direct=auto:me=umh:subme=7:analyse=all:8x8dct:trellis=1:no-fast-pskip=1:psy-rd=1,1"
        ElseIf cboPresets.SelectedItem = "Ipod" Then
            txtConversionString.Text = "-i %s -o %d -e x264 -b 700 -a 1 -E faac -B 160 -R 48 -6 dpl2 -f mp4 -I -X 320 -m -x level=30:bframes=0:cabac=0:ref=1:vbv-maxrate=768:vbv-bufsize=2000:analyse=all:me=umh:no-fast-pskip=1"
        ElseIf cboPresets.SelectedItem = "Universal" Then
            txtConversionString.Text = "-i %s -o %d -e x264 -q 0.589999973773956 -a 1,1 -E faac,ac3 -B 160,auto -R 48,Auto -6 dpl2,auto -f mp4 -X 720 -P -m -x level=30:cabac=0:ref=3:mixed-refs=1:analyse=all:me=umh:no-fast-pskip=1"
        ElseIf cboPresets.SelectedItem = "PSP" Then
            txtConversionString.Text = "-i %s -o %d -b 1024 -a 1 -E faac -B 128 -R 48 -6 dpl2 -f mp4 -X 368 -Y 208 -m"
        ElseIf cboPresets.SelectedItem = "PS3" Then
            txtConversionString.Text = "-i %s -o %d  -e x264 -b 2500 -a 1 -E faac -B 160 -R 48 -6 dpl2 -f mp4 --crop 0:0:0:0 -p -x level=41:me=umh"
        ElseIf cboPresets.SelectedItem = "XBOX360" Then
            txtConversionString.Text = "-i %s -o %d -e x264 -b 2000 -a 1 -E faac -B 160 -R 48 -6 dpl2 -f mp4 -p -x level=40:ref=2:mixed-refs:bframes=3:weightb:subme=9:direct=auto:b-pyramid:me=umh:analyse=all:no-fast-pskip:filter=-2,-1"
        ElseIf cboPresets.SelectedItem = "Custom" Then
            txtConversionString.Text = MainCode.RegRead("txtCustomString")
        End If
        MainCode.RegWrite("txtPreset", cboPresets.Text)


    End Sub

    Private Sub chkSchedule_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSchedule.CheckedChanged
        If chkSchedule.CheckState = CheckState.Checked Then
            MainCode.RegWrite("UseScheduler", "1")
        Else
            MainCode.RegWrite("UseScheduler", "0")
        End If

        If chkSchedule.Checked = True Then
            If Me.WindowState <> FormWindowState.Minimized Then
                Scheduler.Show()
            End If
        Else
            chkSchedule.Text = "Use Scheduler"
        End If

    End Sub

    Private Sub VisitTheWebsiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisitTheWebsiteToolStripMenuItem.Click
        'http://pixeladdiction.co.uk/alertconvert
        System.Diagnostics.Process.Start("http://pixeladdiction.co.uk/alertconvert")
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.btnStart.Text = "Stop" Then
            Debug.Print("timer2 running through " & Now.ToString)
            MainCode.Main()
        End If
    End Sub



    Private Sub chkProcessConcurrent_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkProcessConcurrent.MouseHover
        ToolTip1.SetToolTip(chkProcessConcurrent, "Switch between processing files SEQUENTIALLY or CONCURRENTLY")
    End Sub



    Private Sub chkCheckRecursive_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCheckRecursive.MouseHover
        ToolTip1.SetToolTip(chkCheckRecursive, "Will compile a List of ALL video files in the directory tree if selected")
    End Sub

    Private Sub chkSchedule_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSchedule.MouseHover
        ToolTip1.SetToolTip(chkSchedule, "Conversions take a lot of processing power.  Set times when you DO NOT want conversions to take place here.")
    End Sub


    Private Sub btnSysTray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSysTray.Click
        'If Me.WindowState = FormWindowState.Minimized Then
        '    Me.Hide()
        'End If
        Me.ShowInTaskbar = False
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        NotifyIcon1.Visible = True

        frmListFiles.ShowInTaskbar = False
        frmListFiles.WindowState = FormWindowState.Minimized
        frmListFiles.Visible = False



    End Sub


    'Private Sub sysTrayIcon_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sysTrayIcon.MouseDown
    '    If (e.Button = MouseButtons.Left) Then
    '        Me.Show()
    '        Me.WindowState = FormWindowState.Normal
    '        Me.AllowTransparency = False
    '        Me.ShowInTaskbar = True
    '        Me.bringtofront()
    '    End If
    'End Sub


    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick, NotifyIcon1.Click

        frmListFiles.ShowInTaskbar = True
        frmListFiles.WindowState = FormWindowState.Normal
        frmListFiles.Visible = True


        Me.Visible = True
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        'Me.AllowTransparency = False
        Me.ShowInTaskbar = True
        Me.BringToFront()
        'NotifyIcon1.Visible = False


    End Sub


    Private Sub Form_Resize(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Me.WindowState = FormWindowState.Minimized Then
            btnSysTray_Click(sender, e)
        End If
    End Sub

    Private Sub MainForm_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd, Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            btnSysTray_Click(sender, e)
        End If
    End Sub



    Private Sub StartMinimizedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartMinimizedToolStripMenuItem.Click
        If StartMinimizedToolStripMenuItem.CheckState = CheckState.Unchecked Then
            StartMinimizedToolStripMenuItem.CheckState = CheckState.Checked
            MainCode.RegWrite("StartMinimized", "1")
        Else
            StartMinimizedToolStripMenuItem.CheckState = CheckState.Unchecked
            MainCode.RegWrite("StartMinimized", "0")
        End If
    End Sub

    Private Sub BeginConversionsOnStartUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeginConversionsOnStartUpToolStripMenuItem.Click
        If BeginConversionsOnStartUpToolStripMenuItem.CheckState = CheckState.Checked Then
            BeginConversionsOnStartUpToolStripMenuItem.CheckState = CheckState.Unchecked
            MainCode.RegWrite("BeginAtStartup", "0")
        Else
            BeginConversionsOnStartUpToolStripMenuItem.CheckState = CheckState.Checked
            MainCode.RegWrite("BeginAtStartup", "1")
        End If
    End Sub


    

    Private Sub chkEmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmail.CheckedChanged
        If MainCode.RegRead("strEmailUserName") = "0" Then
            frmEmailDetails.Show()
        End If
        MainCode.RegWrite("flgEmail", chkEmail.CheckState)

    End Sub

    Private Sub RunOnCompletionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunOnCompletionToolStripMenuItem.Click
        frmRunOnCompletion.Show()
    End Sub

    Private Sub chkCheckRecursive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckRecursive.CheckedChanged
        If Me.chkCheckRecursive.CheckState = True Then
            MainCode.RegWrite("flgRecursive", "1")
        Else
            MainCode.RegWrite("flgRecursive", "0")
        End If
    End Sub

    Private Sub txtFolderToWatch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFolderToWatch.LostFocus
        MainCode.RegWrite("strFolderName", txtFolderToWatch.Text)
    End Sub

    Private Sub txtFolderToWatch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFolderToWatch.TextChanged
        '    MainCode.RegWrite("strFolderName", txtFolderToWatch.Text)
    End Sub

    Private Sub AddConvertedFilesToITunesLibraryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddConvertedFilesToITunesLibraryToolStripMenuItem.Click

        If AddConvertedFilesToITunesLibraryToolStripMenuItem.CheckState = CheckState.Unchecked Then
            AddConvertedFilesToITunesLibraryToolStripMenuItem.CheckState = CheckState.Checked
            MainCode.RegWrite("AddToItunes", "1")
            If MainCode.RegRead("strAutomaticAddPath") = "0" Then
                MsgBox("Be sure to set the AUTOMATICALLY ADD TO ITUNES path (not currently set)")
            End If
        Else
            AddConvertedFilesToITunesLibraryToolStripMenuItem.CheckState = CheckState.Unchecked
            MainCode.RegWrite("AddToItunes", "0")
        End If
    End Sub

    Private Sub SetAutomaticallyAddToItunesFolderLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAutomaticallyAddToItunesFolderLocationToolStripMenuItem.Click
        Dim TheFolder As String
        TheFolder = MainCode.RegRead("strAutomaticAddPath")
        If TheFolder <> "0" Then
            FolderBrowserDialog1.SelectedPath = TheFolder
        End If
        FolderBrowserDialog1.ShowDialog()
        MainCode.RegWrite("strAutomaticAddPath", FolderBrowserDialog1.SelectedPath)
    End Sub
End Class
