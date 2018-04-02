<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.RestartDragonButton = New System.Windows.Forms.Button()
        Me.KillAccessButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Version = New System.Windows.Forms.Label()
        Me.KillDragonButton = New System.Windows.Forms.Button()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.ButtonShowCommands = New System.Windows.Forms.Button()
        Me.KillIEButton = New System.Windows.Forms.Button()
        Me.KillExcelButton = New System.Windows.Forms.Button()
        Me.KillWordButton = New System.Windows.Forms.Button()
        Me.ButtonLaunchVoiceComputer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RestartDragonButton
        '
        Me.RestartDragonButton.BackColor = System.Drawing.Color.Black
        Me.RestartDragonButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.RestartDragonButton.ForeColor = System.Drawing.Color.Red
        Me.RestartDragonButton.Location = New System.Drawing.Point(0, 0)
        Me.RestartDragonButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RestartDragonButton.Name = "RestartDragonButton"
        Me.RestartDragonButton.Size = New System.Drawing.Size(212, 59)
        Me.RestartDragonButton.TabIndex = 0
        Me.RestartDragonButton.Text = "&Restart Dragon and Voice Computer"
        Me.RestartDragonButton.UseVisualStyleBackColor = False
        '
        'KillAccessButton
        '
        Me.KillAccessButton.BackColor = System.Drawing.Color.Black
        Me.KillAccessButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.KillAccessButton.ForeColor = System.Drawing.Color.DarkRed
        Me.KillAccessButton.Location = New System.Drawing.Point(0, 59)
        Me.KillAccessButton.Margin = New System.Windows.Forms.Padding(4)
        Me.KillAccessButton.Name = "KillAccessButton"
        Me.KillAccessButton.Size = New System.Drawing.Size(212, 57)
        Me.KillAccessButton.TabIndex = 1
        Me.KillAccessButton.Text = "Kill Microsoft &Access"
        Me.KillAccessButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Version.ForeColor = System.Drawing.Color.DarkRed
        Me.Version.Location = New System.Drawing.Point(0, 518)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(83, 18)
        Me.Version.TabIndex = 2
        Me.Version.Text = "Version 1.00"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KillDragonButton
        '
        Me.KillDragonButton.BackColor = System.Drawing.Color.Black
        Me.KillDragonButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.KillDragonButton.ForeColor = System.Drawing.Color.DarkRed
        Me.KillDragonButton.Location = New System.Drawing.Point(0, 116)
        Me.KillDragonButton.Margin = New System.Windows.Forms.Padding(4)
        Me.KillDragonButton.Name = "KillDragonButton"
        Me.KillDragonButton.Size = New System.Drawing.Size(212, 57)
        Me.KillDragonButton.TabIndex = 4
        Me.KillDragonButton.Text = "Kill The &Dragon and Voice Computer"
        Me.KillDragonButton.UseVisualStyleBackColor = False
        '
        'ButtonOptions
        '
        Me.ButtonOptions.BackColor = System.Drawing.Color.Black
        Me.ButtonOptions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonOptions.ForeColor = System.Drawing.Color.White
        Me.ButtonOptions.Location = New System.Drawing.Point(0, 459)
        Me.ButtonOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOptions.Name = "ButtonOptions"
        Me.ButtonOptions.Size = New System.Drawing.Size(212, 59)
        Me.ButtonOptions.TabIndex = 5
        Me.ButtonOptions.Text = "&Options"
        Me.ButtonOptions.UseVisualStyleBackColor = False
        '
        'ButtonShowCommands
        '
        Me.ButtonShowCommands.BackColor = System.Drawing.Color.Black
        Me.ButtonShowCommands.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonShowCommands.ForeColor = System.Drawing.Color.Sienna
        Me.ButtonShowCommands.Location = New System.Drawing.Point(0, 173)
        Me.ButtonShowCommands.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonShowCommands.Name = "ButtonShowCommands"
        Me.ButtonShowCommands.Size = New System.Drawing.Size(212, 57)
        Me.ButtonShowCommands.TabIndex = 6
        Me.ButtonShowCommands.Text = "Show Commands"
        Me.ButtonShowCommands.UseVisualStyleBackColor = False
        '
        'KillIEButton
        '
        Me.KillIEButton.BackColor = System.Drawing.Color.Black
        Me.KillIEButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.KillIEButton.ForeColor = System.Drawing.Color.DarkRed
        Me.KillIEButton.Location = New System.Drawing.Point(0, 230)
        Me.KillIEButton.Margin = New System.Windows.Forms.Padding(4)
        Me.KillIEButton.Name = "KillIEButton"
        Me.KillIEButton.Size = New System.Drawing.Size(212, 57)
        Me.KillIEButton.TabIndex = 7
        Me.KillIEButton.Text = "Kill Internet Explorer"
        Me.KillIEButton.UseVisualStyleBackColor = False
        '
        'KillExcelButton
        '
        Me.KillExcelButton.BackColor = System.Drawing.Color.Black
        Me.KillExcelButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.KillExcelButton.ForeColor = System.Drawing.Color.DarkRed
        Me.KillExcelButton.Location = New System.Drawing.Point(0, 287)
        Me.KillExcelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.KillExcelButton.Name = "KillExcelButton"
        Me.KillExcelButton.Size = New System.Drawing.Size(212, 57)
        Me.KillExcelButton.TabIndex = 8
        Me.KillExcelButton.Text = "Kill Microsoft Excel"
        Me.KillExcelButton.UseVisualStyleBackColor = False
        '
        'KillWordButton
        '
        Me.KillWordButton.BackColor = System.Drawing.Color.Black
        Me.KillWordButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.KillWordButton.ForeColor = System.Drawing.Color.DarkRed
        Me.KillWordButton.Location = New System.Drawing.Point(0, 344)
        Me.KillWordButton.Margin = New System.Windows.Forms.Padding(4)
        Me.KillWordButton.Name = "KillWordButton"
        Me.KillWordButton.Size = New System.Drawing.Size(212, 57)
        Me.KillWordButton.TabIndex = 9
        Me.KillWordButton.Text = "Kill Microsoft Word"
        Me.KillWordButton.UseVisualStyleBackColor = False
        '
        'ButtonLaunchVoiceComputer
        '
        Me.ButtonLaunchVoiceComputer.BackColor = System.Drawing.Color.Black
        Me.ButtonLaunchVoiceComputer.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonLaunchVoiceComputer.ForeColor = System.Drawing.Color.Sienna
        Me.ButtonLaunchVoiceComputer.Location = New System.Drawing.Point(0, 401)
        Me.ButtonLaunchVoiceComputer.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonLaunchVoiceComputer.Name = "ButtonLaunchVoiceComputer"
        Me.ButtonLaunchVoiceComputer.Size = New System.Drawing.Size(212, 57)
        Me.ButtonLaunchVoiceComputer.TabIndex = 10
        Me.ButtonLaunchVoiceComputer.Text = "Launch Voice Computer"
        Me.ButtonLaunchVoiceComputer.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(212, 536)
        Me.Controls.Add(Me.ButtonLaunchVoiceComputer)
        Me.Controls.Add(Me.KillWordButton)
        Me.Controls.Add(Me.KillExcelButton)
        Me.Controls.Add(Me.KillIEButton)
        Me.Controls.Add(Me.ButtonShowCommands)
        Me.Controls.Add(Me.ButtonOptions)
        Me.Controls.Add(Me.KillDragonButton)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.KillAccessButton)
        Me.Controls.Add(Me.RestartDragonButton)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RestartDragonButton As System.Windows.Forms.Button
    Friend WithEvents KillAccessButton As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents KillDragonButton As System.Windows.Forms.Button
    Friend WithEvents ButtonOptions As Button
    Friend WithEvents ButtonShowCommands As Button
    Friend WithEvents KillIEButton As Button
    Friend WithEvents KillExcelButton As Button
    Friend WithEvents KillWordButton As Button
    Friend WithEvents ButtonLaunchVoiceComputer As Button
End Class
