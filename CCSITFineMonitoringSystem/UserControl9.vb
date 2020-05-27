Imports System.Data.SqlClient
Public Class UserControl9

    Public Sub studentdata(valuetosearch As String)
        Dim n As String = "On"
        Call connect()
        Dim cm As New SqlCommand("select * from student where course = '" & ComboBox2.Text & "' and yearlevel = '" & ComboBox5.Text & "' and section = '" & BunifuMaterialTextbox4.Text & "' and stat = '" & n & "'", conn)
        da = New SqlDataAdapter(cm)
        ds = New DataSet
        da.Fill(ds)
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
    End Sub
    Public Sub studentdata1(valuetosearch As String)
        Dim n As String = "On"
        Call connect()
        Dim cm As New SqlCommand("select * from student where stat = '" & n & "' order by yearlevel,section asc", conn)
        da = New SqlDataAdapter(cm)
        ds = New DataSet
        da.Fill(ds)
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
    End Sub
    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        studentdata("")
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        BunifuMaterialTextbox4.Text = ""
        ComboBox5.Text = ""
        ComboBox2.Text = ""
        studentdata1("")
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick, BunifuCustomDataGrid1.CellClick
        Dim index As Integer
        index = BunifuCustomDataGrid1.CurrentRow.Index

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Call connect()
        Try
            build = New SqlCommandBuilder(da)
            If da.Update(ds) Then
                MsgBox("Updated")
                studentdata1("")
                studentdata("")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim rep As DialogResult
        rep = MessageBox.Show("Are you sure you want to delete this account?", "Yes or No?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Call connect()
            Dim index As Integer
            index = BunifuCustomDataGrid1.CurrentRow.Index
            Dim cm As New SqlCommand("update student set stat = 'Off' where Idnum = '" & BunifuCustomDataGrid1.Item(0, index).Value & "'", conn)
            Try
                If cm.ExecuteNonQuery Then
                    MsgBox("Deleted")
                    Form4.User11.studentdata("")

                End If
                studentdata("")
                studentdata1("")
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
    End Sub

    Private Sub UserControl9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentdata1("")
    End Sub
End Class
