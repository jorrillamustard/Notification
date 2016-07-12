
Public Class Form_Hide

    Public RestClient As New FEPRestClient.Client
    Public AlertChecker As New AlertChecker(RestClient)


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ConfigureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigureToolStripMenuItem.Click
        Form_Configure.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RestClient.Username = My.Settings.UserName
        RestClient.Password = My.Settings.Password
        RestClient.Server = My.Settings.WebServer
        RestClient.IgnoreSSL = True
        RestClient.Authenticate()

        TestConfiguration(1)

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Hide()
        Form_Configure.Show()
    End Sub

End Class
