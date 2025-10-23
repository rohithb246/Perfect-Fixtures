Public Class Sales
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BedsButton.Parent = PictureBox1
        BedsButton.BackColor = Color.Transparent
        SofaButton.Parent = PictureBox1
        SofaButton.BackColor = Color.Transparent
        DiningButton.Parent = PictureBox1
        DiningButton.BackColor = Color.Transparent
        BedsButton.Parent = PictureBox1
        BedsButton.BackColor = Color.Transparent
        ShelfButton.Parent = PictureBox1
        ShelfButton.BackColor = Color.Transparent
        WardrobeButton.Parent = PictureBox1
        WardrobeButton.BackColor = Color.Transparent
        KidsButton.Parent = PictureBox1
        KidsButton.BackColor = Color.Transparent
        DecorButton.Parent = PictureBox1
        DecorButton.BackColor = Color.Transparent




        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        BedsButton.PerformClick()
    End Sub

    Private Sub BedsButton_Click(sender As Object, e As EventArgs) Handles BedsButton.Click
        Panel1.Controls.Clear()
        BedsSales.TopLevel = False
        Panel1.Controls.Add(BedsSales)
        BedsSales.Show()
    End Sub

    Private Sub SofaButton_Click(sender As Object, e As EventArgs) Handles SofaButton.Click
        Panel1.Controls.Clear()
        SofaSales.TopLevel = False
        Panel1.Controls.Add(SofaSales)
        SofaSales.Show()
    End Sub

    Private Sub DiningButton_Click(sender As Object, e As EventArgs) Handles DiningButton.Click
        Panel1.Controls.Clear()
        DiningSales.TopLevel = False
        Panel1.Controls.Add(DiningSales)
        DiningSales.Show()
    End Sub

    Private Sub ShelfButton_Click(sender As Object, e As EventArgs) Handles ShelfButton.Click
        Panel1.Controls.Clear()
        ShelfSales.TopLevel = False
        Panel1.Controls.Add(ShelfSales)
        ShelfSales.Show()
    End Sub

    Private Sub WardrobeButton_Click(sender As Object, e As EventArgs) Handles WardrobeButton.Click
        Panel1.Controls.Clear()
        WardrobeSales.TopLevel = False
        Panel1.Controls.Add(WardrobeSales)
        WardrobeSales.Show()
    End Sub

    Private Sub KidsButton_Click(sender As Object, e As EventArgs) Handles KidsButton.Click
        Panel1.Controls.Clear()
        KidsSales.TopLevel = False
        Panel1.Controls.Add(KidsSales)
        KidsSales.Show()
    End Sub

    Private Sub DecorButton_Click(sender As Object, e As EventArgs) Handles DecorButton.Click
        Panel1.Controls.Clear()
        DecorSales.TopLevel = False
        Panel1.Controls.Add(DecorSales)
        DecorSales.Show()
    End Sub
End Class