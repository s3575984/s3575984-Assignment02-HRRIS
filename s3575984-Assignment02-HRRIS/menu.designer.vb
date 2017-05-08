<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
      Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
      Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.DataCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.GenerateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.GenerateControlBreakReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.CBR1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.CBR2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnNewCus = New System.Windows.Forms.Button()
      Me.btnNewRoom = New System.Windows.Forms.Button()
      Me.btnNewBook = New System.Windows.Forms.Button()
      Me.btnReport1 = New System.Windows.Forms.Button()
      Me.btnReport2 = New System.Windows.Forms.Button()
      Me.btnReport3 = New System.Windows.Forms.Button()
      Me.btnReport4 = New System.Windows.Forms.Button()
      Me.btnReport5 = New System.Windows.Forms.Button()
      Me.btnReport6 = New System.Windows.Forms.Button()
      Me.btnCBReport1 = New System.Windows.Forms.Button()
      Me.btnCBReport2 = New System.Windows.Forms.Button()
      Me.gbInsert = New System.Windows.Forms.GroupBox()
      Me.gbReport = New System.Windows.Forms.GroupBox()
      Me.GroupBox3 = New System.Windows.Forms.GroupBox()
      Me.MenuStrip1.SuspendLayout()
      Me.gbInsert.SuspendLayout()
      Me.gbReport.SuspendLayout()
      Me.GroupBox3.SuspendLayout()
      Me.SuspendLayout()
      '
      'MenuStrip1
      '
      Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataCaptureToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
      Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
      Me.MenuStrip1.Name = "MenuStrip1"
      Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
      Me.MenuStrip1.TabIndex = 3
      Me.MenuStrip1.Text = "MenuStrip1"
      '
      'FileToolStripMenuItem
      '
      Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
      Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
      Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
      Me.FileToolStripMenuItem.Text = "&File"
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
      Me.ExitToolStripMenuItem.Text = "E&xit"
      '
      'DataCaptureToolStripMenuItem
      '
      Me.DataCaptureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.RoomToolStripMenuItem, Me.BookingToolStripMenuItem})
      Me.DataCaptureToolStripMenuItem.Name = "DataCaptureToolStripMenuItem"
      Me.DataCaptureToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
      Me.DataCaptureToolStripMenuItem.Text = "&Data Capture"
      '
      'CustomerToolStripMenuItem
      '
      Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
      Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
      Me.CustomerToolStripMenuItem.Text = "&Customer"
      '
      'RoomToolStripMenuItem
      '
      Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
      Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
      Me.RoomToolStripMenuItem.Text = "&Room"
      '
      'BookingToolStripMenuItem
      '
      Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
      Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
      Me.BookingToolStripMenuItem.Text = "&Booking"
      '
      'ReportToolStripMenuItem
      '
      Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateReportToolStripMenuItem, Me.GenerateControlBreakReportToolStripMenuItem})
      Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
      Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
      Me.ReportToolStripMenuItem.Text = "R&eport"
      '
      'GenerateReportToolStripMenuItem
      '
      Me.GenerateReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Report1ToolStripMenuItem, Me.Report2ToolStripMenuItem, Me.Report3ToolStripMenuItem, Me.Report4ToolStripMenuItem, Me.Report5ToolStripMenuItem, Me.Report6ToolStripMenuItem})
      Me.GenerateReportToolStripMenuItem.Name = "GenerateReportToolStripMenuItem"
      Me.GenerateReportToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
      Me.GenerateReportToolStripMenuItem.Text = "Generate Report"
      '
      'Report1ToolStripMenuItem
      '
      Me.Report1ToolStripMenuItem.Name = "Report1ToolStripMenuItem"
      Me.Report1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.Report1ToolStripMenuItem.Text = "Report 1"
      '
      'Report2ToolStripMenuItem
      '
      Me.Report2ToolStripMenuItem.Name = "Report2ToolStripMenuItem"
      Me.Report2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.Report2ToolStripMenuItem.Text = "Report 2"
      '
      'Report3ToolStripMenuItem
      '
      Me.Report3ToolStripMenuItem.Name = "Report3ToolStripMenuItem"
      Me.Report3ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.Report3ToolStripMenuItem.Text = "Report 3"
      '
      'Report4ToolStripMenuItem
      '
      Me.Report4ToolStripMenuItem.Name = "Report4ToolStripMenuItem"
      Me.Report4ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.Report4ToolStripMenuItem.Text = "Report 4"
      '
      'Report5ToolStripMenuItem
      '
      Me.Report5ToolStripMenuItem.Name = "Report5ToolStripMenuItem"
      Me.Report5ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.Report5ToolStripMenuItem.Text = "Report 5"
      '
      'Report6ToolStripMenuItem
      '
      Me.Report6ToolStripMenuItem.Name = "Report6ToolStripMenuItem"
      Me.Report6ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.Report6ToolStripMenuItem.Text = "Report 6"
      '
      'GenerateControlBreakReportToolStripMenuItem
      '
      Me.GenerateControlBreakReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CBR1ToolStripMenuItem, Me.CBR2ToolStripMenuItem})
      Me.GenerateControlBreakReportToolStripMenuItem.Name = "GenerateControlBreakReportToolStripMenuItem"
      Me.GenerateControlBreakReportToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
      Me.GenerateControlBreakReportToolStripMenuItem.Text = "Generate Control Break Report"
      '
      'CBR1ToolStripMenuItem
      '
      Me.CBR1ToolStripMenuItem.Name = "CBR1ToolStripMenuItem"
      Me.CBR1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.CBR1ToolStripMenuItem.Text = "CBR 1"
      '
      'CBR2ToolStripMenuItem
      '
      Me.CBR2ToolStripMenuItem.Name = "CBR2ToolStripMenuItem"
      Me.CBR2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.CBR2ToolStripMenuItem.Text = "CBR 2"
      '
      'HelpToolStripMenuItem
      '
      Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem})
      Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
      Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
      Me.HelpToolStripMenuItem.Text = "&Help"
      '
      'ViewHelpToolStripMenuItem
      '
      Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
      Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.ViewHelpToolStripMenuItem.Text = "&View Help"
      '
      'AboutToolStripMenuItem
      '
      Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
      Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.AboutToolStripMenuItem.Text = "&About"
      '
      'btnNewCus
      '
      Me.btnNewCus.Location = New System.Drawing.Point(41, 26)
      Me.btnNewCus.Name = "btnNewCus"
      Me.btnNewCus.Size = New System.Drawing.Size(200, 40)
      Me.btnNewCus.TabIndex = 4
      Me.btnNewCus.Text = "Insert New Customer"
      Me.btnNewCus.UseVisualStyleBackColor = True
      '
      'btnNewRoom
      '
      Me.btnNewRoom.Location = New System.Drawing.Point(41, 85)
      Me.btnNewRoom.Name = "btnNewRoom"
      Me.btnNewRoom.Size = New System.Drawing.Size(200, 40)
      Me.btnNewRoom.TabIndex = 5
      Me.btnNewRoom.Text = "Create New Room"
      Me.btnNewRoom.UseVisualStyleBackColor = True
      '
      'btnNewBook
      '
      Me.btnNewBook.Location = New System.Drawing.Point(41, 145)
      Me.btnNewBook.Name = "btnNewBook"
      Me.btnNewBook.Size = New System.Drawing.Size(200, 40)
      Me.btnNewBook.TabIndex = 6
      Me.btnNewBook.Text = "Book A Room"
      Me.btnNewBook.UseVisualStyleBackColor = True
      '
      'btnReport1
      '
      Me.btnReport1.Location = New System.Drawing.Point(41, 31)
      Me.btnReport1.Name = "btnReport1"
      Me.btnReport1.Size = New System.Drawing.Size(75, 30)
      Me.btnReport1.TabIndex = 7
      Me.btnReport1.Text = "Report 1"
      Me.btnReport1.UseVisualStyleBackColor = True
      '
      'btnReport2
      '
      Me.btnReport2.Location = New System.Drawing.Point(134, 31)
      Me.btnReport2.Name = "btnReport2"
      Me.btnReport2.Size = New System.Drawing.Size(75, 30)
      Me.btnReport2.TabIndex = 8
      Me.btnReport2.Text = "Report 2"
      Me.btnReport2.UseVisualStyleBackColor = True
      '
      'btnReport3
      '
      Me.btnReport3.Location = New System.Drawing.Point(41, 90)
      Me.btnReport3.Name = "btnReport3"
      Me.btnReport3.Size = New System.Drawing.Size(75, 30)
      Me.btnReport3.TabIndex = 9
      Me.btnReport3.Text = "Report 3"
      Me.btnReport3.UseVisualStyleBackColor = True
      '
      'btnReport4
      '
      Me.btnReport4.Location = New System.Drawing.Point(134, 90)
      Me.btnReport4.Name = "btnReport4"
      Me.btnReport4.Size = New System.Drawing.Size(75, 30)
      Me.btnReport4.TabIndex = 10
      Me.btnReport4.Text = "Report 4"
      Me.btnReport4.UseVisualStyleBackColor = True
      '
      'btnReport5
      '
      Me.btnReport5.Location = New System.Drawing.Point(41, 150)
      Me.btnReport5.Name = "btnReport5"
      Me.btnReport5.Size = New System.Drawing.Size(75, 30)
      Me.btnReport5.TabIndex = 11
      Me.btnReport5.Text = "Report 5"
      Me.btnReport5.UseVisualStyleBackColor = True
      '
      'btnReport6
      '
      Me.btnReport6.Location = New System.Drawing.Point(134, 150)
      Me.btnReport6.Name = "btnReport6"
      Me.btnReport6.Size = New System.Drawing.Size(75, 30)
      Me.btnReport6.TabIndex = 12
      Me.btnReport6.Text = "Report 6"
      Me.btnReport6.UseVisualStyleBackColor = True
      '
      'btnCBReport1
      '
      Me.btnCBReport1.Location = New System.Drawing.Point(44, 23)
      Me.btnCBReport1.Name = "btnCBReport1"
      Me.btnCBReport1.Size = New System.Drawing.Size(130, 47)
      Me.btnCBReport1.TabIndex = 13
      Me.btnCBReport1.Text = "Control Break Report 1"
      Me.btnCBReport1.UseVisualStyleBackColor = True
      '
      'btnCBReport2
      '
      Me.btnCBReport2.Location = New System.Drawing.Point(220, 23)
      Me.btnCBReport2.Name = "btnCBReport2"
      Me.btnCBReport2.Size = New System.Drawing.Size(130, 47)
      Me.btnCBReport2.TabIndex = 14
      Me.btnCBReport2.Text = "Control Break Report 2"
      Me.btnCBReport2.UseVisualStyleBackColor = True
      '
      'gbInsert
      '
      Me.gbInsert.Controls.Add(Me.btnNewCus)
      Me.gbInsert.Controls.Add(Me.btnNewRoom)
      Me.gbInsert.Controls.Add(Me.btnNewBook)
      Me.gbInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.gbInsert.Location = New System.Drawing.Point(24, 52)
      Me.gbInsert.Name = "gbInsert"
      Me.gbInsert.Size = New System.Drawing.Size(290, 206)
      Me.gbInsert.TabIndex = 15
      Me.gbInsert.TabStop = False
      Me.gbInsert.Text = "Insert"
      '
      'gbReport
      '
      Me.gbReport.Controls.Add(Me.btnReport5)
      Me.gbReport.Controls.Add(Me.btnReport6)
      Me.gbReport.Controls.Add(Me.btnReport4)
      Me.gbReport.Controls.Add(Me.btnReport3)
      Me.gbReport.Controls.Add(Me.btnReport1)
      Me.gbReport.Controls.Add(Me.btnReport2)
      Me.gbReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.gbReport.Location = New System.Drawing.Point(342, 52)
      Me.gbReport.Name = "gbReport"
      Me.gbReport.Size = New System.Drawing.Size(255, 206)
      Me.gbReport.TabIndex = 16
      Me.gbReport.TabStop = False
      Me.gbReport.Text = "Generate Report"
      '
      'GroupBox3
      '
      Me.GroupBox3.Controls.Add(Me.btnCBReport2)
      Me.GroupBox3.Controls.Add(Me.btnCBReport1)
      Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GroupBox3.Location = New System.Drawing.Point(122, 286)
      Me.GroupBox3.Name = "GroupBox3"
      Me.GroupBox3.Size = New System.Drawing.Size(396, 84)
      Me.GroupBox3.TabIndex = 17
      Me.GroupBox3.TabStop = False
      Me.GroupBox3.Text = "Generate Control Break Report"
      '
      'frmMenu
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(634, 452)
      Me.Controls.Add(Me.GroupBox3)
      Me.Controls.Add(Me.gbReport)
      Me.Controls.Add(Me.gbInsert)
      Me.Controls.Add(Me.MenuStrip1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MainMenuStrip = Me.MenuStrip1
      Me.Name = "frmMenu"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Menu"
      Me.MenuStrip1.ResumeLayout(False)
      Me.MenuStrip1.PerformLayout()
      Me.gbInsert.ResumeLayout(False)
      Me.gbReport.ResumeLayout(False)
      Me.GroupBox3.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
   Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents DataCaptureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents GenerateReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents btnNewCus As System.Windows.Forms.Button
   Friend WithEvents btnNewRoom As System.Windows.Forms.Button
   Friend WithEvents btnNewBook As System.Windows.Forms.Button
   Friend WithEvents btnReport1 As System.Windows.Forms.Button
   Friend WithEvents btnReport2 As System.Windows.Forms.Button
   Friend WithEvents btnReport3 As System.Windows.Forms.Button
   Friend WithEvents btnReport4 As System.Windows.Forms.Button
   Friend WithEvents btnReport5 As System.Windows.Forms.Button
   Friend WithEvents btnReport6 As System.Windows.Forms.Button
   Friend WithEvents btnCBReport1 As System.Windows.Forms.Button
   Friend WithEvents btnCBReport2 As System.Windows.Forms.Button
   Friend WithEvents gbInsert As System.Windows.Forms.GroupBox
   Friend WithEvents gbReport As System.Windows.Forms.GroupBox
   Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
   Friend WithEvents Report1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents Report2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents Report3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents Report4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents Report5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents Report6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents GenerateControlBreakReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents CBR1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents CBR2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
