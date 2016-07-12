Imports System.IO
Imports System.Web
Imports Newtonsoft
Imports Newtonsoft.Json
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models.Report
Imports FEPRestClient.Models.Enums
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Alert
Imports System.Collections.ObjectModel
Imports System.Configuration
Imports System.Collections.Specialized

Module Functions

    Public Sub GetAlerts(ByVal Optional DaysBeforeNow As Integer = 20)
        Dim a = Form_Hide.RestClient.Functions.Alert.GetAlertsWithCounts()
        If a.Success = True Then
            For Each e In a.Data.entities
                If e.createDate > Today.AddDays(Math.Abs(DaysBeforeNow) * -1) Then
                    Dim alertnote As New Form_Alert
                    alertnote.shownotification(e.createDate, e.artifactName, My.Resources.Capture, 5000)
                End If
            Next
        End If

    End Sub


End Module
