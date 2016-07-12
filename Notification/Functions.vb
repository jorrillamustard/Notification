

Module Functions


    ''' <summary>
    ''' Test API Settings
    ''' </summary>
    ''' <param name="Src">1 if from Form_HIDE otherwise any integer</param>
    ''' <returns>Returns true or false if successfully authenticates.</returns>

    Public Function TestConfiguration(ByVal Src As Integer)
        Form_Hide.RestClient.Username = My.Settings.UserName
        Form_Hide.RestClient.Password = My.Settings.Password
        Form_Hide.RestClient.Server = My.Settings.WebServer
        Form_Hide.RestClient.IgnoreSSL = True
        Dim auth = Form_Hide.RestClient.Authenticate()
        If auth.Success = True Then
            Return True
        Else
            If Src = 1 Then
                MsgBox("This appears to be the first time you've run the alert application, please configure your settings on the next screen.", MsgBoxStyle.Information, "Configuration Required")
            Else
                MsgBox(auth.Error.Message, MsgBoxStyle.Exclamation, "Authentication Issue")
            End If

            Return False
        End If


    End Function

    ''' <summary>
    ''' Show new alert message
    ''' </summary>
    ''' <param name="Caption">Caption of alert</param>
    ''' <param name="Message">Message of alert</param>
    ''' <param name="Image">Image for alert, 32x32 only</param>
    ''' <param name="Time">Time in seconds to show alert</param>
    Public Sub NewAlert(ByVal Caption As String, ByVal Message As String, ByVal Image As Image, ByVal Optional Time As Integer = 2)
        If My.Settings.AlertTimeout > 2 Then
            Time = My.Settings.AlertTimeout
        End If
        Dim alertbox As New Form_Alert
        alertbox.shownotification(Message, Caption, Image, Math.Abs(Time) * 1000)

    End Sub




End Module
