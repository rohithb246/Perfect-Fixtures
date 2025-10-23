Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


        PictureBox2.Parent = PictureBox1
        PictureBox2.BackColor = Color.Transparent
        PictureBox3.Parent = PictureBox1
        PictureBox3.BackColor = Color.Transparent
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 5
        Else
            AdminMainMenu.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Guna2ComboBox1.SelectedIndex = 0 Then

            Dim conn As SqlConnection = New SqlConnection("Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True")
            If Guna2TextBox1.Text = "" Or Guna2TextBox2.Text = "" Then
                MessageBox.Show("Enter all the fields")
            Else


                Dim cmd As SqlCommand = New SqlCommand("select * from AdminLogin where Username='" + Guna2TextBox1.Text + "' and Password='" + Guna2TextBox2.Text + "'", conn)
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)


                If (dt.Rows.Count > 0) Then
                    PictureBox2.Visible = True
                    PictureBox3.Visible = False
                    Label5.Visible = False
                    Label4.Visible = True
                    Timer1.Enabled = True
                    ProgressBar1.Visible = True
                Else
                    Try
                        PictureBox3.Visible = True
                        PictureBox2.Visible = False
                        Label4.Visible = False
                        Label5.Visible = True
                        Guna2TextBox1.Text = ""
                        Guna2TextBox2.Text = ""
                        ProgressBar1.Value = 0
                        ProgressBar1.Visible = False
                    Catch ex As Exception
                        MessageBox.Show("Fail!!")
                    End Try
                    conn.Close()

                End If

            End If
        End If




        If Guna2ComboBox1.SelectedIndex = 1 Then

            Dim conn As SqlConnection = New SqlConnection("Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True")
            If Guna2TextBox1.Text = "" Or Guna2TextBox2.Text = "" Then
                MessageBox.Show("Enter all the fields")
            Else


                Dim cmd As SqlCommand = New SqlCommand("select * from EmployeeLogin where Username='" + Guna2TextBox1.Text + "' and Password='" + Guna2TextBox2.Text + "'", conn)
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)


                If (dt.Rows.Count > 0) Then
                    PictureBox2.Visible = True
                    PictureBox3.Visible = False
                    Label5.Visible = False
                    Label4.Visible = True
                    Timer2.Enabled = True
                    ProgressBar1.Visible = True
                Else
                    Try
                        PictureBox3.Visible = True
                        PictureBox2.Visible = False
                        Label4.Visible = False
                        Label5.Visible = True
                        Guna2TextBox1.Text = ""
                        Guna2TextBox2.Text = ""
                        ProgressBar1.Value = 0
                        ProgressBar1.Visible = False
                    Catch ex As Exception
                        MessageBox.Show("Fail!!")
                    End Try
                    conn.Close()

                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserRegistration.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ForgotPassword.Show()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 5
        Else
            EmployeeMainMenu.Show()
            Timer2.Enabled = False
        End If
    End Sub
End Class
