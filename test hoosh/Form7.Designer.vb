<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_number = New System.Windows.Forms.Label()
        Me.But_next_page = New System.Windows.Forms.Button()
        Me.But_stop_page = New System.Windows.Forms.Button()
        Me.Button_back_to_home = New System.Windows.Forms.Button()
        Me.Timer_off = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_on = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("B Roya", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(898, 109)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "اگر تنها یک کبریت داشته باشید و وارد یک اتاق سرد و تاریک شوید که در آن یک بخاری ن" & _
    "فتی و یک چراغ نفتی و یک شمع باشد اول کدام یک را روشن میکنید؟"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("B Roya", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(364, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(537, 49)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "کبریت اول باید روشن شود تا بتوانیم آن ها را روشن کنیم"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("B Roya", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(411, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 25)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "جواب   غلط"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("B Roya", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(409, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "جواب صحیح"
        Me.Label4.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(405, 224)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 20)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("B Roya", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(492, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 25)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "توجه : فقط نام وسیله را در پاسخ بنویسید"
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("B Roya", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(335, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(233, 48)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "زمان شما به پایان رسید"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Snap ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(420, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 31)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "59"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Label_number
        '
        Me.Label_number.AutoSize = True
        Me.Label_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label_number.Location = New System.Drawing.Point(156, 191)
        Me.Label_number.Name = "Label_number"
        Me.Label_number.Size = New System.Drawing.Size(98, 108)
        Me.Label_number.TabIndex = 36
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
        Me.But_next_page.Location = New System.Drawing.Point(-1, 182)
        Me.But_next_page.Name = "But_next_page"
        Me.But_next_page.Size = New System.Drawing.Size(150, 127)
        Me.But_next_page.TabIndex = 38
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
        Me.But_stop_page.Location = New System.Drawing.Point(0, 182)
        Me.But_stop_page.Name = "But_stop_page"
        Me.But_stop_page.Size = New System.Drawing.Size(150, 127)
        Me.But_stop_page.TabIndex = 37
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
        Me.Button_back_to_home.Location = New System.Drawing.Point(833, 336)
        Me.Button_back_to_home.Name = "Button_back_to_home"
        Me.Button_back_to_home.Size = New System.Drawing.Size(69, 57)
        Me.Button_back_to_home.TabIndex = 39
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Roya", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Label3.Location = New System.Drawing.Point(339, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 88)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = " پاسخ خود را بنویسید " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "👇"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("B Roya", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(396, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 32)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "چک کردن پاسخ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 200
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(896, 386)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_back_to_home)
        Me.Controls.Add(Me.But_next_page)
        Me.Controls.Add(Me.But_stop_page)
        Me.Controls.Add(Me.Label_number)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تست هوش"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label_number As System.Windows.Forms.Label
    Friend WithEvents But_next_page As Button
    Friend WithEvents But_stop_page As Button
    Friend WithEvents Button_back_to_home As Button
    Friend WithEvents Timer_off As Timer
    Friend WithEvents Timer_on As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
