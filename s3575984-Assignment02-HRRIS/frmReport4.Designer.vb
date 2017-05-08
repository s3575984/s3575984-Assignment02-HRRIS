<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport4
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
      Me.boxMonth = New System.Windows.Forms.ComboBox()
      Me.lblMonth = New System.Windows.Forms.Label()
      Me.lblYear = New System.Windows.Forms.Label()
      Me.txtYear = New System.Windows.Forms.TextBox()
      Me.lblReport = New System.Windows.Forms.Label()
      Me.picYear = New System.Windows.Forms.PictureBox()
      Me.picMonth = New System.Windows.Forms.PictureBox()
      CType(Me.picYear, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picMonth, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btnGenerate
      '
      Me.btnGenerate.Location = New System.Drawing.Point(95, 211)
      Me.btnGenerate.Name = "btnGenerate"
      Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
      Me.btnGenerate.TabIndex = 21
      Me.btnGenerate.Text = "Generate"
      Me.btnGenerate.UseVisualStyleBackColor = True
      '
      'boxMonth
      '
      Me.boxMonth.FormattingEnabled = True
      Me.boxMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
      Me.boxMonth.Location = New System.Drawing.Point(137, 91)
      Me.boxMonth.Name = "boxMonth"
      Me.boxMonth.Size = New System.Drawing.Size(100, 21)
      Me.boxMonth.TabIndex = 20
      '
      'lblMonth
      '
      Me.lblMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblMonth.Location = New System.Drawing.Point(31, 92)
      Me.lblMonth.Name = "lblMonth"
      Me.lblMonth.Size = New System.Drawing.Size(100, 20)
      Me.lblMonth.TabIndex = 19
      Me.lblMonth.Text = "Month"
      Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblYear
      '
      Me.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblYear.Location = New System.Drawing.Point(31, 124)
      Me.lblYear.Name = "lblYear"
      Me.lblYear.Size = New System.Drawing.Size(100, 20)
      Me.lblYear.TabIndex = 18
      Me.lblYear.Text = "Year"
      Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'txtYear
      '
      Me.txtYear.Location = New System.Drawing.Point(137, 124)
      Me.txtYear.Name = "txtYear"
      Me.txtYear.Size = New System.Drawing.Size(100, 20)
      Me.txtYear.TabIndex = 17
      '
      'lblReport
      '
      Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblReport.Location = New System.Drawing.Point(12, 29)
      Me.lblReport.Name = "lblReport"
      Me.lblReport.Size = New System.Drawing.Size(260, 59)
      Me.lblReport.TabIndex = 16
      Me.lblReport.Text = "This report will show all the bookings made in a given month of a given year"
      '
      'picYear
      '
      Me.picYear.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.picYear.Location = New System.Drawing.Point(243, 124)
      Me.picYear.Name = "picYear"
      Me.picYear.Size = New System.Drawing.Size(20, 20)
      Me.picYear.TabIndex = 28
      Me.picYear.TabStop = False
      Me.picYear.Visible = False
      '
      'picMonth
      '
      Me.picMonth.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.picMonth.Location = New System.Drawing.Point(243, 92)
      Me.picMonth.Name = "picMonth"
      Me.picMonth.Size = New System.Drawing.Size(20, 20)
      Me.picMonth.TabIndex = 27
      Me.picMonth.TabStop = False
      Me.picMonth.Visible = False
      '
      'frmReport4
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(284, 262)
      Me.Controls.Add(Me.picYear)
      Me.Controls.Add(Me.picMonth)
      Me.Controls.Add(Me.btnGenerate)
      Me.Controls.Add(Me.boxMonth)
      Me.Controls.Add(Me.lblMonth)
      Me.Controls.Add(Me.lblYear)
      Me.Controls.Add(Me.txtYear)
      Me.Controls.Add(Me.lblReport)
      Me.Name = "frmReport4"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Report 4"
      CType(Me.picYear, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picMonth, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnGenerate As System.Windows.Forms.Button
   Friend WithEvents boxMonth As System.Windows.Forms.ComboBox
   Friend WithEvents lblMonth As System.Windows.Forms.Label
   Friend WithEvents lblYear As System.Windows.Forms.Label
   Friend WithEvents txtYear As System.Windows.Forms.TextBox
   Friend WithEvents lblReport As System.Windows.Forms.Label
   Friend WithEvents picYear As System.Windows.Forms.PictureBox
   Friend WithEvents picMonth As System.Windows.Forms.PictureBox
End Class
