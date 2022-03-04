<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.But_close_setting = New System.Windows.Forms.Button()
        Me.But_open_setting = New System.Windows.Forms.Button()
        Me.But_change_font = New System.Windows.Forms.Button()
        Me.But_change_color = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NatigeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New WindowsApplication1.databaseDataSet()
        Me.NatigeTableAdapter = New WindowsApplication1.databaseDataSetTableAdapters.natigeTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.databaseDataSetTableAdapters.TableAdapterManager()
        Me.MediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button_result = New System.Windows.Forms.Button()
        Me.Timer_finall_1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_finall_2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_finall_3 = New System.Windows.Forms.Timer(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.NatigeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Name = "Label1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Name = "TextBox2"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Name = "Label5"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1"), resources.GetString("ComboBox1.Items2")})
        Me.ComboBox1.Name = "ComboBox1"
        '
        'FontDialog1
        '
        Me.FontDialog1.Font = New System.Drawing.Font("B Nazanin", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FontDialog1.ScriptsOnly = True
        Me.FontDialog1.ShowApply = True
        Me.FontDialog1.ShowEffects = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'But_close_setting
        '
        resources.ApplyResources(Me.But_close_setting, "But_close_setting")
        Me.But_close_setting.BackColor = System.Drawing.Color.White
        Me.But_close_setting.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.But_close_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque
        Me.But_close_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque
        Me.But_close_setting.ForeColor = System.Drawing.Color.Black
        Me.But_close_setting.Name = "But_close_setting"
        Me.ToolTip.SetToolTip(Me.But_close_setting, resources.GetString("But_close_setting.ToolTip"))
        Me.But_close_setting.UseVisualStyleBackColor = False
        '
        'But_open_setting
        '
        resources.ApplyResources(Me.But_open_setting, "But_open_setting")
        Me.But_open_setting.BackColor = System.Drawing.Color.White
        Me.But_open_setting.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.But_open_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque
        Me.But_open_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque
        Me.But_open_setting.ForeColor = System.Drawing.Color.Black
        Me.But_open_setting.Name = "But_open_setting"
        Me.But_open_setting.TabStop = False
        Me.ToolTip.SetToolTip(Me.But_open_setting, resources.GetString("But_open_setting.ToolTip"))
        Me.But_open_setting.UseVisualStyleBackColor = False
        '
        'But_change_font
        '
        resources.ApplyResources(Me.But_change_font, "But_change_font")
        Me.But_change_font.BackColor = System.Drawing.Color.White
        Me.But_change_font.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.But_change_font.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque
        Me.But_change_font.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque
        Me.But_change_font.ForeColor = System.Drawing.Color.Black
        Me.But_change_font.Name = "But_change_font"
        Me.ToolTip.SetToolTip(Me.But_change_font, resources.GetString("But_change_font.ToolTip"))
        Me.But_change_font.UseVisualStyleBackColor = False
        '
        'But_change_color
        '
        resources.ApplyResources(Me.But_change_color, "But_change_color")
        Me.But_change_color.BackColor = System.Drawing.Color.White
        Me.But_change_color.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.But_change_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque
        Me.But_change_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque
        Me.But_change_color.ForeColor = System.Drawing.Color.Black
        Me.But_change_color.Name = "But_change_color"
        Me.ToolTip.SetToolTip(Me.But_change_color, resources.GetString("But_change_color.ToolTip"))
        Me.But_change_color.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.TextBox3, "TextBox3")
        Me.TextBox3.Name = "TextBox3"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Name = "Button2"
        Me.ToolTip.SetToolTip(Me.Button2, resources.GetString("Button2.ToolTip"))
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Button7
        '
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.BackColor = System.Drawing.Color.Bisque
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Bisque
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Name = "Button7"
        Me.Button7.TabStop = False
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.BackColor = System.Drawing.Color.Bisque
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Bisque
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Name = "Button4"
        Me.Button4.TabStop = False
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.BackColor = System.Drawing.Color.Bisque
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Bisque
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Name = "Button3"
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.BackColor = System.Drawing.Color.Bisque
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Bisque
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Name = "Button5"
        Me.Button5.TabStop = False
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Bisque
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.BackColor = System.Drawing.Color.Bisque
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Bisque
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Name = "Button6"
        Me.Button6.TabStop = False
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 200
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.ShowAlways = True
        '
        'NatigeBindingSource
        '
        Me.NatigeBindingSource.DataMember = "natige"
        Me.NatigeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'MediaPlayer1
        '
        resources.ApplyResources(Me.MediaPlayer1, "MediaPlayer1")
        Me.MediaPlayer1.Name = "MediaPlayer1"
        Me.MediaPlayer1.OcxState = CType(resources.GetObject("MediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'Button_result
        '
        resources.ApplyResources(Me.Button_result, "Button_result")
        Me.Button_result.BackColor = System.Drawing.Color.White
        Me.Button_result.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_result.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque
        Me.Button_result.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque
        Me.Button_result.ForeColor = System.Drawing.Color.Black
        Me.Button_result.Name = "Button_result"
        Me.Button_result.TabStop = False
        Me.Button_result.UseVisualStyleBackColor = False
        '
        'Timer_finall_1
        '
        Me.Timer_finall_1.Interval = 300
        '
        'Timer_finall_2
        '
        Me.Timer_finall_2.Interval = 300
        '
        'Timer_finall_3
        '
        Me.Timer_finall_3.Interval = 300
        '
        'Button8
        '
        resources.ApplyResources(Me.Button8, "Button8")
        Me.Button8.Name = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Untitled
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button_result)
        Me.Controls.Add(Me.MediaPlayer1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.But_close_setting)
        Me.Controls.Add(Me.But_open_setting)
        Me.Controls.Add(Me.But_change_font)
        Me.Controls.Add(Me.But_change_color)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NatigeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents But_close_setting As System.Windows.Forms.Button
    Friend WithEvents But_open_setting As System.Windows.Forms.Button
    Friend WithEvents But_change_font As System.Windows.Forms.Button
    Friend WithEvents But_change_color As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents DatabaseDataSet As WindowsApplication1.databaseDataSet
    Friend WithEvents NatigeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NatigeTableAdapter As WindowsApplication1.databaseDataSetTableAdapters.natigeTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button_result As System.Windows.Forms.Button
    Friend WithEvents Timer_finall_1 As System.Windows.Forms.Timer
    Friend WithEvents Timer_finall_2 As System.Windows.Forms.Timer
    Friend WithEvents Timer_finall_3 As System.Windows.Forms.Timer
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
