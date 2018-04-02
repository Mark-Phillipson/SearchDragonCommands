<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClipboardSaver
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClipboardSaver))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Counter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClipboardValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClipboardmemoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateSavedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToKeepDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblClipboardSaverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaunchApplicationsDataSet = New LaunchApplications.LaunchApplicationsDataSet()
        Me.TblClipboardSaverTableAdapter = New LaunchApplications.LaunchApplicationsDataSetTableAdapters.tblClipboardSaverTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MinimiseWindowButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClipboardSaverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaunchApplicationsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.Counter, Me.ClipboardValueDataGridViewTextBoxColumn, Me.ClipboardmemoDataGridViewTextBoxColumn, Me.DateSavedDataGridViewTextBoxColumn, Me.ToKeepDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.TblClipboardSaverBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = "Null"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(349, 534)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        Me.IDDataGridViewTextBoxColumn.Width = 5
        '
        'Counter
        '
        Me.Counter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Counter.HeaderText = "#"
        Me.Counter.Name = "Counter"
        Me.Counter.Width = 25
        '
        'ClipboardValueDataGridViewTextBoxColumn
        '
        Me.ClipboardValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.ClipboardValueDataGridViewTextBoxColumn.DataPropertyName = "Clipboard_Value"
        Me.ClipboardValueDataGridViewTextBoxColumn.HeaderText = "Clipboard Value"
        Me.ClipboardValueDataGridViewTextBoxColumn.Name = "ClipboardValueDataGridViewTextBoxColumn"
        Me.ClipboardValueDataGridViewTextBoxColumn.Width = 5
        '
        'ClipboardmemoDataGridViewTextBoxColumn
        '
        Me.ClipboardmemoDataGridViewTextBoxColumn.DataPropertyName = "clipboard_memo"
        Me.ClipboardmemoDataGridViewTextBoxColumn.HeaderText = "clipboard_memo"
        Me.ClipboardmemoDataGridViewTextBoxColumn.Name = "ClipboardmemoDataGridViewTextBoxColumn"
        Me.ClipboardmemoDataGridViewTextBoxColumn.Visible = False
        Me.ClipboardmemoDataGridViewTextBoxColumn.Width = 5
        '
        'DateSavedDataGridViewTextBoxColumn
        '
        Me.DateSavedDataGridViewTextBoxColumn.DataPropertyName = "Date_Saved"
        Me.DateSavedDataGridViewTextBoxColumn.HeaderText = "Date_Saved"
        Me.DateSavedDataGridViewTextBoxColumn.Name = "DateSavedDataGridViewTextBoxColumn"
        Me.DateSavedDataGridViewTextBoxColumn.Width = 5
        '
        'ToKeepDataGridViewCheckBoxColumn
        '
        Me.ToKeepDataGridViewCheckBoxColumn.DataPropertyName = "To_Keep"
        Me.ToKeepDataGridViewCheckBoxColumn.HeaderText = "To_Keep"
        Me.ToKeepDataGridViewCheckBoxColumn.Name = "ToKeepDataGridViewCheckBoxColumn"
        Me.ToKeepDataGridViewCheckBoxColumn.Visible = False
        Me.ToKeepDataGridViewCheckBoxColumn.Width = 5
        '
        'TblClipboardSaverBindingSource
        '
        Me.TblClipboardSaverBindingSource.DataMember = "tblClipboardSaver"
        Me.TblClipboardSaverBindingSource.DataSource = Me.LaunchApplicationsDataSet
        '
        'LaunchApplicationsDataSet
        '
        Me.LaunchApplicationsDataSet.DataSetName = "LaunchApplicationsDataSet"
        Me.LaunchApplicationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblClipboardSaverTableAdapter
        '
        Me.TblClipboardSaverTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'MinimiseWindowButton
        '
        Me.MinimiseWindowButton.AutoSize = True
        Me.MinimiseWindowButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MinimiseWindowButton.BackColor = System.Drawing.Color.Black
        Me.MinimiseWindowButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MinimiseWindowButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimiseWindowButton.ForeColor = System.Drawing.Color.Red
        Me.MinimiseWindowButton.Location = New System.Drawing.Point(0, 506)
        Me.MinimiseWindowButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimiseWindowButton.Name = "MinimiseWindowButton"
        Me.MinimiseWindowButton.Size = New System.Drawing.Size(349, 28)
        Me.MinimiseWindowButton.TabIndex = 2
        Me.MinimiseWindowButton.Text = "Minimise Clipboard Saver"
        Me.MinimiseWindowButton.UseVisualStyleBackColor = False
        '
        'ClipboardSaver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(349, 534)
        Me.Controls.Add(Me.MinimiseWindowButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ClipboardSaver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Clipboard Saver"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.DeepSkyBlue
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClipboardSaverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaunchApplicationsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LaunchApplicationsDataSet As LaunchApplications.LaunchApplicationsDataSet
    Friend WithEvents TblClipboardSaverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblClipboardSaverTableAdapter As LaunchApplications.LaunchApplicationsDataSetTableAdapters.tblClipboardSaverTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MinimiseWindowButton As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Counter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClipboardValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClipboardmemoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSavedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToKeepDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
