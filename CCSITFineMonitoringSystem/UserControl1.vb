Imports System.Data.SqlClient
Public Class UserControl1


    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Call connect()
        Dim cm As New SqlCommand("INSERT INTO student(Idnum,name,course,yearlevel,section) VALUES(@Idnum,@name,@course,@yearlevel,@section)", conn)
        cm.Parameters.Add("@Idnum", SqlDbType.VarChar).Value = sidtext.Text
        cm.Parameters.Add("@name", SqlDbType.VarChar).Value = sfnametext.Text
        cm.Parameters.Add("@course", SqlDbType.VarChar).Value = ccombo.Text
        cm.Parameters.Add("@yearlevel", SqlDbType.VarChar).Value = yearcombo.Text
        cm.Parameters.Add("@section", SqlDbType.VarChar).Value = ssectiontext.Text
        Try
            If cm.ExecuteNonQuery Then
                MessageBox.Show("Save Successfully")
                sidtext.Text = ""
                sfnametext.Text = ""
                ccombo.Text = ""
                yearcombo.Text = ""
                ssectiontext.Text = ""
                Form4.User11.studentdata("")
            End If

        Catch ex As Exception
            MessageBox.Show("Please Fill Up Everything")
        End Try
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Call connect()
        Dim cm As New SqlCommand("Update student set name = @name,course = @course,yearlevel = @yearlevel,section = @section where Idnum = @Idnum", conn)
        cm.Parameters.Add("@Idnum", SqlDbType.VarChar).Value = sidtext.Text
        cm.Parameters.Add("@name", SqlDbType.VarChar).Value = sfnametext.Text
        cm.Parameters.Add("@course", SqlDbType.VarChar).Value = ccombo.Text
        cm.Parameters.Add("@yearlevel", SqlDbType.VarChar).Value = yearcombo.Text
        cm.Parameters.Add("@section", SqlDbType.VarChar).Value = ssectiontext.Text
        Try
            If cm.ExecuteNonQuery Then
                MessageBox.Show("Update Successfully")
                sidtext.Text = ""
                sfnametext.Text = ""
                ccombo.Text = ""
                yearcombo.Text = ""
                ssectiontext.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        sidtext.Text = ""
        sfnametext.Text = ""
        ccombo.Text = ""
        yearcombo.Text = ""
        ssectiontext.Text = ""
    End Sub
End Class
