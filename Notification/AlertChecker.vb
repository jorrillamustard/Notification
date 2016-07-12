﻿Public Class AlertChecker
    Private Property RestClnt As New FEPRestClient.Client
    Private Property AlertCheckTimer As Timer
    Public Sub New(ByVal RestClient As FEPRestClient.Client)
        RestClnt = RestClient
        AlertCheckTimer = New Timer
        AddHandler AlertCheckTimer.Tick, AddressOf AlertCheckTimer_Tick
        AlertCheckTimer.Enabled = False
    End Sub
    Private Sub CheckForAlerts()
        Dim newa = RestClnt.Functions.Alert.GetAlertsWithCounts
        If newa.Success = True Then
            For Each e In newa.Data.entities
                If e.createDate > Today.AddDays(Math.Abs(My.Settings.DaysBeforeToAlert) * -1) Then
                    Functions.NewAlert(e.artifactName, e.createDate, My.Resources.flogo3232, My.Settings.AlertTimeout)
                End If
            Next
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
