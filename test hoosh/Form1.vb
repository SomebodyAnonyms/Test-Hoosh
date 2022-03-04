
Imports System.ComponentModel

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text > "" Then
            Form2.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength = 1 Then TextBox2.Enabled = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.TextLength = 1 Then
            ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex Then
            Button1.Text = "شروع"
            Button1.ForeColor = Color.Green
        End If
    End Sub

    Private Sub But_open_setting_Click(sender As Object, e As EventArgs) Handles But_open_setting.Click
        But_change_color.Visible = True
        But_change_font.Visible = True
        But_open_setting.Visible = False
        But_close_setting.Visible = True
    End Sub

    Private Sub But_close_setting_Click(sender As Object, e As EventArgs) Handles But_close_setting.Click
        But_close_setting.Visible = False
        But_open_setting.Visible = True
        But_change_color.Visible = False
        But_change_font.Visible = False
    End Sub

    Private Sub But_change_color_Click(sender As Object, e As EventArgs) Handles But_change_color.Click
        ColorDialog1.ShowDialog()
        Label6.Visible = True
        Label6.BackColor = ColorDialog1.Color
        Me.BackColor = ColorDialog1.Color
        Form2.BackColor = ColorDialog1.Color
        Form3.BackColor = ColorDialog1.Color
        Form4.BackColor = ColorDialog1.Color
        Form5.BackColor = ColorDialog1.Color
        Form6.BackColor = ColorDialog1.Color
        Form7.BackColor = ColorDialog1.Color
        Form8.BackColor = ColorDialog1.Color
        Form9.BackColor = ColorDialog1.Color
        Form10.BackColor = ColorDialog1.Color
        Form11.BackColor = ColorDialog1.Color
        Form12.BackColor = ColorDialog1.Color
    End Sub

    Private Sub But_change_font_Click(sender As Object, e As EventArgs) Handles But_change_font.Click
        FontDialog1.ShowDialog()
        Me.Font = FontDialog1.Font
        Form2.Font = FontDialog1.Font
        Form2.Font = FontDialog1.Font
        Form3.Font = FontDialog1.Font
        Form4.Font = FontDialog1.Font
        Form5.Font = FontDialog1.Font
        Form6.Font = FontDialog1.Font
        Form7.Font = FontDialog1.Font
        Form8.Font = FontDialog1.Font
        Form9.Font = FontDialog1.Font
        Form10.Font = FontDialog1.Font
        Form11.Font = FontDialog1.Font
        Form12.Font = FontDialog1.Font
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = True
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel2.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel3.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Visible = False
        Button2.Enabled = True
    End Sub

    Private Sub But_change_color_MouseHover(sender As Object, e As EventArgs) Handles But_change_color.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub But_change_font_MouseHover(sender As Object, e As EventArgs) Handles But_change_font.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub But_close_setting_MouseHover(sender As Object, e As EventArgs) Handles But_close_setting.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub But_open_setting_MouseHover(sender As Object, e As EventArgs) Handles But_open_setting.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Button7_MouseHover(sender As Object, e As EventArgs) Handles Button7.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer_finall_1.Enabled = True
        Me.NatigeTableAdapter.Fill(Me.DatabaseDataSet.natige)

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
     Application.Exit()
    End Sub

    Private Sub NatigeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.NatigeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button_result.Click
        search.Show()
    End Sub

    Private Sub Timer_finall_1_Tick(sender As Object, e As EventArgs) Handles Timer_finall_1.Tick
        Button_result.ForeColor = Color.Red
        Timer_finall_1.Enabled = False
        Timer_finall_2.Enabled = True
    End Sub

    Private Sub Timer_finall_2_Tick(sender As Object, e As EventArgs) Handles Timer_finall_2.Tick
        Button_result.ForeColor = Color.Blue
        Timer_finall_2.Enabled = False
        Timer_finall_3.Enabled = True
    End Sub

    Private Sub Timer_finall_3_Tick(sender As Object, e As EventArgs) Handles Timer_finall_3.Tick
        Button_result.ForeColor = Color.Green
        Timer_finall_3.Enabled = False
        Timer_finall_1.Enabled = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form13.Show()
    End Sub
End Class
