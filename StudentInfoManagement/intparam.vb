Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class intparam
    Private Sub intparam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        Dim report As New ReportDocument
        report.Load("C:\Users\SANDBOX-17\source\repos\MateoEmmanuel\StudentInfoManagement\StudentInfoManagement\DateReport.rpt")
        Dim pfDefinitions As ParameterFieldDefinitions
        Dim pfDefinition As ParameterFieldDefinition
        Dim rParamValues As ParameterValues
        Dim rpDiscreteVal As New ParameterDiscreteValue

        rpDiscreteVal.Value = Convert.ToInt32(txtstudid.Text)
        pfDefinitions = report.DataDefinition.ParameterFields
        pfDefinition = pfDefinitions.Item("Studid")
        rParamValues = pfDefinition.CurrentValues
        rParamValues.Clear()
        rParamValues.Add(rpDiscreteVal)
        pfDefinition.ApplyCurrentValues(rParamValues)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub
End Class