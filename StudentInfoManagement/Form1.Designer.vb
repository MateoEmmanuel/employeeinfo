<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.dataRecord = New System.Windows.Forms.DataGridView()
        Me.btnprint = New System.Windows.Forms.Button()
        CType(Me.dataRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncheck
        '
        Me.btncheck.Location = New System.Drawing.Point(48, 64)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(178, 23)
        Me.btncheck.TabIndex = 0
        Me.btncheck.Text = "Check Connection"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(92, 165)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "Add User"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(69, 257)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(121, 23)
        Me.btnload.TabIndex = 2
        Me.btnload.Text = "Load Record"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(92, 334)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'dataRecord
        '
        Me.dataRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataRecord.Location = New System.Drawing.Point(308, 51)
        Me.dataRecord.Name = "dataRecord"
        Me.dataRecord.Size = New System.Drawing.Size(519, 358)
        Me.dataRecord.TabIndex = 4
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(64, 405)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(126, 23)
        Me.btnprint.TabIndex = 5
        Me.btnprint.Text = "Print Master List"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 483)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.dataRecord)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btncheck)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btncheck As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnload As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents dataRecord As DataGridView
    Friend WithEvents btnprint As Button
End Class
