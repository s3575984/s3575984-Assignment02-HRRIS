<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
      Me.lblBookID = New System.Windows.Forms.Label()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.pckDate = New System.Windows.Forms.DateTimePicker()
      Me.txtAmount = New System.Windows.Forms.TextBox()
      Me.lblAmount = New System.Windows.Forms.Label()
      Me.lblDateInvoice = New System.Windows.Forms.Label()
      Me.txtBookID = New System.Windows.Forms.TextBox()
      Me.btnOK = New System.Windows.Forms.Button()
      Me.GroupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'lblBookID
      '
      Me.lblBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblBookID.Location = New System.Drawing.Point(6, 28)
      Me.lblBookID.Name = "lblBookID"
      Me.lblBookID.Size = New System.Drawing.Size(82, 20)
      Me.lblBookID.TabIndex = 0
      Me.lblBookID.Text = "Booking ID"
      Me.lblBookID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.pckDate)
      Me.GroupBox1.Controls.Add(Me.txtAmount)
      Me.GroupBox1.Controls.Add(Me.lblAmount)
      Me.GroupBox1.Controls.Add(Me.lblDateInvoice)
      Me.GroupBox1.Controls.Add(Me.txtBookID)
      Me.GroupBox1.Controls.Add(Me.lblBookID)
      Me.GroupBox1.Location = New System.Drawing.Point(22, 30)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(234, 166)
      Me.GroupBox1.TabIndex = 1
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Invoice Detail"
      '
      'pckDate
      '
      Me.pckDate.Enabled = False
      Me.pckDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.pckDate.Location = New System.Drawing.Point(111, 73)
      Me.pckDate.Name = "pckDate"
      Me.pckDate.Size = New System.Drawing.Size(100, 20)
      Me.pckDate.TabIndex = 5
      '
      'txtAmount
      '
      Me.txtAmount.Location = New System.Drawing.Point(111, 124)
      Me.txtAmount.Name = "txtAmount"
      Me.txtAmount.ReadOnly = True
      Me.txtAmount.Size = New System.Drawing.Size(100, 20)
      Me.txtAmount.TabIndex = 4
      '
      'lblAmount
      '
      Me.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblAmount.Location = New System.Drawing.Point(6, 124)
      Me.lblAmount.Name = "lblAmount"
      Me.lblAmount.Size = New System.Drawing.Size(82, 20)
      Me.lblAmount.TabIndex = 3
      Me.lblAmount.Text = "Total Amount"
      Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblDateInvoice
      '
      Me.lblDateInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblDateInvoice.Location = New System.Drawing.Point(6, 73)
      Me.lblDateInvoice.Name = "lblDateInvoice"
      Me.lblDateInvoice.Size = New System.Drawing.Size(82, 20)
      Me.lblDateInvoice.TabIndex = 2
      Me.lblDateInvoice.Text = "Invoice Date"
      Me.lblDateInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'txtBookID
      '
      Me.txtBookID.Location = New System.Drawing.Point(111, 28)
      Me.txtBookID.Name = "txtBookID"
      Me.txtBookID.ReadOnly = True
      Me.txtBookID.Size = New System.Drawing.Size(100, 20)
      Me.txtBookID.TabIndex = 1
      '
      'btnOK
      '
      Me.btnOK.Location = New System.Drawing.Point(105, 227)
      Me.btnOK.Name = "btnOK"
      Me.btnOK.Size = New System.Drawing.Size(75, 23)
      Me.btnOK.TabIndex = 2
      Me.btnOK.Text = "OK"
      Me.btnOK.UseVisualStyleBackColor = True
      '
      'frmInvoice
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(284, 262)
      Me.Controls.Add(Me.btnOK)
      Me.Controls.Add(Me.GroupBox1)
      Me.Name = "frmInvoice"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Invoice"
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents lblBookID As System.Windows.Forms.Label
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents txtBookID As System.Windows.Forms.TextBox
   Friend WithEvents pckDate As System.Windows.Forms.DateTimePicker
   Friend WithEvents txtAmount As System.Windows.Forms.TextBox
   Friend WithEvents lblAmount As System.Windows.Forms.Label
   Friend WithEvents lblDateInvoice As System.Windows.Forms.Label
   Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
