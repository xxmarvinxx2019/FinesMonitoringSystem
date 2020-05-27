Imports System.Data.SqlClient

Public Class User1
    Dim it As Integer
    Dim year As String
    Private Sub User1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eventdata("")
        studentdata("")
        fines("")
    End Sub
    Public Sub fines(valuetosearch As String)
        Call connect()
        Dim rs As SqlDataReader
        Dim cmd1 As New SqlCommand("SELECT eventfines from eventst where eventday = '" & ComboBox1.Text & "'", conn)
        rs = cmd1.ExecuteReader
        If rs.HasRows Then
            While rs.Read
                it = rs.Item("eventfines")
            End While
        End If
    End Sub
    Public Sub eventdata(valuetosearch As String)
        Call connect()
        Dim n As String = "On"
        Dim cm As New SqlCommand("select eventday,yearofevent,sem from eventst where stat = '" & n & "'", conn)
        da = New SqlDataAdapter(cm)
        Dim table As New DataTable
        da.Fill(table)
        ComboBox1.DataSource = table
        ComboBox3.DataSource = table
        semtext1.DataSource = table
        semtext1.DisplayMember = "sem"
        semtext1.ValueMember = "sem"
        ComboBox3.DisplayMember = "yearofevent"
        ComboBox3.ValueMember = "yearofevent"
        ComboBox1.DisplayMember = "eventday"
        ComboBox1.ValueMember = "eventday"
    End Sub
    Public Sub studentdata(valuetosearch As String)
        Dim n As String = "On"
        Call connect()
        Dim cm As New SqlCommand("select * from student where stat = '" & n & "' order by section,yearlevel,Idnum asc", conn)
        da = New SqlDataAdapter(cm)
        ds = New DataSet
        da.Fill(ds)
        BunifuCustomDataGrid2.DataSource = ds.Tables(0)
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Form4.UserControl41.BringToFront()
        Form4.Panel3.BackColor = Color.White
        Form4.BunifuFlatButton11.BringToFront()
        Form4.BunifuFlatButton10.BringToFront()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Call connect()
        Try
            For i As Integer = 0 To BunifuCustomDataGrid2.Rows.Count() - 1 Step +1
                Dim cm As New SqlCommand("INSERT INTO attendance(Idnum,name,eventday,yearofevent,sem,eventfines) VALUES(@Idnum,@name,@eventday,@yearofevent,@sem,@eventfines)", conn)
                cm.Parameters.Add("@Idnum", SqlDbType.VarChar).Value = BunifuCustomDataGrid2.Item(0, i).Value
                cm.Parameters.Add("@name", SqlDbType.VarChar).Value = BunifuCustomDataGrid2.Item(1, i).Value
                cm.Parameters.Add("@eventday", SqlDbType.VarChar).Value = ComboBox1.Text
                cm.Parameters.Add("@yearofevent", SqlDbType.Int).Value = ComboBox3.Text
                cm.Parameters.Add("@sem", SqlDbType.VarChar).Value = semtext1.Text
                cm.Parameters.Add("@eventfines", SqlDbType.Int).Value = it
                cm.ExecuteNonQuery()
            Next
            Dim cmd As New SqlCommand("update eventst set stat = 'off' where eventday = '" & ComboBox1.Text & "' and yearofevent = '" & ComboBox3.Text & "' and sem = '" & semtext1.Text & "'", conn)
            Try
                If cmd.ExecuteNonQuery Then
                    MsgBox("Successfully Added")
                    ComboBox1.Text = ""
                    ComboBox3.Text = ""
                    semtext1.Text = ""
                    eventdata("")
                    fines("")
                End If
                studentdata("")
            Catch ex As Exception
                MsgBox("Error")
            End Try
        Catch ex As exception
            MessageBox.Show("Error")
        End Try
    End Sub

End Class
