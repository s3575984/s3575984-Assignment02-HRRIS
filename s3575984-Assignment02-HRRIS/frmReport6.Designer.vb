<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport6
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
      Me.lblRoomId = New System.Windows.Forms.Label()
      Me.boxRoomId = New System.Windows.Forms.ComboBox()
      Me.lblReport = New System.Windows.Forms.Label()
      Me.lblYear = New System.Windows.Forms.Label()
      Me.txtYear = New System.Windows.Forms.TextBox()
      Me.lblMonth = New System.Windows.Forms.Label()
      Me.boxMonth = New System.Windows.Forms.ComboBox()
      Me.btnGenerate = New System.Windows.Forms.Button()
      Me.picRoom = New System.Windows.Forms.PictureBox()
      Me.picYear = New System.Windows.Forms.PictureBox()
      Me.picMonth = New System.Windows.Forms.PictureBox()
      CType(Me.picRoom, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picYear, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picMonth, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'lblRoomId
      '
      Me.lblRoomId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblRoomId.Location = New System.Drawing.Point(28, 81)
      Me.lblRoomId.Name = "lblRoomId"
      Me.lblRoomId.Size = New System.Drawing.Size(100, 20)
      Me.lblRoomId.TabIndex = 7
      Me.lblRoomId.Text = "Room ID"
      Me.lblRoomId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'boxRoomId
      '
      Me.boxRoomId.FormattingEnabled = True
      Me.boxRoomId.Location = New System.Drawing.Point(134, 80)
      Me.boxRoomId.Name = "boxRoomId"
      Me.boxRoomId.Size = New System.Drawing.Size(100, 21)
      Me.boxRoomId.TabIndex = 6
      '
      'lblReport
      '
      Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblReport.Location = New System.Drawing.Point(12, 18)
      Me.lblReport.Name = "lblReport"
      Me.lblReport.Size = New System.Drawing.Size(260, 59)
      Me.lblReport.TabIndex = 8
      Me.lblReport.Text = "This report will show all the bookings for a particular room in a given month of " & _
          "a given year"
      '
      'lblYear
      '
      Me.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblYear.Location = New System.Drawing.Point(28, 145)
      Me.lblYear.Name = "lblYear"
      Me.lblYear.Size = New System.Drawing.Size(100, 20)
      Me.lblYear.TabIndex = 10
      Me.lblYear.Text = "Year"
      Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'txtYear
      '
      Me.txtYear.Location = New System.Drawing.Point(134, 145)
      Me.txtYear.Name = "txtYear"
      Me.txtYear.Size = New System.Drawing.Size(100, 20)
      Me.txtYear.TabIndex = 9
      '
      'lblMonth
      '
      Me.lblMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblMonth.Location = New System.Drawing.Point(28, 113)
      Me.lblMonth.Name = "lblMonth"
      Me.lblMonth.Size = New System.Drawing.Size(100, 20)
      Me.lblMonth.TabIndex = 11
      Me.lblMonth.Text = "Month"
      Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'boxMonth
      '
      Me.boxMonth.FormattingEnabled = True
      Me.boxMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
      Me.boxMonth.Location = New System.Drawing.Point(134, 112)
      Me.boxMonth.Name = "boxMonth"
      Me.boxMonth.Size = New System.Drawing.Size(100, 21)
      Me.boxMonth.TabIndex = 12
      '
      'btnGenerate
      '
      Me.btnGenerate.Location = New System.Drawing.Point(95, 200)
      Me.btnGenerate.Name = "btnGenerate"
      Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
      Me.btnGenerate.TabIndex = 13
      Me.btnGenerate.Text = "Generate"
      Me.btnGenerate.UseVisualStyleBackColor = True
      '
      'picRoom
      '
      Me.picRoom.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.picRoom.Location = New System.Drawing.Point(240, 81)
      Me.picRoom.Name = "picRoom"
      Me.picRoom.Size = New System.Drawing.Size(20, 20)
      Me.picRoom.TabIndex = 30
      Me.picRoom.TabStop = False
      Me.picRoom.Visible = False
      '
      'picYear
      '
      Me.picYear.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.picYear.Location = New System.Drawing.Point(240, 145)
      Me.picYear.Name = "picYear"
      Me.picYear.Size = New System.Drawing.Size(20, 20)
      Me.picYear.TabIndex = 29
      Me.picYear.TabStop = False
      Me.picYear.Visible = False
      '
      'picMonth
      '
      Me.picMonth.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.picMonth.Location = New System.Drawing.Point(240, 113)
      Me.picMonth.Name = "picMonth"
      Me.picMonth.Size = New System.Drawing.Size(20, 20)
      Me.picMonth.TabIndex = 28
      Me.picMonth.TabStop = False
      Me.picMonth.Visible = False
      '
      'frmReport6
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(284, 262)
      Me.Controls.Add(Me.picRoom)
      Me.Controls.Add(Me.picYear)
      Me.Controls.Add(Me.picMonth)
      Me.Controls.Add(Me.btnGenerate)
      Me.Controls.Add(Me.boxMonth)
      Me.Controls.Add(Me.lblMonth)
      Me.Controls.Add(Me.lblYear)
      Me.Controls.Add(Me.txtYear)
      Me.Controls.Add(Me.lblReport)
      Me.Controls.Add(Me.lblRoomId)
      Me.Controls.Add(Me.boxRoomId)
      Me.Name = "frmReport6"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Report 6"
      CType(Me.picRoom, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picYear, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picMonth, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
    Friend WithEvents lblRoomId As System.Windows.Forms.Label
    Friend WithEvents boxRoomId As System.Windows.Forms.ComboBox
    Friend WithEvents lblReport As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents boxMonth As System.Windows.Forms.ComboBox
   Friend WithEvents btnGenerate As System.Windows.Forms.Button
   Friend WithEvents picRoom As System.Windows.Forms.PictureBox
   Friend WithEvents picYear As System.Windows.Forms.PictureBox
   Friend WithEvents picMonth As System.Windows.Forms.PictureBox
End Class
