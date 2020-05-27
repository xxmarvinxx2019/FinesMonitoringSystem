Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Drawing.Printing
Public Class UserControl5
    Dim s As Integer
    Dim month, semester As String
    Private Sub UserControl5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt4 As String = ""
        Dim dtinfo4 As DateTimeFormatInfo
        Dim dtstyle4 As String = "ddd, dd MMMM yyyy"
        dtinfo4 = DateTimeFormatInfo.InvariantInfo
        dt4 = DateTime.Now.ToString(dtstyle4, dtinfo4)
        Label38.Text = dt4

        Dim dt As String = ""
        Dim dtinfo As DateTimeFormatInfo
        Dim dtstyle As String = "dd"
        dtinfo = DateTimeFormatInfo.InvariantInfo
        dt = DateTime.Now.ToString(dtstyle, dtinfo)
        Label27.Text = dt

        Dim dt1 As String = ""
        Dim dtinfo1 As DateTimeFormatInfo
        Dim dtstyle1 As String = "MMMM"
        dtinfo1 = DateTimeFormatInfo.InvariantInfo
        dt1 = DateTime.Now.ToString(dtstyle1, dtinfo1)
        Label28.Text = dt1
        month = dt1

        Dim dt2 As String = ""
        Dim dtinfo2 As DateTimeFormatInfo
        Dim dtstyle2 As String = "yyyy"
        dtinfo2 = DateTimeFormatInfo.InvariantInfo
        dt2 = DateTime.Now.ToString(dtstyle2, dtinfo2)
        Label29.Text = dt2

        If month = "February" Or month = "March" Or month = "April " Or month = "May" Or month = "June" Or month = "July" Then
            semester = "2nd"
        ElseIf month = "August" Or month = "September" Or month = "October" Or month = "November" Or month = "December" Or month = "January" Then
            semester = "1st"
        End If


        BunifuMetroTextbox1.Text = 0
        BunifuMetroTextbox3.Text = 0
        BunifuMetroTextbox4.Text = 0
        BunifuMetroTextbox5.Text = 0
    End Sub
    Public Sub attendancelist(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select eventday,eventfines,stat from attendance  where Idnum = '" & BunifuMetroTextbox2.Text & "' and yearofevent = '" & Label29.Text & "' and sem = '" & semester & "'", conn)
        da = New SqlDataAdapter(cm)
        ds = New DataSet
        If da.Fill(ds) Then
            MsgBox("Record Found!")
            BunifuCustomDataGrid2.DataSource = ds.Tables(0)
        Else
            BunifuCustomDataGrid2.DataSource = ds.Tables(0)
        End If
    End Sub
    Public Sub over(valuetosearch As String)
        Call connect()
        Dim p As String
        Dim index As Integer
        index = BunifuCustomDataGrid2.CurrentRow.Index
        p = "paid"
        Dim cmd As New SqlCommand("update attendance set stat = '" & p & "',logins = 'present',logout = 'present',eventfines = 0 where  Idnum = '" & BunifuMetroTextbox2.Text & "' and yearofevent = '" & Label29.Text & "' and sem = '" & semester & "'", conn)
        Try
            If cmd.ExecuteNonQuery Then
                MsgBox("Paid", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub sum(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select SUM(eventfines) from attendance  where Idnum = '" & BunifuMetroTextbox2.Text & "' and yearofevent = '" & Label29.Text & "' and sem = '" & semester & "'", conn)
        dr = cm.ExecuteReader
        Dim total As String
        Try
            If dr.Read Then
                total = dr.GetValue(0)
                Label31.Text = (total + ".00")
                s = dr.GetValue(0)
                conn.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub printText(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        e.Graphics.DrawString(Label13.Text, New Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, New Point(20, 5))
        e.Graphics.DrawString(Label5.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(5, 15))
        e.Graphics.DrawString(Label6.Text, New Font("Century Gothic", 7, FontStyle.Regular), Brushes.Black, New Point(10, 25))
        e.Graphics.DrawString(Label14.Text, New Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, New Point(15, 40))
        e.Graphics.DrawString(Label15.Text, New Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, New Point(17, 50))
        e.Graphics.DrawString(Label39.Text, New Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, New Point(45, 60))
        e.Graphics.DrawString(Label2.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(10, 80))
        e.Graphics.DrawString(Label20.Text, New Font("Century Gothic", 9, FontStyle.Bold), Brushes.Black, New Point(130, 80))
        e.Graphics.DrawString(Label37.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(20, 100))
        e.Graphics.DrawString(Label38.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(60, 100))
        e.Graphics.DrawString(Label7.Text, New Font("Century Gothic", 9, FontStyle.Bold), Brushes.Black, New Point(20, 120))
        e.Graphics.DrawString(Label21.Text, New Font("Century Gothic", 9, FontStyle.Bold), Brushes.Black, New Point(120, 120))
        e.Graphics.DrawString(Label1.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(20, 140))
        e.Graphics.DrawString(Label9.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(120, 140))
        e.Graphics.DrawString(Label16.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(20, 160))
        e.Graphics.DrawString(Label8.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(120, 160))
        e.Graphics.DrawString(Label17.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(20, 180))
        e.Graphics.DrawString(Label33.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(120, 180))
        e.Graphics.DrawString(Label18.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(20, 200))
        e.Graphics.DrawString(Label34.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(120, 200))
        e.Graphics.DrawString(Label19.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(20, 220))
        e.Graphics.DrawString(Label35.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(120, 220))
        e.Graphics.DrawString(Label10.Text, New Font("Century Gothic", 9, FontStyle.Bold), Brushes.Black, New Point(20, 260))
        e.Graphics.DrawString(Label11.Text, New Font("Century Gothic", 9, FontStyle.Bold), Brushes.Black, New Point(120, 260))
        e.Graphics.DrawString(Label36.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(40, 300))
        e.Graphics.DrawString(Label22.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(60, 315))
    End Sub

    Public Sub printview(valuetosearch As String)
        Dim b, c, d, e, f, total As Integer
        Dim b1, b2, b3, b4 As String
        b1 = BunifuMetroTextbox3.Text
        b2 = BunifuMetroTextbox4.Text
        b3 = BunifuMetroTextbox1.Text
        b4 = BunifuMetroTextbox5.Text
        Label20.Text = BunifuMetroTextbox2.Text
        Label9.Text = (b1 + ".00")
        Label8.Text = Label31.Text
        Label33.Text = (b2 + ".00")
        Label34.Text = (b3 + ".00")
        Label35.Text = (b4 + ".00")
        b = BunifuMetroTextbox3.Text
        c = s
        d = BunifuMetroTextbox4.Text
        e = BunifuMetroTextbox1.Text
        f = BunifuMetroTextbox5.Text
        total = b + c + d + e + f
        Label11.Text = total
        BunifuFlatButton3.Cursor = Cursors.Hand
        BunifuFlatButton3.Enabled = True
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        attendancelist("")
        sum("")
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim rep As DialogResult
        rep = MessageBox.Show("Do you want to Proceed?", "CCSIT Fines Monitoring System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Call connect()
            Dim p As String = "paid"
            Dim cmd As New SqlCommand("insert into fines(Idnum,daypaid,monthpaid,yearofpayment,sempaid,overallfines,semdue,tshirt,contribution,others,stat) values(@Idnum,@daypaid,@monthpaid,@yearofpayment,@sempaid,@overallfines,@semdue,@tshirt,@contribution,@others,@stat)", conn)
            cmd.Parameters.Add("@Idnum", SqlDbType.VarChar).Value = BunifuMetroTextbox2.Text
            cmd.Parameters.Add("@daypaid", SqlDbType.VarChar).Value = Label27.Text
            cmd.Parameters.Add("@monthpaid", SqlDbType.VarChar).Value = Label28.Text
            cmd.Parameters.Add("@yearofpayment", SqlDbType.VarChar).Value = Label29.Text
            cmd.Parameters.Add("@sempaid", SqlDbType.VarChar).Value = semester
            cmd.Parameters.Add("@overallfines", SqlDbType.Int).Value = s
            cmd.Parameters.Add("@semdue", SqlDbType.Int).Value = BunifuMetroTextbox3.Text
            cmd.Parameters.Add("@tshirt", SqlDbType.Int).Value = BunifuMetroTextbox4.Text
            cmd.Parameters.Add("@contribution", SqlDbType.Int).Value = BunifuMetroTextbox1.Text
            cmd.Parameters.Add("@others", SqlDbType.Int).Value = BunifuMetroTextbox5.Text
            cmd.Parameters.Add("@stat", SqlDbType.VarChar).Value = p
            Try
                If cmd.ExecuteNonQuery Then
                    printview("")
                    over("")
                    MessageBox.Show("Print receipt", "CCSIT Fines Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    sum("")
                    BunifuMetroTextbox2.Text = ""
                    BunifuMetroTextbox1.Text = "0"
                    BunifuMetroTextbox3.Text = "0"
                    BunifuMetroTextbox4.Text = "0"
                    BunifuMetroTextbox5.Text = "0"
                    Label31.Text = "0.00"
                    attendancelist("")

                End If
            Catch ex As Exception
                MessageBox.Show("Make Sure to input correct ID Number")
                BunifuMetroTextbox2.Text = ""
                BunifuMetroTextbox1.Text = "0"
                BunifuMetroTextbox3.Text = "0"
                BunifuMetroTextbox4.Text = "0"
                BunifuMetroTextbox5.Text = "0"
                attendancelist("")
            End Try
        Else
            BunifuMetroTextbox2.Text = ""
            BunifuMetroTextbox1.Text = "0"
            BunifuMetroTextbox3.Text = "0"
            BunifuMetroTextbox4.Text = "0"
            BunifuMetroTextbox5.Text = "0"
            attendancelist("")

        End If
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        BunifuMetroTextbox2.Text = ""
        BunifuMetroTextbox1.Text = "0"
        BunifuMetroTextbox3.Text = "0"
        BunifuMetroTextbox4.Text = "0"
        BunifuMetroTextbox5.Text = "0"
        Label31.Text = "0.00"
        attendancelist("")
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Try
            Dim PrintDoc As New PrintDocument
            AddHandler PrintDoc.PrintPage, AddressOf Me.printText
            PrintDoc.Print()
            PrintPreviewDialog1.ShowDialog()
            BunifuMetroTextbox2.Text = ""
            BunifuMetroTextbox1.Text = "0"
            BunifuMetroTextbox3.Text = "0"
            BunifuMetroTextbox4.Text = "0"
            BunifuMetroTextbox5.Text = "0"
            Label31.Text = "0.00"
            BunifuFlatButton3.Cursor = Cursors.No
            BunifuFlatButton3.Enabled = False
            Label20.Text = "00000-0"
            Label9.Text = "0.00"
            Label8.Text = "0.00"
            Label33.Text = "0.00"
            Label34.Text = "0.00"
            Label35.Text = "0.00"
            Label11.Text = "0.00"
            attendancelist("")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            e.Graphics.DrawString(Label13.Text, New Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, New Point(20, 5))
            e.Graphics.DrawString(Label5.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(5, 15))
            e.Graphics.DrawString(Label6.Text, New Font("Century Gothic", 7, FontStyle.Regular), Brushes.Black, New Point(10, 25))
            e.Graphics.DrawString(Label14.Text, New Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, New Point(15, 40))
            e.Graphics.DrawString(Label15.Text, New Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, New Point(17, 50))
            e.Graphics.DrawString(Label39.Text, New Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, New Point(45, 60))
            e.Graphics.DrawString(Label2.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(10, 80))
            e.Graphics.DrawString(Label20.Text, New Font("Century Gothic", 9, FontStyle.Bold), Brushes.Black, New Point(130, 80))
            e.Graphics.DrawString(Label37.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(30, 100))
            e.Graphics.DrawString(Label38.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(80, 100))
            e.Graphics.DrawString(Label7.Text, New Font("Century Gothic", 9, FontStyle.Bold), Brushes.Black, New Point(20, 120))
            e.Graphics.DrawString(Label21.Text, New Font("Century Gothic", 9, FontStyle.Bold), Brushes.Black, New Point(120, 120))
            e.Graphics.DrawString(Label1.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(20, 140))
            e.Graphics.DrawString(Label9.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(120, 140))
            e.Graphics.DrawString(Label16.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(20, 160))
            e.Graphics.DrawString(Label8.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(120, 160))
            e.Graphics.DrawString(Label17.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(20, 180))
            e.Graphics.DrawString(Label33.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(120, 180))
            e.Graphics.DrawString(Label18.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(20, 200))
            e.Graphics.DrawString(Label34.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(120, 200))
            e.Graphics.DrawString(Label19.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(20, 220))
            e.Graphics.DrawString(Label35.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(120, 220))
            e.Graphics.DrawString(Label10.Text, New Font("Century Gothic", 9, FontStyle.Bold), Brushes.Black, New Point(20, 260))
            e.Graphics.DrawString(Label11.Text, New Font("Century Gothic", 9, FontStyle.Bold), Brushes.Black, New Point(120, 260))
            e.Graphics.DrawString(Label36.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(40, 300))
            e.Graphics.DrawString(Label22.Text, New Font("Century Gothic", 9, FontStyle.Regular), Brushes.Black, New Point(60, 315))
        Catch ex As Exception

        End Try
    End Sub
End Class
