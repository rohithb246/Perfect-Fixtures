Imports System.Data
Imports System.Data.SqlClient



Public Class BedsCHistory



    Private Sub BedsCHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As SqlDataReader



        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent




        conn.ConnectionString = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"
        conn.Open()
        Guna2ComboBox1.Items.Clear()
        cmd.CommandText = "select * from BedsCustomer"

        cmd.Connection = conn
        dr = cmd.ExecuteReader
        While dr.Read
            Guna2ComboBox1.Items.Add(dr.GetString(6))
        End While

        dr.Close()
        conn.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection

        conn.ConnectionString = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"

        conn.Open()
        Dim cmd As New SqlCommand("select CustomerName,CustomerNum,CustomerAddress,Product,PurchaseDate,Quantity,Total,Payment from BedsCustomer where CustomerName='" + Guna2ComboBox1.Text + "'", conn)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        DataGridView1.DataSource = dt

        DataGridView1.Columns(0).HeaderText = "CustomerName"
        DataGridView1.Columns(1).HeaderText = "CustomerNum"
        DataGridView1.Columns(2).HeaderText = "CustomerAddress"
        DataGridView1.Columns(3).HeaderText = "Product"
        DataGridView1.Columns(4).HeaderText = "PurchaseDate"
        DataGridView1.Columns(5).HeaderText = "Quantity"
        DataGridView1.Columns(6).HeaderText = "Total"
        DataGridView1.Columns(7).HeaderText = "Payment"

        conn.Close()


    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Dim conn As New SqlConnection

        conn.ConnectionString = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"

        conn.Open()
        Dim cmd As New SqlCommand("select CustomerName,CustomerNum,CustomerAddress,Product,PurchaseDate,Quantity,Total,Payment from BedsCustomer where CustomerName='" + Guna2ComboBox1.Text + "'", conn)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        DataGridView1.DataSource = dt

        DataGridView1.Columns(0).HeaderText = "CustomerName"
        DataGridView1.Columns(1).HeaderText = "CustomerNum"
        DataGridView1.Columns(2).HeaderText = "CustomerAddress"
        DataGridView1.Columns(3).HeaderText = "Product"
        DataGridView1.Columns(4).HeaderText = "PurchaseDate"
        DataGridView1.Columns(5).HeaderText = "Quantity"
        DataGridView1.Columns(6).HeaderText = "Total"
        DataGridView1.Columns(7).HeaderText = "Payment"

        conn.Close()
    End Sub
End Class