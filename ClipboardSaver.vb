Public Class ClipboardSaver

    ' Activate an application window. 
    Declare Auto Function SetForegroundWindow Lib "USER32.DLL" _
        (ByVal hWnd As IntPtr) As Boolean


    Private Declare Function GetAsyncKeyState Lib "USER32.DLL" (ByVal vkey As Long) As Integer



    Private Sub ClipboardSaver_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.Timer1.Enabled = False
    End Sub

    Private Sub ClipboardSaver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblClipboardSaverTableAdapter.Fill(Me.LaunchApplicationsDataSet.tblClipboardSaver)
        Me.Timer1.Interval = 2000
        Me.Timer1.Enabled = True
        objConn = GetObjConn()
        objConn.Open()
        ' objConn.OpenAsync()
        Dim strSQLText As String = "DELETE  dbo.tblClipboardSaver" & vbCrLf _
         & " WHERE dbo.tblClipboardSaver.Date_Saved < (GetDate() - 30) And dbo.tblClipboardSaver.To_Keep = 0"

        Dim objCmd As New SqlClient.SqlCommand(strSQLText, objConn)
        'Dim objCmd As New OleDbCommand(strSQLText, objConn)
        objCmd.CommandType = CommandType.Text
        Try
            objCmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Me.TblClipboardSaverBindingSource.Sort = "[Date_Saved] DESC"

        NumberItems()
    End Sub

    Private Sub NumberItems()
        For Each row In Me.DataGridView1.Rows
            If row.index + 1 = 21 Then Exit For
            Me.DataGridView1.Rows(row.index).Cells(1).Value = row.Index + 1
        Next

    End Sub
    Dim objConn As SqlClient.SqlConnection 'OleDbConnection
    Private Shared Function GetObjConn() As SqlClient.SqlConnection 'OleDbConnection
        'Dim objConn As New OleDbConnection _
        '          ("Provider=SQLOLEDB;Data Source=USER-HP;Initial Catalog=MyDatabase;Integrated Security=SSPI;")
        Dim objConn As New SqlClient.SqlConnection(My.Settings.SaveClipboardShowCommandsConnectionString)
        Return objConn
    End Function

    Private Sub ClipboardSaver_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        objConn.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Static blnUpdateRequired As Boolean
        Static strLastClipboard As String
        Static Counter As Long
        Dim blnAlreadyThere As Boolean = False

        Counter = Counter + 1

        If Counter > 500 Then
            Me.WindowState = FormWindowState.Minimized
            Counter = 0
        End If

        If blnUpdateRequired Then
            Try
                Me.TblClipboardSaverTableAdapter.Fill(Me.LaunchApplicationsDataSet.tblClipboardSaver)
                NumberItems()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try

            blnUpdateRequired = False
        End If
        Dim strClipboard As String = ""
        Try
            strClipboard = Clipboard.GetText()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If strClipboard = strLastClipboard Then Exit Sub
        strLastClipboard = strClipboard
        If Len(strClipboard) < 4097 And Len(strClipboard) > 0 Then
            Dim intTemporaryValueLength As Integer
            If Len(strClipboard) < 255 Then
                intTemporaryValueLength = Len(strClipboard)
            Else
                intTemporaryValueLength = 255
            End If

            Dim objCmd As New SqlClient.SqlCommand("insert into tblClipboardSaver (Clipboard_Value, clipboard_memo) values (" &
                                           FixQuotes(strClipboard.Substring(0, intTemporaryValueLength)) & ", " & FixQuotes(strClipboard) & ")",
            objConn)
            objCmd.CommandType = CommandType.Text
            Try
                objCmd.ExecuteNonQuery()
                ' refresh the data grid view
                blnUpdateRequired = True

            Catch ex As Exception
                If InStr(ex.Message, "duplicate") > 0 Then
                    '  ignore the error message
                    blnAlreadyThere = True
                Else
                    MessageBox.Show(ex.Message)
                End If
            End Try
            If blnAlreadyThere Then
                Dim strSQLText As String
                strSQLText = "UPDATE tblClipboardSaver SET tblClipboardSaver.Date_Saved = GetDate()" & vbCrLf
                strSQLText = strSQLText & "       WHERE (((tblClipboardSaver.Clipboard_Value)=" & FixQuotes(strClipboard) & "));"

                Dim objCmdUpdate As New SqlClient.SqlCommand(strSQLText,
                objConn)
                objCmdUpdate.CommandType = CommandType.Text
                Try
                    objCmdUpdate.ExecuteNonQuery()
                    ' refresh the data grid view
                    blnUpdateRequired = True

                Catch ex As Exception
                    If InStr(ex.Message, "failed to update data saved!") > 0 Then
                        '  ignore the error message
                    Else
                        MessageBox.Show(ex.Message)
                    End If
                End Try

            End If

        Else
            '    Beep()
        End If


    End Sub


    'Public Function GetOriginalWindowHandle() As IntPtr
    '    Dim strSQLText As String
    '    strSQLText = "SELECT [Handle] FROM [dbo].[CurrentWindow] WHERE ID = 1"

    '    Dim objCmdSelect As New OleDbCommand(strSQLText, _
    '    objConn)
    '    objCmdSelect.CommandType = CommandType.Text
    '    Try
    '        Dim Handle As Integer = objCmdSelect.ExecuteScalar()
    '        ' refresh the data grid view
    '        Return Handle
    '    Catch ex As Exception
    '        If InStr(ex.Message, "failed to update data saved!") > 0 Then
    '            '  ignore the error message
    '        Else
    '            MessageBox.Show(ex.Message)
    '        End If
    '    End Try

    'End Function

    Public Function FixQuotes(ByVal varValue As Object) As String
        ' Double any quotes inside varValue, and
        ' surround it with quotes.

        ' From Access 2000 Developer's Handbook, Volume I
        ' by Getz, Litwin, Gilbert (Sybex)
        ' Copyright 1999.  All rights reserved.



        FixQuotes = "'" & Replace$(varValue & "", "'", "''", Compare:=vbTextCompare) & "'"
    End Function

    'Private Sub OpacityButton_Click(sender As Object, e As EventArgs) Handles OpacityButton.Click
    '    If Me.Opacity > 0.5 Then
    '        Me.Opacity = Me.Opacity - 0.2
    '        Me.TransparencyKey = Color.White
    '    End If
    'End Sub

    'Private Sub OpacityMoreButton_Click(sender As Object, e As EventArgs) Handles OpacityMoreButton.Click
    '    If Me.Opacity < 1 Then
    '        Me.Opacity = Me.Opacity + 0.2
    '        Me.TransparencyKey = Color.Aqua
    '    End If
    'End Sub

    Private Sub ClipboardSaver_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Timer1.Enabled = True
    End Sub

    Private Sub MinimiseWindowButton_Click(sender As Object, e As EventArgs) Handles MinimiseWindowButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class