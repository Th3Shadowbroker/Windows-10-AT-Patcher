Imports Microsoft.Win32

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkWindowsVersion()
        checkCurrentStatus()
    End Sub

    Private Sub checkWindowsVersion()

        If Not My.Computer.Info.OSFullName.Contains("Windows 10") Then
            MsgBox("Ungültiges OS !" & vbCrLf & "Sie benötigen eine gültige Version von Windows 10." & vbCrLf & "Installiertes Betriebssystem: " & My.Computer.Info.OSFullName, MsgBoxStyle.Critical, "OS-Fehler...")
            Application.Exit()
        End If

    End Sub

    Private Sub RunPatcher_Click(sender As Object, e As EventArgs) Handles RunPatcher.Click

        Try
            Dim req As MsgBoxResult = MsgBox("Der Autor dieses Tools übernimmt keinerlei Haftung, für durch diese Software eventuell entstehende Schäden, an Hard oder Software sowie Dateien !" & vbCrLf & vbCrLf & "Stimmen sie diesen Richtlinien zu ?", MsgBoxStyle.YesNo, "Sicherheithinweis...")

            If req = MsgBoxResult.Yes Then

                Dim key As RegistryKey = My.Computer.Registry.LocalMachine.CreateSubKey("Software\Policies\Microsoft\Windows\DataCollection")

                If RegKeyExists(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\DataCollection", "AllowTelemetry") = True And key.GetValue("AllowTelemetry") = 0 Then

                    key.SetValue("AllowTelemetry", 3, RegistryValueKind.DWord)

                    MsgBox("Die Telemetrie wurde reaktiviert.", MsgBoxStyle.Information, "Erfolgreich...")

                    checkCurrentStatus()

                Else

                    key.SetValue("AllowTelemetry", 0, RegistryValueKind.DWord)

                    MsgBox("Die Telemetrie wurde deaktiviert.", MsgBoxStyle.Information, "Erfolgreich...")

                    checkCurrentStatus()

                End If

            Else

                MsgBox("Der AT-Patcher wird nun beendet.", MsgBoxStyle.Information, "Patcher beendet...")

                Application.Exit()

            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Fehler...")
        End Try

    End Sub

    Private Sub checkCurrentStatus()

        Try

            Dim key As RegistryKey = My.Computer.Registry.LocalMachine.CreateSubKey("Software\Policies\Microsoft\Windows\DataCollection")

            If RegKeyExists(RegistryHive.LocalMachine, "Software\Policies\Microsoft\Windows\DataCollection", "AllowTelemetry") And key.GetValue("AllowTelemetry") = 0 Then
                Status.Text = "Status: AT-Patch ist aktiv."
            Else
                Status.Text = "Status: AT-Patch ist nicht aktiv."
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Fehler...")
        End Try


    End Sub

    Private Function RegKeyExists(ByVal hive As RegistryHive, _
                                      ByVal path As String, _
                                      ByVal keyName As String) As Boolean
        Dim regKey As RegistryKey
        Select Case hive
            Case RegistryHive.CurrentUser
                regKey = Registry.CurrentUser.OpenSubKey(path)
            Case RegistryHive.LocalMachine
                regKey = Registry.LocalMachine.OpenSubKey(path)
            Case Else

                Return False
        End Select
        If regKey Is Nothing Then Return False
        For Each regKeyName As String In regKey.GetValueNames()
            If regKeyName.Trim.ToUpper = keyName.Trim.ToUpper Then Return True
        Next
        Return False
    End Function

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        MsgBox("Windows 10: AT-Patcher" & vbCrLf & "Autor  Jens F." & vbCrLf & "Version  " & My.Application.Info.Version.ToString & vbCrLf & "Alle Rechte vorbehalten." & vbCrLf & "http://crafter629.de" & vbCrLf & vbCrLf & "DIESE SOFTWARE STEHT IN KEINERLEI ZUSAMMENHANG MIT MICROSOFT ODER DEREN SOFTWARE. DER AUTOR ÜBERNIMMT KEINERLEI HAFTUNG FÜR EVENTUELL AUFTRETENDE SCHÄDEN IN SOFT- ODER HARDWARE.", MsgBoxStyle.Information, "Über den AT-Patcher...")
    End Sub

    Private Sub IconCreditLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles IconCreditLink.LinkClicked
        Process.Start("http://www.iconsmind.com")
    End Sub
End Class
