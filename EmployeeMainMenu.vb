Public Class EmployeeMainMenu
    Private Sub EmployeeMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HomeBtn.Parent = PictureBox2
        HomeBtn.BackColor = Color.Transparent
        Logoutbtn.Parent = PictureBox2
        Logoutbtn.BackColor = Color.Transparent
        CustomerBtn.Parent = PictureBox2
        CustomerBtn.BackColor = Color.Transparent
        HomeBtn.PerformClick()
    End Sub

    Private Sub Logoutbtn_Click(sender As Object, e As EventArgs) Handles Logoutbtn.Click
        If EmployeeMainMenu.ActiveForm.Visible = True Then
            EmployeeMainMenu.ActiveForm.Visible = False
            Login.Show()
            Login.Guna2TextBox1.Text = ""
            Login.Guna2TextBox2.Text = ""
            Login.Guna2ComboBox1.Text = ""
            Login.ProgressBar1.Visible = False
            Login.Label4.Visible = False
            Login.PictureBox2.Visible = False

        End If
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Panel1.Controls.Clear()
        Home.TopLevel = False
        Panel1.Controls.Add(Home)
        Home.Show()
        Stock.Close()
        CustomerHistory.Close()
        Sales.Close()

    End Sub


    Private Sub CustomerBtn_Click(sender As Object, e As EventArgs) Handles CustomerBtn.Click
        Panel1.Controls.Clear()
        CustomerHistory.TopLevel = False
        Panel1.Controls.Add(CustomerHistory)
        CustomerHistory.Show()
        Home.Close()
        Stock.Close()
        Sales.Close()
    End Sub
End Class