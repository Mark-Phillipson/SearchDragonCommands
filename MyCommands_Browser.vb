Imports System
Imports System.Xml.Linq
Imports System.Xml
Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class MyCommands_Browser

    'Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As Integer
    Declare Function GetWindowTextLength Lib "user32.dll" Alias "GetWindowTextLengthA" (ByVal hwnd As Integer) As Integer
    Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
    Declare Function GetForegroundWindow Lib "user32.dll" () As Int32

    Declare Function GetWindowThreadProcessId Lib "user32.dll" (
        ByVal hwnd As Int32,
        ByRef lpdwProcessId As Int32) As Int32

    Private m_LastHwnd As Integer

    Dim valueBindingDS As New BindingSource
    Dim masterBindingSource As New BindingSource()
    Dim ContentsBindingSource As New BindingSource()
    Dim detailsBindingSource As New BindingSource()
    Dim detailsBindingSource2 As New BindingSource()
    Dim ListsBindingSource As New BindingSource()
    Dim CommandBindingSource As New BindingSource()
    Dim CommandsBindingSource As New BindingSource()
    Dim ApplicationBindingSource As New BindingSource()
    Dim ds As New DataSet

    Public Function RetCurWindowProcessID() As Int32
        Dim processID As Int32
        GetWindowThreadProcessId(GetForegroundWindow(), processID)
        'Return Process.GetProcessById(processID).MainWindowTitle
        Return processID
    End Function    ' The hWnd of the most recently found window.

    Private Sub MyCommands_Browser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo 0

        Me.TblApplicationCaptionsTableAdapter.Fill(Me.LaunchApplicationsDataSet.tblApplicationCaptions)
        Dim xrs = New XmlReaderSettings()
        Me.Timer1.Interval = 5000
        'Me.Timer1.Enabled = True
        Me.Timer1.Enabled = False
        Me.masterBindingSource.Filter = ""

        'xrs.ProhibitDtd = False
        xrs.DtdProcessing = DtdProcessing.Ignore
        'the document type definition appears to be unavailable or restricted in some way therefore:
        'Exit Sub
        If Not ReadXML(xrs, ds) Then Exit Sub
        'only when connected to work or at work is it unavailable!
        DataGridViewCommand.DataSource = detailsBindingSource
        'DataGridViewCommand2.DataSource = detailsBindingSource2
        Me.DataGridViewContents.DataSource = ContentsBindingSource

        masterBindingSource.DataSource = ds
        '  Dim filename As String = "c:\cwtest.csv"
        ' Dim sw As New StreamWriter(filename, False, System.Text.Encoding.UTF8)
        ' Code to export as a delimited file not tested
        'Try
        '    sw.WriteLine("""Column1"", ""Column2""")
        '    For Each DataRow In ds.Tables(2).Rows
        '        sw.WriteLine("""{0}"", ""{1}""", DataRow(0), DataRow(1))
        '    Next
        'Finally
        '    sw.Close()
        'End Try

        masterBindingSource.DataMember = "Commands"
        ApplicationBindingSource.DataSource = ds
        ApplicationBindingSource.DataMember = "Commands"
        Me.DataGridViewCommands.DataSource = masterBindingSource
        DataGridViewCommands.Columns(0).Visible = False
        DataGridViewCommands.Columns(1).Visible = True
        Me.DataGridViewCommands.Columns(1).HeaderText = "Company"
        Me.DataGridViewCommands.Columns(2).HeaderText = "Application"
        Me.DataGridViewCommands.Columns(2).Width = 270
        Me.DataGridViewCommands.Columns(3).HeaderText = "Window Caption"
        Me.DataGridViewCommands.Columns(3).Width = 150
        On Error Resume Next
        Me.DataGridViewCommands.Columns(4).HeaderText = "Class"
        Me.DataGridViewCommands.Columns(4).Visible = False
        Me.DataGridViewCommands.Columns(5).HeaderText = "Type"
        Me.DataGridViewCommands.Columns(5).Width = 100
        On Error GoTo 0
        '        ' where description field in the commands table is empty set it to global
        detailsBindingSource.DataSource = masterBindingSource
        detailsBindingSource.DataMember = "Commands_Command"
        detailsBindingSource2.DataSource = masterBindingSource
        detailsBindingSource2.DataMember = "Commands_Command"
        ContentsBindingSource.DataSource = detailsBindingSource
        ContentsBindingSource.DataMember = "Command_contents"
        ListsBindingSource.DataSource = ds
        ListsBindingSource.DataMember = "List"
        valueBindingDS.DataSource = ds
        valueBindingDS.DataMember = "Value"
        Dim column As DataGridViewColumn
        Me.DataGridViewCommand.ReadOnly = True
        Me.DataGridViewContents.ReadOnly = True
        column = Me.DataGridViewCommand.Columns(1)
        column.HeaderText = "Command Name"
        Me.CommandsBindingSource.DataSource = ds.Tables(1)
        Me.DataGridViewCommandsShowAll.DataSource = ApplicationBindingSource
        CommandsBindingSource.Sort = "description ASC"
        DataGridViewCommandsShowAll.Columns(0).Visible = False
        DataGridViewCommandsShowAll.Columns(1).Visible = False
        Me.DataGridViewCommandsShowAll.Columns(2).HeaderText = "Application"
        Me.DataGridViewCommandsShowAll.Columns(2).Width = 270
        Me.DataGridViewCommandsShowAll.Columns(3).HeaderText = "Window Caption"
        Me.DataGridViewCommandsShowAll.Columns(3).Width = 150
        On Error Resume Next
        Me.DataGridViewCommandsShowAll.Columns(4).HeaderText = "Class"
        Me.DataGridViewCommandsShowAll.Columns(4).Visible = False
        Me.DataGridViewCommandsShowAll.Columns(5).HeaderText = "Type"
        Me.DataGridViewCommandsShowAll.Columns(5).Width = 100
        On Error GoTo 0
        Me.DataGridViewCommandsShowAll.Visible = False ' this is hidden by default and shown when filter all items is ticked
        detailsBindingSource.Sort = "name ASC"
        detailsBindingSource2.Sort = "name DESC"

        DataGridViewCommand.Columns(0).Visible = False
        DataGridViewCommand.Columns(1).Visible = True
        DataGridViewCommand.Columns(1).Width = 310
        DataGridViewCommand.Columns(1).HeaderText = "Command"
        DataGridViewCommand.Columns(2).Visible = True
        DataGridViewCommand.Columns(2).Width = 70
        DataGridViewCommand.Columns(2).HeaderText = "Group"
        DataGridViewCommand.Columns(0).DisplayIndex = 4
        DataGridViewCommand.Columns(3).Visible = False
        DataGridViewCommand.Columns(4).Visible = False

        'DataGridViewCommand2.Columns(0).Visible = False
        'DataGridViewCommand2.Columns(2).Visible = True
        'DataGridViewCommand2.Columns(0).DisplayIndex = 4
        'DataGridViewCommand2.Columns(3).Visible = False
        'DataGridViewCommand2.Columns(4).Visible = False
        Me.DataGridViewContents.Columns(0).Visible = False
        Me.DataGridViewContents.Columns(1).Visible = False
        Me.DataGridViewContents.Columns(2).HeaderText = "Command Type"
        Me.DataGridViewContents.Columns(2).Width = 180

        Dim index As Integer =
        detailsBindingSource.Find("name", "Compile Code")
        If index < -1 Then 'it was found; move to that position
            detailsBindingSource.Position = index
        End If
        Me.detailsBindingSource.MoveFirst()
        Dim drv = detailsBindingSource.Item(detailsBindingSource.Position)
        If Not IsDBNull(drv.Item(2)) Then
            FilterLists(drv.Item(2))
        End If
        ' by default to do not show learned scripts  for example with a group name of  Custom Learned
        Me.detailsBindingSource.Filter = "group = 'Custom'"
        Me.detailsBindingSource2.Filter = "group = 'Custom'"
        Me.checkboxSynchronise.Checked = False
        If Me.checkboxSynchronise.Checked Then
            Me.Timer1.Enabled = True
            Me.CheckBoxShowAll.Checked = False
        Else
            Me.Timer1.Enabled = False
            Me.masterBindingSource.Filter = ""
        End If


        RandomSelectCommand()
        RefreshFormControls()
        Me.txtSearch.Focus()
    End Sub


    Private Shared Function ReadXML(ByVal xrs As XmlReaderSettings, ByRef ds As DataSet) As Boolean
        Dim xmlFile As XmlReader
        Dim stringFile As String = ""
        If My.Settings.DragonXMLCommandsFileLocation.Length > 0 Then
            stringFile = My.Settings.DragonXMLCommandsFileLocation '& IIf(My.Settings.DragonXMLCommandsFileLocation.Substring(My.Settings.DragonXMLCommandsFileLocation.Length - 1, 1) = "\", "", "\") & "MyCommands.xml"
        Else
            stringFile = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\MyCommands.xml"
        End If

        Try
            xmlFile = XmlReader.Create(stringFile, xrs)
            ' xrs.ValidationType = ValidationType.None


            ds.ReadXml(xmlFile)
            ds.ReadXmlSchema(xmlFile)

        Catch ex As Exception
            If InStr(ex.Message, "Could not find file") > 0 Then
                MessageBox.Show(ex.Message & " please Export your commands from the Command Browser first in XML format and save them to to the file and location listed above. Otherwise Dragon commands will not be shown.",
                                " File Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False : Exit Function
            Else
                MessageBox.Show(ex.Message, " Unexpected Exception Occurred ")
                Return False : Exit Function
            End If

        End Try
        Return True : Exit Function
    End Function
    Public Shared Sub PrintDataSet(ByVal ds As DataSet)

        ' Print out all tables and their columns   
        For Each table As DataTable In ds.Tables
            Debug.Print(" table name " & table.TableName)
            Debug.Print(" number of rows " & table.Rows.Count)
            Debug.Print("---------------------------------------------------------------")

            For Each column As DataColumn In table.Columns
                Debug.Print(column.ColumnName & " " & column.DataType.ToString())
            Next  ' For Each column   
            Debug.Print("---------------------------------------------------------------")


        Next  ' For Each table   

        ' Print out table relations   
        For Each relation As DataRelation In ds.Relations
            Debug.Print(" relations name " & relation.RelationName)
            Debug.Print("parent/child---------------------------------------------------------------")
            Debug.Print(relation.ParentTable.TableName)
            Debug.Print(relation.ChildTable.TableName)

        Next  ' For Each relation   

    End Sub


    Private Sub DataGridView2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewCommand.SelectionChanged

        'Dim MyCommands As XDocument=XDocument.Load(CurDir & "\MyCommands.xml"

        'Dim cnt = Aggregate ele In MyCommands.<Commands> _
        '         Into Count()
        RefreshFormControls()


    End Sub

    Private Sub RefreshFormControls()
        Me.TreeViewLists.Nodes.Clear()
        Dim MyCommands As XElement = XElement.Load(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\MyCommands.xml")

        Dim drv As DataRowView
        'If detailsBindingSource.Position < 1 Then Exit Sub
        If detailsBindingSource.Position > -1 And Not Me.CheckBoxShowAll.Checked Then
            drv = detailsBindingSource.Item(detailsBindingSource.Position)
            If IsDBNull(drv.Item(2)) Then Exit Sub

            Me.TextBoxDescription.Text = drv.Item(0) ' show description in text box
            Dim result = From ele In MyCommands.<Commands>.<Command>
                         Where ele.@name = drv.Item(2) And ele.<contents>.@type = "SCRIPT"
                         Select ele.<contents>.Value

            Me.RichTextBox1.Text = ""

            'On Error Resume Next
            For Each cmd In result

                Me.RichTextBox1.Text = cmd
            Next
            On Error GoTo 0
            If Me.RichTextBox1.Text = "" Then
                GetRichTextValue(drv, MyCommands)
            End If
            If Not IsDBNull(drv.Item(2)) Then
                FilterLists(drv.Item(2))
            End If
        End If

        If Me.CheckBoxShowAll.Checked And CommandBindingSource.Position > -1 Then ' display the application name in a text box
            drv = CommandBindingSource.Item(CommandBindingSource.Position)
            If Not IsDBNull(drv.Item(2)) Then
                Dim result = From ele In MyCommands.<Commands>.<Command>
                             Where ele.@name = drv.Item(2) And ele.<contents>.@type = "SCRIPT"
                             Select ele.<contents>.Value

                Me.RichTextBox1.Text = ""

                'On Error Resume Next
                For Each cmd In result

                    Me.RichTextBox1.Text = cmd
                Next
                On Error GoTo 0
            End If
            If Not IsDBNull(drv.Item(6)) Then
                If drv.Item(6) > -1 Then
                    Me.ApplicationBindingSource.Filter = "Commands_ID =" & drv.Item(6) ' 
                End If
            End If
            If Me.RichTextBox1.Text = "" Then
                GetRichTextValue(drv, MyCommands)
            End If
            ' if docmd name contains square brackets filter the lists combo box upon the first argument
            If Not IsDBNull(drv.Item(2)) Then

                FilterLists(drv.Item(2))
            End If
        End If

    End Sub

    Private Sub GetRichTextValue(ByVal drv As DataRowView, ByVal MyCommands As Xml.Linq.XElement)
        Dim result = From ele In MyCommands.<Commands>.<Command>
                     Where ele.@name = drv.Item(2) And ele.<contents>.@type = "TEXT-GRAPHICS"
                     Select ele.<contents>.<RTF>.Value
        Me.RichTextBox1.Text = ""

        'On Error Resume Next
        For Each cmd In result

            'Me.RichTextBox1.Text = cmd
            Me.RichTextBox1.Rtf = cmd
        Next
        On Error GoTo 0

        If Me.RichTextBox1.Text = "" Then
            result = From ele In MyCommands.<Commands>.<Command>
                     Where ele.@name = drv.Item(2) And ele.<contents>.@type = "TEXT-GRAPHICS"
                     Select ele.<contents>.<TEXT>.Value
            Me.RichTextBox1.Text = ""

            'On Error Resume Next
            For Each cmd In result

                Me.RichTextBox1.Text = cmd
            Next

        End If

    End Sub

    Private Function GetAppFolder() As String
        Dim strfolder As String = System.Reflection.Assembly.GetExecutingAssembly.Location().Substring(0,
                        System.Reflection.Assembly.GetExecutingAssembly.Location().Length - 24)
        Return strfolder
    End Function

    Private Sub ComboBoxList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ListsBindingSource.Position = Me.ComboBoxList.SelectedIndex
        'Dim MyCommands As XElement = XElement.Load(GetAppFolder() & "\MyCommands.xml")
        ''Dim MyCommands As XDocument=XDocument.Load(CurDir & "\MyCommands.xml"

        ''Dim cnt = Aggregate ele In MyCommands.<Commands> _
        ''         Into Count()
        'If ListsBindingSource.Position > -1 Then
        '    Dim drv As DataRowView = ListsBindingSource.Item(ListsBindingSource.Position)
        '    ' this is only selecting one item in the list and I have no idea why folks like
        '    Dim result = From ele In MyCommands.<Lists>.<List> _
        '                 Where ele.@name = Me.ComboBoxList.Text _
        '                 Select ele.<Value>.Value

        '    Me.RichTextBoxList.Text = ""
        '    'MessageBox.Show(Me.ComboBoxList.Text)
        '    On Error Resume Next
        '    Dim strTemp As String = ""
        '    For Each cmd In result

        '        strTemp = strTemp & cmd.ToString & "; "
        '    Next
        '    On Error GoTo 0
        '    Me.RichTextBoxList.Text = strTemp
        'End If


    End Sub



    Private Sub FilterLists(ByVal strCommandName As String)
        ' if docmd name contains square brackets filter the lists combo box upon the first argument
        Dim MyCommands As XElement = XElement.Load(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\MyCommands.xml")

        If Not IsDBNull(strCommandName) And strCommandName.ToString.Contains("[") Then
            Dim strTemporary As String = strCommandName
            Dim intNodeCounter As Integer = 0
            Me.TreeViewLists.Nodes.Clear()
            Do
                Dim position1 = strTemporary.ToString.IndexOf("[")
                Dim position2 = strTemporary.ToString.IndexOf("]")
                If position2 > 0 Then

                    Dim strListName As String = strTemporary.ToString.Substring(position1 + 1, position2 - position1 - 1)
                    Me.ListsBindingSource.Filter = "name = '" & strListName & "'"

                    Dim RootNode = New TreeNode(strListName)
                    Me.TreeViewLists.Nodes.Add(RootNode)



                    ' loop through each list item
                    ListsBindingSource.MoveFirst()

                    'Dim result = From ele In MyCommands.<Lists>.<List> _
                    '             Where ele.@name = strListName _
                    '             Select ele.Value

                    'For Each v In result
                    '    Me.TreeViewLists.Nodes(intNodeCounter).Nodes.Add(New TreeNode(v))
                    'Next




                    Dim drv As DataRowView
                    If ListsBindingSource.Position > -1 Then
                        drv = ListsBindingSource.Item(ListsBindingSource.Position)
                        valueBindingDS.Filter = "List_Id= " & drv.Item(0)
                        Me.valueBindingDS.MoveFirst()
                        Do
                            drv = valueBindingDS.Item(Me.valueBindingDS.Position)
                            Me.TreeViewLists.Nodes(intNodeCounter).Nodes.Add(New TreeNode(drv.Item(0)))
                            If Me.valueBindingDS.Position = Me.valueBindingDS.Count - 1 Then Exit Do
                            Me.valueBindingDS.MoveNext()
                        Loop
                    End If
                    intNodeCounter = intNodeCounter + 1

                    'For intLoopIndex As Integer = 2 To 3
                    '    Me.TreeViewLists.Nodes(0).Nodes(0).Nodes.Add(New  _
                    '        TreeNode("Node" & Str(intLoopIndex)))
                    'Next intLoopIndex

                    'Me.TreeViewLists.Nodes(0).Nodes.Add(New TreeNode("Node 4"))

                    'For intLoopIndex As Integer = 5 To 6
                    '    Me.TreeViewLists.Nodes(0).Nodes(1).Nodes.Add(New  _
                    '        TreeNode("Node" & Str(intLoopIndex)))
                    'Next intLoopIndex


                    strTemporary = Mid(strTemporary, position2 + 2)
                Else
                    Exit Do
                End If
            Loop
        Else
            Me.ListsBindingSource.Filter = ""
        End If
        Me.TreeViewLists.ExpandAll()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ' Get the window's handle.
        Dim fg_hwnd As Long = GetForegroundWindow()

        ' If this is the same as the previous foreground window,
        ' let that one remain the most recent entry.
        If m_LastHwnd = fg_hwnd Then Exit Sub
        m_LastHwnd = fg_hwnd
        If Me.CheckBoxShowAll.Checked Then
            Me.Timer1.Enabled = False
            Exit Sub
        End If
        Dim hWndChildProcessID = RetCurWindowProcessID()

        Dim strWindowTitle = GetWindowTitle(fg_hwnd)
        Me.TextBoxApplicationCaption.Text = strWindowTitle
        If strWindowTitle = "My Commands in Dragon" Or strWindowTitle = "Launcher" Then
            Exit Sub
        End If
        Dim p As System.Diagnostics.Process
        For Each p In System.Diagnostics.Process.GetProcesses()
            ' Because Windows Explorer does not have a set to Windows title work out from the process ID
            If p.ProcessName = "explorer" And hWndChildProcessID = p.Id Then
                strWindowTitle = "Windows Explorer"
                Exit For
            End If
        Next
        'Because we can have books about Microsoft Access:
        If strWindowTitle.IndexOf("Kindle") > 0 Then
            strWindowTitle = "Kindle"
        End If
        Me.TextBoxApplicationCaption.Text = strWindowTitle

        Dim strFilter As String

        Dim query = From caption In Me.LaunchApplicationsDataSet.tblApplicationCaptions
                    Select caption
        strFilter = "type='global'"
        Dim strFilter_By_Description As String = ""
        Dim ShowCommands As Boolean

        For Each row In query

            If InStr(strWindowTitle, row.Caption_Contains) > 0 Then
                strFilter = row.Application_Name
                If Not row.Description_Filter = "n/a" Then
                    '
                    strFilter_By_Description = row.Description_Filter
                End If
                ShowCommands = row.Show_Commands
                Exit For
            End If

        Next
        If Not ShowCommands Then
            Me.WindowState = FormWindowState.Minimized
            Exit Sub
        Else
            Me.WindowState = FormWindowState.Normal
        End If
        If strFilter_By_Description.Length > 0 Then
            Me.detailsBindingSource.Filter = strFilter_By_Description
            Me.detailsBindingSource2.Filter = strFilter_By_Description
        Else
            Me.detailsBindingSource.Filter = ""
        End If

        If Not strFilter = Me.masterBindingSource.Filter Then

            Me.masterBindingSource.Filter = strFilter

            If detailsBindingSource.Position = -1 Then Exit Sub
            Dim drv = detailsBindingSource.Item(detailsBindingSource.Position)
            If Not IsDBNull(drv.Item(2)) Then
                FilterLists(drv.Item(2))
            End If

        End If
        Me.TextBoxFilterApplied.Text = Me.detailsBindingSource.Filter
        RandomSelectCommand()
        RefreshFormControls()
    End Sub

    Private Sub RandomSelectCommand()
        Me.DataGridViewCommand.ClearSelection()
        If Me.DataGridViewCommand.Rows.Count > 0 Then
            Dim randomValue = CInt(Math.Floor((Me.DataGridViewCommand.Rows.Count) * Rnd()))
            Me.DataGridViewCommand.CurrentCell = Me.DataGridViewCommand.Rows(randomValue).Cells(1)

        End If
    End Sub
    ' Return the window's title.
    Private Function GetWindowTitle(ByVal window_hwnd As Integer) As String
        ' See how long the window's title is.
        Dim length As Integer
        length = GetWindowTextLength(window_hwnd) + 1
        If length <= 1 Then
            ' There's no title. Use the hWnd.
            Return "<" & window_hwnd & ">"
        Else
            ' Get the title.
            Dim buf As String = Space$(length)
            length = GetWindowText(window_hwnd, buf, length)
            Return buf.Substring(0, length)
        End If
    End Function


    Private Sub TblApplicationCaptionsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblApplicationCaptionsBindingSource.EndEdit()
        Me.TblApplicationCaptionsTableAdapter.Update(Me.LaunchApplicationsDataSet.tblApplicationCaptions)

    End Sub


    Private Sub CheckBoxShowAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxShowAll.CheckedChanged
        If Me.CheckBoxShowAll.Checked Then
            Me.CommandBindingSource.DataSource = ds.Tables("Command")
            Me.CommandBindingSource.Sort = "name ASC"
            Me.DataGridViewCommandsShowAll.Visible = True
            Me.DataGridViewCommand.DataSource = CommandBindingSource
            Me.checkboxSynchronise.Checked = False
            Me.DataGridViewCommands.Visible = False
            Me.DataGridViewContents.Visible = False
            Me.TextBoxFilterApplications.Text = ""
            Me.TextBoxFilterApplications.Visible = False
        Else
            Me.DataGridViewCommand.DataSource = detailsBindingSource
            Me.DataGridViewCommandsShowAll.Visible = False
            Me.DataGridViewCommands.Visible = True
            Me.DataGridViewContents.Visible = False
            Me.TextBoxFilterApplications.Visible = True

        End If
        RandomSelectCommand()
        RefreshFormControls()

    End Sub

    Private Sub checkboxSynchronise_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkboxSynchronise.CheckStateChanged
        If Me.checkboxSynchronise.Checked Then
            Me.Timer1.Enabled = True
            Me.CheckBoxShowAll.Checked = False
        Else
            Me.Timer1.Enabled = False
            Me.masterBindingSource.Filter = ""
            RandomSelectCommand()
            RefreshFormControls()

        End If

    End Sub

    Private Sub ButtonLists_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLists.Click
        Me.TreeViewLists.Focus()
    End Sub

    Private Sub DataGridViewCommands_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'masterBindingSource.Position = Me.DataGridViewCommands.SelectedIndex

    End Sub


    Private Sub ButtonApplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonApplication.Click
        If Me.DataGridViewCommandsShowAll.Visible Then
            Me.DataGridViewCommandsShowAll.Focus()
        ElseIf Me.DataGridViewCommands.Visible Then
            Me.DataGridViewCommands.Focus()

        End If
    End Sub


    'Private Sub CheckboxShowLearned_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckboxShowLearned.CheckedChanged
    '    If Me.CheckboxShowLearned.Checked Then
    '        Me.detailsBindingSource.Filter = "group = 'Custom Learned'"
    '        Me.detailsBindingSource2.Filter = "group = 'Custom Learned'"
    '    Else
    '        Me.detailsBindingSource.Filter = "group='Custom'"
    '        Me.detailsBindingSource2.Filter = "group='Custom'"
    '    End If
    'End Sub

    Private Sub TextBoxFilterGroup_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFilterGroup.TextChanged
        BuildFilter()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        BuildFilter()
    End Sub

    Private Sub BuildFilter()
        Dim ex As Exception
        If True Then
            If Me.CheckBoxShowAll.Checked Then
                Me.CommandBindingSource.Filter = ""
                Try
                    If Me.txtSearch.Text.Length > 0 Then
                        Me.CommandBindingSource.Filter = "name Like '%" & Me.txtSearch.Text & "%' or description Like '%" & Me.txtSearch.Text & "%'"
                    End If
                    If Me.TextBoxFilterGroup.Text.Length > 0 Then
                        Me.CommandBindingSource.Filter = Me.CommandBindingSource.Filter & IIf(Me.CommandBindingSource.Filter.Length > 0, " And ", "") & "group Like '%" & Me.TextBoxFilterGroup.Text & "%'"
                    End If
                    If Me.TextBoxFilterApplications.Text.Length > 0 Then
                        Me.masterBindingSource.Filter = "description Like '%" & Me.TextBoxFilterApplications.Text & "%'"
                    Else
                        Me.masterBindingSource.Filter = ""
                    End If
                Catch ex
                    MessageBox.Show(ex.Message)
                End Try

                Me.TextBoxDescription.Text = Me.CommandBindingSource.Filter
            Else
                Try
                    detailsBindingSource.Filter = ""
                    If Me.txtSearch.Text.Length > 0 Then
                        Me.detailsBindingSource.Filter = "name Like '%" & Me.txtSearch.Text _
                        & "%' or description Like '%" & Me.txtSearch.Text & "%'"
                    Else
                        Me.detailsBindingSource.Filter = ""
                    End If
                    If Me.TextBoxFilterGroup.Text.Length > 0 Then
                        Me.detailsBindingSource.Filter = Me.detailsBindingSource.Filter & IIf(Me.detailsBindingSource.Filter.Length > 0, " And ", "") & "group Like '%" & Me.TextBoxFilterGroup.Text & "%'"
                    End If
                    If Me.TextBoxFilterApplications.Text.Length > 0 Then
                        Me.masterBindingSource.Filter = "description Like '%" & Me.TextBoxFilterApplications.Text & "%'"
                    Else
                        Me.masterBindingSource.Filter = ""
                    End If

                Catch ex
                    MessageBox.Show(ex.Message)
                End Try
            End If
            Me.TextBoxDescription.Text = Me.detailsBindingSource.Filter
        Else
            detailsBindingSource.Filter = ""
            Me.TextBoxDescription.Text = ""
        End If





    End Sub

    Private Sub ButtonCommands_Click_1(sender As Object, e As EventArgs) Handles ButtonCommands.Click
        Me.DataGridViewCommand.Focus()
    End Sub

    Private Sub TextBoxFilterApplications_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFilterApplications.TextChanged
        BuildFilter()
    End Sub

    Private Sub ApplicationCaptionsButton_Click(sender As Object, e As EventArgs) Handles ApplicationCaptionsButton.Click
        Dim form As New ApplicationCaptions()
        form.Show()
    End Sub

End Class


