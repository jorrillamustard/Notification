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

    Public Function TestConfiguration()

        Form_Hide.RestClient.Username = My.Settings.UserName
        Form_Hide.RestClient.Password = My.Settings.Password
        Form_Hide.RestClient.Server = My.Settings.WebServer
        Form_Hide.RestClient.IgnoreSSL = True
        Dim auth = Form_Hide.RestClient.Authenticate()
        If auth.Success = True Then
            Return True
        Else
            MsgBox(auth.Error.Message,, "Authentication Issue")
            Return False
        End If


    End Function

    Public Sub NewAlert(ByVal Caption As String, ByVal Message As String, ByVal Image As Image, ByVal Optional Time As Integer = 2)
        If My.Settings.AlertTimeout > 2 Then
            Time = My.Settings.AlertTimeout
        End If
        Dim alertbox As New Form_Alert
        alertbox.shownotification(Message, Caption, Image, Math.Abs(Time) * 1000)

    End Sub

End Module
