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

        Me.Opacity = 0
        Me.Show()
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Me.Opacity = 100
        Me.Text = notificationtitle
        KryptonLabel1.Text = notificationtext
        Dim strsize = MeasureString(notificationtext)

        KryptonLabel1.Height = strsize.Height
        KryptonLabel1.Width = strsize.Width
        Dim loc As New System.Drawing.Point(intX - Me.Width, intY)
        If strsize.Height > 58 Then
            Me.Height = strsize.Height
            Me.Refresh()
        End If

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
    Public Function MeasureString(ByVal Str As String) As SizeF
        Dim font As New Font(FontFamily.GenericSansSerif, 20, FontStyle.Regular)

        Dim g As Graphics = Me.CreateGraphics
        Return g.MeasureString(Str, font)
    End Function
    Sub endtimer_tick()

        Me.Close()
        endtimer.Stop()
        endtimer.Enabled = False
    End Sub
    Sub timer_tick()
        Do Until i = Me.Height + 40
            Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
            Dim loc As New System.Drawing.Point(intX - Me.Width, intY - i)
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
