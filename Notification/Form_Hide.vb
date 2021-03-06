﻿
Public Class Form_Hide

    Public RestClient As New FEPRestClient.Client
    Public AlertChecker As New AlertChecker(RestClient)


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitProgram.Click
        Me.Close()
    End Sub

    Private Sub ConfigureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigureToolStripMenuItem.Click
        Form_Configure.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Process.Start(".\Resources\NotificationHelp.htm")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RestClient.Username = My.Settings.UserName
        RestClient.Password = My.Settings.Password
        RestClient.Server = My.Settings.WebServer
        RestClient.IgnoreSSL = True
        RestClient.Authenticate()
        If Not IO.File.Exists("NotificationDB.db3") Then
            Debug.WriteLine("SQLDB NotificationDB.db3 not found...Creating...")
            Functions.CreateNotificationDB()
        Else
            Debug.WriteLine("SQLDB NotificationDB.db3 found...Validating..")
            Functions.ValidateNotificationDB()
        End If

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Hide()


        If TestConfiguration(1) = True Then
            Functions.NewAlert("Endpoint Alert Notifications", "Endpoint Alert Notifications Started", My.Resources.flogo3232, 10000)
            ' Start Timer/Function
            If My.Settings.LastCheckTime < DateTime.Now.AddHours(-1) Then
                My.Settings.LastCheckTime = DateTime.Now
                My.Settings.Save()
            End If
            AlertChecker.StartAlertChecker()
        Else
            My.Settings.LastCheckTime = DateTime.Now
            My.Settings.Save()
            Form_Configure.Show()
        End If

    End Sub


End Class
