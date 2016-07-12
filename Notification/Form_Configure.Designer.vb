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
        Me.nmbDaysBeforeToAlert = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAlertColors = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtStatusStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nmbDaysBeforeToAlert, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnSave.Location = New System.Drawing.Point(258, 238)
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
        Me.chkSound.Location = New System.Drawing.Point(9, 80)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.Size = New System.Drawing.Size(132, 21)
        Me.chkSound.TabIndex = 9
        Me.chkSound.Text = "Sound on Alert?"
        Me.chkSound.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkSound)
        Me.GroupBox2.Controls.Add(Me.cmbAlertColors)
        Me.GroupBox2.Controls.Add(Me.nmbDaysBeforeToAlert)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(249, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 207)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alert Configuration"
        '
        'nmbDaysBeforeToAlert
        '
        Me.nmbDaysBeforeToAlert.Location = New System.Drawing.Point(241, 21)
        Me.nmbDaysBeforeToAlert.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nmbDaysBeforeToAlert.Name = "nmbDaysBeforeToAlert"
        Me.nmbDaysBeforeToAlert.Size = New System.Drawing.Size(69, 22)
        Me.nmbDaysBeforeToAlert.TabIndex = 1
        Me.nmbDaysBeforeToAlert.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Days Before Current Date To Alert:"
        '
        'cmbAlertColors
        '
        Me.cmbAlertColors.FormattingEnabled = True
        Me.cmbAlertColors.Location = New System.Drawing.Point(114, 50)
        Me.cmbAlertColors.Name = "cmbAlertColors"
        Me.cmbAlertColors.Size = New System.Drawing.Size(196, 24)
        Me.cmbAlertColors.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Color Scheme:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtStatusStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 359)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(881, 25)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtStatusStrip
        '
        Me.txtStatusStrip.Name = "txtStatusStrip"
        Me.txtStatusStrip.Size = New System.Drawing.Size(49, 20)
        Me.txtStatusStrip.Text = "Status"
        '
        'Form_Configure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 384)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "Form_Configure"
        Me.Text = "Configure"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nmbDaysBeforeToAlert, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents nmbDaysBeforeToAlert As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAlertColors As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents txtStatusStrip As ToolStripStatusLabel
End Class
