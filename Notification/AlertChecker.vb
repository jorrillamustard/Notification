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
        Dim query As New StringBuilder
        query.Append("(createDate >= DateTime.Parse(""")
        query.Append(My.Settings.LastCheckTime.ToString("MM/dd/yyyy HH:mm:ss"))
        query.Append("""))")
        Dim newa = RestClnt.Functions.Alert.GetAlertsWithCounts(,,,, query.ToString)
        If newa.Success = True Then

            For Each e In newa.Data.entities

                Dim sevlogo As Image = GetSevLogo(e.severity)
                Dim caption As String = "New Alert"
                Dim message As New StringBuilder
                message.AppendLine("Name: " & e.artifactName)
                message.AppendLine("Assessment: " & e.assessment)
                Dim sev As Functions.Sev = e.severity
                message.AppendLine("Severity: " & sev.ToString)
                message.AppendLine("Source: " & e.source)
                message.AppendLine("Target: " & e.target)

                Functions.NewAlert(caption, message.ToString, sevlogo, My.Settings.AlertTimeout)

            Next

            Form_Configure.lblLastAlertCheck.Text = "Last Alert Check: " & My.Settings.LastCheckTime
        End If
    End Sub

    Public Sub StartAlertChecker()
        AlertCheckTimer.Interval = Math.Abs(My.Settings.CheckInterval) * 1000
        AlertCheckTimer.Enabled = True
        AlertCheckTimer.Start()
    End Sub

    Private Function GetSevLogo(ByVal severity As Integer)
        Select Case severity
            Case 1 'Critical
                Return My.Resources.FtransparentRed
            Case 2 'High
                Return My.Resources.FtransparentRed
            Case 3 'Medium
                Return My.Resources.FtransparentOrange_1
            Case 4 'Low
                Return My.Resources.FtransparentYellow
            Case 5 'Warning
                Return My.Resources.FtransparentYellow
                'Catch all
            Case Else
                Return My.Resources.flogo3232
        End Select
    End Function
    Private Sub AlertCheckTimer_Tick()
        CheckForAlerts()
    End Sub

End Class
