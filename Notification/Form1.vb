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


Public Class Form1
    Public RestClient As New Global.FEPRestClient.Client
    Public image As System.Drawing.Image


    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TrayIcon.MouseDoubleClick

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ConfigureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigureToolStripMenuItem.Click
        Configure.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        image = My.Resources.ResourceManager.GetObject("Capture.PNG")

        RestClient.Username = My.Settings.UserName
        RestClient.Password = My.Settings.Password
        RestClient.Server = My.Settings.WebServer
        RestClient.IgnoreSSL = True
        RestClient.Authenticate()



    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If RestClient.IsAuthenticated = True Then
            Notifier1.shownotification("Alerts Started", "Now Listening", image, 10000)
            Functions.GetAlerts()
        Else
            Configure.Show()
        End If
    End Sub
End Class
