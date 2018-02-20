Imports System.IO
Imports Microsoft.Win32
'Imports Yedda.Twitter
Imports System.Net.Mail
''ALERT AND CONVERT!
Imports System.Runtime.InteropServices







Module MainCode
    Public strFolderName As String
    Public strConvertedFolderName As String
    Public strTwitterUsername As String
    Public strTwitterPassword As String
    Public flgAlertTwitter As Boolean
    Public flgAlertEmail As Boolean
    Public flgConvert As Boolean
    Public flgAllDone As Boolean
    Public flgRunOnCompletion As Boolean
    Public strRunOnFileCompletion As String
    Public strRunOnAllFilesCompletion As String
    Public flgCheckRecursive As Boolean
    Public strCurlPath As String
    Public strHandbrakePath As String
    Public strHandbrakeString As String
    Public strEmailAddress As String
    Public strEMailPassword As String
    Public flgScheduleOn As Boolean
    Public flgCurrentlyConverting As Boolean
    Public LastFileSource As String
    Public LastFileDestination As String
    Declare Function TwitterooCore Lib "TiwtterooCore.dll" ()


    Public Sub Main()
        LoadVariables()
        MainForm.Timer1.Stop()
        MainForm.Timer1.Enabled = False
        Dim RightNow As Integer
        Dim ScheduleStart, ScheduleEnd As Integer


        RightNow = Hour(Now()) & Microsoft.VisualBasic.Right("00" & Minute(Now()), 2)
        ScheduleStart = RegRead("ScheduleStart")
        ScheduleEnd = RegRead("ScheduleEnd")

        If flgScheduleOn = True Then
            If RightNow >= ScheduleStart And RightNow < ScheduleEnd Then
                If MainForm.lblStatus.Text <> "WAITING FOR SCHEDULE " & RegRead("ScheduleStart") & " - " & RegRead("ScheduleEnd") Then
                    MainForm.NotifyIcon1.ShowBalloonTip(500, "Alert And Convert", MainForm.lblStatus.Text, ToolTipIcon.Info)
                End If
                MainForm.lblStatus.Text = "WAITING FOR SCHEDULE " & RegRead("ScheduleStart") & " - " & RegRead("ScheduleEnd")
                MainForm.Timer1.Start()
                MainForm.Timer1.Enabled = True
                Exit Sub
            End If
        End If

        GetFolderToWatch()
        CheckfoldersExist()

        If strFolderName = "0" Then
            Exit Sub
        End If

        If flgCheckRecursive = True Then
            CheckFolderRecursive()
        Else
            CheckFolder()
        End If

        Application.DoEvents()

        Convert()

    End Sub

    Public Sub CheckfoldersExist()
        If (My.Computer.FileSystem.DirectoryExists(strFolderName)) = True Then
            If (My.Computer.FileSystem.DirectoryExists(strConvertedFolderName)) = False Then
                '     Directory.CreateDirectory(strConvertedFolderName)
            End If
        Else
            MsgBox("Source Folder Does Not Exist. Please point it to a valid folder.")
            Exit Sub
        End If
    End Sub

    Public Sub LoadVariables()
        strFolderName = MainForm.txtFolderToWatch.Text
        If strFolderName = "0" Then
            Exit Sub
        End If
        strConvertedFolderName = MainForm.txtFolderToWatch.Text & "\Converted"
        strTwitterUsername = RegRead("strTwitterUsername")
        strTwitterPassword = RegRead("strTwitterPassword")

        strEmailAddress = RegRead("strEmailUserName")
        strEMailPassword = RegRead("strEmailPassword")

        strHandbrakeString = MainForm.txtConversionString.Text

        flgAlertTwitter = MainForm.chkTwitter.CheckState
        flgAlertEmail = MainForm.chkEmail.CheckState
        flgConvert = MainForm.chkConvert.CheckState
        flgCheckRecursive = MainForm.chkCheckRecursive.CheckState
        flgScheduleOn = MainForm.chkSchedule.CheckState

        flgRunOnCompletion = RegRead("flgRunOnCompletion")
        strRunOnAllFilesCompletion = RegRead("strRunAfterAllFiles")
        strRunOnFileCompletion = RegRead("strRunAfterEachFile")


    End Sub

    Public Sub CheckFolder()
        Dim filenames() As String = Directory.GetFiles(strFolderName, MainForm.txtFilter.Text, SearchOption.TopDirectoryOnly)
        Dim i As Integer
        Dim filename As String
        Try

            frmListFiles.lstFiles.Items.Clear()
            For i = 0 To filenames.Length - 1
                ' filename = Path.GetFileName(filenames(i)) ' This is much better than relying on substring to be accurate
                filename = Path.GetFullPath(filenames(i))
                frmListFiles.lstFiles.Items.Add(filename)
            Next i
            frmListFiles.Show()
            If filenames.Length = 0 Then
                frmListFiles.lstFiles.Items.Add("No files Found to Convert")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub CheckFolderRecursive()
        Dim filenames() As String = Directory.GetFiles(strFolderName, MainForm.txtFilter.Text, SearchOption.AllDirectories)
        Dim i As Integer
        Dim filename As String
        frmListFiles.lstFiles.Items.Clear()
        For i = 0 To filenames.Length - 1
            'filename = Path.GetFileName(filenames(i)) ' This is much better than relying on substring to be accurate
            filename = Path.GetFullPath(filenames(i))
            frmListFiles.lstFiles.Items.Add(filename)
        Next i
        frmListFiles.Show()
        If filenames.Length = 0 Then
            frmListFiles.lstFiles.Items.Add("No files Found to Convert")
        End If
    End Sub




    Public Sub Alert(ByVal CurrentStatus As String)
        Dim tipicon As ToolTipIcon
        tipicon = ToolTipIcon.Info
        MainForm.lblStatus.Text = CurrentStatus
        MainForm.lblStatus.Update()
        MainForm.NotifyIcon1.ShowBalloonTip(500, "Alert And Convert", CurrentStatus, tipicon)
        LoadVariables()
        Dim EmailPort As Integer

        EmailPort = RegRead("strEmailPort")

        'If flgAlertTwitter = True Then
        '    Try
        '        Dim myProcess As System.Diagnostics.Process = New System.Diagnostics.Process()
        '        Dim TwitterString As String
        '        ' UpdateAsXML(strTwitterUsername, strTwitterPassword, "HELLO WORLD")
        '        'curl string should look like : curl -u CCI_BITeam:admincc -d status="PriceComp Synnex Files FAILED" http://twitter.com/statuses/update.xml

        '        TwitterString = "-u " & strTwitterUsername & ":" & strTwitterPassword & " -d status=" & """" & CurrentStatus & """" & " http://twitter.com/statuses/update.xml"
        '        myProcess.StartInfo.FileName = strCurlPath
        '        myProcess.StartInfo.Arguments = TwitterString
        '        myProcess.StartInfo.WindowStyle = _
        '           System.Diagnostics.ProcessWindowStyle.Normal
        '        Debug.Print(strCurlPath & " " & TwitterString)
        '        myProcess.Start()
        '        myProcess.WaitForExit()



        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try
        'End If
        Try
            System.Net.ServicePointManager.Expect100Continue = False
            If flgAlertTwitter = True Then
                Dim that As New RareEdge.Twitteroo.TwitterooCore(strTwitterUsername, strTwitterPassword)
                'Dim THis As New RareEdge.Twitteroo.User
                'THis.ScreenName = strTwitterUsername
                'THis.Name = strTwitterUsername
                'THis.Id = strTwitterUsername
                that.Username = strTwitterUsername
                that.Password = strTwitterPassword
                that.ChangeStatus(CurrentStatus & " #AlertConvert")
            End If
        Catch ex As Exception
            MsgBox("Error sending TWEET - Invalid Twitter Login Details or Twitter is Down (Avast Fail Whale!). -- " & ex.ToString)
        End Try

        If flgAlertEmail = True Then
            Try
                Dim SmtpServer As New SmtpClient()
                Dim mail As New MailMessage()
                SmtpServer.Credentials = New  _
                Net.NetworkCredential(strEmailAddress, strEMailPassword)
                SmtpServer.Port = EmailPort
                SmtpServer.Host = RegRead("strEmailsmtp")
                mail = New MailMessage()
                mail.From = New MailAddress(strEmailAddress)
                mail.To.Add(strEmailAddress)
                mail.Subject = "ALERT AND CONVERT -  " & CurrentStatus
                mail.Body = "Message from ALERT AND CONVERT -" & CurrentStatus & " Message Sent at - " & Now.ToString
                SmtpServer.EnableSsl = True
                SmtpServer.Send(mail)
                '                MsgBox("mail send")
            Catch ex As Exception
                MsgBox("Email Failed.  Check Username, Password and Server.  Error Message - " & ex.ToString)
            End Try
        End If




    End Sub

    Public Sub Convert()
        Dim CurrentFileName As String
        Dim CurrentFilePath As String
        Dim StrippedName As String
        Dim FileCount As Integer
        Dim Counter As Integer = 0
        Dim RUSure As Integer
        Dim ConvertString As String
        Dim ExecuteString As String
        Dim CurrentStatus As String
        Dim ConvertFlag As Boolean = True
        Dim ConvertedAnything As Boolean = False

        Dim myProcess As System.Diagnostics.Process = New System.Diagnostics.Process()
        Dim RunThis As System.Diagnostics.Process = New System.Diagnostics.Process()
  
        Dim AppFolder As String
        Dim LogFileName As String

  
        Try
            AppFolder = System.AppDomain.CurrentDomain.BaseDirectory()
            LogFileName = AppFolder & "\" & "FilesProcessed.txt"
            'If System.IO.File.Exists(LogFileName) Then  ' CODE HERE TO UPDATE LOG FILE
            '    oWrite = oFile.AppendText(LogFileName)

            'Else
            '    oWrite = oFile.CreateText(LogFileName)
            'End If



            If flgConvert = True Then
                If strHandbrakePath = Nothing Then
                    MsgBox("Please set Handbrake Path First")
                    Exit Sub
                End If
                If MainForm.chkPrompt.Checked = True Then
                    RUSure = MsgBox("Are you sure you want to convert these files?", MsgBoxStyle.OkCancel, "Really?  Really?")
                Else
                    RUSure = 5
                End If

                If RUSure <> 2 Then
                    FileCount = frmListFiles.lstFiles.Items.Count
                    While Counter < FileCount And MainForm.btnStart.Text = "Stop"
                        CurrentFileName = frmListFiles.lstFiles.Items(Counter).ToString()
                        StrippedName = Mid(CurrentFileName, 1, Len(CurrentFileName) - 4)
                        CurrentFilePath = Path.GetDirectoryName(CurrentFileName)
                        ConvertString = Replace(strHandbrakeString, "%s", """" & CurrentFileName & """")
                        ConvertString = Replace(ConvertString, "%d", """" & StrippedName & ".mp4" & """")

                        'Check to see if MP4 exists
                        If MainForm.chkOverwrite.Checked = False Then
                            If System.IO.File.Exists(StrippedName & ".MP4") Then
                                '  MsgBox("FIle Exists")
                                ConvertFlag = False
                            Else
                                ' MsgBox("File Does Not Exist")
                                ConvertFlag = True
                            End If
                        Else
                            ConvertFlag = True
                        End If 'Check Pre Existing File exists

                        'Check to see if it is currently converting anything
                        flgCurrentlyConverting = False
                        Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("handbrakecli")
                        For Each p As Process In pProcess
                            If p.MainWindowTitle <> "" Then
                                flgCurrentlyConverting = True
                                MainForm.Update()
                            End If
                        Next

                        If flgCurrentlyConverting = True And MainForm.chkProcessConcurrent.Checked = False Then
                            MainForm.Update()
                            MainForm.Focus()
                            Exit Sub
                        End If



                        'If flgCurrentlyConverting = False And flgRunOnCompletion = True Then
                        '    If RegRead("LastActionedFile") <> LastFileDestination And LastFileDestination <> "" And LastFileDestination <> Nothing Then
                        '        Try
                        '            If strRunOnFileCompletion <> "" Then
                        '                If InStr(strRunOnFileCompletion, " ") > 0 Then
                        '                    RunThisFilename = Trim(Left(strRunOnFileCompletion, InStr(strRunOnFileCompletion, " ") - 1))
                        '                    RunThisArguments = Trim(Mid(strRunOnFileCompletion, InStr(strRunOnFileCompletion, " ") + 1, Len(strRunOnAllFilesCompletion)))
                        '                    RunThisArguments = Replace(RunThisArguments, "%s", """" & CurrentFileName & """")
                        '                    RunThisArguments = Replace(RunThisArguments, "%d", """" & LastFileDestination & """")
                        '                    RunThis.StartInfo.Arguments = RunThisArguments

                        '                Else
                        '                    RunThisFilename = strRunOnFileCompletion
                        '                    RunThis.StartInfo.Arguments = Nothing
                        '                End If
                        '                RunThis.StartInfo.FileName = RunThisFilename
                        '                RunThis.Start()
                        '            End If
                        '        Catch ex As Exception
                        '            MsgBox("Something is wrong with the process you've asked to run on each conversion - Exact error - " & ex.ToString)
                        '        End Try
                        '        RegWrite("LastActionedFile", LastFileDestination)
                        '    End If
                        'End If

                        If RegRead("LastActionedFile") <> "" And flgCurrentlyConverting = False Then
                            If RegRead("AddToItunes") = 1 Then
                                AddToItunes(RegRead("LastActionedFile"))
                            End If
                        End If



                        If ConvertFlag = True Then



                            CurrentStatus = "Converting " & Path.GetFileName(CurrentFileName)
                            Alert(CurrentStatus)

                            'oWrite.WriteLine(CurrentFileName)
                            'oWrite.Close()

                            LastFileSource = CurrentFileName
                            LastFileDestination = StrippedName & ".mp4"
                            RegWrite("LastActionedFile", StrippedName & ".mp4")
                            RegWrite("CurrentlyConverting", StrippedName & ".mp4")

                            ExecuteString = strHandbrakePath & " " & ConvertString
                            Debug.Print(ExecuteString)


                            myProcess.StartInfo.FileName = strHandbrakePath
                            myProcess.StartInfo.Arguments = ConvertString
                            myProcess.StartInfo.WindowStyle = _
                               System.Diagnostics.ProcessWindowStyle.Normal
                            myProcess.Start()
                            If MainForm.chkProcessConcurrent.Checked = False Then
                                Delay(5)
                                '    myProcess.WaitForExit()
                            End If


                            flgCurrentlyConverting = False
                            ConvertedAnything = True
                            '   CurrentStatus = Path.GetFileName(CurrentFileName) & " converted."
                            'Alert(CurrentStatus)
                            MainForm.Timer2.Start()
                            MainForm.Timer2.Enabled = True

                        End If 'convertflag

                        Counter = Counter + 1
                        ConvertFlag = True
                    End While
                    If ConvertedAnything = True Then
                        '    If RegRead("LastActionedFile") <> "" Then
                        '        If RegRead("AddToItunes") = 1 Then
                        '            AddToItunes(RegRead("LastActionedFile"))
                        '        End If
                        '    End If

                        'added june 22 2010 to better display the "all done" when it's really all done.
                        Dim pProcess2() As Process = System.Diagnostics.Process.GetProcessesByName("handbrakecli")
                        For Each p As Process In pProcess2
                            If p.MainWindowTitle <> "" Then
                                flgCurrentlyConverting = True
                                MainForm.Update()
                            End If
                        Next

                        If flgCurrentlyConverting = False And ConvertedAnything = True Then  'KA 30/04/2010
                            CurrentStatus = "All files converted."
                            If RegRead("LastActionedFile") <> "" And flgCurrentlyConverting = False Then
                                If RegRead("AddToItunes") = 1 Then
                                    AddToItunes(RegRead("LastActionedFile"))
                                End If
                                Alert(CurrentStatus)
                            End If

                        End If

                        ' RegWrite("LastActionedFile", "")
                        'MainForm.Timer2.Stop()
                        'MainForm.Timer2.Enabled = False
                        Alert(CurrentStatus)
                    End If
                    frmListFiles.lstFiles.Items.Clear()
                    frmListFiles.lstFiles.Items.Add("Nothing to Process")
                    MainForm.lblStatus.Text = ""
                End If


            End If
            ConvertedAnything = False
            MainForm.Timer1.Enabled = True
            MainForm.Timer1.Start()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub



    Public Sub RegWrite(ByVal RegEntryName As String, ByVal RegEntry As String)
        Dim regKey As RegistryKey
        Dim rkkey As RegistryKey
        Dim regexists As Boolean

        rkKey = Registry.LocalMachine.OpenSubKey("Software\AlertAndConvert", True)
        If rkKey Is Nothing Then
            RegExists = False
        End If
        If regexists = False Then
            Dim regKey2 As RegistryKey
            regKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
            regKey2.CreateSubKey("AlertAndConvert")
            regKey2.Close()
        End If

        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\AlertAndConvert", True)
        regKey.SetValue(RegEntryName, RegEntry)
        regKey.Close()
    End Sub

    Public Function RegRead(ByVal RegEntryName As String)
        Dim RegExists As Boolean
        Dim rkKey As RegistryKey
        Dim StringValue As String
        rkKey = Registry.LocalMachine.OpenSubKey("Software\AlertAndConvert", True)
        If rkKey Is Nothing Then
            RegExists = False
            StringValue = Nothing
        Else
            RegExists = True
            StringValue = rkKey.GetValue(RegEntryName, 0)
            rkKey.Close()
        End If
        Return StringValue
    End Function

    Public Sub AddToItunes(ByVal TheFileName As String)
        'Dim RunThis As System.Diagnostics.Process = New System.Diagnostics.Process()
        'Dim RunString As String
        'Dim ScriptPath As String

        'ScriptPath = Path.GetDirectoryName(RegRead("Homepath"))
        'ScriptPath = ScriptPath + "\" + "addtoplaylist.js"

        'RunString = ScriptPath

        'RunThis.StartInfo.Arguments = """" & TheFileName & """"
        'RunThis.StartInfo.FileName = RunString

        Dim TheFileDestination As String
        TheFileDestination = MainCode.RegRead("strAutomaticAddPath") & "\" & Path.GetFileName(TheFileName)


        Try
            TheFileDestination = MainCode.RegRead("strAutomaticAddPath") & "\" & Path.GetFileName(TheFileName)
            If System.IO.File.Exists(TheFileDestination) = False Then   'destination does not already exist
                If System.IO.File.Exists(TheFileName) = True Then    ' source exists
                    System.IO.File.Copy(TheFileName, TheFileDestination)
                End If
            End If
            RegWrite("LastActionedFile", "")

            'If System.IO.File.Exists(RunString) Then
            '    RunThis.Start()
            '    RunThis.WaitForExit()
            '    Alert("File " & Path.GetFileName(TheFileName) & " added to iTunes Library")
            'Else
            '    Alert("AddtoPlaylist.js does not exist in execution path, file not added to itunes")
            'End If



        Catch ex As Exception
            Alert("Couldn't Update Itunes with newly converted file - Error Message - " & ex.ToString)
        End Try

    End Sub

    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop

    End Sub

    Public Function GetFolderToWatch()
        Try

            Dim RegExists As Boolean

            Dim rkKey As RegistryKey
            rkKey = Registry.LocalMachine.OpenSubKey("Software\AlertAndConvert", True)
            If rkKey Is Nothing Then
                RegExists = False
            Else
                RegExists = True
                strFolderName = rkKey.GetValue("strFolderName", 0.0)
                strHandbrakePath = rkKey.GetValue("strHandbrakePath", 0.0)
                '            strCurlPath = rkKey.GetValue("strCurlPath", 0.0)
                rkKey.Close()
            End If


            If RegExists = False Then
                Dim regKey As RegistryKey
                regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
                regKey.CreateSubKey("AlertAndConvert")
                regKey.SetValue("strFolderName", "d:\downloads")
                regKey.SetValue("strHandbrakePath", "")

                regKey.Close()
            End If


            Return strFolderName
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return strFolderName
        End Try
    End Function

    Public Function GetVersion()
        Dim VersionNumber As String
        Dim myBuildInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
        VersionNumber = myBuildInfo.FileVersion
        Return VersionNumber

    End Function

End Module
