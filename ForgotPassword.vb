Imports System.Data
Imports System.Data.SqlClient
Public Class ForgotPassword


    Dim conn As New SqlConnection
    Dim dr As SqlDataReader
    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        HintLabel.Parent = PictureBox1
        HintLabel.BackColor = Color.Transparent
        Label3.Parent = PictureBox1
        Label3.BackColor = Color.Transparent
        HintAnswer.Parent = PictureBox1
        HintAnswer.BackColor = Color.Transparent


    End Sub



    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox2.SelectedIndexChanged
        If Guna2ComboBox2.SelectedIndex = 0 Then
            conn.ConnectionString = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"
            conn.Open()
            Guna2ComboBox1.Items.Clear()
            Dim cmd As New SqlCommand
            cmd.CommandText = "select * from AdminLogin"
            cmd.Connection = conn
            dr = cmd.ExecuteReader
            While dr.Read
                Guna2ComboBox1.Items.Add(dr.GetString(0))

            End While
            dr.Close()
            conn.Close()
        End If

        If Guna2ComboBox2.SelectedIndex = 1 Then
            conn.ConnectionString = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"
            conn.Open()
            Guna2ComboBox1.Items.Clear()
            Dim cmd As New SqlCommand
            cmd.CommandText = "select * from EmployeeLogin"
            cmd.Connection = conn
            dr = cmd.ExecuteReader
            While dr.Read
                Guna2ComboBox1.Items.Add(dr.GetString(0))

            End While
            dr.Close()
            conn.Close()
        End If

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        If Guna2ComboBox2.SelectedIndex = 0 Then
            Dim cnn As New SqlConnection
            cnn.ConnectionString = ("Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True")
            cnn.Open()

            Dim str As String

            str = "select Hint from AdminLogin where Username = '" + Guna2ComboBox1.Text + "'"
            Dim comd As New SqlCommand(str, cnn)
            Dim myreader As SqlDataReader

            myreader = comd.ExecuteReader
            myreader.Read()

            HintAnswer.Text = myreader("Hint")
            HintLabel.Visible = True
            HintAnswer.Visible = True




            cnn.Close()


        ElseIf Guna2ComboBox2.SelectedIndex = 1 Then
            Dim cnn As New SqlConnection
            cnn.ConnectionString = ("Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True")
            cnn.Open()

            Dim str As String

            str = "select Hint from EmployeeLogin where Username = '" + Guna2ComboBox1.Text + "'"
            Dim comd As New SqlCommand(str, cnn)
            Dim myreader As SqlDataReader

            myreader = comd.ExecuteReader
            myreader.Read()

            HintAnswer.Text = myreader("Hint")
            HintLabel.Visible = True
            HintAnswer.Visible = True




            cnn.Close()
        End If
    End Sub

End Class