Imports System.IO
Imports System.Globalization
Public Class UserControl3

    Private Sub UserControl3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Function myzero(ByVal value As Integer) As String
        Return value.ToString().PadLeft(2, "0")
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim txt As String = ""
        txt &= myzero(DateTime.Now.Hour)
        txt &= ":" & myzero(DateTime.Now.Minute)
        txt &= ":" & myzero(DateTime.Now.Second)
        Label17.Text = txt
        Dim dt As String = ""
        Dim dtinfo As DateTimeFormatInfo
        Dim dtstyle As String = "ddd, dd MMMM yyyy"
        dtinfo = DateTimeFormatInfo.InvariantInfo
        dt = DateTime.Now.ToString(dtstyle, dtinfo)
        Label1.Text = dt
    End Sub

End Class
