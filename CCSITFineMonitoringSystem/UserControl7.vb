Imports System.Data.SqlClient

Public Class UserControl7
    Dim s, o, c, t, ot, total As Integer
    Public Sub sumsem(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select SUM(semdue),SUM(overallfines),SUM(contribution),SUM(tshirt),SUM(others) from fines where daypaid = '" & daytext.Text & "' and monthpaid = '" & monthtext.Text & "' and yearofpayment = '" & yeartext.Text & "'", conn)
        dr = cm.ExecuteReader
        Try
            If dr.Read Then
                MsgBox("Record Found")
                Label15.Text = dr.GetValue(0)
                Label16.Text = dr.GetValue(1)
                Label17.Text = dr.GetValue(2)
                Label18.Text = dr.GetValue(3)
                Label19.Text = dr.GetValue(4)
                s = dr.GetValue(0)
                o = dr.GetValue(1)
                c = dr.GetValue(2)
                t = dr.GetValue(3)
                ot = dr.GetValue(4)
                total = s + o + c + t + ot
                Label20.Text = total
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("No Record Found!")
            Label15.Text = "0.0"
            Label16.Text = "0.0"
            Label17.Text = "0.0"
            Label18.Text = "0.0"
            Label19.Text = "0.0"
            Label20.Text = "0.0"
        End Try
    End Sub
    Public Sub sumsem1(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select SUM(semdue),SUM(overallfines),SUM(contribution),SUM(tshirt),SUM(others) from fines where sempaid = '" & ComboBox2.Text & "' and yearofpayment = '" & BunifuMetroTextbox1.Text & "' ", conn)
        dr = cm.ExecuteReader
        Try
            If dr.Read Then

                Label15.Text = dr.GetValue(0)
                Label16.Text = dr.GetValue(1)
                Label17.Text = dr.GetValue(2)
                Label18.Text = dr.GetValue(3)
                Label19.Text = dr.GetValue(4)
                s = dr.GetValue(0)
                o = dr.GetValue(1)
                c = dr.GetValue(2)
                t = dr.GetValue(3)
                ot = dr.GetValue(4)
                total = s + o + c + t + ot
                Label20.Text = total
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("No Record Found!")
            Label15.Text = "0.0"
            Label16.Text = "0.0"
            Label17.Text = "0.0"
            Label18.Text = "0.0"
            Label19.Text = "0.0"
            Label20.Text = "0.0"
        End Try
    End Sub
    Public Sub sumsem2(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select SUM(semdue),SUM(overallfines),SUM(contribution),SUM(tshirt),SUM(others) from fines where yearofpayment = '" & BunifuMetroTextbox3.Text & "' ", conn)
        dr = cm.ExecuteReader
        Try
            If dr.Read Then

                Label15.Text = dr.GetValue(0)
                Label16.Text = dr.GetValue(1)
                Label17.Text = dr.GetValue(2)
                Label18.Text = dr.GetValue(3)
                Label19.Text = dr.GetValue(4)
                s = dr.GetValue(0)
                o = dr.GetValue(1)
                c = dr.GetValue(2)
                t = dr.GetValue(3)
                ot = dr.GetValue(4)
                total = s + o + c + t + ot
                Label20.Text = total
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("No Record Found!")
            Label15.Text = "0.0"
            Label16.Text = "0.0"
            Label17.Text = "0.0"
            Label18.Text = "0.0"
            Label19.Text = "0.0"
            Label20.Text = "0.0"
        End Try
    End Sub
    Public Sub searchday(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select Idnum,overallfines,semdue,tshirt,contribution,others from fines where daypaid = '" & daytext.Text & "' and monthpaid = '" & monthtext.Text & "' and yearofpayment = '" & yeartext.Text & "' order by Idnum ASC", conn)
        da = New SqlDataAdapter(cm)
        ds = New DataSet

        da.Fill(ds)
        BunifuCustomDataGrid2.DataSource = ds.Tables(0)

    End Sub
    Public Sub searchday1(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select Idnum,overallfines,semdue,tshirt,contribution,others from fines where sempaid = '" & ComboBox2.Text & "' and yearofpayment = '" & BunifuMetroTextbox1.Text & "' order by Idnum ASC", conn)
        da = New SqlDataAdapter(cm)
        ds = New DataSet
        da.Fill(ds)

        BunifuCustomDataGrid2.DataSource = ds.Tables(0)
    End Sub
    Public Sub searchday2(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select Idnum,overallfines,semdue,tshirt,contribution,others from fines where yearofpayment = '" & BunifuMetroTextbox3.Text & "' order by Idnum ASC", conn)
        da = New SqlDataAdapter(cm)
        ds = New DataSet
        da.Fill(ds)
        BunifuCustomDataGrid2.DataSource = ds.Tables(0)
    End Sub
    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        searchday("")
        sumsem("")
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        searchday1("")
        sumsem1("")
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        searchday2("")
        sumsem2("")
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        daytext.Text = ""
        monthtext.Text = "Month"
        yeartext.Text = "Year"
        ComboBox2.Text = ""
        BunifuMetroTextbox1.Text = ""
        BunifuMetroTextbox3.Text = ""

        Label15.Text = "0.0"
        Label16.Text = "0.0"
        Label17.Text = "0.0"
        Label18.Text = "0.0"
        Label19.Text = "0.0"
        Label20.Text = "0.0"

        searchday("")
        searchday1("")
        searchday2("")
        daytext.Text = "Day"
    End Sub

End Class
