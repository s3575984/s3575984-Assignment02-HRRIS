<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
      Me.lblTitle = New System.Windows.Forms.Label()
      Me.lblTitle2 = New System.Windows.Forms.Label()
      Me.txtAbout = New System.Windows.Forms.TextBox()
      Me.btnOK = New System.Windows.Forms.Button()
      Me.linkOnline = New System.Windows.Forms.LinkLabel()
      Me.SuspendLayout()
      '
      'lblTitle
      '
      Me.lblTitle.AutoSize = True
      Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitle.Location = New System.Drawing.Point(37, 13)
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Size = New System.Drawing.Size(137, 18)
      Me.lblTitle.TabIndex = 0
      Me.lblTitle.Text = "Phuc, Pham Hoang"
      '
      'lblTitle2
      '
      Me.lblTitle2.AutoSize = True
      Me.lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitle2.Location = New System.Drawing.Point(37, 34)
      Me.lblTitle2.Name = "lblTitle2"
      Me.lblTitle2.Size = New System.Drawing.Size(72, 18)
      Me.lblTitle2.TabIndex = 1
      Me.lblTitle2.Text = "s3575984"
      '
      'txtAbout
      '
      Me.txtAbout.Location = New System.Drawing.Point(40, 68)
      Me.txtAbout.Multiline = True
      Me.txtAbout.Name = "txtAbout"
      Me.txtAbout.ReadOnly = True
      Me.txtAbout.Size = New System.Drawing.Size(458, 201)
      Me.txtAbout.TabIndex = 2
      Me.txtAbout.TabStop = False
      '
      'btnOK
      '
      Me.btnOK.Location = New System.Drawing.Point(448, 281)
      Me.btnOK.Name = "btnOK"
      Me.btnOK.Size = New System.Drawing.Size(75, 23)
      Me.btnOK.TabIndex = 3
      Me.btnOK.Text = "OK"
      Me.btnOK.UseVisualStyleBackColor = True
      '
      'linkOnline
      '
      Me.linkOnline.AutoSize = True
      Me.linkOnline.Location = New System.Drawing.Point(40, 281)
      Me.linkOnline.Name = "linkOnline"
      Me.linkOnline.Size = New System.Drawing.Size(220, 13)
      Me.linkOnline.TabIndex = 4
      Me.linkOnline.TabStop = True
      Me.linkOnline.Text = "View more about this program in your browser"
      '
      'frmAbout
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(545, 316)
      Me.Controls.Add(Me.linkOnline)
      Me.Controls.Add(Me.btnOK)
      Me.Controls.Add(Me.txtAbout)
      Me.Controls.Add(Me.lblTitle2)
      Me.Controls.Add(Me.lblTitle)
      Me.Name = "frmAbout"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "About"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents lblTitle As System.Windows.Forms.Label
   Friend WithEvents lblTitle2 As System.Windows.Forms.Label
   Friend WithEvents txtAbout As System.Windows.Forms.TextBox
   Friend WithEvents btnOK As System.Windows.Forms.Button
   Friend WithEvents linkOnline As System.Windows.Forms.LinkLabel
End Class
