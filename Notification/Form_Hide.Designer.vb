<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Hide
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Hide))
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConfigureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.NotifyMenuStrip1
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "FEP Notifications"
        Me.TrayIcon.Visible = True
        '
        'NotifyMenuStrip1
        '
        Me.NotifyMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NotifyMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigureToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitProgram})
        Me.NotifyMenuStrip1.Name = "NotifyMenuStrip1"
        Me.NotifyMenuStrip1.Size = New System.Drawing.Size(150, 82)
        '
        'ConfigureToolStripMenuItem
        '
        Me.ConfigureToolStripMenuItem.Name = "ConfigureToolStripMenuItem"
        Me.ConfigureToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.ConfigureToolStripMenuItem.Text = "Configure"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExitProgram
        '
        Me.ExitProgram.Name = "ExitProgram"
        Me.ExitProgram.Size = New System.Drawing.Size(149, 26)
        Me.ExitProgram.Text = "Exit"
        '
        'Form_Hide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(77, 13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Hide"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "Notify"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.NotifyMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TrayIcon As NotifyIcon
    Friend WithEvents NotifyMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExitProgram As ToolStripMenuItem
    Friend WithEvents ConfigureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
