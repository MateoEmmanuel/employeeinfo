Imports MySql.Data.MySqlClient
Module Module1
    Public conn As New MySqlConnection
    Dim dbname As String = "oopdbase"
    Dim server As String = "127.0.0.1"
    Dim uname As String = "root"
    Dim pwd As String = "admin"
    Public Sub dbConnect()
        If Not conn Is Nothing Then
            conn.Close()
            conn.ConnectionString = "server=" & server & "; user id=" & uname & ";password=" & pwd & ";database=" & dbname & ""

            Try
                conn.Open()
                MsgBox("Connected")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
End Module
