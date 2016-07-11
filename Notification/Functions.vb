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

    Public Sub GetAlerts()
        Dim AlertNotifier = New Notifier1
        'Form1.RestClient.Authenticate()
        Dim a = Form1.RestClient.Functions.Alert.GetAlertsWithCounts()

        If a.Success = True Then
            For Each e In a.Data.entities
                'If e.createDate > TimeOfDay.AddMinutes(-1) Then
                AlertNotifier.shownotification(e.description & " " & e.createDate.ToString, "New Alert: " & e.artifactName.ToString, Form1.image, 10000)
                'End If
            Next
        End If

    End Sub


End Module
