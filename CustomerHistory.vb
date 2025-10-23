Public Class CustomerHistory
    Private Sub CustomerHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        BedsCHistory.TopLevel = False
        Panel1.Controls.Add(BedsCHistory)
        BedsCHistory.Show()
    End Sub

    Private Sub SofaButton_Click(sender As Object, e As EventArgs) Handles SofaButton.Click
        Panel1.Controls.Clear()
        SofaCHistory.TopLevel = False
        Panel1.Controls.Add(SofaCHistory)
        SofaCHistory.Show()
    End Sub

    Private Sub DiningButton_Click(sender As Object, e As EventArgs) Handles DiningButton.Click
        Panel1.Controls.Clear()
        DiningCHistory.TopLevel = False
        Panel1.Controls.Add(DiningCHistory)
        DiningCHistory.Show()
    End Sub

    Private Sub ShelfButton_Click(sender As Object, e As EventArgs) Handles ShelfButton.Click
        Panel1.Controls.Clear()
        ShelfCHistory.TopLevel = False
        Panel1.Controls.Add(ShelfCHistory)
        ShelfCHistory.Show()
    End Sub

    Private Sub WardrobeButton_Click(sender As Object, e As EventArgs) Handles WardrobeButton.Click
        Panel1.Controls.Clear()
        WardrobeCHistory.TopLevel = False
        Panel1.Controls.Add(WardrobeCHistory)
        WardrobeCHistory.Show()
    End Sub

    Private Sub KidsButton_Click(sender As Object, e As EventArgs) Handles KidsButton.Click
        Panel1.Controls.Clear()
        KidsCHistory.TopLevel = False
        Panel1.Controls.Add(KidsCHistory)
        KidsCHistory.Show()
    End Sub

    Private Sub DecorButton_Click(sender As Object, e As EventArgs) Handles DecorButton.Click
        Panel1.Controls.Clear()
        DecorCHistory.TopLevel = False
        Panel1.Controls.Add(DecorCHistory)
        DecorCHistory.Show()
    End Sub
End Class