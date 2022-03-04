<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_number = New System.Windows.Forms.Label()
        Me.But_next_page = New System.Windows.Forms.Button()
        Me.But_stop_page = New System.Windows.Forms.Button()
        Me.Button_back_to_home = New System.Windows.Forms.Button()
        Me.Timer_off = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_on = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("B Roya", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(846, 117)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "اگر دکتر به شما 3 قرص بدهد و بگوید هر نیم ساعت یک قرص بخورید چقدر طول میکشد تا تم" & _
    "ام قرص ها خورده شود؟"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("B Roya", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gold
        Me.Button4.Location = New System.Drawing.Point(261, 219)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(183, 61)
        Me.Button4.TabIndex = 13
        Me.Button4.TabStop = False
        Me.Button4.Text = "1ساعت"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("B Roya", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Gold
        Me.Button3.Location = New System.Drawing.Point(444, 219)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 61)
        Me.Button3.TabIndex = 12
        Me.Button3.TabStop = False
        Me.Button3.Text = "0/5ساعت"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("B Roya", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gold
        Me.Button2.Location = New System.Drawing.Point(261, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 61)
        Me.Button2.TabIndex = 11
        Me.Button2.TabStop = False
        Me.Button2.Text = "1/5ساعت"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("B Roya", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(444, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 61)
        Me.Button1.TabIndex = 10
        Me.Button1.TabStop = False
        Me.Button1.Text = " 2ساعت"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(0, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(884, 46)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "برای مثال شما یک قرص را در ساعت 1 و دیگری را در ساعت 1/5 و بعدی را در ساعت 2 میخو" & _
    "رید"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("B Roya", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(326, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 48)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "زمان شما به پایان رسید"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Snap ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 31)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "29"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Label_number
        '
        Me.Label_number.AutoSize = True
        Me.Label_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label_number.Location = New System.Drawing.Point(156, 166)
        Me.Label_number.Name = "Label_number"
        Me.Label_number.Size = New System.Drawing.Size(98, 108)
        Me.Label_number.TabIndex = 18
        Me.Label_number.Text = "6"
        Me.Label_number.Visible = False
        '
        'But_next_page
        '
        Me.But_next_page.BackColor = System.Drawing.Color.White
        Me.But_next_page.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.But_next_page.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.But_next_page.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon
        Me.But_next_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.But_next_page.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.But_next_page.Location = New System.Drawing.Point(-1, 154)
        Me.But_next_page.Name = "But_next_page"
        Me.But_next_page.Size = New System.Drawing.Size(150, 127)
        Me.But_next_page.TabIndex = 24
        Me.But_next_page.Text = "◀"
        Me.ToolTip1.SetToolTip(Me.But_next_page, "ادامه تایمر")
        Me.But_next_page.UseVisualStyleBackColor = False
        Me.But_next_page.Visible = False
        '
        'But_stop_page
        '
        Me.But_stop_page.BackColor = System.Drawing.Color.White
        Me.But_stop_page.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.But_stop_page.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.But_stop_page.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon
        Me.But_stop_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.But_stop_page.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.But_stop_page.Location = New System.Drawing.Point(0, 154)
        Me.But_stop_page.Name = "But_stop_page"
        Me.But_stop_page.Size = New System.Drawing.Size(150, 127)
        Me.But_stop_page.TabIndex = 23
        Me.But_stop_page.Text = "⏸"
        Me.ToolTip1.SetToolTip(Me.But_stop_page, "نگه داشتن تایمر")
        Me.But_stop_page.UseVisualStyleBackColor = False
        Me.But_stop_page.Visible = False
        '
        'Button_back_to_home
        '
        Me.Button_back_to_home.AutoSize = True
        Me.Button_back_to_home.BackColor = System.Drawing.Color.White
        Me.Button_back_to_home.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_back_to_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque
        Me.Button_back_to_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque
        Me.Button_back_to_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_back_to_home.Font = New System.Drawing.Font("B Roya", 20.25!)
        Me.Button_back_to_home.ForeColor = System.Drawing.Color.Black
        Me.Button_back_to_home.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_back_to_home.Location = New System.Drawing.Point(827, 336)
        Me.Button_back_to_home.Name = "Button_back_to_home"
        Me.Button_back_to_home.Size = New System.Drawing.Size(75, 56)
        Me.Button_back_to_home.TabIndex = 26
        Me.Button_back_to_home.TabStop = False
        Me.Button_back_to_home.Text = "🈴"
        Me.ToolTip1.SetToolTip(Me.Button_back_to_home, "بازگشت به خانه")
        Me.Button_back_to_home.UseVisualStyleBackColor = False
        '
        'Timer_off
        '
        Me.Timer_off.Interval = 300
        '
        'Timer_on
        '
        Me.Timer_on.Interval = 300
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 200
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(896, 386)
        Me.Controls.Add(Me.Button_back_to_home)
        Me.Controls.Add(Me.But_next_page)
        Me.Controls.Add(Me.But_stop_page)
        Me.Controls.Add(Me.Label_number)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تست هوش"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label_number As System.Windows.Forms.Label
    Friend WithEvents But_next_page As System.Windows.Forms.Button
    Friend WithEvents But_stop_page As System.Windows.Forms.Button
    Friend WithEvents Button_back_to_home As System.Windows.Forms.Button
    Friend WithEvents Timer_off As System.Windows.Forms.Timer
    Friend WithEvents Timer_on As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As ToolTip
End Class
