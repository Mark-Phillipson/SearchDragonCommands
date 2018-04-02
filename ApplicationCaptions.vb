Imports System.ComponentModel

Public Class ApplicationCaptions
    Private Sub ApplicationCaptions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Validate()
        Me.TblApplicationCaptionsBindingSource.EndEdit()
        Me.TblApplicationCaptionsTableAdapter.Update(Me.MyDatabaseDataSet)

    End Sub

    Private Sub ApplicationCaptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LaunchApplicationsDataSet.tblApplicationCaptions' table. You can move, or remove it, as needed.
        Me.TblApplicationCaptionsTableAdapter.Fill(Me.MyDatabaseDataSet.tblApplicationCaptions)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.TblApplicationCaptionsBindingSource.EndEdit()
        Me.TblApplicationCaptionsTableAdapter.Update(Me.MyDatabaseDataSet)
    End Sub
End Class