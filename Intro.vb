Public Class Intro
    Private Sub Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2CircleProgressBar1.Parent = PictureBox1
        Guna2CircleProgressBar1.BackColor = Color.Transparent
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Guna2CircleProgressBar1.Value < 100 Then
            Guna2CircleProgressBar1.Value = Guna2CircleProgressBar1.Value + 7
        Else
            Login.Show()
            Timer1.Enabled = False

        End If
    End Sub
End Class