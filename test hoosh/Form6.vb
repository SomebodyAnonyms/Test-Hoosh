Imports System.ComponentModel

Public Class Form6

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength = 1 Then Button1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label9.Text = Label9.Text - 1
        If Label9.Text = "0" Then
            Timer1.Stop()
            Button1.Enabled = False
            Label8.Visible = True
            Timer2.Enabled = True
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Me.Hide()
        Form7.Show()
        Timer2.Enabled = False

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label_number.Visible = True
        Label_number.Text = Label_number.Text - 1
        But_stop_page.Visible = True
        If Label_number.Text = "0" Then
            Timer3.Stop()
            Me.Hide()
            Form7.Show()
            Timer3.Enabled = False
        End If

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer_off_Tick(sender As Object, e As EventArgs) Handles Timer_off.Tick
        Label6.Visible = False
        Timer_on.Enabled = True
        Timer_off.Enabled = False
    End Sub

    Private Sub Timer_on_Tick(sender As Object, e As EventArgs) Handles Timer_on.Tick
        Label6.Visible = True
        Timer_off.Enabled = True
        Timer_on.Enabled = False
    End Sub

    Private Sub But_next_page_Click_1(sender As Object, e As EventArgs) Handles But_next_page.Click
        Timer3.Start()
        But_stop_page.Visible = True
        But_next_page.Visible = False
    End Sub

    Private Sub But_stop_page_Click_1(sender As Object, e As EventArgs) Handles But_stop_page.Click
        Timer3.Stop()
        But_next_page.Visible = True
        But_stop_page.Visible = False
    End Sub

    Private Sub Button_back_to_home_Click(sender As Object, e As EventArgs) Handles Button_back_to_home.Click
        Me.Close()
        Form5.Close()
        Form4.Close()
        Form3.Close()
        Form2.Close()
        Form1.Show()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.ComboBox1.Text = ""
        Form1.Button1.Text = "لطفا اطلاعات خود را وارد کنید"
        Form1.Button1.ForeColor = Color.Red
        Form1.TextBox2.Enabled = False
        Form1.ComboBox1.Enabled = False
    End Sub

    Private Sub But_next_page_MouseHover(sender As Object, e As EventArgs) Handles But_next_page.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub But_stop_page_MouseHover(sender As Object, e As EventArgs) Handles But_stop_page.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Button_back_to_home_MouseHover(sender As Object, e As EventArgs) Handles Button_back_to_home.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs)
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "9" Then
            TextBox1.ForeColor = Color.Green
            TextBox1.BackColor = Color.GreenYellow
            Label4.Visible = True
            TextBox1.Enabled = False
            Button1.Enabled = False
        Else
            TextBox1.ForeColor = Color.Red
            Label5.Visible = True
            Button1.Enabled = False
            TextBox1.Enabled = False
            Label6.Visible = True
            Timer_off.Enabled = True
        End If

        If Label4.Visible = True Then
            My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171671__leszek-szary__success-1.wav")
        Else
            My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\362205__taranp__horn-fail-wahwah-2.wav")
        End If

        Timer1.Stop()
        Timer3.Enabled = True
    End Sub

    Private Sub Form6_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class