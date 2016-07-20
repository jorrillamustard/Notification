Imports System.Text

Public Class AlertChecker
    Private Property RestClnt As New FEPRestClient.Client
    Private Property AlertCheckTimer As Timer

    Public Sub New(ByVal RestClient As FEPRestClient.Client)
        RestClnt = RestClient
        AlertCheckTimer = New Timer
        AddHandler AlertCheckTimer.Tick, AddressOf AlertCheckTimer_Tick
        AlertCheckTimer.Enabled = False

    End Sub
    Private Sub CheckForAlerts()
        Dim lastcheck As DateTime = My.Settings.LastCheckTime
        Debug.WriteLine("Checking for new alerts since " & lastcheck & ".....")
        My.Settings.LastCheckTime = DateTime.Now
        My.Settings.Save()
        Debug.WriteLine("Minute Window Setting: " & My.Settings.MinuteWindow)
        Dim query As New StringBuilder
        query.Append("(createDate >= DateTime.Parse(""")
        query.Append(My.Settings.LastCheckTime.AddMinutes(Math.Abs(My.Settings.MinuteWindow) * -1).ToString("MM/dd/yyyy HH:mm")) 'Check based on minute due to slowness in some alert generations
        query.Append("""))")
        Debug.WriteLine("Query Used: " & query.ToString)
        Dim newa = RestClnt.Functions.Alert.GetAlertsWithCounts(,,,, query.ToString)
        If newa.Success = True Then
            Debug.WriteLine("Query Success... Result Count: " & newa.Data.totalCount)
            For Each e In newa.Data.entities
                If Not DoesAlertExistInSQDB(e.alertId) = True Then
                    Debug.WriteLine("Showing New Alert: " & e.alertId)
                    Dim sevlogo As Image = GetSevLogo(e.severity)
                    Dim caption As String = "New Alert"
                    Dim message As New StringBuilder
                    message.AppendLine("Name: " & e.artifactName)
                    message.AppendLine("Assessment: " & e.assessment)
                    Dim sev As Functions.Sev = e.severity
                    message.AppendLine("Severity: " & sev.ToString)
                    message.AppendLine("Source: " & e.source)
                    message.AppendLine("Target: " & e.target)
                    AddAlertIDtoSQDB(e.alertId)
                    Functions.NewAlert(caption, message.ToString, sevlogo, My.Settings.AlertTimeout)
                Else
                    Debug.WriteLine("Hiding Previously Shown Alert: " & e.alertId)
                End If
            Next
            Debug.WriteLine("Alert Check Done...")
            Form_Configure.lblLastAlertCheck.Text = "Last Alert Check: " & My.Settings.LastCheckTime
        Else
            Debug.WriteLine("API Error: " & newa.Error.Message)
        End If
    End Sub

    Private Sub AddAlertIDtoSQDB(ByVal alert As Integer)
        Debug.WriteLine("Adding AlertID " & alert & " to PreviousAlerts table...")
        Dim conn As String = "Data Source=NotificationDB.db3;Version=3"
        Dim sqlconn As New SQLite.SQLiteConnection
        Dim sqlcmd As New SQLite.SQLiteCommand

        sqlconn.ConnectionString = conn
        sqlconn.Open()
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandText = "INSERT INTO PreviousAlerts (AlertID) VALUES (" & alert & ");"
        sqlcmd.ExecuteNonQuery()
        sqlcmd.Dispose()
        sqlconn.Close()
        sqlconn.Dispose()

    End Sub

    Private Function DoesAlertExistInSQDB(ByVal alert As Integer)
        Debug.WriteLine("Checking for AlertID " & alert & " in PreviousAlerts table...")
        Dim conn As String = "Data Source=NotificationDB.db3;Version=3"
        Dim sqlconn As New SQLite.SQLiteConnection
        Dim sqlcmd As New SQLite.SQLiteCommand
        Dim sqldr As SQLite.SQLiteDataReader
        sqlconn.ConnectionString = conn
        sqlconn.Open()
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandText = "SELECT AlertID FROM PreviousAlerts WHERE AlertID = " & alert & ";"
        sqldr = sqlcmd.ExecuteReader
        Dim fnd As Boolean = False

        While sqldr.Read
            If sqldr("AlertID") = alert Then
                Debug.WriteLine("AlertID found in PreviousAlerts.")
                fnd = True
            End If
        End While

        sqldr.Close()
        sqlcmd.Dispose()
        sqlconn.Close()
        sqlconn.Dispose()
        Return fnd
    End Function

    Public Sub StartAlertChecker()
        AlertCheckTimer.Interval = Math.Abs(My.Settings.CheckInterval) * 1000
        AlertCheckTimer.Enabled = True
        AlertCheckTimer.Start()
    End Sub

    Public Sub StopAlertChecker()
        AlertCheckTimer.Stop()
        AlertCheckTimer.Enabled = False
    End Sub

    Public Sub RecreateDatabase()
        AlertCheckTimer.Stop()
        AlertCheckTimer.Enabled = False
        AlertCheckTimer.Dispose()
        Functions.RecreateNotificationDB()
    End Sub

    Private Function GetSevLogo(ByVal severity As Integer)
        Select Case severity
            Case 1 'Critical
                Return My.Resources.FtransparentRed
            Case 2 'High
                Return My.Resources.FtransparentRed
            Case 3 'Medium
                Return My.Resources.FtransparentOrange_1
            Case 4 'Low
                Return My.Resources.FtransparentYellow
            Case 5 'Warning
                Return My.Resources.FtransparentYellow
                'Catch all
            Case Else
                Return My.Resources.flogo3232
        End Select
    End Function
    Private Sub AlertCheckTimer_Tick()
        CheckForAlerts()
    End Sub

End Class
