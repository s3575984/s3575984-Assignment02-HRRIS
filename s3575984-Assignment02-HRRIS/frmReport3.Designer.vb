<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport3
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
      Me.lblCusId = New System.Windows.Forms.Label()
      Me.lblReport = New System.Windows.Forms.Label()
      Me.boxCusId = New System.Windows.Forms.ComboBox()
      Me.boxMonth = New System.Windows.Forms.ComboBox()
      Me.lblMonth = New System.Windows.Forms.Label()
      Me.lblYear = New System.Windows.Forms.Label()
      Me.txtYear = New System.Windows.Forms.TextBox()
      Me.picYear = New System.Windows.Forms.PictureBox()
      Me.picMonth = New System.Windows.Forms.PictureBox()
      Me.picCust = New System.Windows.Forms.PictureBox()
      CType(Me.picYear, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picMonth, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picCust, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btnGenerate
      '
      Me.btnGenerate.Location = New System.Drawing.Point(100, 227)
      Me.btnGenerate.Name = "btnGenerate"
      Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
      Me.btnGenerate.TabIndex = 12
      Me.btnGenerate.Text = "Generate"
      Me.btnGenerate.UseVisualStyleBackColor = True
      '
      'lblCusId
      '
      Me.lblCusId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblCusId.Location = New System.Drawing.Point(30, 105)
      Me.lblCusId.Name = "lblCusId"
      Me.lblCusId.Size = New System.Drawing.Size(100, 20)
      Me.lblCusId.TabIndex = 11
      Me.lblCusId.Text = "Customer ID"
      Me.lblCusId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblReport
      '
      Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblReport.Location = New System.Drawing.Point(12, 26)
      Me.lblReport.Name = "lblReport"
      Me.lblReport.Size = New System.Drawing.Size(260, 59)
      Me.lblReport.TabIndex = 10
      Me.lblReport.Text = "This report will show how many rooms were booked by a given customer for a given " & _
          "period of time"
      '
      'boxCusId
      '
      Me.boxCusId.FormattingEnabled = True
      Me.boxCusId.Location = New System.Drawing.Point(136, 104)
      Me.boxCusId.Name = "boxCusId"
      Me.boxCusId.Size = New System.Drawing.Size(100, 21)
      Me.boxCusId.TabIndex = 9
      '
      'boxMonth
      '
      Me.boxMonth.FormattingEnabled = True
      Me.boxMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
      Me.boxMonth.Location = New System.Drawing.Point(136, 133)
      Me.boxMonth.Name = "boxMonth"
      Me.boxMonth.Size = New System.Drawing.Size(100, 21)
      Me.boxMonth.TabIndex = 24
      '
      'lblMonth
      '
      Me.lblMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblMonth.Location = New System.Drawing.Point(30, 134)
      Me.lblMonth.Name = "lblMonth"
      Me.lblMonth.Size = New System.Drawing.Size(100, 20)
      Me.lblMonth.TabIndex = 23
      Me.lblMonth.Text = "Month"
      Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblYear
      '
      Me.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblYear.Location = New System.Drawing.Point(30, 164)
      Me.lblYear.Name = "lblYear"
      Me.lblYear.Size = New System.Drawing.Size(100, 20)
      Me.lblYear.TabIndex = 22
      Me.lblYear.Text = "Year"
      Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'txtYear
      '
      Me.txtYear.Location = New System.Drawing.Point(136, 164)
      Me.txtYear.Name = "txtYear"
      Me.txtYear.Size = New System.Drawing.Size(100, 20)
      Me.txtYear.TabIndex = 21
      '
      'picYear
      '
      Me.picYear.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.picYear.Location = New System.Drawing.Point(242, 164)
      Me.picYear.Name = "picYear"
      Me.picYear.Size = New System.Drawing.Size(20, 20)
      Me.picYear.TabIndex = 26
      Me.picYear.TabStop = False
      Me.picYear.Visible = False
      '
      'picMonth
      '
      Me.picMonth.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.picMonth.Location = New System.Drawing.Point(242, 134)
      Me.picMonth.Name = "picMonth"
      Me.picMonth.Size = New System.Drawing.Size(20, 20)
      Me.picMonth.TabIndex = 25
      Me.picMonth.TabStop = False
      Me.picMonth.Visible = False
      '
      'picCust
      '
      Me.picCust.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.picCust.Location = New System.Drawing.Point(242, 105)
      Me.picCust.Name = "picCust"
      Me.picCust.Size = New System.Drawing.Size(20, 20)
      Me.picCust.TabIndex = 27
      Me.picCust.TabStop = False
      Me.picCust.Visible = False
      '
      'frmReport3
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(284, 262)
      Me.Controls.Add(Me.picCust)
      Me.Controls.Add(Me.picYear)
      Me.Controls.Add(Me.picMonth)
      Me.Controls.Add(Me.boxMonth)
      Me.Controls.Add(Me.lblMonth)
      Me.Controls.Add(Me.lblYear)
      Me.Controls.Add(Me.txtYear)
      Me.Controls.Add(Me.btnGenerate)
      Me.Controls.Add(Me.lblCusId)
      Me.Controls.Add(Me.lblReport)
      Me.Controls.Add(Me.boxCusId)
      Me.Name = "frmReport3"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Report 3"
      CType(Me.picYear, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picMonth, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picCust, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lblCusId As System.Windows.Forms.Label
    Friend WithEvents lblReport As System.Windows.Forms.Label
    Friend WithEvents boxCusId As System.Windows.Forms.ComboBox
    Friend WithEvents boxMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
   Friend WithEvents txtYear As System.Windows.Forms.TextBox
   Friend WithEvents picYear As System.Windows.Forms.PictureBox
   Friend WithEvents picMonth As System.Windows.Forms.PictureBox
   Friend WithEvents picCust As System.Windows.Forms.PictureBox
End Class
