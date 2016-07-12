
Public Class Form_Hide


    Public RestClient As New Global.FEPRestClient.Client
    Public image As System.Drawing.Image
    Public TrackTime As DateTime




    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TrayIcon.MouseDoubleClick

    End Sub



    Public RestClient As New FEPRestClient.Client
    Public AlertChecker As New AlertChecker(RestClient)


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ConfigureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigureToolStripMenuItem.Click
        Form_Configure.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        image = My.Resources.ResourceManager.GetObject("Capture.PNG")

        RestClient.Username = My.Settings.UserName
        RestClient.Password = My.Settings.Password
        RestClient.Server = My.Settings.WebServer
        RestClient.IgnoreSSL = True
        RestClient.Authenticate()

        Timer_Alerts.Start()

        TestConfiguration(1)

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Hide()
        Form_Configure.Show()
    End Sub

    Private Sub Timer_Alerts_Tick(sender As Object, e As EventArgs) Handles Timer_Alerts.Tick
        Functions.MonitorAlerts()
        My.Settings.DaysSinceAlert = Now
        My.Settings.Save()
    End Sub
End Class
