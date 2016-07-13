Imports System.ComponentModel
Imports ComponentFactory.Krypton.Toolkit

Public Class Form_Configure

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.WebServer = txtServer.Text
        My.Settings.UserName = txtUserName.Text
        My.Settings.Password = txtPassword.Text
        My.Settings.Sound = chkSound.Checked
        My.Settings.MinuteWindow = nmbMinuteWindow.Value
        My.Settings.ColorScheme = cmbAlertColors.SelectedItem
        My.Settings.DaysSinceAlert = Now
        My.Settings.AlertTimeout = nmbAlertTimeout.Value
        My.Settings.CheckInterval = nmbCheckInterval.Value
        My.Settings.Save()

        'Test Configuration
        If Functions.TestConfiguration(2) = True Then
            txtStatusStrip.Text = "Configuration Saved and Logged In"
            Functions.NewAlert("Endpoint Alert Notifications", "Endpoint Alert Notifications Started", My.Resources.flogo3232, 10000)
            ' Start timer/functions
            Form_Hide.AlertChecker.StartAlertChecker()
        Else
            txtStatusStrip.Text = "Configuration Not Saved. Invalid Settings."
        End If


    End Sub

    Private Sub Configure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.Text = My.Settings.WebServer
        txtUserName.Text = My.Settings.UserName
        txtPassword.Text = My.Settings.Password
        chkSound.Checked = My.Settings.Sound
        nmbMinuteWindow.Value = My.Settings.MinuteWindow
        nmbAlertTimeout.Value = My.Settings.AlertTimeout
        lblLastAlertCheck.Text = "Last Alert Check: " & My.Settings.LastCheckTime
        nmbCheckInterval.Value = My.Settings.CheckInterval
        For Each x In [Enum].GetValues(GetType(PaletteModeManager))
            cmbAlertColors.Items.Add(x.ToString)
        Next
        cmbAlertColors.SelectedIndex = 0
        cmbAlertColors.SelectedItem = My.Settings.ColorScheme
        txtStatusStrip.Text = ""

    End Sub

End Class