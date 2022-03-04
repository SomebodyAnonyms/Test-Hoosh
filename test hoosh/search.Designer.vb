<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search
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
        Me.DatabaseDataSet = New WindowsApplication1.databaseDataSet()
        Me.NatigeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NatigeTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.natigeTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.databaseDataSetTableAdapters.TableAdapterManager()
        Me.NatigeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Radio_iq = New System.Windows.Forms.RadioButton()
        Me.Radio_gender = New System.Windows.Forms.RadioButton()
        Me.Radio_lastname = New System.Windows.Forms.RadioButton()
        Me.Radio_name = New System.Windows.Forms.RadioButton()
        Me.Radio_id = New System.Windows.Forms.RadioButton()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NatigeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NatigeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NatigeBindingSource
        '
        Me.NatigeBindingSource.DataMember = "natige"
        Me.NatigeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'NatigeTableAdapter
        '
        Me.NatigeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.natigeTableAdapter = Me.NatigeTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NatigeDataGridView
        '
        Me.NatigeDataGridView.AllowUserToAddRows = False
        Me.NatigeDataGridView.AllowUserToDeleteRows = False
        Me.NatigeDataGridView.AutoGenerateColumns = False
        Me.NatigeDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NatigeDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.NatigeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NatigeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1})
        Me.NatigeDataGridView.DataSource = Me.NatigeBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NatigeDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.NatigeDataGridView.Location = New System.Drawing.Point(51, 67)
        Me.NatigeDataGridView.Name = "NatigeDataGridView"
        Me.NatigeDataGridView.ReadOnly = True
        Me.NatigeDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NatigeDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.NatigeDataGridView.Size = New System.Drawing.Size(806, 307)
        Me.NatigeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "نام"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "last_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "نام خانوادگی"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "جنسیت"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "true"
        Me.DataGridViewTextBoxColumn5.HeaderText = "جوابهای درست"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "false"
        Me.DataGridViewTextBoxColumn6.HeaderText = "جوابهای غلط"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "iq_level"
        Me.DataGridViewTextBoxColumn7.HeaderText = "سطح هوش"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = " کد پیگیری"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Radio_iq)
        Me.GroupBox1.Controls.Add(Me.Radio_gender)
        Me.GroupBox1.Controls.Add(Me.Radio_lastname)
        Me.GroupBox1.Controls.Add(Me.Radio_name)
        Me.GroupBox1.Controls.Add(Me.Radio_id)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(806, 49)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جستجو بر اساس "
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBox1.Location = New System.Drawing.Point(111, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = ""
        Me.TextBox1.Location = New System.Drawing.Point(111, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(303, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("B Roya", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "جستجو"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Radio_iq
        '
        Me.Radio_iq.AutoSize = True
        Me.Radio_iq.Location = New System.Drawing.Point(442, 19)
        Me.Radio_iq.Name = "Radio_iq"
        Me.Radio_iq.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Radio_iq.Size = New System.Drawing.Size(74, 17)
        Me.Radio_iq.TabIndex = 4
        Me.Radio_iq.Text = "سطح هوش"
        Me.Radio_iq.UseVisualStyleBackColor = True
        '
        'Radio_gender
        '
        Me.Radio_gender.AutoSize = True
        Me.Radio_gender.Location = New System.Drawing.Point(522, 19)
        Me.Radio_gender.Name = "Radio_gender"
        Me.Radio_gender.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Radio_gender.Size = New System.Drawing.Size(57, 17)
        Me.Radio_gender.TabIndex = 3
        Me.Radio_gender.Text = "جنسیت"
        Me.Radio_gender.UseVisualStyleBackColor = True
        '
        'Radio_lastname
        '
        Me.Radio_lastname.AutoSize = True
        Me.Radio_lastname.Location = New System.Drawing.Point(585, 19)
        Me.Radio_lastname.Name = "Radio_lastname"
        Me.Radio_lastname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Radio_lastname.Size = New System.Drawing.Size(87, 17)
        Me.Radio_lastname.TabIndex = 2
        Me.Radio_lastname.Text = "نام خانوادگی"
        Me.Radio_lastname.UseVisualStyleBackColor = True
        '
        'Radio_name
        '
        Me.Radio_name.AutoSize = True
        Me.Radio_name.Location = New System.Drawing.Point(678, 19)
        Me.Radio_name.Name = "Radio_name"
        Me.Radio_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Radio_name.Size = New System.Drawing.Size(38, 17)
        Me.Radio_name.TabIndex = 1
        Me.Radio_name.Text = "نام"
        Me.Radio_name.UseVisualStyleBackColor = True
        '
        'Radio_id
        '
        Me.Radio_id.AutoSize = True
        Me.Radio_id.Checked = True
        Me.Radio_id.Location = New System.Drawing.Point(722, 19)
        Me.Radio_id.Name = "Radio_id"
        Me.Radio_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Radio_id.Size = New System.Drawing.Size(74, 17)
        Me.Radio_id.TabIndex = 0
        Me.Radio_id.TabStop = True
        Me.Radio_id.Text = "کد پیگیری"
        Me.Radio_id.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(896, 386)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NatigeDataGridView)
        Me.MaximizeBox = False
        Me.Name = "search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "search"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NatigeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NatigeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatabaseDataSet As WindowsApplication1.databaseDataSet
    Friend WithEvents NatigeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NatigeTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.natigeTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NatigeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Radio_iq As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_gender As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_lastname As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_name As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_id As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
