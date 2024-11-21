Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form4

    Private Sub btnseearch_Click(sender As Object, e As EventArgs) Handles btnseearch.Click
        Dim report As New ReportDocument
        report.Load("")
        Dim cParamFieldDefinitions As ParameterFieldDefinitions
        Dim cParamFieldDefinition As ParameterFieldDefinition
        Dim cParamValues As New ParameterValues
        Dim cParamDiscreteValue As New ParameterDiscreteValue
        'parameter discretevalues'
        cParamDiscreteValue.Value = txtdata.Text
        cParamFieldDefinitions = report.DataDefinition.ParameterFields
        cParamFieldDefinition = cParamFieldDefinitions.Item("username")
        cParamValues = cParamFieldDefinition.CurrentValues
        cParamValues.Clear()
        cParamValues.Add(cParamDiscreteValue)
        cParamFieldDefinition.ApplyCurrentValues(cParamValues)
        CrystalReportViewer1.ReportSource = report \
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
End Class