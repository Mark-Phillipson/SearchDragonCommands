'Imports System.Runtime.InteropServices

'Public Class frmLauncher

'    Inherits System.Windows.Forms.Form

'    Public WM_SYSCOMMAND As Integer = &H112
'    Public SC_MONITORPOWER As Integer = &HF170

'    <DllImport("user32.dll")> _
'    Private Shared Function SendMessage(hWnd As Integer, hMsg As Integer, wParam As Integer, lParam As Integer) As Integer
'    End Function


'#Region "Functions for shortcut key"
'    Private Const WM_HOTKEY As Integer = &H312
'    Private Const MOD_ALT As Integer = &H1
'    Private Const MOD_CONTROL As Integer = &H2
'    Private Const MOD_SHIFT As Integer = &H4
'    Private Declare Function RegisterHotKey Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal id As Integer, ByVal fsModifier As Integer, ByVal vk As Integer) As Integer
'    Private Declare Function UnregisterHotKey Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal id As Integer) As Boolean
'    Private Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
'#End Region
'    Dim frmDataForm As DataForm1
'    Dim frmMyCommands_Browser As MyCommands_Browser
'    Dim myformSendKeysCommands As SendKeysCommands
'    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
'    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
'    Friend WithEvents EditItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents ReloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents btnMenu6 As System.Windows.Forms.Button
'    Friend WithEvents btnMenu7 As System.Windows.Forms.Button
'    Friend WithEvents btnMenu8 As System.Windows.Forms.Button
'    Private mouse_offset As Point

'    Friend WithEvents MyCommandsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents btnMenu9 As System.Windows.Forms.Button
'    Friend WithEvents btnGo As System.Windows.Forms.Button
'    Friend WithEvents LabelProgram As System.Windows.Forms.Label
'    Friend WithEvents LaunchApplicationsDataSet As LaunchApplications.ads_offlineDataSet
'    Friend WithEvents TblCategoriesBindingSource1 As System.Windows.Forms.BindingSource
'    Friend WithEvents TblCategoriesTableAdapter1 As LaunchApplications.ads_offlineDataSetTableAdapters.tblCategoriesTableAdapter
'    Friend WithEvents TblLauncherBindingSource As System.Windows.Forms.BindingSource
'    Friend WithEvents TblLauncherTableAdapter As LaunchApplications.ads_offlineDataSetTableAdapters.tblLauncherTableAdapter
'    Friend WithEvents BuildSendKeysCommandsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents SetOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents ReadClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents IntelliSenseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents KillDragonToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents KillAccess1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents KillWindowsExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Friend WithEvents MonitorsOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
'    Private strCategories(11) As String


'#Region " Windows Form Designer generated code "

'    Public Sub New()
'        MyBase.New()

'        'This call is required by the Windows Form Designer.
'        InitializeComponent()

'        'Add any initialization after the InitializeComponent() call

'    End Sub

'    'Form overrides dispose to clean up the component list.
'    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
'        If disposing Then
'            If Not (components Is Nothing) Then
'                components.Dispose()
'            End If
'        End If
'        MyBase.Dispose(disposing)
'    End Sub

'    'Required by the Windows Form Designer
'    Private components As System.ComponentModel.IContainer

'    'NOTE: The following procedure is required by the Windows Form Designer
'    'It can be modified using the Windows Form Designer.  
'    'Do not modify it using the code editor.
'    Friend WithEvents btnMenu1 As System.Windows.Forms.Button
'    Friend WithEvents btnMenu2 As System.Windows.Forms.Button
'    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
'    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
'    Friend WithEvents DataView1 As System.Data.DataView
'    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
'    Friend WithEvents Label1 As System.Windows.Forms.Label
'    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
'    Friend WithEvents btnMenu3 As System.Windows.Forms.Button
'    Friend WithEvents btnMenu4 As System.Windows.Forms.Button
'    Friend WithEvents lblCommandline As System.Windows.Forms.Label
'    Friend WithEvents btnMenu5 As System.Windows.Forms.Button
'    Friend WithEvents Label2 As System.Windows.Forms.Label
'    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
'    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
'    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
'    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
'    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
'    Friend WithEvents lblTitle As System.Windows.Forms.Label
'    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
'        Me.components = New System.ComponentModel.Container()
'        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLauncher))
'        Me.btnMenu1 = New System.Windows.Forms.Button()
'        Me.btnMenu2 = New System.Windows.Forms.Button()
'        Me.btnMenu3 = New System.Windows.Forms.Button()
'        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
'        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
'        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
'        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
'        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
'        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
'        Me.ListBox1 = New System.Windows.Forms.ListBox()
'        Me.DataView1 = New System.Data.DataView()
'        Me.LaunchApplicationsDataSet = New LaunchApplications.ads_offlineDataSet()
'        Me.TblLauncherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
'        Me.btnMenu4 = New System.Windows.Forms.Button()
'        Me.Label1 = New System.Windows.Forms.Label()
'        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
'        Me.lblCommandline = New System.Windows.Forms.Label()
'        Me.Label2 = New System.Windows.Forms.Label()
'        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
'        Me.lblTitle = New System.Windows.Forms.Label()
'        Me.btnMenu5 = New System.Windows.Forms.Button()
'        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
'        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.EditItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.BuildSendKeysCommandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.SetOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.KillDragonToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
'        Me.KillWindowsExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.KillAccess1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
'        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.MyCommandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.ReadClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.MonitorsOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.IntelliSenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
'        Me.btnMenu6 = New System.Windows.Forms.Button()
'        Me.btnMenu7 = New System.Windows.Forms.Button()
'        Me.btnMenu8 = New System.Windows.Forms.Button()
'        Me.btnMenu9 = New System.Windows.Forms.Button()
'        Me.btnGo = New System.Windows.Forms.Button()
'        Me.LabelProgram = New System.Windows.Forms.Label()
'        Me.TblCategoriesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
'        Me.TblCategoriesTableAdapter1 = New LaunchApplications.ads_offlineDataSetTableAdapters.tblCategoriesTableAdapter()
'        Me.TblLauncherTableAdapter = New LaunchApplications.ads_offlineDataSetTableAdapters.tblLauncherTableAdapter()
'        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.LaunchApplicationsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.TblLauncherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.MenuStrip1.SuspendLayout()
'        CType(Me.TblCategoriesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        '
'        'btnMenu1
'        '
'        Me.btnMenu1.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.btnMenu1.BackColor = System.Drawing.Color.Transparent
'        Me.btnMenu1.BackgroundImage = Global.LaunchApplications.My.Resources.Resources.button_smallBlue_search
'        Me.btnMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.btnMenu1.FlatAppearance.BorderColor = System.Drawing.Color.White
'        Me.btnMenu1.FlatAppearance.BorderSize = 0
'        Me.btnMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.btnMenu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnMenu1.ForeColor = System.Drawing.SystemColors.ControlText
'        Me.btnMenu1.Location = New System.Drawing.Point(10, 117)
'        Me.btnMenu1.Name = "btnMenu1"
'        Me.btnMenu1.Size = New System.Drawing.Size(48, 32)
'        Me.btnMenu1.TabIndex = 3
'        Me.btnMenu1.Text = "1"
'        Me.btnMenu1.UseVisualStyleBackColor = False
'        '
'        'btnMenu2
'        '
'        Me.btnMenu2.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.btnMenu2.BackgroundImage = CType(resources.GetObject("btnMenu2.BackgroundImage"), System.Drawing.Image)
'        Me.btnMenu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.btnMenu2.FlatAppearance.BorderColor = System.Drawing.Color.White
'        Me.btnMenu2.FlatAppearance.BorderSize = 0
'        Me.btnMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.btnMenu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnMenu2.ForeColor = System.Drawing.SystemColors.ControlText
'        Me.btnMenu2.Location = New System.Drawing.Point(10, 161)
'        Me.btnMenu2.Name = "btnMenu2"
'        Me.btnMenu2.Size = New System.Drawing.Size(48, 32)
'        Me.btnMenu2.TabIndex = 4
'        Me.btnMenu2.Text = "2"
'        '
'        'btnMenu3
'        '
'        Me.btnMenu3.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.btnMenu3.BackgroundImage = CType(resources.GetObject("btnMenu3.BackgroundImage"), System.Drawing.Image)
'        Me.btnMenu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.btnMenu3.FlatAppearance.BorderColor = System.Drawing.Color.White
'        Me.btnMenu3.FlatAppearance.BorderSize = 0
'        Me.btnMenu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.btnMenu3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnMenu3.ForeColor = System.Drawing.SystemColors.ControlText
'        Me.btnMenu3.Location = New System.Drawing.Point(10, 205)
'        Me.btnMenu3.Name = "btnMenu3"
'        Me.btnMenu3.Size = New System.Drawing.Size(48, 32)
'        Me.btnMenu3.TabIndex = 5
'        Me.btnMenu3.Text = "3"
'        '
'        'OleDbConnection1
'        '
'        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Launch Applications\Data\Launch" & _
'    "Applications.accdb"""
'        '
'        'OleDbDataAdapter1
'        '
'        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
'        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
'        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
'        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblLauncher", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("CommandLine", "CommandLine"), New System.Data.Common.DataColumnMapping("Menu", "Menu"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Icon", "Icon")})})
'        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
'        '
'        'OleDbDeleteCommand1
'        '
'        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
'        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
'        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_CommandLine", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CommandLine", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_CommandLine", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CommandLine", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Menu", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Menu", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Menu", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Menu", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Name", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Icon", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Icon", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Icon", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Icon", System.Data.DataRowVersion.Original, Nothing)})
'        '
'        'OleDbInsertCommand1
'        '
'        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `tblLauncher` (`CommandLine`, `Menu`, `Name`, `Icon`) VALUES (?, ?, ?" & _
'    ", ?)"
'        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
'        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CommandLine", System.Data.OleDb.OleDbType.VarWChar, 0, "CommandLine"), New System.Data.OleDb.OleDbParameter("Menu", System.Data.OleDb.OleDbType.SmallInt, 0, "Menu"), New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 0, "Name"), New System.Data.OleDb.OleDbParameter("Icon", System.Data.OleDb.OleDbType.VarWChar, 0, "Icon")})
'        '
'        'OleDbSelectCommand1
'        '
'        Me.OleDbSelectCommand1.CommandText = "SELECT ID, CommandLine, Menu, Name, Icon FROM tblLauncher ORDER BY Name"
'        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
'        '
'        'OleDbUpdateCommand1
'        '
'        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
'        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
'        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CommandLine", System.Data.OleDb.OleDbType.VarWChar, 0, "CommandLine"), New System.Data.OleDb.OleDbParameter("Menu", System.Data.OleDb.OleDbType.SmallInt, 0, "Menu"), New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 0, "Name"), New System.Data.OleDb.OleDbParameter("Icon", System.Data.OleDb.OleDbType.VarWChar, 0, "Icon"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_CommandLine", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CommandLine", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_CommandLine", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CommandLine", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Menu", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Menu", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Menu", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Menu", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Name", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Icon", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Icon", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Icon", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Icon", System.Data.DataRowVersion.Original, Nothing)})
'        '
'        'ListBox1
'        '
'        Me.ListBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.ListBox1.BackColor = System.Drawing.Color.Black
'        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataView1, "CommandLine", True))
'        Me.ListBox1.DataSource = Me.DataView1
'        Me.ListBox1.DisplayMember = "Name"
'        Me.ListBox1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.ListBox1.ForeColor = System.Drawing.Color.White
'        Me.ListBox1.ItemHeight = 21
'        Me.ListBox1.Location = New System.Drawing.Point(66, 117)
'        Me.ListBox1.Name = "ListBox1"
'        Me.ListBox1.Size = New System.Drawing.Size(380, 382)
'        Me.ListBox1.TabIndex = 2
'        Me.ListBox1.ValueMember = "ID"
'        '
'        'DataView1
'        '
'        Me.DataView1.Table = Me.LaunchApplicationsDataSet.tblLauncher
'        '
'        'LaunchApplicationsDataSet
'        '
'        Me.LaunchApplicationsDataSet.DataSetName = "LaunchApplicationsDataSet"
'        Me.LaunchApplicationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'        '
'        'TblLauncherBindingSource
'        '
'        Me.TblLauncherBindingSource.DataMember = "tblLauncher"
'        Me.TblLauncherBindingSource.DataSource = Me.LaunchApplicationsDataSet
'        '
'        'btnMenu4
'        '
'        Me.btnMenu4.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.btnMenu4.BackgroundImage = CType(resources.GetObject("btnMenu4.BackgroundImage"), System.Drawing.Image)
'        Me.btnMenu4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.btnMenu4.FlatAppearance.BorderColor = System.Drawing.Color.White
'        Me.btnMenu4.FlatAppearance.BorderSize = 0
'        Me.btnMenu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.btnMenu4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnMenu4.ForeColor = System.Drawing.SystemColors.ControlText
'        Me.btnMenu4.Location = New System.Drawing.Point(10, 249)
'        Me.btnMenu4.Name = "btnMenu4"
'        Me.btnMenu4.Size = New System.Drawing.Size(48, 32)
'        Me.btnMenu4.TabIndex = 6
'        Me.btnMenu4.Text = "4"
'        '
'        'Label1
'        '
'        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.Label1.BackColor = System.Drawing.Color.Black
'        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.Label1.ForeColor = System.Drawing.Color.White
'        Me.Label1.Location = New System.Drawing.Point(10, 88)
'        Me.Label1.Name = "Label1"
'        Me.Label1.Size = New System.Drawing.Size(48, 16)
'        Me.Label1.TabIndex = 0
'        Me.Label1.Text = "Menu"
'        '
'        'lblCommandline
'        '
'        Me.lblCommandline.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.lblCommandline.ForeColor = System.Drawing.Color.Red
'        Me.lblCommandline.Location = New System.Drawing.Point(229, 53)
'        Me.lblCommandline.Name = "lblCommandline"
'        Me.lblCommandline.Size = New System.Drawing.Size(40, 8)
'        Me.lblCommandline.TabIndex = 7
'        Me.lblCommandline.Visible = False
'        '
'        'Label2
'        '
'        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.Label2.BackColor = System.Drawing.Color.Black
'        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.Label2.ForeColor = System.Drawing.Color.White
'        Me.Label2.Location = New System.Drawing.Point(61, 88)
'        Me.Label2.Name = "Label2"
'        Me.Label2.Size = New System.Drawing.Size(184, 16)
'        Me.Label2.TabIndex = 1
'        Me.Label2.Text = "Select an Item and press enter"
'        '
'        'PictureBox2
'        '
'        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.PictureBox2.Location = New System.Drawing.Point(312, 58)
'        Me.PictureBox2.Name = "PictureBox2"
'        Me.PictureBox2.Size = New System.Drawing.Size(48, 44)
'        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
'        Me.PictureBox2.TabIndex = 12
'        Me.PictureBox2.TabStop = False
'        '
'        'lblTitle
'        '
'        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.lblTitle.BackColor = System.Drawing.Color.Black
'        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lblTitle.ForeColor = System.Drawing.Color.White
'        Me.lblTitle.Location = New System.Drawing.Point(9, 45)
'        Me.lblTitle.Name = "lblTitle"
'        Me.lblTitle.Size = New System.Drawing.Size(297, 24)
'        Me.lblTitle.TabIndex = 14
'        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
'        '
'        'btnMenu5
'        '
'        Me.btnMenu5.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.btnMenu5.BackgroundImage = CType(resources.GetObject("btnMenu5.BackgroundImage"), System.Drawing.Image)
'        Me.btnMenu5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.btnMenu5.FlatAppearance.BorderColor = System.Drawing.Color.White
'        Me.btnMenu5.FlatAppearance.BorderSize = 0
'        Me.btnMenu5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.btnMenu5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnMenu5.ForeColor = System.Drawing.SystemColors.ControlText
'        Me.btnMenu5.Location = New System.Drawing.Point(10, 293)
'        Me.btnMenu5.Name = "btnMenu5"
'        Me.btnMenu5.Size = New System.Drawing.Size(48, 32)
'        Me.btnMenu5.TabIndex = 15
'        Me.btnMenu5.Text = "5"
'        '
'        'MenuStrip1
'        '
'        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CloseToolStripMenuItem, Me.HelpToolStripMenuItem, Me.MyCommandsToolStripMenuItem, Me.ReadClipboardToolStripMenuItem, Me.MonitorsOffToolStripMenuItem, Me.IntelliSenseToolStripMenuItem})
'        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
'        Me.MenuStrip1.Name = "MenuStrip1"
'        Me.MenuStrip1.Size = New System.Drawing.Size(461, 24)
'        Me.MenuStrip1.TabIndex = 18
'        Me.MenuStrip1.Text = "MenuStrip1"
'        '
'        'FileToolStripMenuItem
'        '
'        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditItemsToolStripMenuItem, Me.BuildSendKeysCommandsToolStripMenuItem, Me.SetOptionsToolStripMenuItem, Me.KillDragonToolStripMenuItem2, Me.KillWindowsExplorerToolStripMenuItem, Me.KillAccess1ToolStripMenuItem, Me.ReloadToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
'        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
'        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
'        Me.FileToolStripMenuItem.Text = "&File"
'        '
'        'EditItemsToolStripMenuItem
'        '
'        Me.EditItemsToolStripMenuItem.Name = "EditItemsToolStripMenuItem"
'        Me.EditItemsToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
'        Me.EditItemsToolStripMenuItem.Text = "Edit &Items"
'        '
'        'BuildSendKeysCommandsToolStripMenuItem
'        '
'        Me.BuildSendKeysCommandsToolStripMenuItem.Image = Global.LaunchApplications.My.Resources.Resources.Build
'        Me.BuildSendKeysCommandsToolStripMenuItem.Name = "BuildSendKeysCommandsToolStripMenuItem"
'        Me.BuildSendKeysCommandsToolStripMenuItem.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
'            Or System.Windows.Forms.Keys.Shift) _
'            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
'        Me.BuildSendKeysCommandsToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
'        Me.BuildSendKeysCommandsToolStripMenuItem.Text = "&Build Sendkeys"
'        '
'        'SetOptionsToolStripMenuItem
'        '
'        Me.SetOptionsToolStripMenuItem.Name = "SetOptionsToolStripMenuItem"
'        Me.SetOptionsToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
'        Me.SetOptionsToolStripMenuItem.Text = "Set Options"
'        '
'        'KillDragonToolStripMenuItem2
'        '
'        Me.KillDragonToolStripMenuItem2.Name = "KillDragonToolStripMenuItem2"
'        Me.KillDragonToolStripMenuItem2.Size = New System.Drawing.Size(249, 22)
'        Me.KillDragonToolStripMenuItem2.Text = "&Restart Dragon"
'        '
'        'KillWindowsExplorerToolStripMenuItem
'        '
'        Me.KillWindowsExplorerToolStripMenuItem.Name = "KillWindowsExplorerToolStripMenuItem"
'        Me.KillWindowsExplorerToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
'        Me.KillWindowsExplorerToolStripMenuItem.Text = "Kill Windows &Explorer"
'        '
'        'KillAccess1ToolStripMenuItem
'        '
'        Me.KillAccess1ToolStripMenuItem.Name = "KillAccess1ToolStripMenuItem"
'        Me.KillAccess1ToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
'        Me.KillAccess1ToolStripMenuItem.Text = "Kill Access &1"
'        '
'        'ReloadToolStripMenuItem
'        '
'        Me.ReloadToolStripMenuItem.Image = Global.LaunchApplications.My.Resources.Resources.button_smallBlue_search
'        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
'        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
'        Me.ReloadToolStripMenuItem.Text = "Reload"
'        '
'        'ToolStripSeparator1
'        '
'        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
'        Me.ToolStripSeparator1.Size = New System.Drawing.Size(246, 6)
'        '
'        'ExitToolStripMenuItem
'        '
'        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
'        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
'        Me.ExitToolStripMenuItem.Text = "E&xit"
'        '
'        'CloseToolStripMenuItem
'        '
'        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
'        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
'        Me.CloseToolStripMenuItem.Text = "&Close"
'        '
'        'HelpToolStripMenuItem
'        '
'        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
'        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
'        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
'        Me.HelpToolStripMenuItem.Text = "&Help"
'        '
'        'AboutToolStripMenuItem
'        '
'        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
'        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
'        Me.AboutToolStripMenuItem.Text = "&About"
'        '
'        'MyCommandsToolStripMenuItem
'        '
'        Me.MyCommandsToolStripMenuItem.Name = "MyCommandsToolStripMenuItem"
'        Me.MyCommandsToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
'        Me.MyCommandsToolStripMenuItem.Text = "MyCommands"
'        '
'        'ReadClipboardToolStripMenuItem
'        '
'        Me.ReadClipboardToolStripMenuItem.Name = "ReadClipboardToolStripMenuItem"
'        Me.ReadClipboardToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
'        Me.ReadClipboardToolStripMenuItem.Text = "Read Clipboard"
'        '
'        'MonitorsOffToolStripMenuItem
'        '
'        Me.MonitorsOffToolStripMenuItem.Name = "MonitorsOffToolStripMenuItem"
'        Me.MonitorsOffToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
'        Me.MonitorsOffToolStripMenuItem.Text = "Monitors Off"
'        '
'        'IntelliSenseToolStripMenuItem
'        '
'        Me.IntelliSenseToolStripMenuItem.Name = "IntelliSenseToolStripMenuItem"
'        Me.IntelliSenseToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
'        Me.IntelliSenseToolStripMenuItem.Text = "IntelliSense"
'        Me.IntelliSenseToolStripMenuItem.Visible = False
'        '
'        'btnMenu6
'        '
'        Me.btnMenu6.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.btnMenu6.BackgroundImage = CType(resources.GetObject("btnMenu6.BackgroundImage"), System.Drawing.Image)
'        Me.btnMenu6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.btnMenu6.FlatAppearance.BorderColor = System.Drawing.Color.White
'        Me.btnMenu6.FlatAppearance.BorderSize = 0
'        Me.btnMenu6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.btnMenu6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnMenu6.ForeColor = System.Drawing.SystemColors.ControlText
'        Me.btnMenu6.Location = New System.Drawing.Point(10, 337)
'        Me.btnMenu6.Name = "btnMenu6"
'        Me.btnMenu6.Size = New System.Drawing.Size(48, 32)
'        Me.btnMenu6.TabIndex = 21
'        Me.btnMenu6.Text = "6"
'        '
'        'btnMenu7
'        '
'        Me.btnMenu7.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.btnMenu7.BackgroundImage = CType(resources.GetObject("btnMenu7.BackgroundImage"), System.Drawing.Image)
'        Me.btnMenu7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.btnMenu7.FlatAppearance.BorderColor = System.Drawing.Color.White
'        Me.btnMenu7.FlatAppearance.BorderSize = 0
'        Me.btnMenu7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.btnMenu7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnMenu7.ForeColor = System.Drawing.SystemColors.ControlText
'        Me.btnMenu7.Location = New System.Drawing.Point(10, 381)
'        Me.btnMenu7.Name = "btnMenu7"
'        Me.btnMenu7.Size = New System.Drawing.Size(48, 32)
'        Me.btnMenu7.TabIndex = 22
'        Me.btnMenu7.Text = "7"
'        '
'        'btnMenu8
'        '
'        Me.btnMenu8.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.btnMenu8.BackgroundImage = CType(resources.GetObject("btnMenu8.BackgroundImage"), System.Drawing.Image)
'        Me.btnMenu8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.btnMenu8.FlatAppearance.BorderColor = System.Drawing.Color.White
'        Me.btnMenu8.FlatAppearance.BorderSize = 0
'        Me.btnMenu8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.btnMenu8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnMenu8.ForeColor = System.Drawing.SystemColors.ControlText
'        Me.btnMenu8.Location = New System.Drawing.Point(11, 425)
'        Me.btnMenu8.Name = "btnMenu8"
'        Me.btnMenu8.Size = New System.Drawing.Size(48, 32)
'        Me.btnMenu8.TabIndex = 23
'        Me.btnMenu8.Text = "8"
'        '
'        'btnMenu9
'        '
'        Me.btnMenu9.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.btnMenu9.BackgroundImage = CType(resources.GetObject("btnMenu9.BackgroundImage"), System.Drawing.Image)
'        Me.btnMenu9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.btnMenu9.FlatAppearance.BorderColor = System.Drawing.Color.White
'        Me.btnMenu9.FlatAppearance.BorderSize = 0
'        Me.btnMenu9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.btnMenu9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnMenu9.ForeColor = System.Drawing.SystemColors.ControlText
'        Me.btnMenu9.Location = New System.Drawing.Point(11, 469)
'        Me.btnMenu9.Name = "btnMenu9"
'        Me.btnMenu9.Size = New System.Drawing.Size(48, 32)
'        Me.btnMenu9.TabIndex = 24
'        Me.btnMenu9.Text = "9"
'        '
'        'btnGo
'        '
'        Me.btnGo.Anchor = System.Windows.Forms.AnchorStyles.Left
'        Me.btnGo.BackgroundImage = CType(resources.GetObject("btnGo.BackgroundImage"), System.Drawing.Image)
'        Me.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.White
'        Me.btnGo.FlatAppearance.BorderSize = 0
'        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnGo.ForeColor = System.Drawing.SystemColors.ControlText
'        Me.btnGo.Location = New System.Drawing.Point(398, 58)
'        Me.btnGo.Name = "btnGo"
'        Me.btnGo.Size = New System.Drawing.Size(48, 32)
'        Me.btnGo.TabIndex = 25
'        Me.btnGo.Text = "Go"
'        '
'        'LabelProgram
'        '
'        Me.LabelProgram.AutoSize = True
'        Me.LabelProgram.ForeColor = System.Drawing.Color.White
'        Me.LabelProgram.Location = New System.Drawing.Point(18, 514)
'        Me.LabelProgram.Name = "LabelProgram"
'        Me.LabelProgram.Size = New System.Drawing.Size(0, 13)
'        Me.LabelProgram.TabIndex = 26
'        '
'        'TblCategoriesBindingSource1
'        '
'        Me.TblCategoriesBindingSource1.DataMember = "tblCategories"
'        Me.TblCategoriesBindingSource1.DataSource = Me.LaunchApplicationsDataSet
'        '
'        'TblCategoriesTableAdapter1
'        '
'        Me.TblCategoriesTableAdapter1.ClearBeforeFill = True
'        '
'        'TblLauncherTableAdapter
'        '
'        Me.TblLauncherTableAdapter.ClearBeforeFill = True
'        '
'        'frmLauncher
'        '
'        Me.AccessibleDescription = "uild solution switch to launch"
'        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
'        Me.BackColor = System.Drawing.Color.Black
'        Me.ClientSize = New System.Drawing.Size(461, 523)
'        Me.ControlBox = False
'        Me.Controls.Add(Me.LabelProgram)
'        Me.Controls.Add(Me.btnGo)
'        Me.Controls.Add(Me.lblTitle)
'        Me.Controls.Add(Me.btnMenu9)
'        Me.Controls.Add(Me.btnMenu8)
'        Me.Controls.Add(Me.btnMenu7)
'        Me.Controls.Add(Me.btnMenu6)
'        Me.Controls.Add(Me.btnMenu4)
'        Me.Controls.Add(Me.btnMenu5)
'        Me.Controls.Add(Me.PictureBox2)
'        Me.Controls.Add(Me.Label2)
'        Me.Controls.Add(Me.lblCommandline)
'        Me.Controls.Add(Me.Label1)
'        Me.Controls.Add(Me.ListBox1)
'        Me.Controls.Add(Me.btnMenu3)
'        Me.Controls.Add(Me.btnMenu2)
'        Me.Controls.Add(Me.btnMenu1)
'        Me.Controls.Add(Me.MenuStrip1)
'        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
'        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
'        Me.MainMenuStrip = Me.MenuStrip1
'        Me.MaximizeBox = False
'        Me.MinimizeBox = False
'        Me.Name = "frmLauncher"
'        Me.Opacity = 0.0R
'        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
'        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
'        Me.Text = "Launcher"
'        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
'        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.LaunchApplicationsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.TblLauncherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.MenuStrip1.ResumeLayout(False)
'        Me.MenuStrip1.PerformLayout()
'        CType(Me.TblCategoriesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)
'        Me.PerformLayout()

'    End Sub

'#End Region

'    Private Sub frmLauncher_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
'        UnregisterHotKey(Me.Handle, 0)

'    End Sub




'    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


'        '        Me.TblCategoriesTableAdapter1.Fill(Me.Ads_offlineDataSet1.tblCategories)
'        'TODO: This line of code loads data into the 'DataSet11.tblCategories' table. You can move, or remove it, as needed.



'        'Set up shortcut key to switch to app (Ctrl+Shift+P)
'        'RegisterHotKey(Me.Handle, 0, MOD_CONTROL + MOD_SHIFT, Keys.P)
'        'RegisterHotKey(Me.Handle, 0, MOD_CONTROL + MOD_SHIFT, Keys.O)
'        Me.OleDbConnection1.ConnectionString = My.Settings.LaunchApplicationsConnectionString
'        Me.OleDbDataAdapter1.Fill(Me.LaunchApplicationsDataSet)
'        Me.ListBox1.Focus()
'        Me.DataView1.RowFilter = "Menu=1"
'        Me.lblCommandline.Text = Me.ListBox1.Tag & ""
'        If Len(Me.ListBox1.SelectedValue & "") > 0 Then
'            On Error Resume Next
'            Dim row = Me.ListBox1.SelectedItem
'            Me.PictureBox2.Image = Image.FromFile(row.row.itemarray(4))
'            Me.PictureBox2.Visible = True
'            On Error GoTo 0
'        Else
'            Me.PictureBox2.Visible = False
'        End If
'        Me.Refresh()
'        Me.ListBox1.Refresh()
'        ' fill array with category names
'        'Me.OleDbDataAdapter1.Fill(Me.DataSet11)
'        Me.TblCategoriesTableAdapter1.Fill(LaunchApplicationsDataSet.tblCategories)
'        'Dim dt As DataTable = Me.DataView2.Table
'        Dim dv As New DataView(Me.LaunchApplicationsDataSet.tblCategories)
'        Dim k As Integer = 0
'        For Each drv As DataRowView In dv
'            k = k + 1
'            strCategories(k) = drv(1).ToString
'        Next
'        Me.lblTitle.Text = strCategories(1)
'        HighlightCurrentButton(Me.btnMenu1)
'        frmMyCommands_Browser = New MyCommands_Browser

'        Dim myScreens() As Screen = Screen.AllScreens
'        '        If (myScreens.Length = 2) Then

'        frmMyCommands_Browser.Left = myScreens(0).Bounds.Width + 10
'        If Screen.AllScreens.Length > 1 Then
'            frmMyCommands_Browser.Height = myScreens(1).Bounds.Height
'        End If
'        '       End If

'        'frmMyCommands_Browser.WindowState = FormWindowState.Maximized
'        On Error GoTo 0
'        frmMyCommands_Browser.Show()


'    End Sub

'    Private Sub btnMenu1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu1.Click

'        HandleButtonClick("Menu=1", sender, 1)
'    End Sub
'    Private Sub HandleButtonClick(ByVal strFilter As String, ByVal sender As System.Object, ByVal intButtonNumber As Integer)
'        Me.DataView1.RowFilter = strFilter
'        Me.ListBox1.Focus()
'        If Len(Me.ListBox1.SelectedValue & "") > 0 Then
'            On Error Resume Next
'            Me.PictureBox2.Image = Image.FromFile(Me.ListBox1.SelectedValue)
'            Me.PictureBox2.Visible = True

'        Else
'            Me.PictureBox2.Visible = False
'        End If
'        Me.lblTitle.Text = strCategories(intButtonNumber)
'        HighlightCurrentButton(sender)
'        System.Media.SystemSounds.Beep.Play()

'    End Sub
'    Private Sub btnMenu2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu2.Click
'        HandleButtonClick("Menu=2", sender, 2)
'    End Sub


'    Private Sub btnMenu4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu4.Click
'        HandleButtonClick("Menu=4", sender, 4)
'    End Sub

'    Private Sub ListBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown

'        If e.KeyCode = Keys.Enter Then
'            LaunchApplication()

'        ElseIf e.KeyCode = Keys.Escape Then
'            End
'        ElseIf e.KeyCode = Keys.D1 Then
'            Me.btnMenu1.PerformClick()
'        ElseIf e.KeyCode = Keys.D2 Then
'            Me.btnMenu2.PerformClick()
'        ElseIf e.KeyCode = Keys.D3 Then
'            Me.btnMenu3.PerformClick()
'        ElseIf e.KeyCode = Keys.D4 Then
'            Me.btnMenu4.PerformClick()
'        ElseIf e.KeyCode = Keys.D5 Then
'            Me.btnMenu5.PerformClick()
'        ElseIf e.KeyCode = Keys.D6 Then
'            Me.btnMenu6.PerformClick()
'        ElseIf e.KeyCode = Keys.D7 Then
'            Me.btnMenu7.PerformClick()
'        ElseIf e.KeyCode = Keys.D8 Then
'            Me.btnMenu8.PerformClick()
'        ElseIf e.KeyCode = Keys.D9 Then
'            Me.btnMenu9.PerformClick()
'        End If


'    End Sub

'    Private Sub btnMenu3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu3.Click
'        HandleButtonClick("Menu=3", sender, 3)
'    End Sub

'    Private Sub btnMenu1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenu1.MouseHover
'        Me.ToolTip1.SetToolTip(Me.btnMenu1, strCategories(1))

'    End Sub

'    Private Sub btnMenu2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenu2.MouseHover
'        Me.ToolTip1.SetToolTip(Me.btnMenu2, strCategories(2))
'    End Sub

'    Private Sub btnMenu3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenu3.MouseHover
'        Me.ToolTip1.SetToolTip(Me.btnMenu3, strCategories(3))
'    End Sub

'    Private Sub btnMenu4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenu4.MouseHover
'        Me.ToolTip1.SetToolTip(Me.btnMenu4, strCategories(4))
'    End Sub

'    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
'        If Len(Me.ListBox1.SelectedValue & "") > 0 Then

'            On Error Resume Next

'            Me.LabelProgram.Text = Me.ListBox1.Tag
'            Me.LabelProgram.Width = 100
'            Me.PictureBox2.Image = Nothing

'            Dim row = Me.ListBox1.SelectedItem
'            Me.PictureBox2.Image = Image.FromFile(row.row.itemarray(4))
'            Me.PictureBox2.Visible = True

'        Else
'            Me.PictureBox2.Visible = False
'        End If


'    End Sub

'    Private Sub btnEditItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        frmDataForm = New DataForm1

'        frmDataForm.Show()
'        frmDataForm.TblLauncherBindingSource.Filter = "[Icon] = '" & Me.ListBox1.SelectedValue & "'"
'        'MsgBox(frmDataForm.TblLauncherBindingSource.Filter)

'    End Sub

'    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Me.LaunchApplicationsDataSet.Clear()
'        Me.OleDbDataAdapter1.Fill(Me.LaunchApplicationsDataSet)
'        Me.ListBox1.Focus()
'        Me.ListBox1.Refresh()
'        Me.lblCommandline.Text = Me.ListBox1.SelectedValue & ""
'    End Sub

'    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
'        Dim strCommandLine As String
'        strCommandLine = Me.ListBox1.Tag
'        If strCommandLine.Length = 0 Then Exit Sub
'        Select Case strCommandLine.Substring(Len(strCommandLine) - 4, 3)
'            Case "mdb", "mda", "mdw", "cdb"
'                strCommandLine = """C:\Program Files (x86)\Microsoft Office\OFFICE14\MSACCESS.EXE""  " _
'                & strCommandLine
'            Case "rtf", "doc", "dot"
'                strCommandLine = """C:\Program Files (x86)\Microsoft Office\OFFICE14\winword.EXE""  " _
'                & strCommandLine
'        End Select
'        Try

'            Shell(strCommandLine, AppWinStyle.MaximizedFocus, False, -1)
'            'End
'        Catch ex As Exception
'            MsgBox(ex.Message & vbCrLf & strCommandLine, MsgBoxStyle.Critical)
'        End Try




'    End Sub

'    Private Sub frmLauncher_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
'        mouse_offset = New Point(-e.X, -e.Y)

'    End Sub

'    Private Sub frmLauncher_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
'        'If e.Button = MouseButtons.Left Then
'        '    Dim mousePos As Point = Control.MousePosition
'        '    mousePos.Offset(mouse_offset.X, mouse_offset.Y)
'        '    Location = mousePos
'        'End If


'    End Sub

'    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        End
'    End Sub

'    Private Sub frmLauncher_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
'        'Dim img As Bitmap
'        'Dim reg As Region
'        'Dim col As Color = Color.Black
'        'img = Bitmap.FromFile("G:\Mercury Documents\Corel\Background.bmp")
'        'reg = GetRegion(img, col)
'        'Me.FormBorderStyle = FormBorderStyle.None
'        'Me.BackgroundImage = img
'        'Me.Region = reg
'        Me.Opacity = 100

'        'e.Graphics.FillRegion(New SolidBrush(Color.Red), reg)
'    End Sub
'    Private Function GetRegion(ByVal img As Bitmap, ByVal theColor As Color) As Region
'        Dim matchColor As Color
'        Dim CurrentColour As Color
'        matchColor = Color.FromArgb(theColor.R, theColor.G, theColor.B)
'        Dim rgn As New System.Drawing.Region
'        rgn.MakeEmpty()
'        Dim rc As New Rectangle(0, 0, 0, 0)
'        Dim inimage As Boolean = False
'        Dim y As Integer
'        Dim x As Integer
'        For y = 1 To (img.Height - 1) Step 1
'            For x = 1 To (img.Width - 1) Step 1
'                If Not inimage Then
'                    CurrentColour = img.GetPixel(x, y)
'                    CurrentColour = Color.FromArgb(CurrentColour.R, CurrentColour.G, CurrentColour.B)
'                    If Not (CurrentColour.R = matchColor.R And CurrentColour.G = matchColor.G And CurrentColour.B = matchColor.B) Then
'                        inimage = True
'                        rc.Y = y
'                        rc.X = x
'                        rc.Height = 1
'                        'MsgBox(CurrentColour.R & " " & CurrentColour.G & " " & CurrentColour.B)
'                        'Me.Label2.BackColor = CurrentColour
'                        'Me.Label1.BackColor = CurrentColour
'                    End If
'                Else
'                    CurrentColour = img.GetPixel(x, y)
'                    CurrentColour = Color.FromArgb(CurrentColour.R, CurrentColour.G, CurrentColour.B)
'                    If (CurrentColour.R = matchColor.R And CurrentColour.G = matchColor.G And CurrentColour.B = matchColor.B) Then
'                        inimage = False
'                        rc.Width = x - rc.X
'                        rgn.Union(rc)
'                    End If
'                End If
'            Next
'            If inimage Then
'                inimage = False
'                rc.Width = img.Width - rc.X
'                rgn.Union(rc)
'            End If
'        Next
'        Return rgn
'    End Function

'    Private Sub btnMenu5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu5.Click
'        HandleButtonClick("Menu=5", sender, 5)
'    End Sub

'    Private Sub btnMenu5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenu5.MouseHover
'        Me.ToolTip1.SetToolTip(Me.btnMenu5, strCategories(5))
'    End Sub



'    'Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
'    '    'Shortcut key for application (Ctrl+Shift+P)
'    '    If (m.Msg = WM_HOTKEY AndAlso m.WParam = CType(0, IntPtr)) Then
'    '        Dim currentProcess As Process = System.Diagnostics.Process.GetCurrentProcess
'    '        Dim s As String = currentProcess.ToString


'    '        Me.Visible = True
'    '        If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
'    '        SetForegroundWindow(Me.Handle)
'    '    End If
'    '    MyBase.WndProc(m)
'    'End Sub



'    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
'        AboutBox1.ShowDialog()
'    End Sub

'    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
'        End
'    End Sub

'    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
'        End
'    End Sub

'    Private Sub EditItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditItemsToolStripMenuItem.Click
'        frmDataForm = New DataForm1

'        frmDataForm.Show()
'        'frmDataForm.TblLauncherBindingSource.Filter = "[Icon] = '" & Me.ListBox1.SelectedValue & "'"
'        Dim row = Me.ListBox1.SelectedItem

'        frmDataForm.TblLauncherBindingSource.Filter = "[Name] = '" & row.row.itemarray(1) & "'"

'    End Sub

'    Private Sub ReloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem.Click
'        Me.LaunchApplicationsDataSet.Clear()
'        Me.OleDbDataAdapter1.Fill(Me.LaunchApplicationsDataSet)
'        Me.ListBox1.Focus()
'        Me.ListBox1.Refresh()
'        Me.lblCommandline.Text = Me.ListBox1.SelectedValue & ""

'    End Sub

'    Private Sub Update1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim strText As String = "If you update your version of Data Translation it should work"
'        SendSomeKeysToApp(strText)
'    End Sub


'    Private Sub SendSomeKeysToApp(ByVal strText As String)
'        SendKeys.SendWait("%{TAB}")
'        SendKeys.SendWait("{ENTER}")
'        SendKeys.SendWait("")
'        SendKeys.SendWait("")
'        SendKeys.SendWait("")
'        SendKeys.SendWait("")
'        SendKeys.SendWait("")
'        For k As Integer = 0 To strText.Length - 1
'            SendKeys.SendWait(strText.Substring(k, 1))
'        Next
'        SendKeys.SendWait("{ENTER}")

'    End Sub

'    Private Sub Update2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim strText As String = "If you update your version of UCP it should work"
'        SendSomeKeysToApp(strText)

'    End Sub

'    Private Sub Update3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim strText As String = "If you update your version of STM Journals it should work"
'        SendSomeKeysToApp(strText)

'    End Sub

'    Private Sub Update4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim strText As String = "If you update your version of Stock System it should work"
'        SendSomeKeysToApp(strText)

'    End Sub

'    Private Sub ThanksMarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim strText As String = "Thanks Mark"
'        SendSomeKeysToApp(strText)

'    End Sub

'    Private Sub HomeEmailAddressToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim strText As String = "mphillipson@btopenworld.com"
'        SendSomeKeysToApp(strText)
'    End Sub

'    Private Sub BugFixedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim strText As String = "This was a bug in the system.  It has been fixed in the development version and will propagate on the next update." & vbCrLf & vbCrLf & "Thanks Mark"
'        SendSomeKeysToApp(strText)
'    End Sub

'    Private Sub CopyDHLGLOBALMAILToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Clipboard.Clear()
'        Clipboard.SetText("DHLGLOBALMAIL")
'        SendKeys.SendWait("%{TAB}")
'    End Sub

'    Private Sub CopyEmailAddressToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Clipboard.Clear()
'        Clipboard.SetText("m.phillipson@dhlglobalmail.co.uk")
'        SendKeys.SendWait("%{TAB}")
'    End Sub

'    Private Sub FeatureAddedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim strText As String = "This functionality has now been added to the system.  It is done in the development version and will propagate on the next update." & vbCrLf & vbCrLf & "Thanks Mark"
'        SendSomeKeysToApp(strText)

'    End Sub
'    Private Sub LaunchApplication()
'        Dim strCommandLine As String
'        strCommandLine = Me.ListBox1.Tag

'        If strCommandLine.Length = 0 Then Exit Sub
'        If strCommandLine.Length > 5 Then
'            Select Case strCommandLine.Substring(Len(strCommandLine) - 4, 3)
'                Case "mdb", "mda", "mdw", "adp", "cdb"
'                    strCommandLine = """C:\Program Files\Microsoft Office 15\root\office15\MSACCESS.EXE""  " _
'                    & strCommandLine
'                Case "rtf", "doc", "dot"
'                    strCommandLine = """C:\Program Files\Microsoft Office 15\root\office15\winword.EXE""  " _
'                    & strCommandLine
'            End Select
'        End If
'        If InStr(LCase(strCommandLine), "exe") = 0 Then
'            strCommandLine = "EXPLORER.EXE /e,/root," & strCommandLine & "\"

'            '         Examples()
'            '-----------------------------------------------------------------------
'            'Example 1: Explorer /select,C:\TestDir\TestProg.exe
'            '           Opens a window view with TestProg selected.

'            'Example 2: Explorer /e,/root,C:\TestDir\TestProg.exe
'            '           Opens Explorer with drive C expanded and TestProg selected.

'            'Example 3: Explorer /root,\\TestSvr\TestShare
'            '           Opens a window view of the specified share.

'            'Example 4: Explorer /root,\\TestSvr\TestShare,select,TestProg.exe
'            '           Opens a window view of the specified share with TestProg selected.

'            'strCommandLine = "EXPLORER.EXE /e,/select," & strCommandLine & "\"

'        End If
'        Try

'            Shell(strCommandLine, AppWinStyle.NormalFocus, False, -1)

'        Catch ex As Exception
'            MsgBox(ex.Message & vbCrLf & strCommandLine, MsgBoxStyle.Critical)
'        End Try


'    End Sub


'    Private Sub btnMenu6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenu6.Click
'        HandleButtonClick("Menu=6", sender, 6)
'    End Sub

'    Private Sub btnMenu7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenu7.Click
'        HandleButtonClick("Menu=7", sender, 7)
'    End Sub

'    Private Sub btnMenu8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenu8.Click
'        HandleButtonClick("Menu=8", sender, 8)
'    End Sub

'    Private Sub lblTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitle.Click

'    End Sub


'    Private Sub MyCommandsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyCommandsToolStripMenuItem.Click
'        frmMyCommands_Browser = New MyCommands_Browser

'        frmMyCommands_Browser.Show()

'    End Sub
'    Private Sub HighlightCurrentButton(ByRef btn As Button)
'        ' set all buttons to un highlighted
'        For K = 1 To 9
'            Me.Controls("btnMenu" & Trim(CStr(K))).ForeColor = Color.Gray
'        Next
'        btn.ForeColor = Color.Aqua
'    End Sub

'    Private Sub btnMenu9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu9.Click
'        HandleButtonClick("Menu=9", sender, 9)
'    End Sub

'    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
'        LaunchApplication()
'        ListBox1.Focus()

'    End Sub

'    Private Sub BuildSendKeysCommandsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildSendKeysCommandsToolStripMenuItem.Click
'        myformSendKeysCommands = New SendKeysCommands
'        myformSendKeysCommands.Show()
'    End Sub

'    Private Sub ApplicationCaptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim frm = New ApplicationCaptions

'        frm.Show()

'    End Sub

'    Private Sub SetOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetOptionsToolStripMenuItem.Click
'        Dim frm = New Options
'        frm.ShowDialog()
'    End Sub

'    Private Sub CustomIntelliSenseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        Dim form = New CustomIntelliSense
'        form.Show()
'    End Sub

'    Private Sub ReadClipboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReadClipboardToolStripMenuItem.Click
'        Dim form = New SpeakClipboard
'        form.Show()
'    End Sub

'    Private Sub IntelliSenseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntelliSenseToolStripMenuItem.Click
'        Dim form = New CustomIntelliSense
'        form.Show()

'    End Sub


'    Private Sub KillDragonToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillDragonToolStripMenuItem2.Click
'        ' loop through the running processes and add
'        'each to the list
'        Dim p As System.Diagnostics.Process
'        Dim stringTemporary As String = ""
'        For Each p In System.Diagnostics.Process.GetProcesses()
'            '            lstProcesses.Items.Add(p.ProcessName & " - " & p.Id.ToString())
'            'Freesr
'            stringTemporary = stringTemporary & p.ProcessName & " / "
'            If p.ProcessName = "natspeak" Or p.ProcessName = "PCByVoice SpeechStart" Or p.ProcessName = "CommandRobot" Then
'                On Error Resume Next
'                p.Kill()
'                'MessageBox.Show("Killed " & p.ProcessName)
'                On Error GoTo 0
'            End If

'        Next
'        'MessageBox.Show(stringTemporary)
'        Shell("C:\Program Files (x86)\Nuance\NaturallySpeaking12\Program\natspeak.exe", AppWinStyle.NormalFocus)
'        Shell("C:\Program Files (x86)\pcbyvoice\SpeechStart+\PCByVoice SpeechStart.exe", AppWinStyle.NormalFocus)
'    End Sub

'    Private Sub KillAccess1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillAccess1ToolStripMenuItem.Click
'        ' loop through the running processes and add
'        'each to the list
'        Dim integerCounter As Integer
'        Dim p As System.Diagnostics.Process
'        Dim stringTemporary As String = ""
'        For Each p In System.Diagnostics.Process.GetProcesses()
'            '            lstProcesses.Items.Add(p.ProcessName & " - " & p.Id.ToString())

'            stringTemporary = stringTemporary & p.ProcessName & " / "
'            If p.ProcessName = "MSACCESS" Then
'                On Error Resume Next
'                p.Kill()
'                integerCounter = integerCounter + 1

'                'MessageBox.Show("Killed " & p.ProcessName)
'                On Error GoTo 0
'            End If

'        Next
'        If integerCounter > 0 Then
'            MessageBox.Show("Killed Microsoft  Access processes: " & integerCounter)
'        End If

'    End Sub

'    Private Sub KillWindowsExplorerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KillWindowsExplorerToolStripMenuItem.Click
'        Dim integerCounter As Integer
'        Dim p As System.Diagnostics.Process
'        Dim stringTemporary As String = ""
'        For Each p In System.Diagnostics.Process.GetProcesses()
'            '            lstProcesses.Items.Add(p.ProcessName & " - " & p.Id.ToString())

'            stringTemporary = stringTemporary & p.ProcessName & " / "
'            If p.ProcessName = "explorer" Then
'                On Error Resume Next
'                p.Kill()
'                integerCounter = integerCounter + 1

'                'MessageBox.Show("Killed " & p.ProcessName)
'                On Error GoTo 0
'            End If

'        Next
'        If integerCounter > 0 Then
'            'MessageBox.Show("Killed Microsoft  Access processes: " & integerCounter)
'        End If

'    End Sub

'    Private Sub MonitorsOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitorsOffToolStripMenuItem.Click

'        Dim p As System.Diagnostics.Process
'        Dim stringTemporary As String = ""
'        For Each p In System.Diagnostics.Process.GetProcesses()
'            '            lstProcesses.Items.Add(p.ProcessName & " - " & p.Id.ToString())
'            'Freesr
'            stringTemporary = stringTemporary & p.ProcessName & " / "
'            If p.ProcessName = "PCByVoice SpeechStart" Or p.ProcessName = "CommandRobot" Then
'                On Error Resume Next
'                p.Kill()
'                'MessageBox.Show("Killed " & p.ProcessName)
'                On Error GoTo 0
'            End If

'        Next

'        Dim vcmd As New DNSTools.DgnVoiceCmd
'        Dim commandstring = "HeardWord ""microphone"", ""off"""
'        vcmd.Register("", 0)
'        vcmd.ExecuteScript(Script:=commandstring, ID:=0)
'        vcmd.UnRegister()

'        SendMessage(Me.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, 2)
'    End Sub
'End Class
