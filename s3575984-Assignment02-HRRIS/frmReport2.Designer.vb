<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport2
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.txtRoomNum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(95, 211)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 27
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblRoom
        '
        Me.lblRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRoom.Location = New System.Drawing.Point(34, 112)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(100, 20)
        Me.lblRoom.TabIndex = 25
        Me.lblRoom.Text = "Room number"
        Me.lblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReport
        '
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(12, 29)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(260, 59)
        Me.lblReport.TabIndex = 22
        Me.lblReport.Text = "This report will show when was the last time the room booked and what was the tot" & _
            "al price paid"
        '
        'txtRoomNum
        '
        Me.txtRoomNum.Location = New System.Drawing.Point(140, 111)
        Me.txtRoomNum.Name = "txtRoomNum"
        Me.txtRoomNum.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomNum.TabIndex = 28
        '
        'frmReport2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtRoomNum)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.lblReport)
        Me.Name = "frmReport2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents btnGenerate As System.Windows.Forms.Button
   Friend WithEvents lblRoom As System.Windows.Forms.Label
   Friend WithEvents lblReport As System.Windows.Forms.Label
   Friend WithEvents txtRoomNum As System.Windows.Forms.TextBox
End Class
