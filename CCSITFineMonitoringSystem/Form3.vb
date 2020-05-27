Imports System.Data.SqlClient

Public Class Form3

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Application.Exit()

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Call connect()
        Dim cm As New SqlCommand("select password from admin where Idnum = '" & BunifuMetroTextbox1.Text & "' and name = '" & BunifuMetroTextbox2.Text & "'", conn)
        dr = cm.ExecuteReader
        Try
            If dr.Read Then
                Dim s As String = dr.GetValue(0)
                MsgBox("Your password: " + s, MsgBoxStyle.Information)
                BunifuMetroTextbox1.Text = ""
                BunifuMetroTextbox2.Text = ""
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class