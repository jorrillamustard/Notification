Imports RestSharp
Imports System.Net
Imports System.Text
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

Public Class Form_Configure

    Dim PasswordText As String
    Dim UsernameText As String
    Dim ServerText As String


    Public Function test1()

        Form_Hide.RestClient.Username = My.Settings.UserName
        Form_Hide.RestClient.Password = My.Settings.Password
        Form_Hide.RestClient.Server = My.Settings.WebServer
        Form_Hide.RestClient.IgnoreSSL = True
        Form_Hide.RestClient.Authenticate()

        If Form_Hide.RestClient.IsAuthenticated = True Then
            txtStatusStrip.Text = "Saved and Logged in"
            Form_Alert.shownotification("Alert Notifcations Started", "Now Listening for Alerts", Form_Hide.image, 10000)
            Functions.GetAlerts(My.Settings.DaysBeforeToAlert)
            Return True
        Else
            txtStatusStrip.Text = "Login Failed Information not saved"
            Return False
        End If

    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        My.Settings.WebServer = txtServer.Text
        My.Settings.UserName = txtUserName.Text
        My.Settings.Password = txtPassword.Text
        My.Settings.Sound = chkSound.Checked
        My.Settings.DaysBeforeToAlert = nmbDaysBeforeToAlert.Value
        My.Settings.Save()

        test1()

    End Sub

    Private Sub Configure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.Text = My.Settings.WebServer
        txtUserName.Text = My.Settings.UserName
        txtPassword.Text = My.Settings.Password
        chkSound.Checked = My.Settings.Sound
        nmbDaysBeforeToAlert.Value = My.Settings.DaysBeforeToAlert

    End Sub

    Private Sub Configure_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Form_Hide.RestClient.IsAuthenticated = True Then
            Form_Alert.shownotification("Alerts Started", "Now Listening", Form_Hide.image, 10000)
            Functions.GetAlerts(My.Settings.DaysBeforeToAlert)
            Me.Hide()
        Else

        End If
    End Sub
End Class