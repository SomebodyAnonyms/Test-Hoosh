Imports System.ComponentModel

Public Class Form11

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Green
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Visible = True
        Timer1.Stop()
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171671__leszek-szary__success-1.wav")
        Timer_finall_1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Red
        Button3.Enabled = False
        Button4.Enabled = False
        Button1.Enabled = False
        Label4.Visible = True
        Button5.Visible = True
        Timer1.Stop()
        Timer_off.Enabled = True
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\362205__taranp__horn-fail-wahwah-2.wav")
        Timer_finall_1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.BackColor = Color.Green
        Button3.BackColor = Color.Red
        Button2.Enabled = False
        Button4.Enabled = False
        Button1.Enabled = False
        Label4.Visible = True
        Button5.Visible = True
        Timer1.Stop()
        Timer_off.Enabled = True
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\362205__taranp__horn-fail-wahwah-2.wav")
        Timer_finall_1.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.BackColor = Color.Green
        Button4.BackColor = Color.Red
        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = False
        Label4.Visible = True
        Button5.Visible = True
        Timer1.Stop()
        Timer_off.Enabled = True
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\362205__taranp__horn-fail-wahwah-2.wav")
        Timer_finall_1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Label7.Text - 1
        If Label7.Text = "0" Then
            Timer1.Stop()
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Label6.Visible = True
            Button5.Visible = True
        End If

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form12.Show()
        Form1.NatigeTableAdapter.ADDInfo(Form1.TextBox1.Text, Form1.TextBox2.Text, Form1.ComboBox1.Text, Form12.TextBox1.Text, Form12.Label3.Text, Form12.Label2.Text)
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer_off_Tick(sender As Object, e As EventArgs) Handles Timer_off.Tick
        Label4.Visible = False
        Timer_on.Enabled = True
        Timer_off.Enabled = False
    End Sub

    Private Sub Timer_on_Tick(sender As Object, e As EventArgs) Handles Timer_on.Tick
        Label4.Visible = True
        Timer_off.Enabled = True
        Timer_on.Enabled = False
    End Sub

    Private Sub Button_back_to_home_Click(sender As Object, e As EventArgs) Handles Button_back_to_home.Click
        Me.Close()
        Form10.Close()
        Form9.Close()
        Form8.Close()
        Form7.Close()
        Form6.Close()
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

    Private Sub Button_back_to_home_MouseHover(sender As Object, e As EventArgs) Handles Button_back_to_home.MouseHover
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

    Private Sub Timer_finall_1_Tick(sender As Object, e As EventArgs) Handles Timer_finall_1.Tick
        Button5.BackColor = Color.Pink
        Timer_finall_1.Enabled = False
        Timer_finall_2.Enabled = True
    End Sub

    Private Sub Timer_finall_2_Tick(sender As Object, e As EventArgs) Handles Timer_finall_2.Tick
        Button5.BackColor = Color.DodgerBlue
        Timer_finall_2.Enabled = False
        Timer_finall_3.Enabled = True
    End Sub

    Private Sub Timer_finall_3_Tick(sender As Object, e As EventArgs) Handles Timer_finall_3.Tick
        Button5.BackColor = Color.DarkOrange
        Timer_finall_3.Enabled = False
        Timer_finall_1.Enabled = True
    End Sub

    Private Sub Form11_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class