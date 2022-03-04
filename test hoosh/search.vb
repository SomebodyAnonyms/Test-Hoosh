Public Class search

    Public Sub GridColor(ByVal GridControl As DataGridView)
        Dim MBMIran_coler As Color
        MBMIran_coler = Color.FromArgb(223, 236, 245)
        For i = 0 To GridControl.RowCount - 1
            Dim a As Integer = i Mod 2
            If (i Mod 2) = 0 Then

                For j = 0 To GridControl.ColumnCount - 1
                    GridControl.Rows.Item(i).Cells.Item(j).Style.BackColor = MBMIran_coler
                    GridControl.Rows.Item(i).Cells.Item(j).Style.ForeColor = Color.Black
                Next
            Else
                For j = 0 To GridControl.ColumnCount - 1
                    GridControl.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.White
                    GridControl.Rows.Item(i).Cells.Item(j).Style.ForeColor = Color.Black

                Next
            End If
        Next
        GridControl.Refresh()
    End Sub

    Private Sub search_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
    End Sub

    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.NatigeTableAdapter.Fill(Me.DatabaseDataSet.natige)

        ' For i = 0 To NatigeDataGridView.Rows.Count Step 2
        'For b = 0 To 6
        'NatigeDataGridView.Rows.Item(i).Cells.Item(b).Style.BackColor = Color.Blue
        '  NatigeDataGridView.Rows.Item(i).Cells.Item(b).Style.ForeColor = Color.White
        '   Next
        '  Next

        GridColor(NatigeDataGridView)

    End Sub
    Private Sub Radio_gender_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_gender.CheckedChanged
        TextBox1.Visible = False
        ComboBox1.Visible = True
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("زن")
        ComboBox1.Items.Add("مرد")

        ComboBox1.Text = "جنسیت خود را انتخاب کنید"
        ComboBox1.ForeColor = Color.Gray
    End Sub

    Private Sub Radio_iq_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_iq.CheckedChanged
        TextBox1.Visible = False
        ComboBox1.Visible = True
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("دانش اموز دبستان")
        ComboBox1.Items.Add("دانش آموز دبیرستان")
        ComboBox1.Items.Add("دانشجو")
        ComboBox1.Items.Add("استاد دانشگاه")
        ComboBox1.Items.Add("نابغه")

        ComboBox1.Text = "سطح هوش خود را انتخاب کنید"
        ComboBox1.ForeColor = Color.Gray
    End Sub

    Private Sub Radio_id_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_id.CheckedChanged
        TextBox1.Visible = True
        ComboBox1.Visible = False
        TextBox1.Text = "کد پیگیری را اینجا بنویسید"
        TextBox1.ForeColor = Color.Gray
    End Sub

    Private Sub Radio_name_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_name.CheckedChanged
        TextBox1.Visible = True
        ComboBox1.Visible = False
        TextBox1.Text = "نام خود را اینجا بنویسید"
        TextBox1.ForeColor = Color.Gray
    End Sub

    Private Sub Radio_lastname_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_lastname.CheckedChanged
        TextBox1.Visible = True
        ComboBox1.Visible = False
        TextBox1.Text = "نام خانوادگی خود را اینجا بنویسید"
        TextBox1.ForeColor = Color.Gray
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Radio_id.Checked = True Then
            NatigeBindingSource.Filter = "Id='" & TextBox1.Text & "'"
        End If
        If Radio_name.Checked = True Then
            NatigeBindingSource.Filter = "name like '%" & TextBox1.Text & "%'"
        End If
        If Radio_lastname.Checked = True Then
            NatigeBindingSource.Filter = "last_name like '%" & TextBox1.Text & "%'"
        End If
        If Radio_gender.Checked = True Then
            NatigeBindingSource.Filter = "gender='" & ComboBox1.Text & "'"
        End If
        If Radio_iq.Checked = True Then
            NatigeBindingSource.Filter = "iq_level='" & ComboBox1.Text & "'"
        End If
        GridColor(NatigeDataGridView)



    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If TextBox1.TextLength > 23 Then
            TextBox1.Text = " "
        End If
        TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        If ComboBox1.Text.Length > 23 Then
            ComboBox1.Text = " "
        End If
        ComboBox1.ForeColor = Color.Black
    End Sub
End Class