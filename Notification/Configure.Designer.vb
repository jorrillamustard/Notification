<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Configure
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
        Me.Server = New System.Windows.Forms.TextBox()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtStatusStrip = New System.Windows.Forms.Label()
        Me.lblserver = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Server
        '
        Me.Server.Location = New System.Drawing.Point(99, 56)
        Me.Server.Name = "Server"
        Me.Server.Size = New System.Drawing.Size(100, 22)
        Me.Server.TabIndex = 0
        '
        'UserName
        '
        Me.UserName.Location = New System.Drawing.Point(99, 93)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(100, 22)
        Me.UserName.TabIndex = 1
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(99, 130)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(100, 22)
        Me.Password.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(111, 169)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtStatusStrip
        '
        Me.txtStatusStrip.AutoSize = True
        Me.txtStatusStrip.Location = New System.Drawing.Point(28, 254)
        Me.txtStatusStrip.Name = "txtStatusStrip"
        Me.txtStatusStrip.Size = New System.Drawing.Size(52, 17)
        Me.txtStatusStrip.TabIndex = 4
        Me.txtStatusStrip.Text = "Status:"
        '
        'lblserver
        '
        Me.lblserver.AutoSize = True
        Me.lblserver.Location = New System.Drawing.Point(13, 56)
        Me.lblserver.Name = "lblserver"
        Me.lblserver.Size = New System.Drawing.Size(83, 17)
        Me.lblserver.TabIndex = 5
        Me.lblserver.Text = "Web Server"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(10, 93)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(75, 17)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "UserName"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(10, 130)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password"
        '
        'Configure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 296)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblserver)
        Me.Controls.Add(Me.txtStatusStrip)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Server)
        Me.Name = "Configure"
        Me.Text = "Configure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Server As TextBox
    Friend WithEvents UserName As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtStatusStrip As Label
    Friend WithEvents lblserver As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
End Class
