<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Configure
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblserver = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkSound = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nmbMinuteWindow = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nmbCheckInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nmbAlertTimeout = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAlertColors = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtStatusStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblLastAlertCheck = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnRecreateDatabase = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nmbMinuteWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmbCheckInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmbAlertTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(100, 18)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(100, 22)
        Me.txtServer.TabIndex = 0
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(100, 47)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 22)
        Me.txtUserName.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(100, 75)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtPassword.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(484, 177)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblserver
        '
        Me.lblserver.AutoSize = True
        Me.lblserver.Location = New System.Drawing.Point(11, 21)
        Me.lblserver.Name = "lblserver"
        Me.lblserver.Size = New System.Drawing.Size(83, 17)
        Me.lblserver.TabIndex = 5
        Me.lblserver.Text = "Web Server"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(11, 50)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(75, 17)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "UserName"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(11, 78)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtServer)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.lblserver)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 112)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "API Settings"
        '
        'chkSound
        '
        Me.chkSound.AutoSize = True
        Me.chkSound.Checked = True
        Me.chkSound.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSound.Location = New System.Drawing.Point(9, 132)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.Size = New System.Drawing.Size(132, 21)
        Me.chkSound.TabIndex = 9
        Me.chkSound.Text = "Sound on Alert?"
        Me.chkSound.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.nmbMinuteWindow)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.nmbCheckInterval)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.nmbAlertTimeout)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkSound)
        Me.GroupBox2.Controls.Add(Me.cmbAlertColors)
        Me.GroupBox2.Location = New System.Drawing.Point(249, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 159)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alert Configuration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "minutes"
        '
        'nmbMinuteWindow
        '
        Me.nmbMinuteWindow.Location = New System.Drawing.Point(183, 102)
        Me.nmbMinuteWindow.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.nmbMinuteWindow.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmbMinuteWindow.Name = "nmbMinuteWindow"
        Me.nmbMinuteWindow.Size = New System.Drawing.Size(52, 22)
        Me.nmbMinuteWindow.TabIndex = 17
        Me.nmbMinuteWindow.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Minute Window For Query: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "seconds"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Time Between Checks:"
        '
        'nmbCheckInterval
        '
        Me.nmbCheckInterval.Location = New System.Drawing.Point(163, 74)
        Me.nmbCheckInterval.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nmbCheckInterval.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nmbCheckInterval.Name = "nmbCheckInterval"
        Me.nmbCheckInterval.Size = New System.Drawing.Size(52, 22)
        Me.nmbCheckInterval.TabIndex = 14
        Me.nmbCheckInterval.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "seconds"
        '
        'nmbAlertTimeout
        '
        Me.nmbAlertTimeout.Location = New System.Drawing.Point(136, 47)
        Me.nmbAlertTimeout.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nmbAlertTimeout.Name = "nmbAlertTimeout"
        Me.nmbAlertTimeout.Size = New System.Drawing.Size(57, 22)
        Me.nmbAlertTimeout.TabIndex = 11
        Me.nmbAlertTimeout.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Alert Display Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Color Scheme:"
        '
        'cmbAlertColors
        '
        Me.cmbAlertColors.FormattingEnabled = True
        Me.cmbAlertColors.Location = New System.Drawing.Point(114, 19)
        Me.cmbAlertColors.Name = "cmbAlertColors"
        Me.cmbAlertColors.Size = New System.Drawing.Size(196, 24)
        Me.cmbAlertColors.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtStatusStrip, Me.lblLastAlertCheck})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 220)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(581, 25)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtStatusStrip
        '
        Me.txtStatusStrip.Name = "txtStatusStrip"
        Me.txtStatusStrip.Size = New System.Drawing.Size(49, 20)
        Me.txtStatusStrip.Text = "Status"
        '
        'lblLastAlertCheck
        '
        Me.lblLastAlertCheck.Name = "lblLastAlertCheck"
        Me.lblLastAlertCheck.Size = New System.Drawing.Size(117, 20)
        Me.lblLastAlertCheck.Text = "Last Alert Check:"
        '
        'btnRecreateDatabase
        '
        Me.btnRecreateDatabase.Location = New System.Drawing.Point(12, 184)
        Me.btnRecreateDatabase.Name = "btnRecreateDatabase"
        Me.btnRecreateDatabase.Size = New System.Drawing.Size(166, 23)
        Me.btnRecreateDatabase.TabIndex = 12
        Me.btnRecreateDatabase.Text = "Re-Create Database"
        Me.btnRecreateDatabase.UseVisualStyleBackColor = True
        '
        'Form_Configure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 245)
        Me.Controls.Add(Me.btnRecreateDatabase)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Configure"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Endpoint Alert Configuration"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nmbMinuteWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmbCheckInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmbAlertTimeout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblserver As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkSound As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbAlertColors As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents txtStatusStrip As ToolStripStatusLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents nmbAlertTimeout As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents nmbCheckInterval As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLastAlertCheck As ToolStripStatusLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents nmbMinuteWindow As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRecreateDatabase As Button
End Class
