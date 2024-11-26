<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class intparam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.txtstudid = New System.Windows.Forms.TextBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dateReport1 = New StudentInfoManagement.DateReport()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Student ID"
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(425, 34)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(75, 23)
        Me.btndisplay.TabIndex = 1
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'txtstudid
        '
        Me.txtstudid.Location = New System.Drawing.Point(221, 36)
        Me.txtstudid.Name = "txtstudid"
        Me.txtstudid.Size = New System.Drawing.Size(137, 20)
        Me.txtstudid.TabIndex = 2
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(24, 114)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(736, 324)
        Me.CrystalReportViewer1.TabIndex = 3
        '
        'intparam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.txtstudid)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.Label1)
        Me.Name = "intparam"
        Me.Text = "intparam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btndisplay As Button
    Friend WithEvents txtstudid As TextBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dateReport1 As DateReport
End Class
