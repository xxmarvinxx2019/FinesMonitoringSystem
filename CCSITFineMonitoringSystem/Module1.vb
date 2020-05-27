Imports System.Data.SqlClient

Module Module1
    Public conn As SqlConnection
    Public str As String
    Public da As SqlDataAdapter
    Public da1 As SqlDataAdapter
    Public ds As New DataSet
    Public dr As SqlDataReader
    Public build As SqlCommandBuilder
    Sub connect()
        str = "Data Source=MARVIN\SQLEXPRESS;Database = ccsitfines1;Integrated Security = true"
        conn = New SqlConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
