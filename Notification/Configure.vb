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

Public Class Configure

    Dim PasswordText As String
    Dim UsernameText As String
    Dim ServerText As String


    Public Function test1()

        Form1.RestClient.Username = My.Settings.UserName
        Form1.RestClient.Password = My.Settings.Password
        Form1.RestClient.Server = My.Settings.WebServer
        Form1.RestClient.IgnoreSSL = True
        Form1.RestClient.Authenticate()

        If Form1.RestClient.IsAuthenticated = True Then
            txtStatusStrip.Text = "Saved and Logged in"

            Notifier1.shownotification("Alert Notifcations Started", "Now Listening for Alerts", Form1.image, 10000)
            Return True
        Else
            txtStatusStrip.Text = "Login Failed Information not saved"
            Return False
        End If

    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        My.Settings.WebServer = Server.Text
            My.Settings.UserName = UserName.Text
            My.Settings.Password = Password.Text
            My.Settings.Save()

        test1()

    End Sub

    Private Sub Configure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Server.Text = My.Settings.WebServer
        UserName.Text = My.Settings.UserName
        Password.Text = My.Settings.Password


    End Sub


End Class