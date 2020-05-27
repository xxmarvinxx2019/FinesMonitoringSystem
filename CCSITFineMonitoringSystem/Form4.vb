Public Class Form4

    Private Sub Form4_load(sender As Object, e As EventArgs) Handles MyBase.Load
        User11.studentdata("")
    End Sub
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        UserControl11.BringToFront()
        BunifuFlatButton12.BringToFront()
        Panel3.BackColor = Color.White
        BunifuFlatButton11.BringToFront()
        BunifuFlatButton10.BringToFront()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click, BunifuTransition1.AllAnimationsCompleted
        UserControl21.BringToFront()
        Panel3.BackColor = Color.White
        BunifuFlatButton11.BringToFront()
        BunifuFlatButton10.BringToFront()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        UserControl31.BringToFront()
        Panel3.BackColor = Color.DodgerBlue
        BunifuFlatButton11.BringToFront()
        BunifuFlatButton10.BringToFront()

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        UserControl41.BringToFront()
        Panel3.BackColor = Color.White
        BunifuFlatButton11.BringToFront()
        BunifuFlatButton10.BringToFront()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Me.Hide()
        Form1.Show()
        Panel3.BackColor = Color.DodgerBlue
        UserControl31.BringToFront()
        BunifuFlatButton11.BringToFront()
        BunifuFlatButton10.BringToFront()
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        UserControl51.BringToFront()
        Panel3.BackColor = Color.White
        BunifuFlatButton11.BringToFront()
        BunifuFlatButton10.BringToFront()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        UserControl61.BringToFront()
        Panel3.BackColor = Color.White
        BunifuFlatButton11.BringToFront()
        BunifuFlatButton10.BringToFront()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        UserControl71.BringToFront()
        Panel3.BackColor = Color.White
        BunifuFlatButton11.BringToFront()
        BunifuFlatButton10.BringToFront()
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        UserControl81.BringToFront()
        Panel3.BackColor = Color.White
        BunifuFlatButton11.BringToFront()
        BunifuFlatButton10.BringToFront()
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        Application.Exit()
    End Sub

    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        Me.UserControl91.studentdata1("")
        UserControl91.BringToFront()
        Panel3.BackColor = Color.White
        BunifuFlatButton11.BringToFront()
        BunifuFlatButton10.BringToFront()
    End Sub
End Class