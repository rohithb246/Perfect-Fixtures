Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing


Public Class Kids

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        longpaper = longpaper + 240
    End Sub

    Private Sub Kids_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As SqlDataReader


        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        Label3.Parent = PictureBox1
        Label3.BackColor = Color.Transparent
        Label4.Parent = PictureBox1
        Label4.BackColor = Color.Transparent
        Label5.Parent = PictureBox1
        Label5.BackColor = Color.Transparent
        Label6.Parent = PictureBox1
        Label6.BackColor = Color.Transparent
        Label7.Parent = PictureBox1
        Label7.BackColor = Color.Transparent
        Label8.Parent = PictureBox1
        Label8.BackColor = Color.Transparent
        Label9.Parent = PictureBox1
        Label9.BackColor = Color.Transparent
        Label10.Parent = PictureBox1
        Label10.BackColor = Color.Transparent
        Label11.Parent = PictureBox1
        Label11.BackColor = Color.Transparent

        conn.ConnectionString = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"
        conn.Open()
        Guna2ComboBox1.Items.Clear()
        cmd.CommandText = "select * from KidsStock"

        cmd.Connection = conn
        dr = cmd.ExecuteReader
        While dr.Read
            Guna2ComboBox1.Items.Add(dr.GetString(0))
        End While

        dr.Close()
        conn.Close()
    End Sub
    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress
        Dim allowednos As String = "1234567890"
        If Not (Asc(e.KeyChar) = 8) Then

            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please Enter a Valid Price!!")
                e.KeyChar = ChrW(0)
                e.Handled = True

            End If
        End If

    End Sub

    Private Sub Guna2TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox2.KeyPress
        Dim allowednos As String = "1234567890"
        If Not (Asc(e.KeyChar) = 8) Then

            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please Enter a Valid Price!!")
                e.KeyChar = ChrW(0)
                e.Handled = True

            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""
        Guna2TextBox3.Text = ""
        Guna2TextBox4.Text = ""
        Guna2TextBox5.Text = ""
        Guna2TextBox6.Text = ""
        Guna2TextBox7.Text = ""
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Guna2TextBox7.Text = DateTimePicker1.Value.Date
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Dim adapter As New SqlDataAdapter
        Dim data As New DataTable
        Dim str As String = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"
        Dim conn As New SqlConnection(str)
        adapter = New SqlDataAdapter("select Picture from KidsStock where Product = '" + Guna2ComboBox1.Text + "'", conn)


        Dim cmdbuild As New SqlCommandBuilder(adapter)
        adapter.Fill(data)


        Dim picbyte() As Byte = data.Rows(0).Item("Picture")
        Dim pic As New System.IO.MemoryStream(picbyte)
        PictureBox2.Image = Image.FromStream(pic)

        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        pic.Close()


        Dim cnn As New SqlConnection
        cnn.ConnectionString = ("Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True")
        cnn.Open()

        Dim str2 As String

        str2 = "select Price,Description from KidsStock where Product = '" + Guna2ComboBox1.Text + "'"
        Dim comd As New SqlCommand(str2, cnn)
        Dim myreader As SqlDataReader

        myreader = comd.ExecuteReader
        myreader.Read()
        Guna2TextBox2.Text = myreader("Price")
        Guna2TextBox3.Text = myreader("Description")

        cnn.Close()
    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox2.SelectedIndexChanged
        Dim p As Integer

        If Guna2ComboBox2.SelectedIndex = 0 Then
            p = Val(Guna2TextBox2.Text) * 1

        End If

        If Guna2ComboBox2.SelectedIndex = 1 Then
            p = Val(Guna2TextBox2.Text) * 2

        End If

        If Guna2ComboBox2.SelectedIndex = 2 Then
            p = Val(Guna2TextBox2.Text) * 3

        End If

        If Guna2ComboBox2.SelectedIndex = 3 Then
            p = Val(Guna2TextBox2.Text) * 4

        End If

        If Guna2ComboBox2.SelectedIndex = 4 Then
            p = Val(Guna2TextBox2.Text) * 5

        End If

        If Guna2ComboBox2.SelectedIndex = 5 Then
            p = Val(Guna2TextBox2.Text) * 6

        End If

        Guna2TextBox1.Text = p
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Guna2TextBox1.Text = "" Or Guna2TextBox2.Text = "" Or Guna2TextBox3.Text = "" Or Guna2TextBox4.Text = "" Or
            Guna2TextBox5.Text = "" Or Guna2TextBox6.Text = "" Or Guna2TextBox7.Text = "" Then
            MessageBox.Show("Enter all the fields !")
        Else
            If Guna2TextBox5.TextLength < 10 Then
                MessageBox.Show("Enter a Valid Number !")


            Else
                If Guna2TextBox5.TextLength = 10 Then



                    Dim conn1 As New SqlConnection
                    Dim cmd1 As New SqlCommand
                    Dim dt1 As New DataTable
                    Dim da1 As New SqlDataAdapter(cmd1)

                    conn1.ConnectionString = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"

                    Try


                        conn1.Open()
                        cmd1 = conn1.CreateCommand()
                        cmd1.CommandType = CommandType.Text
                        cmd1.CommandText = "insert into KidsCustomer(Product,Price,Description,Quantity,Total,Payment,CustomerName,CustomerNum,PurchaseDate,CustomerAddress) values 
       ('" + Guna2ComboBox1.Text + "','" + Guna2TextBox2.Text + "','" + Guna2TextBox3.Text + "',
       '" + Guna2ComboBox2.Text + "','" + Guna2TextBox1.Text + "','" + Guna2ComboBox3.Text + "','" + Guna2TextBox4.Text + "',
        '" + Guna2TextBox5.Text + "','" + Guna2TextBox7.Text + "','" + Guna2TextBox6.Text + "')"
                        cmd1.ExecuteNonQuery()
                        MessageBox.Show("Customer Record Added!")

                        conn1.Close()
                        Dim result As DialogResult = MessageBox.Show("Do you want to print reciept?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.Yes Then
                            changelongpaper()
                            PPD.Document = PD
                            PPD.ShowDialog()
                        ElseIf result = DialogResult.No Then
                            MessageBox.Show("No pressed")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Customer Record Failed!")


                    End Try
                Else
                    MessageBox.Show("Enter a Valid Number")

                End If
            End If


        End If

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint


        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)

        PD.DefaultPageSettings = pagesetup




    End Sub


    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "***********************************************"

        e.Graphics.DrawString("Perfect Fixtures", f10b, Brushes.Black, centermargin, 15, center)

        e.Graphics.DrawString("Bengaluru", f10b, Brushes.Black, centermargin, 30, center)
        e.Graphics.DrawString("Tel 080-12345678", f10b, Brushes.Black, centermargin, 45, center)

        e.Graphics.DrawString("Customer Name : " + Guna2TextBox4.Text + "", f8, Brushes.Black, centermargin, 70, center)


        e.Graphics.DrawString("Mobile Number : " + Guna2TextBox5.Text + "", f8, Brushes.Black, centermargin, 85, center)


        e.Graphics.DrawString("Date : " + Guna2TextBox7.Text + "", f8, Brushes.Black, centermargin, 100, center)

        e.Graphics.DrawString("Qty", f10b, Brushes.Black, 0, 125)
        e.Graphics.DrawString("Item", f10b, Brushes.Black, 25, 125)
        e.Graphics.DrawString("Price", f10b, Brushes.Black, 180, 125, right)
        e.Graphics.DrawString("Total", f10b, Brushes.Black, rightmargin, 125, right)
        '
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 140)

        Dim height As Integer
        Dim i As Long


        height += 15
        e.Graphics.DrawString(Guna2ComboBox2.Text, f8, Brushes.Black, 0, 135 + height)
        e.Graphics.DrawString(Guna2ComboBox1.Text, f8, Brushes.Black, 25, 135 + height)
        i = Guna2TextBox2.Text
        Guna2TextBox2.Text = Format(i, "##,##0")
        e.Graphics.DrawString(Guna2TextBox2.Text, f8, Brushes.Black, 180, 135 + height, right)


        Dim totalprice As Long
        totalprice = Guna2TextBox1.Text
        e.Graphics.DrawString(totalprice.ToString("##,##0"), f8, Brushes.Black, rightmargin, 135 + height, right)





        Dim height2 As Integer
        height2 = 145 + height

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total: " & (Guna2TextBox1.Text), f10b, Brushes.Black, rightmargin, 10 + height2, right)


        e.Graphics.DrawString("~ Thanks for shopping with us ~", f10, Brushes.Black, centermargin, 70 + height2, center)
        e.Graphics.DrawString("~ Perfect Fixtures ~", f10, Brushes.Black, centermargin, 85 + height2, center)


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub Guna2TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox4.KeyPress
        Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
        If Not (Asc(e.KeyChar) = 8) Then


            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please Enter Characters only!")
                e.KeyChar = ChrW(0)
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub Guna2TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox5.KeyPress
        Dim allowednos As String = "1234567890"
        If Not (Asc(e.KeyChar) = 8) Then

            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please Enter a Valid Number!!")
                e.KeyChar = ChrW(0)
                e.Handled = True

            End If
        End If

    End Sub

End Class