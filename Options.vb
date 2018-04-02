Imports System.Windows.Forms

Public Class Options

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ' My.Settings.MyDatabaseConnectionString = Me.TextBoxDatabaseConnectionString.Text
        My.Settings.AppToRunWhenRestarting = TextBoxAppToRunWhenRestarting.Text
        My.Settings.DragonXMLCommandsFileLocation = TextBoxDragonXMLCommandsFileLocation.Text
        My.Settings.AutomaticallyShowDragonCommands = CheckBoxShowCommands.Checked
        My.Settings.Save()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'Private Sub ButtonBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBrowse.Click
    '    Dim OpenF As New OpenFileDialog
    '    With OpenF
    '        .Filter = "Microsoft Access database (*.mdb)|*.mdb"
    '        .FilterIndex = 0
    '        .InitialDirectory = "C:\"
    '        .Multiselect = False

    '        If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub

    '        If .FileNames(0).Length > 0 Then
    '            Me.TextBoxDatabaseLocation.Text = .FileNames(0).ToString()
    '        End If
    '    End With

    'End Sub

    Private Sub Options_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBoxAppToRunWhenRestarting.Text = My.Settings.AppToRunWhenRestarting
        TextBoxDragonXMLCommandsFileLocation.Text = My.Settings.DragonXMLCommandsFileLocation
        CheckBoxShowCommands.Checked = My.Settings.AutomaticallyShowDragonCommands
    End Sub

    Private Sub ApplicationCaptionsButton_Click(sender As Object, e As EventArgs) Handles ApplicationCaptionsButton.Click
        Dim form As New ApplicationCaptions()
        form.Show()
    End Sub
End Class
