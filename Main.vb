Imports System.IO

Public Class Main
    Dim frmMyCommands_Browser As MyCommands_Browser

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.AutomaticallyShowDragonCommands Then
            ShowDragonCommands()
        End If
        Dim frmClipboardSaverForm As New ClipboardSaver

        Dim myScreens() As Screen = Screen.AllScreens

        'frmClipboardSaverForm.Show()
        'If (myScreens.Length = 2) Then
        '    frmClipboardSaverForm.Location = New Point(2250, 450)
        'End If

        Dim p As System.Diagnostics.Process
        Dim blnDragonRunning As Boolean = False
        Dim blnVoiceComputerRunning As Boolean = False
        Try
            For Each p In System.Diagnostics.Process.GetProcesses()
                If p.ProcessName = "natspeak" Then
                    blnDragonRunning = True
                ElseIf p.ProcessName = "VP" Then
                    blnVoiceComputerRunning = True
                End If
            Next
            If Not blnDragonRunning Then
                RunFile("C:\Program Files (x86)\Nuance\NaturallySpeaking15\Program\natspeak.exe")
            End If
            If Not blnVoiceComputerRunning Then
                'RunFile("C:\Program Files (x86)\VoiceTeach\VoiceComputer\scripts\VoiceComputer.exe")
            End If
            Me.Version.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ShowDragonCommands()
        frmMyCommands_Browser = New MyCommands_Browser

        Dim myScreens() As Screen = Screen.AllScreens
        '        If (myScreens.Length = 2) Then

        frmMyCommands_Browser.Left = myScreens(0).Bounds.Width + 10
        If Screen.AllScreens.Length > 1 Then
            frmMyCommands_Browser.Height = myScreens(1).Bounds.Height - 50

        End If
        '       End If

        'frmMyCommands_Browser.WindowState = FormWindowState.Maximized
        On Error GoTo 0
        frmMyCommands_Browser.Show()
    End Sub

    Private Sub RunFile(stringFileName As String)
        If My.Computer.FileSystem.FileExists(stringFileName) Then
            On Error Resume Next
            Dim result = Shell(stringFileName, AppWinStyle.MinimizedNoFocus)
            'MessageBox.Show("Result:" & result)

        End If

    End Sub

    Private Sub RestartDragonButton_Click(sender As Object, e As EventArgs) Handles RestartDragonButton.Click
        ' loop through the running processes and add
        'each to the list
        Dim p As System.Diagnostics.Process
        Dim stringTemporary As String = ""
        If MessageBox.Show("Kill Dragon NaturallySpeaking Confirm?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        For Each p In System.Diagnostics.Process.GetProcesses()
            '            lstProcesses.Items.Add(p.ProcessName & " - " & p.Id.ToString())
            stringTemporary = stringTemporary & p.ProcessName & " / "
            If p.ProcessName = "natspeak" Or p.ProcessName = "dragonbar" Or p.ProcessName = "VP" Then 'p.ProcessName = "PCByVoice SpeechStart" Or p.ProcessName = "CommandRobot" Or
                On Error Resume Next
                p.Kill()
                'MessageBox.Show("Killed " & p.ProcessName)
                On Error GoTo 0
            Else
                'MsgBox(p.ProcessName, vbInformation, "Process Name")
            End If

        Next
        'MessageBox.Show(stringTemporary)
        'RunFile("C:\Program Files (x86)\Nuance\NaturallySpeaking15\Program\natspeak.exe")
        'RunFile("C:\Program Files (x86)\VoiceTeach\VoiceComputer\scripts\VoiceComputer.exe")
        SendKeys.Send("^%(v)")
        'RunFile(My.Settings.AppToRunWhenRestarting)
    End Sub

    Private Sub KillAccessButton_Click(sender As Object, e As EventArgs) Handles KillAccessButton.Click
        ' loop through the running processes and add
        'each to the list
        Dim integerCounter As Integer
        Dim p As System.Diagnostics.Process
        Dim stringTemporary As String = ""



        For Each p In System.Diagnostics.Process.GetProcesses()
            '            lstProcesses.Items.Add(p.ProcessName & " - " & p.Id.ToString())

            stringTemporary = stringTemporary & p.ProcessName & " / "

            If p.ProcessName = "MSACCESS" Then
                On Error Resume Next
                If MessageBox.Show("Kill " & p.MainWindowTitle & " Confirm?", "Question: " & p.MainWindowTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                        = Windows.Forms.DialogResult.Yes Then


                    p.Kill()
                    integerCounter = integerCounter + 1
                End If
                'MessageBox.Show("Killed " & p.ProcessName)
                On Error GoTo 0
            End If

        Next
        If integerCounter = 0 Then
            Me.KillAccessButton.Text = "Access Not Found"
        Else
            Me.KillAccessButton.Text = "Killed Access (" & integerCounter & ")"
        End If
        Me.Timer1.Interval = 1000
        Me.Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.KillAccessButton.Text = "Kill Access"
        Me.KillIEButton.Text = "Kill IE"
        Me.KillExcelButton.Text = "Kill Excel"
        Me.KillWordButton.Text = "Kill Word"
        Me.ButtonLaunchVoiceComputer.Text = "Open Voice Computer"
        Me.Timer1.Enabled = False
    End Sub



    Private Sub KillDragonButton_Click(sender As Object, e As EventArgs) Handles KillDragonButton.Click
        Dim p As System.Diagnostics.Process
        Dim stringTemporary As String = ""
        If MessageBox.Show("Kill Dragon NaturallySpeaking Confirm?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        For Each p In System.Diagnostics.Process.GetProcesses()
            '            lstProcesses.Items.Add(p.ProcessName & " - " & p.Id.ToString())
            'Freesr
            stringTemporary = stringTemporary & p.ProcessName & " / "
            If p.ProcessName = "natspeak" Or p.ProcessName = "dragonbar" Then
                p.Kill()
                On Error GoTo 0
            End If

        Next

    End Sub

    Private Sub ButtonOptions_Click(sender As Object, e As EventArgs) Handles ButtonOptions.Click
        Dim frmClipboardSaverForm As New ClipboardSaver
        Dim Options As New Options
        Options.Show()
    End Sub

    Private Sub ButtonShowCommands_Click(sender As Object, e As EventArgs) Handles ButtonShowCommands.Click
        ShowDragonCommands()
    End Sub

    Private Sub KillIEButton_Click(sender As Object, e As EventArgs) Handles KillIEButton.Click
        KillApplication("iexplore", Me.KillIEButton)
    End Sub

    Private Sub KillApplication(stringProcessName As String, Button As Button)
        Dim integerCounter As Integer
        Dim p As System.Diagnostics.Process
        Dim stringTemporary As String = ""



        For Each p In System.Diagnostics.Process.GetProcesses()
            '            lstProcesses.Items.Add(p.ProcessName & " - " & p.Id.ToString())

            stringTemporary = stringTemporary & p.ProcessName & " / "


            If p.ProcessName = stringProcessName Then

                On Error Resume Next
                If MessageBox.Show("Kill " & p.MainWindowTitle & " Confirm?", "Question: " & p.MainWindowTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                        = Windows.Forms.DialogResult.Yes Then


                    p.Kill()
                    integerCounter = integerCounter + 1
                End If
                'MessageBox.Show("Killed " & p.ProcessName)
                On Error GoTo 0
            End If
        Next
        'MessageBox.Show(stringTemporary)
        If integerCounter = 0 Then
            Button.Text = stringProcessName & " Not Found"
        Else
            Button.Text = "Killed " & stringProcessName & " (" & integerCounter & ")"
        End If
        Me.Timer1.Interval = 1000
        Me.Timer1.Start()
    End Sub

    Private Sub KillExcelButton_Click(sender As Object, e As EventArgs) Handles KillExcelButton.Click
        KillApplication("EXCEL", Me.KillExcelButton)
    End Sub

    Private Sub KillWordButton_Click(sender As Object, e As EventArgs) Handles KillWordButton.Click
        KillApplication("WINWORD", Me.KillWordButton)
    End Sub

    Private Sub ButtonLaunchVoiceComputer_Click(sender As Object, e As EventArgs) Handles ButtonLaunchVoiceComputer.Click
        KillApplication("VP", Me.ButtonLaunchVoiceComputer)
        SendKeys.Send("^%(v)")
        'RunFile(My.Settings.AppToRunWhenRestarting)
    End Sub

    Private Sub Main_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub
End Class
