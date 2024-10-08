Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As New MySqlConnection
    Dim str As String
    Dim dbname As String = "pacedDB"
    Dim server As String = "127.0.0.1"
    Dim uname As String = "root"
    Dim pwd As String = ""

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        If Not conn Is Nothing Then
            conn.Close()
            conn.ConnectionString = "server=" & server & "; user id=" & uname & ";password=" & pwd & ";database=" & dbname & ""

            Try
                conn.Open()
                MsgBox("Connected")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()

        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Try
            str = "SELECT * FROM studinfo"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable
            da.Fill(dt)
            dataRecord.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

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
            conn.Close()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbConnect()
    End Sub
End Class
