Imports System.Data.SqlClient
Imports System.Globalization

Public Class UserControl4
    Dim s As Integer
    Dim eventfines As Integer
    Dim year As String
    Dim semester As String
    Dim month As String
    Private Sub UserControl4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt2 As String = ""
        Dim dtinfo2 As DateTimeFormatInfo
        Dim dtstyle2 As String = "yyyy"
        dtinfo2 = DateTimeFormatInfo.InvariantInfo
        dt2 = DateTime.Now.ToString(dtstyle2, dtinfo2)
        year = dt2

        Dim dt3 As String = ""
        Dim dtinfo3 As DateTimeFormatInfo
        Dim dtstyle3 As String = "MMMM"
        dtinfo3 = DateTimeFormatInfo.InvariantInfo
        dt3 = DateTime.Now.ToString(dtstyle3, dtinfo3)
        month = dt3
        If month = "January" Or month = "February" Or month = "March" Or month = "April " Or month = "May" Then
            semester = "2nd"
        ElseIf month = "August" Or month = "September" Or month = "October" Or month = "November" Or month = "December" Then
            semester = "1st"
        End If
        eventdata1("")
    End Sub
    Public Sub eventdata1(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select eventday from eventst where yearofevent = '" & year & "' and sem = '" & semester & "'", conn)
        da = New SqlDataAdapter(cm)
        Dim table As New DataTable
        da.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "eventday"
        ComboBox1.ValueMember = "eventday"
    End Sub
    Public Sub attendancelist(valuetosearch As String)
        Call connect()
        Dim cm As New SqlCommand("select attendance.Idnum,attendance.name,attendance.logins,attendance.logout from attendance inner join student on attendance.Idnum = student.Idnum where student.section = '" & BunifuMetroTextbox2.Text & "' and student.yearlevel = '" & semtext1.Text & "' and student.course = '" & ComboBox2.Text & "' and attendance.eventday = '" & ComboBox1.Text & "' and attendance.yearofevent = '" & year & "' and attendance.sem = '" & semester & "' order by Idnum", conn)
        da = New SqlDataAdapter(cm)
        ds = New DataSet
        If da.Fill(ds) Then
            BunifuCustomDataGrid2.DataSource = ds.Tables(0)
        Else
            MsgBox("No Record Found!")
            BunifuCustomDataGrid2.DataSource = ds.Tables(0)
        End If
    End Sub
    Public Sub attupdate(valuetosearch As String)
        Call connect()
        Dim p As String
        p = "paid"
        Dim cmd As New SqlCommand("update attendance set stat = '" & p & "' where  Idnum = '" & BunifuMetroTextbox1.Text & "' and eventday = '" & ComboBox1.Text & "' and yearofevent = '" & year & "' and sem = '" & semester & "' and eventfines = 0", conn)
        Try
            If cmd.ExecuteNonQuery Then
                attendancelist("")
                MsgBox("Updated")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        attendancelist("")
        Call connect()
        Dim cm As New SqlCommand("select eventfines from attendance  where eventday = '" & ComboBox1.Text & "' and yearofevent = '" & year & "'and sem = '" & semester & "' and stat = 'unpaid'", conn)
        dr = cm.ExecuteReader
        If dr.Read Then
            s = dr.GetValue(0)
        End If
        eventfines = s / 2

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        BunifuMetroTextbox2.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        semtext1.Text = ""
        BunifuCheckbox1.Checked = False
        BunifuCheckbox2.Checked = False
        BunifuMetroTextbox1.Text = ""
        attendancelist("")
        eventdata1("")
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Call connect()
        Dim p As String
        p = "present"
        If BunifuMetroTextbox1.Text = "" Then
            MessageBox.Show("Enter ID Number")
        Else
            If BunifuCheckbox1.Checked = True Then
                Dim cmd As New SqlCommand("update attendance set logins = @logins,eventfines = eventfines -'" & eventfines & "' where  Idnum = '" & BunifuMetroTextbox1.Text & "' and eventday = '" & ComboBox1.Text & "' and yearofevent = '" & year & "' and sem = '" & semester & "'", conn)
                cmd.Parameters.Add("@logins", SqlDbType.VarChar).Value = p
                Try
                    If cmd.ExecuteNonQuery Then
                        attendancelist("")
                    End If
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
            If BunifuCheckbox2.Checked = True Then
                Dim cmd As New SqlCommand("update attendance set logout = @logout,eventfines = eventfines-'" & eventfines & "' where  Idnum = '" & BunifuMetroTextbox1.Text & "' and eventday = '" & ComboBox1.Text & "' and yearofevent = '" & year & "' and sem = '" & semester & "'", conn)
                cmd.Parameters.Add("@logout", SqlDbType.VarChar).Value = p
                Try
                    If cmd.ExecuteNonQuery Then
                        attendancelist("")
                    End If
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
            If BunifuCheckbox1.Checked = True And BunifuCheckbox2.Checked = True Then
                Dim cmd As New SqlCommand("update attendance set logins = @logins,logout = @logout,eventfines = 0 where  Idnum = '" & BunifuMetroTextbox1.Text & "' and eventday = '" & ComboBox1.Text & "' and yearofevent = '" & year & "' and sem = '" & semester & "'", conn)
                cmd.Parameters.Add("@logins", SqlDbType.VarChar).Value = p
                cmd.Parameters.Add("@logout", SqlDbType.VarChar).Value = p
                Try
                    If cmd.ExecuteNonQuery Then
                        attendancelist("")
                    End If
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
            attupdate("")
        End If
            
    End Sub

End Class
