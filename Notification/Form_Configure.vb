Imports ComponentFactory.Krypton.Toolkit

Public Class Form_Configure

    Dim PasswordText As String
    Dim UsernameText As String
    Dim ServerText As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.WebServer = txtServer.Text
        My.Settings.UserName = txtUserName.Text
        My.Settings.Password = txtPassword.Text
        My.Settings.Sound = chkSound.Checked
        My.Settings.DaysBeforeToAlert = nmbDaysBeforeToAlert.Value
        My.Settings.ColorScheme = cmbAlertColors.SelectedItem
        My.Settings.AlertTimeout = nmbAlertTimeout.Value
        My.Settings.Save()

        'Test Configuration
        If Functions.TestConfiguration = True Then
            txtStatusStrip.Text = "Configuration Saved and Logged In"
            Functions.NewAlert("Endpoint Alert Notifications", "Endpoint Alert Notifications Started", My.Resources.Capture, 10000)

            'TODO: Start timer/functions
            'Functions.GetAlerts(My.Settings.DaysBeforeToAlert)

        Else
            txtStatusStrip.Text = "Configuration Not Saved. Invalid Settings."
        End If

        'TODO: Start timer/functions


    End Sub

    Private Sub Configure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.Text = My.Settings.WebServer
        txtUserName.Text = My.Settings.UserName
        txtPassword.Text = My.Settings.Password
        chkSound.Checked = My.Settings.Sound
        nmbAlertTimeout.Value = My.Settings.AlertTimeout
        nmbDaysBeforeToAlert.Value = My.Settings.DaysBeforeToAlert

        For Each x In [Enum].GetValues(GetType(PaletteModeManager))
            cmbAlertColors.Items.Add(x.ToString)
        Next
        cmbAlertColors.SelectedIndex = 0
        cmbAlertColors.SelectedItem = My.Settings.ColorScheme
        txtStatusStrip.Text = ""

    End Sub

    Private Sub Configure_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Form_Hide.RestClient.IsAuthenticated = True Then
            Me.Hide()
            Functions.NewAlert("Endpoint Alert Notifications", "Endpoint Alert Notifications Started", My.Resources.Capture, 10000)
            'TODO: Start Timer/Function
            'Functions.GetAlerts(My.Settings.DaysBeforeToAlert)
        Else

        End If
    End Sub
End Class