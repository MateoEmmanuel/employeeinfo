Imports MySql.Data.MySqlClient
Public Class Form2
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim fname As String
    Dim username As String
    Dim password As String
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        fname = txtfullname.Text
        username = txtusername.Text
        password = txtpassword.Text
        Try
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO studinfo" & "(fullname, username, password)" & "VALUES('" & fname & "','" & username & "','" & password & "')"
                result = .ExecuteNonQuery
                If result > 0 Then
                    MsgBox("Record inserted succesfully")
                Else
                    MsgBox("insertion failed")
                End If
                clearData()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbConnect()
    End Sub
    Public Sub clearData()
        txtfullname.Clear()
        txtpassword.Clear()
        txtusername.Clear()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class