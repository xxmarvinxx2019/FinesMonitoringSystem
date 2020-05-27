Imports System.Data.SqlClient
Public Class UserControl2

    Public Sub eventdata(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select * from eventst where yearofevent = '" & ComboBox1.Text & "'", conn)
        da = New SqlDataAdapter(cm)

        ds = New DataSet
        da.Fill(ds)
        BunifuCustomDataGrid2.DataSource = ds.Tables(0)
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
            Call connect()
            Dim cm As New SqlCommand("INSERT INTO eventst(eventday,dateofevent,monthofevent,yearofevent,eventfines,sem) VALUES(@eventday,@dateofevent,@monthofevent,@yearofevent,@eventfines,@sem)", conn)
            cm.Parameters.Add("@eventday", SqlDbType.VarChar).Value = eventtext.Text
            cm.Parameters.Add("@dateofevent", SqlDbType.VarChar).Value = daytext.Text
            cm.Parameters.Add("@monthofevent", SqlDbType.VarChar).Value = monthtext.Text
            cm.Parameters.Add("@yearofevent", SqlDbType.VarChar).Value = yeartext.Text
            cm.Parameters.Add("@eventfines", SqlDbType.VarChar).Value = finestext.Text
            cm.Parameters.Add("@sem", SqlDbType.VarChar).Value = semtext.Text
            Try
                If cm.ExecuteNonQuery Then
                    MessageBox.Show("Save Successfully")
                    eventtext.Text = ""
                    daytext.Text = "Day"
                    monthtext.Text = "Month"
                    yeartext.Text = "Year"
                    finestext.Text = ""
                    semtext.Text = ""
                    Form4.User11.eventdata("")
                    Form4.UserControl41.eventdata1("")
                End If

            Catch ex As Exception
            MessageBox.Show("Error")
            End Try
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        eventdata("")
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        eventtext.Text = ""
        semtext.Text = ""
        finestext.Text = ""
        daytext.Text = "Day"
        monthtext.Text = "Month"
        yeartext.Text = "Year"
        ComboBox1.Text = ""
        eventdata("")
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Form4.User11.BringToFront()
        Form4.User11.fines("")
        Form4.Panel3.BackColor = Color.White
        Form4.BunifuFlatButton11.BringToFront()
        Form4.BunifuFlatButton10.BringToFront()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim rep As DialogResult
        rep = MessageBox.Show("Do you want to Proceed?", "CCSIT Fines Monitoring System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Call connect()
            Dim cm As New SqlCommand("delete from eventst where eventday = @eventday and yearofevent = @yearofevent and sem = @sem", conn)
            cm.Parameters.Add("@eventday", SqlDbType.VarChar).Value = eventtext.Text
            cm.Parameters.Add("@yearofevent", SqlDbType.VarChar).Value = yeartext.Text
            cm.Parameters.Add("@sem", SqlDbType.VarChar).Value = semtext.Text
            Try
                If cm.ExecuteNonQuery Then
                    MessageBox.Show("Deleted")
                    eventtext.Text = ""
                    daytext.Text = ""
                    monthtext.Text = ""
                    yeartext.Text = ""
                    finestext.Text = ""
                    semtext.Text = ""
                    eventdata("")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            eventtext.Text = ""
            yeartext.Text = ""
            semtext.Text = ""
            monthtext.Text = ""
            daytext.Text = ""
            finestext.Text = ""
        End If
    End Sub

    Private Sub BunifuCustomDataGrid2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid2.CellContentClick, BunifuCustomDataGrid2.CellClick
        Dim index As Integer
        index = BunifuCustomDataGrid2.CurrentRow.Index
        eventtext.Text = BunifuCustomDataGrid2.Item(0, index).Value
        daytext.Text = BunifuCustomDataGrid2.Item(1, index).Value
        monthtext.Text = BunifuCustomDataGrid2.Item(2, index).Value
        yeartext.Text = BunifuCustomDataGrid2.Item(3, index).Value
        semtext.Text = BunifuCustomDataGrid2.Item(4, index).Value
        finestext.Text = BunifuCustomDataGrid2.Item(5, index).Value
    End Sub

End Class
