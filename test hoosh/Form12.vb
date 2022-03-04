Imports System.ComponentModel

Public Class Form12
    Dim time As Long

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer_finall_1.Enabled = True

        If Form2.Button1.Enabled = False Then
            Label3.Text = Label3.Text + 1
        Else
            Label2.Text = Label2.Text + 1
        End If


        If Form3.Button4.Enabled = False Then
            Label3.Text = Label3.Text + 1
        Else
            Label2.Text = Label2.Text + 1
        End If


        If Form4.Button2.Enabled = False Then
            Label3.Text = Label3.Text + 1
        Else
            Label2.Text = Label2.Text + 1
        End If


        If Form5.TextBox1.Text = "70" Then
            Label2.Text = Label2.Text + 1
        Else
            Label3.Text = Label3.Text + 1
        End If


        If Form6.TextBox1.Text = "9" Then
            Label2.Text = Label2.Text + 1
        Else
            Label3.Text = Label3.Text + 1
        End If


        If Form7.TextBox1.Text = "کبریت" Then
            Label2.Text = Label2.Text + 1
        Else
            Label3.Text = Label3.Text + 1
        End If


        If Form8.Button1.Enabled = False Then
            Label3.Text = Label3.Text + 1
        Else
            Label2.Text = Label2.Text + 1
        End If


        If Form9.Button3.Enabled = False Then
            Label3.Text = Label3.Text + 1
        Else
            Label2.Text = Label2.Text + 1
        End If


        If Form10.Button4.Enabled = False Then
            Label3.Text = Label3.Text + 1
        Else
            Label2.Text = Label2.Text + 1
        End If


        If Form11.Button1.Enabled = False Then
            Label3.Text = Label3.Text + 1
        Else
            Label2.Text = Label2.Text + 1
        End If

        NewMethod()

        If Form1.ComboBox1.Text = "زن" Then
            Label17.Text = "سرکار خانم"
        End If

        If Form1.ComboBox1.Text = "مرد" Then
            Label17.Text = "جناب آقای"
        End If





        If Label17.Text = "جناب آقای" And TextBox1.Text = "دانش آموز دبستان" Then PictureBox_b_dabestan.Visible = True
        If Label17.Text = "سرکار خانم" And TextBox1.Text = "دانش آموز دبستان" Then PictureBox_w_dabestan.Visible = True


        If Label17.Text = "جناب آقای" And TextBox1.Text = "دانش آموز دبیرستان" Then PictureBox_b_dabirestan.Visible = True
        If Label17.Text = "سرکار خانم" And TextBox1.Text = "دانش آموز دبیرستان" Then PictureBox_w_dabirestan.Visible = True


        If Label17.Text = "جناب آقای" And TextBox1.Text = "دانشجو" Then PictureBox_b_daneshgoo.Visible = True
        If Label17.Text = "سرکار خانم" And TextBox1.Text = "دانشجو" Then PictureBox_w_daneshgoo.Visible = True


        If Label17.Text = "جناب آقای" And TextBox1.Text = "استاد دانشگاه" Then PictureBox_b_ostad.Visible = True
        If Label17.Text = "سرکار خانم" And TextBox1.Text = "استاد دانشگاه" Then PictureBox_w_ostad.Visible = True


        If Label17.Text = "جناب آقای" And TextBox1.Text = "نابغه" Then PictureBox_b_nabeghe.Visible = True
        If Label17.Text = "سرکار خانم" And TextBox1.Text = "نابغه" Then PictureBox_w_nabeghe.Visible = True



        Label18.Text = Form1.TextBox1.Text
        Label19.Text = Form1.TextBox2.Text


        time = 0
        Label22.Text = 390 - (Val(Form2.Label5.Text) + Val(Form3.Label5.Text) + Val(Form4.Label5.Text) + Val(Form5.Label9.Text) + Val(Form6.Label9.Text) + Val(Form7.Label10.Text) + Val(Form8.Label5.Text) + Val(Form9.Label5.Text) + Val(Form10.Label5.Text) + Val(Form11.Label7.Text))
    End Sub

    Private Sub NewMethod()
        If Label2.Text = "0" Then
            Label5.ForeColor = Color.Green
            Label10.ForeColor = Color.Green
            TextBox1.Text = "دانش آموز دبستان"
        End If

        If Label2.Text = "1" Then
            Label5.ForeColor = Color.Green
            Label10.ForeColor = Color.Green
            TextBox1.Text = "دانش آموز دبستان"
        End If

        If Label2.Text = "2" Then
            Label5.ForeColor = Color.Green
            Label10.ForeColor = Color.Green
            TextBox1.Text = "دانش آموز دبستان"
        End If


        If Label2.Text = "3" Then
            Label6.ForeColor = Color.Green
            Label11.ForeColor = Color.Green
            TextBox1.Text = "دانش آموز دبیرستان"
        End If

        If Label2.Text = "4" Then
            Label6.ForeColor = Color.Green
            Label11.ForeColor = Color.Green
            TextBox1.Text = "دانش آموز دبیرستان"
        End If

        If Label2.Text = "5" Then
            Label7.ForeColor = Color.Green
            Label12.ForeColor = Color.Green
            TextBox1.Text = "دانشجو"
        End If

        If Label2.Text = "6" Then
            Label7.ForeColor = Color.Green
            Label12.ForeColor = Color.Green
            TextBox1.Text = "دانشجو"
        End If

        If Label2.Text = "7" Then
            Label8.ForeColor = Color.Green
            Label13.ForeColor = Color.Green
            TextBox1.Text = "استاد دانشگاه"
        End If

        If Label2.Text = "8" Then
            Label8.ForeColor = Color.Green
            Label13.ForeColor = Color.Green
            TextBox1.Text = "استاد دانشگاه"
        End If

        If Label2.Text = "9" Then
            Label9.ForeColor = Color.Green
            Label14.ForeColor = Color.Green
            TextBox1.Text = "نابغه"
        End If

        If Label2.Text = "10" Then
            Label9.ForeColor = Color.Green
            Label14.ForeColor = Color.Green
            TextBox1.Text = "نابغه"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Refresh()
        Form11.Refresh()
        Form10.Refresh()
        Form9.Refresh()
        Form8.Refresh()
        Form7.Refresh()
        Form6.Refresh()
        Form5.Refresh()
        Form4.Refresh()
        Form3.Refresh()
        Form2.Refresh()
        Form1.Show()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.ComboBox1.Text = ""
        Form1.Button1.Text = "لطفا اطلاعات خود را وارد کنید"
        Form1.Button1.ForeColor = Color.Red
        Form1.TextBox2.Enabled = False
        Form1.ComboBox1.Enabled = False
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        My.Computer.Audio.Play("E:\Program\test hoosh\test hoosh\bin\Debug\sound\171697__nenadsimic__menu-selection-click.wav")
    End Sub

    Private Sub Form12_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed

        Application.Exit()

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

    Private Sub Button_result_Click(sender As Object, e As EventArgs) Handles Button_result.Click
        search.Refresh()
        search.Show()
    End Sub
End Class