Imports System.Data.SqlClient
Public Class Form1

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Application.Exit()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Me.Hide()
        Form2.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rs As SqlDataReader
        Call connect()
        Dim cm As New SqlCommand("select * from admin where Idnum = '" & BunifuMetroTextbox1.Text & "' and password = '" & BunifuMetroTextbox2.Text & "'", conn)
        rs = cm.ExecuteReader
        If rs.HasRows = True Then
            Me.Hide()
            Form4.Show()
            Form4.UserControl61.adminprof("")
            If BunifuCheckbox1.Checked = False Then
                BunifuMetroTextbox1.Text = ""
                BunifuMetroTextbox2.Text = ""
            End If
        ElseIf BunifuMetroTextbox1.Text = "" And BunifuMetroTextbox2.Text = "" Then
            MessageBox.Show("Enter Username or Password")
        Else
            MessageBox.Show("Wrong User or Password")
            BunifuMetroTextbox1.Text = ""
            BunifuMetroTextbox2.Text = ""
        End If
    End Sub
End Class
