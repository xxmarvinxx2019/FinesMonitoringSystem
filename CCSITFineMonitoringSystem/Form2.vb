Imports System.Data.SqlClient

Public Class Form2

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Application.Exit()

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
            Call connect()
            Dim cm As New SqlCommand("INSERT INTO admin(Idnum,name,course,yearlevel,section,position,password) VALUES(@Idnum,@name,@course,@yearlevel,@section,@position,@password)", conn)
            cm.Parameters.Add("@Idnum", SqlDbType.VarChar).Value = BunifuMaterialTextbox1.Text
            cm.Parameters.Add("@name", SqlDbType.VarChar).Value = BunifuMaterialTextbox2.Text
            cm.Parameters.Add("@course", SqlDbType.VarChar).Value = ComboBox1.Text
            cm.Parameters.Add("@yearlevel", SqlDbType.VarChar).Value = ComboBox3.Text
            cm.Parameters.Add("@section", SqlDbType.VarChar).Value = BunifuMaterialTextbox3.Text
            cm.Parameters.Add("@position", SqlDbType.VarChar).Value = BunifuMaterialTextbox5.Text
            cm.Parameters.Add("@password", SqlDbType.VarChar).Value = BunifuMaterialTextbox4.Text
            Try
                If cm.ExecuteNonQuery Then
                    MessageBox.Show("Save Successfully")
                    BunifuMaterialTextbox1.Text = ""
                    BunifuMaterialTextbox2.Text = ""
                    ComboBox1.Text = ""
                    ComboBox3.Text = ""
                    BunifuMaterialTextbox3.Text = ""
                    BunifuMaterialTextbox4.Text = ""
                    BunifuMaterialTextbox5.Text = ""
                End If

            Catch ex As Exception
                MessageBox.Show("Please Fill Up Everything")
            End Try
    End Sub
End Class