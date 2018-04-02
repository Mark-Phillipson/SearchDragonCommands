<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.TextBoxAppToRunWhenRestarting = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDragonXMLCommandsFileLocation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBoxShowCommands = New System.Windows.Forms.CheckBox()
        Me.ApplicationCaptionsButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(363, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(336, 12)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowse.TabIndex = 3
        Me.ButtonBrowse.Text = "&Browse"
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        Me.ButtonBrowse.Visible = False
        '
        'TextBoxAppToRunWhenRestarting
        '
        Me.TextBoxAppToRunWhenRestarting.Location = New System.Drawing.Point(15, 187)
        Me.TextBoxAppToRunWhenRestarting.Name = "TextBoxAppToRunWhenRestarting"
        Me.TextBoxAppToRunWhenRestarting.Size = New System.Drawing.Size(482, 20)
        Me.TextBoxAppToRunWhenRestarting.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Application to Run when Restarting"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Dragon XML Commands File Location and Name"
        '
        'TextBoxDragonXMLCommandsFileLocation
        '
        Me.TextBoxDragonXMLCommandsFileLocation.Location = New System.Drawing.Point(15, 68)
        Me.TextBoxDragonXMLCommandsFileLocation.Name = "TextBoxDragonXMLCommandsFileLocation"
        Me.TextBoxDragonXMLCommandsFileLocation.Size = New System.Drawing.Size(482, 20)
        Me.TextBoxDragonXMLCommandsFileLocation.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(482, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "If left blank then the current Users Documents Folder will be used.  With a name " &
    "of MyCommands.xml"
        '
        'CheckBoxShowCommands
        '
        Me.CheckBoxShowCommands.AutoSize = True
        Me.CheckBoxShowCommands.Location = New System.Drawing.Point(18, 117)
        Me.CheckBoxShowCommands.Name = "CheckBoxShowCommands"
        Me.CheckBoxShowCommands.Size = New System.Drawing.Size(211, 17)
        Me.CheckBoxShowCommands.TabIndex = 9
        Me.CheckBoxShowCommands.Text = "Automatically Show Dragon Commands"
        Me.CheckBoxShowCommands.UseVisualStyleBackColor = True
        '
        'ApplicationCaptionsButton
        '
        Me.ApplicationCaptionsButton.Location = New System.Drawing.Point(101, 274)
        Me.ApplicationCaptionsButton.Name = "ApplicationCaptionsButton"
        Me.ApplicationCaptionsButton.Size = New System.Drawing.Size(128, 23)
        Me.ApplicationCaptionsButton.TabIndex = 10
        Me.ApplicationCaptionsButton.Text = "Application Captions"
        Me.ApplicationCaptionsButton.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(521, 315)
        Me.Controls.Add(Me.ApplicationCaptionsButton)
        Me.Controls.Add(Me.CheckBoxShowCommands)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxDragonXMLCommandsFileLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxAppToRunWhenRestarting)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ButtonBrowse As System.Windows.Forms.Button
    Friend WithEvents TextBoxAppToRunWhenRestarting As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDragonXMLCommandsFileLocation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBoxShowCommands As CheckBox
    Friend WithEvents ApplicationCaptionsButton As Button
End Class
