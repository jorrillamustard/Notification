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
                    Select Case e.severity
                        Case 1
                            Functions.NewAlert(e.artifactName, e.createDate, My.Resources.FtransparentRed, My.Settings.AlertTimeout)

                        Case 2
                            Functions.NewAlert(e.artifactName, e.createDate, My.Resources.FtransparentRed, My.Settings.AlertTimeout)

                        Case 3
                            Functions.NewAlert(e.artifactName, e.createDate, My.Resources.FtransparentOrange_1, My.Settings.AlertTimeout)

                        Case Else
                            Functions.NewAlert(e.artifactName, e.createDate, My.Resources.FtransparentYellow, My.Settings.AlertTimeout)
                    End Select
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
