<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoom
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
      Me.lblRoomNumber = New System.Windows.Forms.Label()
      Me.lblType = New System.Windows.Forms.Label()
      Me.lblPrice = New System.Windows.Forms.Label()
      Me.lblNumBeds = New System.Windows.Forms.Label()
      Me.lblAvailability = New System.Windows.Forms.Label()
      Me.lblFloor = New System.Windows.Forms.Label()
      Me.lblDescription = New System.Windows.Forms.Label()
      Me.txtRoomNumber = New System.Windows.Forms.TextBox()
      Me.txtDescription = New System.Windows.Forms.TextBox()
      Me.txtPrice = New System.Windows.Forms.TextBox()
      Me.boxType = New System.Windows.Forms.ComboBox()
      Me.boxNumBeds = New System.Windows.Forms.ComboBox()
      Me.boxFloor = New System.Windows.Forms.ComboBox()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnCancel = New System.Windows.Forms.Button()
      Me.rdYes = New System.Windows.Forms.RadioButton()
      Me.rdNo = New System.Windows.Forms.RadioButton()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.picInfor = New System.Windows.Forms.PictureBox()
      Me.btnRefresh = New System.Windows.Forms.Button()
      Me.txtRoomId = New System.Windows.Forms.TextBox()
      Me.lblRoomId = New System.Windows.Forms.Label()
      Me.PictureBox7 = New System.Windows.Forms.PictureBox()
      Me.PictureBox6 = New System.Windows.Forms.PictureBox()
      Me.PictureBox5 = New System.Windows.Forms.PictureBox()
      Me.PictureBox4 = New System.Windows.Forms.PictureBox()
      Me.PictureBox3 = New System.Windows.Forms.PictureBox()
      Me.PictureBox2 = New System.Windows.Forms.PictureBox()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
      Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.DataCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.GenerateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.btnLast = New System.Windows.Forms.Button()
      Me.btnNext = New System.Windows.Forms.Button()
      Me.btnPrev = New System.Windows.Forms.Button()
      Me.btnFirst = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnUpdate = New System.Windows.Forms.Button()
      Me.btnFind = New System.Windows.Forms.Button()
      Me.dgvRoom = New System.Windows.Forms.DataGridView()
      Me.GenerateControlBreakReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.CBR1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.CBR2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.GroupBox1.SuspendLayout()
      CType(Me.picInfor, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.MenuStrip1.SuspendLayout()
      CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'lblRoomNumber
      '
      Me.lblRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblRoomNumber.Location = New System.Drawing.Point(6, 55)
      Me.lblRoomNumber.Name = "lblRoomNumber"
      Me.lblRoomNumber.Size = New System.Drawing.Size(120, 20)
      Me.lblRoomNumber.TabIndex = 0
      Me.lblRoomNumber.Text = "Room number"
      Me.lblRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblType
      '
      Me.lblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblType.Location = New System.Drawing.Point(6, 85)
      Me.lblType.Name = "lblType"
      Me.lblType.Size = New System.Drawing.Size(120, 20)
      Me.lblType.TabIndex = 1
      Me.lblType.Text = "Type"
      Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblPrice
      '
      Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblPrice.Location = New System.Drawing.Point(6, 115)
      Me.lblPrice.Name = "lblPrice"
      Me.lblPrice.Size = New System.Drawing.Size(120, 20)
      Me.lblPrice.TabIndex = 2
      Me.lblPrice.Text = "Price"
      Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblNumBeds
      '
      Me.lblNumBeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblNumBeds.Location = New System.Drawing.Point(6, 145)
      Me.lblNumBeds.Name = "lblNumBeds"
      Me.lblNumBeds.Size = New System.Drawing.Size(120, 20)
      Me.lblNumBeds.TabIndex = 3
      Me.lblNumBeds.Text = "Number of beds"
      Me.lblNumBeds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblAvailability
      '
      Me.lblAvailability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblAvailability.Location = New System.Drawing.Point(6, 175)
      Me.lblAvailability.Name = "lblAvailability"
      Me.lblAvailability.Size = New System.Drawing.Size(120, 20)
      Me.lblAvailability.TabIndex = 4
      Me.lblAvailability.Text = "Availability"
      Me.lblAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblFloor
      '
      Me.lblFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblFloor.Location = New System.Drawing.Point(6, 205)
      Me.lblFloor.Name = "lblFloor"
      Me.lblFloor.Size = New System.Drawing.Size(120, 20)
      Me.lblFloor.TabIndex = 5
      Me.lblFloor.Text = "Floor"
      Me.lblFloor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblDescription
      '
      Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblDescription.Location = New System.Drawing.Point(6, 235)
      Me.lblDescription.Name = "lblDescription"
      Me.lblDescription.Size = New System.Drawing.Size(120, 20)
      Me.lblDescription.TabIndex = 6
      Me.lblDescription.Text = "Description"
      Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'txtRoomNumber
      '
      Me.txtRoomNumber.Location = New System.Drawing.Point(140, 54)
      Me.txtRoomNumber.Name = "txtRoomNumber"
      Me.txtRoomNumber.Size = New System.Drawing.Size(220, 20)
      Me.txtRoomNumber.TabIndex = 7
      '
      'txtDescription
      '
      Me.txtDescription.Location = New System.Drawing.Point(140, 236)
      Me.txtDescription.Multiline = True
      Me.txtDescription.Name = "txtDescription"
      Me.txtDescription.Size = New System.Drawing.Size(220, 50)
      Me.txtDescription.TabIndex = 8
      '
      'txtPrice
      '
      Me.txtPrice.Location = New System.Drawing.Point(141, 116)
      Me.txtPrice.Name = "txtPrice"
      Me.txtPrice.Size = New System.Drawing.Size(220, 20)
      Me.txtPrice.TabIndex = 10
      '
      'boxType
      '
      Me.boxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.boxType.FormattingEnabled = True
      Me.boxType.Items.AddRange(New Object() {"Family", "Standard", "Suite", "Super Large"})
      Me.boxType.Location = New System.Drawing.Point(141, 85)
      Me.boxType.Name = "boxType"
      Me.boxType.Size = New System.Drawing.Size(121, 21)
      Me.boxType.TabIndex = 11
      '
      'boxNumBeds
      '
      Me.boxNumBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.boxNumBeds.FormattingEnabled = True
      Me.boxNumBeds.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
      Me.boxNumBeds.Location = New System.Drawing.Point(141, 145)
      Me.boxNumBeds.Name = "boxNumBeds"
      Me.boxNumBeds.Size = New System.Drawing.Size(121, 21)
      Me.boxNumBeds.TabIndex = 12
      '
      'boxFloor
      '
      Me.boxFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.boxFloor.FormattingEnabled = True
      Me.boxFloor.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
      Me.boxFloor.Location = New System.Drawing.Point(140, 205)
      Me.boxFloor.Name = "boxFloor"
      Me.boxFloor.Size = New System.Drawing.Size(121, 21)
      Me.boxFloor.TabIndex = 14
      '
      'btnSave
      '
      Me.btnSave.Location = New System.Drawing.Point(515, 52)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(107, 23)
      Me.btnSave.TabIndex = 15
      Me.btnSave.Text = "Insert"
      Me.btnSave.UseVisualStyleBackColor = True
      '
      'btnCancel
      '
      Me.btnCancel.Location = New System.Drawing.Point(481, 294)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.Size = New System.Drawing.Size(75, 23)
      Me.btnCancel.TabIndex = 16
      Me.btnCancel.Text = "Cancel"
      Me.btnCancel.UseVisualStyleBackColor = True
      '
      'rdYes
      '
      Me.rdYes.Location = New System.Drawing.Point(141, 175)
      Me.rdYes.Name = "rdYes"
      Me.rdYes.Size = New System.Drawing.Size(57, 20)
      Me.rdYes.TabIndex = 17
      Me.rdYes.TabStop = True
      Me.rdYes.Text = "Yes"
      Me.rdYes.UseVisualStyleBackColor = True
      '
      'rdNo
      '
      Me.rdNo.Location = New System.Drawing.Point(204, 175)
      Me.rdNo.Name = "rdNo"
      Me.rdNo.Size = New System.Drawing.Size(57, 20)
      Me.rdNo.TabIndex = 18
      Me.rdNo.TabStop = True
      Me.rdNo.Text = "No"
      Me.rdNo.UseVisualStyleBackColor = True
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.picInfor)
      Me.GroupBox1.Controls.Add(Me.btnRefresh)
      Me.GroupBox1.Controls.Add(Me.txtRoomId)
      Me.GroupBox1.Controls.Add(Me.lblRoomId)
      Me.GroupBox1.Controls.Add(Me.lblRoomNumber)
      Me.GroupBox1.Controls.Add(Me.lblType)
      Me.GroupBox1.Controls.Add(Me.PictureBox7)
      Me.GroupBox1.Controls.Add(Me.lblPrice)
      Me.GroupBox1.Controls.Add(Me.PictureBox6)
      Me.GroupBox1.Controls.Add(Me.lblNumBeds)
      Me.GroupBox1.Controls.Add(Me.PictureBox5)
      Me.GroupBox1.Controls.Add(Me.lblAvailability)
      Me.GroupBox1.Controls.Add(Me.PictureBox4)
      Me.GroupBox1.Controls.Add(Me.lblFloor)
      Me.GroupBox1.Controls.Add(Me.PictureBox3)
      Me.GroupBox1.Controls.Add(Me.lblDescription)
      Me.GroupBox1.Controls.Add(Me.PictureBox2)
      Me.GroupBox1.Controls.Add(Me.txtRoomNumber)
      Me.GroupBox1.Controls.Add(Me.PictureBox1)
      Me.GroupBox1.Controls.Add(Me.txtDescription)
      Me.GroupBox1.Controls.Add(Me.rdNo)
      Me.GroupBox1.Controls.Add(Me.txtPrice)
      Me.GroupBox1.Controls.Add(Me.rdYes)
      Me.GroupBox1.Controls.Add(Me.boxType)
      Me.GroupBox1.Controls.Add(Me.boxNumBeds)
      Me.GroupBox1.Controls.Add(Me.boxFloor)
      Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(400, 300)
      Me.GroupBox1.TabIndex = 27
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Room Detail"
      '
      'picInfor
      '
      Me.picInfor.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources._1493456375_Info_Circle_Symbol_Information_Letter
      Me.picInfor.Location = New System.Drawing.Point(267, 24)
      Me.picInfor.Name = "picInfor"
      Me.picInfor.Size = New System.Drawing.Size(20, 20)
      Me.picInfor.TabIndex = 34
      Me.picInfor.TabStop = False
      '
      'btnRefresh
      '
      Me.btnRefresh.BackgroundImage = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.reload
      Me.btnRefresh.FlatAppearance.BorderSize = 0
      Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnRefresh.Location = New System.Drawing.Point(365, 19)
      Me.btnRefresh.Name = "btnRefresh"
      Me.btnRefresh.Size = New System.Drawing.Size(25, 25)
      Me.btnRefresh.TabIndex = 33
      Me.btnRefresh.UseVisualStyleBackColor = True
      '
      'txtRoomId
      '
      Me.txtRoomId.Location = New System.Drawing.Point(141, 24)
      Me.txtRoomId.Name = "txtRoomId"
      Me.txtRoomId.ReadOnly = True
      Me.txtRoomId.Size = New System.Drawing.Size(120, 20)
      Me.txtRoomId.TabIndex = 27
      '
      'lblRoomId
      '
      Me.lblRoomId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblRoomId.Location = New System.Drawing.Point(6, 25)
      Me.lblRoomId.Name = "lblRoomId"
      Me.lblRoomId.Size = New System.Drawing.Size(120, 20)
      Me.lblRoomId.TabIndex = 26
      Me.lblRoomId.Text = "Room ID"
      Me.lblRoomId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'PictureBox7
      '
      Me.PictureBox7.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox7.Location = New System.Drawing.Point(370, 236)
      Me.PictureBox7.Name = "PictureBox7"
      Me.PictureBox7.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox7.TabIndex = 25
      Me.PictureBox7.TabStop = False
      Me.PictureBox7.Visible = False
      '
      'PictureBox6
      '
      Me.PictureBox6.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox6.Location = New System.Drawing.Point(268, 206)
      Me.PictureBox6.Name = "PictureBox6"
      Me.PictureBox6.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox6.TabIndex = 24
      Me.PictureBox6.TabStop = False
      Me.PictureBox6.Visible = False
      '
      'PictureBox5
      '
      Me.PictureBox5.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox5.Location = New System.Drawing.Point(267, 175)
      Me.PictureBox5.Name = "PictureBox5"
      Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox5.TabIndex = 23
      Me.PictureBox5.TabStop = False
      Me.PictureBox5.Visible = False
      '
      'PictureBox4
      '
      Me.PictureBox4.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox4.Location = New System.Drawing.Point(268, 146)
      Me.PictureBox4.Name = "PictureBox4"
      Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox4.TabIndex = 22
      Me.PictureBox4.TabStop = False
      Me.PictureBox4.Visible = False
      '
      'PictureBox3
      '
      Me.PictureBox3.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox3.Location = New System.Drawing.Point(370, 115)
      Me.PictureBox3.Name = "PictureBox3"
      Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox3.TabIndex = 21
      Me.PictureBox3.TabStop = False
      Me.PictureBox3.Visible = False
      '
      'PictureBox2
      '
      Me.PictureBox2.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox2.Location = New System.Drawing.Point(268, 85)
      Me.PictureBox2.Name = "PictureBox2"
      Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox2.TabIndex = 20
      Me.PictureBox2.TabStop = False
      Me.PictureBox2.Visible = False
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox1.Location = New System.Drawing.Point(370, 54)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox1.TabIndex = 19
      Me.PictureBox1.TabStop = False
      Me.PictureBox1.Visible = False
      '
      'MenuStrip1
      '
      Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataCaptureToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
      Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
      Me.MenuStrip1.Name = "MenuStrip1"
      Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
      Me.MenuStrip1.TabIndex = 28
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
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
      Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.CustomerToolStripMenuItem.Text = "&Customer"
      '
      'RoomToolStripMenuItem
      '
      Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
      Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.RoomToolStripMenuItem.Text = "&Room"
      '
      'BookingToolStripMenuItem
      '
      Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
      Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
      'btnNew
      '
      Me.btnNew.Location = New System.Drawing.Point(427, 52)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(75, 23)
      Me.btnNew.TabIndex = 33
      Me.btnNew.TabStop = False
      Me.btnNew.Text = "New"
      Me.btnNew.UseVisualStyleBackColor = True
      '
      'btnLast
      '
      Me.btnLast.Location = New System.Drawing.Point(577, 202)
      Me.btnLast.Name = "btnLast"
      Me.btnLast.Size = New System.Drawing.Size(40, 23)
      Me.btnLast.TabIndex = 46
      Me.btnLast.Text = ">|"
      Me.btnLast.UseVisualStyleBackColor = True
      '
      'btnNext
      '
      Me.btnNext.Location = New System.Drawing.Point(531, 202)
      Me.btnNext.Name = "btnNext"
      Me.btnNext.Size = New System.Drawing.Size(40, 23)
      Me.btnNext.TabIndex = 45
      Me.btnNext.Text = ">"
      Me.btnNext.UseVisualStyleBackColor = True
      '
      'btnPrev
      '
      Me.btnPrev.Location = New System.Drawing.Point(478, 202)
      Me.btnPrev.Name = "btnPrev"
      Me.btnPrev.Size = New System.Drawing.Size(40, 23)
      Me.btnPrev.TabIndex = 44
      Me.btnPrev.Text = "<"
      Me.btnPrev.UseVisualStyleBackColor = True
      '
      'btnFirst
      '
      Me.btnFirst.Location = New System.Drawing.Point(432, 202)
      Me.btnFirst.Name = "btnFirst"
      Me.btnFirst.Size = New System.Drawing.Size(40, 23)
      Me.btnFirst.TabIndex = 43
      Me.btnFirst.Text = "|<"
      Me.btnFirst.UseVisualStyleBackColor = True
      '
      'btnDelete
      '
      Me.btnDelete.Location = New System.Drawing.Point(427, 146)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(195, 23)
      Me.btnDelete.TabIndex = 42
      Me.btnDelete.TabStop = False
      Me.btnDelete.Text = "Delete"
      Me.btnDelete.UseVisualStyleBackColor = True
      '
      'btnUpdate
      '
      Me.btnUpdate.Location = New System.Drawing.Point(427, 115)
      Me.btnUpdate.Name = "btnUpdate"
      Me.btnUpdate.Size = New System.Drawing.Size(195, 23)
      Me.btnUpdate.TabIndex = 41
      Me.btnUpdate.TabStop = False
      Me.btnUpdate.Text = "Update"
      Me.btnUpdate.UseVisualStyleBackColor = True
      '
      'btnFind
      '
      Me.btnFind.Location = New System.Drawing.Point(427, 85)
      Me.btnFind.Name = "btnFind"
      Me.btnFind.Size = New System.Drawing.Size(195, 23)
      Me.btnFind.TabIndex = 40
      Me.btnFind.TabStop = False
      Me.btnFind.Text = "Find"
      Me.btnFind.UseVisualStyleBackColor = True
      '
      'dgvRoom
      '
      Me.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvRoom.Location = New System.Drawing.Point(12, 336)
      Me.dgvRoom.Name = "dgvRoom"
      Me.dgvRoom.ReadOnly = True
      Me.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dgvRoom.Size = New System.Drawing.Size(610, 124)
      Me.dgvRoom.TabIndex = 47
      Me.dgvRoom.TabStop = False
      '
      'GenerateControlBreakReportToolStripMenuItem
      '
      Me.GenerateControlBreakReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CBR1ToolStripMenuItem, Me.CBR2ToolStripMenuItem})
      Me.GenerateControlBreakReportToolStripMenuItem.Name = "GenerateControlBreakReportToolStripMenuItem"
      Me.GenerateControlBreakReportToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
      Me.GenerateControlBreakReportToolStripMenuItem.Text = "Generate Control Break Report"
      '
      'Report1ToolStripMenuItem
      '
      Me.Report1ToolStripMenuItem.Name = "Report1ToolStripMenuItem"
      Me.Report1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.Report1ToolStripMenuItem.Text = "Report 1 "
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
      'frmRoom
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(634, 472)
      Me.Controls.Add(Me.dgvRoom)
      Me.Controls.Add(Me.btnLast)
      Me.Controls.Add(Me.btnNext)
      Me.Controls.Add(Me.btnPrev)
      Me.Controls.Add(Me.btnFirst)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnUpdate)
      Me.Controls.Add(Me.btnFind)
      Me.Controls.Add(Me.btnNew)
      Me.Controls.Add(Me.MenuStrip1)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnCancel)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.Name = "frmRoom"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Room"
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      CType(Me.picInfor, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.MenuStrip1.ResumeLayout(False)
      Me.MenuStrip1.PerformLayout()
      CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents lblRoomNumber As System.Windows.Forms.Label
   Friend WithEvents lblType As System.Windows.Forms.Label
   Friend WithEvents lblPrice As System.Windows.Forms.Label
   Friend WithEvents lblNumBeds As System.Windows.Forms.Label
   Friend WithEvents lblAvailability As System.Windows.Forms.Label
   Friend WithEvents lblFloor As System.Windows.Forms.Label
   Friend WithEvents lblDescription As System.Windows.Forms.Label
   Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
   Friend WithEvents txtDescription As System.Windows.Forms.TextBox
   Friend WithEvents txtPrice As System.Windows.Forms.TextBox
   Friend WithEvents boxType As System.Windows.Forms.ComboBox
   Friend WithEvents boxNumBeds As System.Windows.Forms.ComboBox
   Friend WithEvents boxFloor As System.Windows.Forms.ComboBox
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnCancel As System.Windows.Forms.Button
   Friend WithEvents rdYes As System.Windows.Forms.RadioButton
   Friend WithEvents rdNo As System.Windows.Forms.RadioButton
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
   Friend WithEvents txtRoomId As System.Windows.Forms.TextBox
   Friend WithEvents lblRoomId As System.Windows.Forms.Label
   Friend WithEvents btnRefresh As System.Windows.Forms.Button
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents btnLast As System.Windows.Forms.Button
   Friend WithEvents btnNext As System.Windows.Forms.Button
   Friend WithEvents btnPrev As System.Windows.Forms.Button
   Friend WithEvents btnFirst As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnUpdate As System.Windows.Forms.Button
   Friend WithEvents btnFind As System.Windows.Forms.Button
   Friend WithEvents picInfor As System.Windows.Forms.PictureBox
   Friend WithEvents dgvRoom As System.Windows.Forms.DataGridView
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
