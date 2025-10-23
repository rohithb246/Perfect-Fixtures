Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        BedsButton.PerformClick()
    End Sub

    Private Sub BedsButton_Click(sender As Object, e As EventArgs) Handles BedsButton.Click
        Panel1.Controls.Clear()
        Beds.TopLevel = False
        Panel1.Controls.Add(Beds)
        Beds.Show()
    End Sub

    Private Sub SofaButton_Click(sender As Object, e As EventArgs) Handles SofaButton.Click
        Panel1.Controls.Clear()
        Sofa.TopLevel = False
        Panel1.Controls.Add(Sofa)
        Sofa.Show()
    End Sub

    Private Sub DiningButton_Click(sender As Object, e As EventArgs) Handles DiningButton.Click
        Panel1.Controls.Clear()
        Dining.TopLevel = False
        Panel1.Controls.Add(Dining)
        Dining.Show()
    End Sub

    Private Sub ShelfButton_Click(sender As Object, e As EventArgs) Handles ShelfButton.Click
        Panel1.Controls.Clear()
        Shelf.TopLevel = False
        Panel1.Controls.Add(Shelf)
        Shelf.Show()
    End Sub

    Private Sub WardrobeButton_Click(sender As Object, e As EventArgs) Handles WardrobeButton.Click
        Panel1.Controls.Clear()
        Wardrobe.TopLevel = False
        Panel1.Controls.Add(Wardrobe)
        Wardrobe.Show()
    End Sub

    Private Sub KidsButton_Click(sender As Object, e As EventArgs) Handles KidsButton.Click
        Panel1.Controls.Clear()
        Kids.TopLevel = False
        Panel1.Controls.Add(Kids)
        Kids.Show()
    End Sub

    Private Sub DecorButton_Click(sender As Object, e As EventArgs) Handles DecorButton.Click
        Panel1.Controls.Clear()
        Decor.TopLevel = False
        Panel1.Controls.Add(Decor)
        Decor.Show()
    End Sub
End Class