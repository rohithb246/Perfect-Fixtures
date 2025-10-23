Imports System.Data
Imports System.Data.SqlClient

Public Class BedsStock

    Dim connv As New SqlConnection
    Dim cmdv As SqlCommand
    Dim dtv As New DataTable
    Dim dav As New SqlDataAdapter(cmdv)

    Private Sub viewer()
        connv.Open()
        cmdv = connv.CreateCommand()
        cmdv.CommandType = CommandType.Text
        cmdv.CommandText = "select * from BedsStock"
        cmdv.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmdv)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        connv.Close()


    End Sub



    Private Sub BedsStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        Label3.Parent = PictureBox1
        Label3.BackColor = Color.Transparent
        Label4.Parent = PictureBox1
        Label4.BackColor = Color.Transparent

        connv.ConnectionString = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"

        viewer()


    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If Guna2TextBox1.Text = "" Or Guna2TextBox2.Text = "" Or Guna2TextBox3.Text = "" Or PictureBox2.Image Is Nothing Then
            MessageBox.Show("Enter all the fields!")

        Else


            Dim conn2 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader




            Dim filename As String = OpenFileDialog1.FileName + ".jpg"
            Dim filesize As Int32

            Dim mstream As New System.IO.MemoryStream



            PictureBox2.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrimage() As Byte = mstream.GetBuffer
            filesize = mstream.Length

            Dim sqlcmd As New SqlCommand

            mstream.Close()

            Dim str As String = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"
            Dim conn As New SqlConnection(str)

            Dim sql As String = "insert into BedsStock(Product,Price,Description,Picture,Filename,Filesize) values ('" + Guna2TextBox1.Text + "','" + Guna2TextBox2.Text + "','" + Guna2TextBox3.Text + "',@File,@filename,@filesize)"
            Try
                conn.Open()
                With sqlcmd
                    .CommandText = sql
                    .Connection = conn
                    .Parameters.AddWithValue("Product", Guna2TextBox1.Text)
                    .Parameters.AddWithValue("Price", Guna2TextBox2.Text)
                    .Parameters.AddWithValue("Description", Guna2TextBox3.Text)
                    .Parameters.AddWithValue("@Filename", filename)
                    .Parameters.AddWithValue("@Filesize", filesize)
                    .Parameters.AddWithValue("@File", arrimage)


                    .ExecuteNonQuery()
                    MessageBox.Show("Bed Stock Updated !")

                End With
            Catch ex As Exception
                MessageBox.Show("Error in Updation !")
            Finally
                conn.Close()
            End Try
            Guna2TextBox1.Text = ""
            Guna2TextBox2.Text = ""
            Guna2TextBox3.Text = ""
            PictureBox2.Image = Nothing

            viewer()
            DataGridView1.Refresh()
        End If

    End Sub

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage

        End If
    End Sub


    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        Dim conn As New SqlConnection
        Dim cmd As SqlCommand
        conn.ConnectionString = "Data Source=ROHITH\SQLEXPRESS;Initial Catalog=Perfect Fixtures;Integrated Security=True"


        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from BedsStock where Product = '" + Guna2TextBox1.Text + "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Bed Record Deleted!!")
            Guna2TextBox1.Text = ""
            Guna2TextBox2.Text = ""
            Guna2TextBox3.Text = ""
            PictureBox2.Image = Nothing

        Catch ex As Exception
            MessageBox.Show("Error in Deletion!!")

        End Try

        viewer()
        DataGridView1.Refresh()

        conn.Close()
    End Sub

    Private Sub ViewBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            Guna2TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Guna2TextBox2.Text = row.Cells("Price").Value.ToString
            Guna2TextBox3.Text = row.Cells("Description").Value.ToString

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


End Class