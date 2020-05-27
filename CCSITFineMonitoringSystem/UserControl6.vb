Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class UserControl6

    Private Sub UserControl6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adminprof("")
    End Sub
    Public Sub adminprof(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select * from admin where Idnum = '" & Form1.BunifuMetroTextbox1.Text & "'", conn)
        da = New SqlDataAdapter(cm)
        ds = New DataSet
        da.Fill(ds)
        display(ds)
    End Sub
    Public Sub display(ByVal dataset As DataSet)
        Try
            Dim table As DataTable
            table = dataset.Tables(0)
            If table.Rows.Count <> 0 Then
                Label5.Text = Convert.ToString(table.Rows(0)(0))
                Label6.Text = Convert.ToString(table.Rows(0)(1))
                ComboBox1.Text = Convert.ToString(table.Rows(0)(2))
                ComboBox3.Text = Convert.ToString(table.Rows(0)(3))
                BunifuMaterialTextbox3.Text = Convert.ToString(table.Rows(0)(4))
                BunifuMaterialTextbox5.Text = Convert.ToString(table.Rows(0)(5))
                BunifuMaterialTextbox4.Text = Convert.ToString(table.Rows(0)(6))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Call connect()
        Dim cm As New SqlCommand("update admin set course = '" & ComboBox1.Text & "',yearlevel = '" & ComboBox3.Text & "',section = '" & BunifuMaterialTextbox3.Text & "',position = '" & BunifuMaterialTextbox5.Text & "',password = '" & BunifuMaterialTextbox4.Text & "' where Idnum = '" & Label5.Text & "' ", conn)
        Try
            If cm.ExecuteNonQuery Then
                MsgBox("Succesfully Updated")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class
