Imports System.Text

Public Class AlertChecker
    Private Property RestClnt As New FEPRestClient.Client
    Private Property AlertCheckTimer As Timer
    Public Sub New(ByVal RestClient As FEPRestClient.Client)
        RestClnt = RestClient
        AlertCheckTimer = New Timer
        AddHandler AlertCheckTimer.Tick, AddressOf AlertCheckTimer_Tick
        AlertCheckTimer.Enabled = False
    End Sub
    Private Sub CheckForAlerts()
        Dim lastcheck As DateTime = My.Settings.LastCheckTime
        My.Settings.LastCheckTime = DateTime.Now
        My.Settings.Save()
        Dim newa = RestClnt.Functions.Alert.GetAlertsWithCounts
        If newa.Success = True Then
            For Each e In newa.Data.entities
                If e.createDate > lastcheck Then
                    Dim sevlogo As Image
                    Select Case e.severity
                        Case 1
                            sevlogo = My.Resources.FtransparentRed
                        Case 2
                            sevlogo = My.Resources.FtransparentRed
                        Case 3
                            sevlogo = My.Resources.FtransparentOrange_1
                        Case Else
                            sevlogo = My.Resources.FtransparentYellow
                    End Select
                    Dim caption As String = "New Alert"
                    Dim message As New StringBuilder
                    message.AppendLine("Name: " & e.artifactName)
                    message.AppendLine("Assessment: " & e.assessment)
                    Dim sev As Functions.Sev = e.severity
                    message.AppendLine("Severity: " & sev.ToString)
                    message.AppendLine("Source: " & e.source)
                    message.AppendLine("Target: " & e.target)

                    Functions.NewAlert(caption, message.ToString, sevlogo, My.Settings.AlertTimeout)

                End If
            Next

            Form_Configure.lblLastAlertCheck.Text = "Last Alert Check: " & My.Settings.LastCheckTime
        End If
    End Sub

    Public Sub StartAlertChecker()
        AlertCheckTimer.Interval = Math.Abs(My.Settings.CheckInterval) * 1000
        AlertCheckTimer.Enabled = True
        AlertCheckTimer.Start()
    End Sub

    Private Sub AlertCheckTimer_Tick()
        CheckForAlerts()
    End Sub

End Class
