Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient
Public Class Form1

    Dim str As String

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        dbConnect()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Try
            str = "SELECT * FROM studinfo"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dataRecord.DataSource = dt
            dataRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbConnect()
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Form3.Show()
        Dim reports As New ReportDocument
        reports.Load("C:\Users\SANDBOX-17\Source\Repos\frncs04\StudentInfoManagement\StudentInfoManagement\studentList.rpt")
        Form3.CrystalReportViewer1.ReportSource = reports
        Form3.CrystalReportViewer1.Refresh()
    End Sub
End Class
