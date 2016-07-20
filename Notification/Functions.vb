

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

    Public Enum Sev
        Critical = 1
        High = 2
        Medium = 3
        Low = 4
        Warning = 5
    End Enum

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

    Public Sub CreateNotificationDB()
        Debug.WriteLine("Creating Database...NotificationDB.db3")
        SQLite.SQLiteConnection.CreateFile("NotificationDB.db3")
        Dim conn As String = "Data Source=NotificationDB.db3;Version=3"
        Dim sqlconn As New SQLite.SQLiteConnection
        Dim sqlcmd As New SQLite.SQLiteCommand

        sqlconn.ConnectionString = conn
        sqlconn.Open()
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandText = "CREATE TABLE PreviousAlerts(AlertID INTEGER PRIMARY KEY ASC);"
        Debug.WriteLine("SQLDB Creating Table PreviousAlerts...")
        sqlcmd.ExecuteNonQuery()
        sqlcmd.Dispose()
        sqlconn.Close()
        sqlconn.Dispose()
    End Sub

    Public Sub ValidateNotificationDB()
        Debug.WriteLine("Validating Tables in NotificationDB")
        Dim conn As String = "Data Source=NotificationDB.db3;Version=3"
        Dim sqlconn As New SQLite.SQLiteConnection
        Dim sqlcmd As New SQLite.SQLiteCommand
        Dim sqldr As SQLite.SQLiteDataReader
        sqlconn.ConnectionString = conn
        sqlconn.Open()
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='PreviousAlerts';"
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read
            Debug.WriteLine("SQDB Query Result: " & sqldr("name"))
            If sqldr("name") = "PreviousAlerts" Then
                Debug.WriteLine("PreviousAlerts table found...")
            Else
                Debug.WriteLine("PreviousAlerts not found..Creating missing table PreviousAlerts..")
                sqlcmd.CommandText = "CREATE TABLE PreviousAlerts(AlertID INTEGER PRIMARY KEY ASC);"
                sqlcmd.ExecuteNonQuery()
            End If

        End While

        sqldr.Close()
        sqlcmd.Dispose()
        sqlconn.Close()
        sqlconn.Dispose()
    End Sub

    Public Sub RecreateNotificationDB()
        IO.File.Delete("NotificationDB.db3")
        CreateNotificationDB()
    End Sub


End Module
