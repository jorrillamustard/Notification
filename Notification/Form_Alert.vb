Imports ComponentFactory.Krypton.Toolkit
Public Class Form_Alert
    Public timer As New Timer
    Public i As Integer = 0
    Public endtimer As New Timer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load using the color scheme specified, otherwise default black
        If Not My.Settings.ColorScheme = vbNullString Then
            KryptonManager.GlobalPaletteMode = DirectCast([Enum].Parse(GetType(PaletteModeManager), My.Settings.ColorScheme), PaletteModeManager)
        Else
            KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        End If


    End Sub
    Sub shownotification(ByVal notificationtext As String, ByVal notificationtitle As String, ByVal icon As Image, ByVal lengthinmilliseconds As Integer)
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim loc As New System.Drawing.Point(intX - 500, intY)
        Me.Show()
        Me.Text = notificationtitle
        KryptonLabel1.Text = notificationtext
        PictureBox1.Image = icon
        Me.Location = loc
        timer.Interval = 500
        endtimer.Interval = lengthinmilliseconds
        endtimer.Enabled = True
        endtimer.Start()
        timer.Enabled = True
        timer.Start()

        AddHandler timer.Tick, AddressOf timer_tick
        AddHandler endtimer.Tick, AddressOf endtimer_tick


    End Sub
    Sub endtimer_tick()

        Me.Close()
        endtimer.Stop()
        endtimer.Enabled = False
    End Sub
    Sub timer_tick()
        Do Until i = 135
            Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
            Dim loc As New System.Drawing.Point(intX - 500, intY - i)
            Me.Location = loc
            i = i + 1
        Loop
        timer.Stop()
        timer.Enabled = False
        i = 0
        If My.Settings.Sound = True Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        End If
    End Sub
End Class