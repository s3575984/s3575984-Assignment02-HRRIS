<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport1
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
        Me.boxCusId = New System.Windows.Forms.ComboBox()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.lblCusId = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'boxCusId
        '
        Me.boxCusId.FormattingEnabled = True
        Me.boxCusId.Location = New System.Drawing.Point(127, 105)
        Me.boxCusId.Name = "boxCusId"
        Me.boxCusId.Size = New System.Drawing.Size(121, 21)
        Me.boxCusId.TabIndex = 0
        '
        'lblReport
        '
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(12, 23)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(260, 59)
        Me.lblReport.TabIndex = 2
        Me.lblReport.Text = "This report will show when was the last time a booking made and for how many days" & _
            " based on customer ID"
        '
        'lblCusId
        '
        Me.lblCusId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCusId.Location = New System.Drawing.Point(21, 106)
        Me.lblCusId.Name = "lblCusId"
        Me.lblCusId.Size = New System.Drawing.Size(100, 20)
        Me.lblCusId.TabIndex = 5
        Me.lblCusId.Text = "Customer ID"
        Me.lblCusId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(99, 179)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 8
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'frmReport1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblCusId)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.boxCusId)
        Me.Name = "frmReport1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report 1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents boxCusId As System.Windows.Forms.ComboBox
    Friend WithEvents lblReport As System.Windows.Forms.Label
    Friend WithEvents lblCusId As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
End Class
