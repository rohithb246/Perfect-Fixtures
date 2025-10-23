Imports System.Data
Imports System.Data.SqlClient

Public Class WardrobeSupplier
    Private Sub viewer()
        Dim connv As New SqlConnection("Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True")
        Dim cmdv As SqlCommand
        Dim dtv As New DataTable
        Dim dav As New SqlDataAdapter(cmdv)
        connv.Open()
        cmdv = connv.CreateCommand()
        cmdv.CommandType = CommandType.Text
        cmdv.CommandText = "select * from WardrobeSupplier"
        cmdv.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmdv)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        connv.Close()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""
        Guna2TextBox3.Text = ""
        Guna2TextBox4.Text = ""
        Guna2TextBox5.Text = ""
        Guna2TextBox6.Text = ""
        Guna2TextBox8.Text = ""
        Guna2TextBox9.Text = ""
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Guna2TextBox5.Text = DateTimePicker1.Value.Date
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Guna2TextBox8.Text = DateTimePicker2.Value.Date
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim dt1 As New DataTable
        Dim da1 As New SqlDataAdapter(cmd1)

        conn1.ConnectionString = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"

        Try


            conn1.Open()
            cmd1 = conn1.CreateCommand()
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "insert into WardrobeSupplier(Source,DealershipName,DealerName,Item,Quantity,Date,Total,Payment,SettlementDate) values 
       ('" + Guna2TextBox1.Text + "','" + Guna2TextBox2.Text + "','" + Guna2TextBox3.Text + "',
       '" + Guna2TextBox4.Text + "','" + Guna2TextBox9.Text + "','" + Guna2TextBox5.Text + "','" + Guna2TextBox6.Text + "',
        '" + Guna2ComboBox1.Text + "','" + Guna2TextBox8.Text + "')"
            cmd1.ExecuteNonQuery()
            MessageBox.Show("Wardrobe Supplier Record Added!")

            conn1.Close()
            Guna2TextBox1.Text = ""
            Guna2TextBox2.Text = ""
            Guna2TextBox3.Text = ""
            Guna2TextBox4.Text = ""
            Guna2TextBox5.Text = ""
            Guna2TextBox6.Text = ""
            Guna2TextBox8.Text = ""
            Guna2TextBox9.Text = ""
        Catch ex As Exception
            MessageBox.Show("Wardrobe Supplier Record Failed!")


        End Try
        viewer()
        DataGridView1.Refresh()
    End Sub

    Private Sub WardrobeSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewer()
    End Sub
End Class