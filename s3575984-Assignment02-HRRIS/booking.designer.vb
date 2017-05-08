<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
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
      Me.lblDate = New System.Windows.Forms.Label()
      Me.lblRoomId = New System.Windows.Forms.Label()
      Me.lblCustomerId = New System.Windows.Forms.Label()
      Me.lblNumDays = New System.Windows.Forms.Label()
      Me.lblNumGuests = New System.Windows.Forms.Label()
      Me.lblCheckinDate = New System.Windows.Forms.Label()
      Me.lblTotalPrice = New System.Windows.Forms.Label()
      Me.lblComments = New System.Windows.Forms.Label()
      Me.txtTotalPrice = New System.Windows.Forms.TextBox()
      Me.txtNumGuests = New System.Windows.Forms.TextBox()
      Me.txtNumDays = New System.Windows.Forms.TextBox()
      Me.txtComments = New System.Windows.Forms.TextBox()
      Me.txtCustomerId = New System.Windows.Forms.TextBox()
      Me.pckDate = New System.Windows.Forms.DateTimePicker()
      Me.pckCheckin = New System.Windows.Forms.DateTimePicker()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnCancel = New System.Windows.Forms.Button()
      Me.bxRoomNumber = New System.Windows.Forms.ComboBox()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.PictureBox2 = New System.Windows.Forms.PictureBox()
      Me.PictureBox3 = New System.Windows.Forms.PictureBox()
      Me.PictureBox4 = New System.Windows.Forms.PictureBox()
      Me.PictureBox5 = New System.Windows.Forms.PictureBox()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.picInfor2 = New System.Windows.Forms.PictureBox()
      Me.picInfor = New System.Windows.Forms.PictureBox()
      Me.btnRefresh = New System.Windows.Forms.Button()
      Me.txtBookId = New System.Windows.Forms.TextBox()
      Me.lblBookId = New System.Windows.Forms.Label()
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
      Me.btnLast = New System.Windows.Forms.Button()
      Me.btnNext = New System.Windows.Forms.Button()
      Me.btnPrev = New System.Windows.Forms.Button()
      Me.btnFirst = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnUpdate = New System.Windows.Forms.Button()
      Me.btnFind = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.dgvBooking = New System.Windows.Forms.DataGridView()
      Me.btnInvoice = New System.Windows.Forms.Button()
      Me.GenerateControlBreakReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Report6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.CBR1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.CBR2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.GroupBox1.SuspendLayout()
      CType(Me.picInfor2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picInfor, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.MenuStrip1.SuspendLayout()
      CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'lblDate
      '
      Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblDate.Location = New System.Drawing.Point(6, 55)
      Me.lblDate.Name = "lblDate"
      Me.lblDate.Size = New System.Drawing.Size(120, 20)
      Me.lblDate.TabIndex = 0
      Me.lblDate.Text = "Date"
      Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblRoomId
      '
      Me.lblRoomId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblRoomId.Location = New System.Drawing.Point(6, 85)
      Me.lblRoomId.Name = "lblRoomId"
      Me.lblRoomId.Size = New System.Drawing.Size(120, 20)
      Me.lblRoomId.TabIndex = 1
      Me.lblRoomId.Text = "Room number"
      Me.lblRoomId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblCustomerId
      '
      Me.lblCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblCustomerId.Location = New System.Drawing.Point(6, 115)
      Me.lblCustomerId.Name = "lblCustomerId"
      Me.lblCustomerId.Size = New System.Drawing.Size(120, 20)
      Me.lblCustomerId.TabIndex = 2
      Me.lblCustomerId.Text = "Customer Phone"
      Me.lblCustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblNumDays
      '
      Me.lblNumDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblNumDays.Location = New System.Drawing.Point(6, 145)
      Me.lblNumDays.Name = "lblNumDays"
      Me.lblNumDays.Size = New System.Drawing.Size(120, 20)
      Me.lblNumDays.TabIndex = 3
      Me.lblNumDays.Text = "Number of days"
      Me.lblNumDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblNumGuests
      '
      Me.lblNumGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblNumGuests.Location = New System.Drawing.Point(6, 175)
      Me.lblNumGuests.Name = "lblNumGuests"
      Me.lblNumGuests.Size = New System.Drawing.Size(120, 20)
      Me.lblNumGuests.TabIndex = 4
      Me.lblNumGuests.Text = "Number of guests"
      Me.lblNumGuests.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblCheckinDate
      '
      Me.lblCheckinDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblCheckinDate.Location = New System.Drawing.Point(6, 205)
      Me.lblCheckinDate.Name = "lblCheckinDate"
      Me.lblCheckinDate.Size = New System.Drawing.Size(120, 20)
      Me.lblCheckinDate.TabIndex = 5
      Me.lblCheckinDate.Text = "Check-in date"
      Me.lblCheckinDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblTotalPrice
      '
      Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblTotalPrice.Location = New System.Drawing.Point(6, 235)
      Me.lblTotalPrice.Name = "lblTotalPrice"
      Me.lblTotalPrice.Size = New System.Drawing.Size(120, 20)
      Me.lblTotalPrice.TabIndex = 6
      Me.lblTotalPrice.Text = "Total price"
      Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblComments
      '
      Me.lblComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblComments.Location = New System.Drawing.Point(6, 265)
      Me.lblComments.Name = "lblComments"
      Me.lblComments.Size = New System.Drawing.Size(120, 20)
      Me.lblComments.TabIndex = 7
      Me.lblComments.Text = "Comments"
      Me.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'txtTotalPrice
      '
      Me.txtTotalPrice.Location = New System.Drawing.Point(143, 235)
      Me.txtTotalPrice.Name = "txtTotalPrice"
      Me.txtTotalPrice.ReadOnly = True
      Me.txtTotalPrice.Size = New System.Drawing.Size(220, 20)
      Me.txtTotalPrice.TabIndex = 10
      '
      'txtNumGuests
      '
      Me.txtNumGuests.Location = New System.Drawing.Point(143, 176)
      Me.txtNumGuests.Name = "txtNumGuests"
      Me.txtNumGuests.Size = New System.Drawing.Size(220, 20)
      Me.txtNumGuests.TabIndex = 12
      '
      'txtNumDays
      '
      Me.txtNumDays.Location = New System.Drawing.Point(143, 145)
      Me.txtNumDays.Name = "txtNumDays"
      Me.txtNumDays.Size = New System.Drawing.Size(220, 20)
      Me.txtNumDays.TabIndex = 13
      Me.txtNumDays.Text = "1"
      '
      'txtComments
      '
      Me.txtComments.Location = New System.Drawing.Point(143, 266)
      Me.txtComments.Multiline = True
      Me.txtComments.Name = "txtComments"
      Me.txtComments.Size = New System.Drawing.Size(220, 40)
      Me.txtComments.TabIndex = 14
      Me.txtComments.Text = " "
      '
      'txtCustomerId
      '
      Me.txtCustomerId.Location = New System.Drawing.Point(143, 115)
      Me.txtCustomerId.Name = "txtCustomerId"
      Me.txtCustomerId.Size = New System.Drawing.Size(220, 20)
      Me.txtCustomerId.TabIndex = 15
      '
      'pckDate
      '
      Me.pckDate.Enabled = False
      Me.pckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.pckDate.Location = New System.Drawing.Point(143, 55)
      Me.pckDate.Name = "pckDate"
      Me.pckDate.ShowCheckBox = True
      Me.pckDate.Size = New System.Drawing.Size(121, 20)
      Me.pckDate.TabIndex = 17
      '
      'pckCheckin
      '
      Me.pckCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.pckCheckin.Location = New System.Drawing.Point(143, 205)
      Me.pckCheckin.Name = "pckCheckin"
      Me.pckCheckin.ShowCheckBox = True
      Me.pckCheckin.Size = New System.Drawing.Size(100, 20)
      Me.pckCheckin.TabIndex = 18
      '
      'btnSave
      '
      Me.btnSave.Location = New System.Drawing.Point(515, 52)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(107, 23)
      Me.btnSave.TabIndex = 19
      Me.btnSave.Text = "Save"
      Me.btnSave.UseVisualStyleBackColor = True
      '
      'btnCancel
      '
      Me.btnCancel.Location = New System.Drawing.Point(486, 295)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.Size = New System.Drawing.Size(75, 23)
      Me.btnCancel.TabIndex = 20
      Me.btnCancel.Text = "Cancel"
      Me.btnCancel.UseVisualStyleBackColor = True
      '
      'bxRoomNumber
      '
      Me.bxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.bxRoomNumber.FormattingEnabled = True
      Me.bxRoomNumber.Location = New System.Drawing.Point(143, 85)
      Me.bxRoomNumber.Name = "bxRoomNumber"
      Me.bxRoomNumber.Size = New System.Drawing.Size(121, 21)
      Me.bxRoomNumber.TabIndex = 21
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox1.Location = New System.Drawing.Point(270, 85)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox1.TabIndex = 22
      Me.PictureBox1.TabStop = False
      Me.PictureBox1.Visible = False
      '
      'PictureBox2
      '
      Me.PictureBox2.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox2.Location = New System.Drawing.Point(368, 115)
      Me.PictureBox2.Name = "PictureBox2"
      Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox2.TabIndex = 23
      Me.PictureBox2.TabStop = False
      Me.PictureBox2.Visible = False
      '
      'PictureBox3
      '
      Me.PictureBox3.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox3.Location = New System.Drawing.Point(368, 145)
      Me.PictureBox3.Name = "PictureBox3"
      Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox3.TabIndex = 24
      Me.PictureBox3.TabStop = False
      Me.PictureBox3.Visible = False
      '
      'PictureBox4
      '
      Me.PictureBox4.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox4.Location = New System.Drawing.Point(368, 176)
      Me.PictureBox4.Name = "PictureBox4"
      Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox4.TabIndex = 25
      Me.PictureBox4.TabStop = False
      Me.PictureBox4.Visible = False
      '
      'PictureBox5
      '
      Me.PictureBox5.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources.Button_Close_icon
      Me.PictureBox5.Location = New System.Drawing.Point(249, 205)
      Me.PictureBox5.Name = "PictureBox5"
      Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox5.TabIndex = 26
      Me.PictureBox5.TabStop = False
      Me.PictureBox5.Visible = False
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.picInfor2)
      Me.GroupBox1.Controls.Add(Me.picInfor)
      Me.GroupBox1.Controls.Add(Me.btnRefresh)
      Me.GroupBox1.Controls.Add(Me.txtBookId)
      Me.GroupBox1.Controls.Add(Me.lblBookId)
      Me.GroupBox1.Controls.Add(Me.lblDate)
      Me.GroupBox1.Controls.Add(Me.lblRoomId)
      Me.GroupBox1.Controls.Add(Me.PictureBox5)
      Me.GroupBox1.Controls.Add(Me.lblCustomerId)
      Me.GroupBox1.Controls.Add(Me.PictureBox4)
      Me.GroupBox1.Controls.Add(Me.lblNumDays)
      Me.GroupBox1.Controls.Add(Me.PictureBox3)
      Me.GroupBox1.Controls.Add(Me.lblNumGuests)
      Me.GroupBox1.Controls.Add(Me.PictureBox2)
      Me.GroupBox1.Controls.Add(Me.lblCheckinDate)
      Me.GroupBox1.Controls.Add(Me.PictureBox1)
      Me.GroupBox1.Controls.Add(Me.lblTotalPrice)
      Me.GroupBox1.Controls.Add(Me.bxRoomNumber)
      Me.GroupBox1.Controls.Add(Me.lblComments)
      Me.GroupBox1.Controls.Add(Me.txtTotalPrice)
      Me.GroupBox1.Controls.Add(Me.txtNumGuests)
      Me.GroupBox1.Controls.Add(Me.pckCheckin)
      Me.GroupBox1.Controls.Add(Me.txtNumDays)
      Me.GroupBox1.Controls.Add(Me.pckDate)
      Me.GroupBox1.Controls.Add(Me.txtComments)
      Me.GroupBox1.Controls.Add(Me.txtCustomerId)
      Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(400, 320)
      Me.GroupBox1.TabIndex = 28
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Booking Detail"
      '
      'picInfor2
      '
      Me.picInfor2.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources._1493456375_Info_Circle_Symbol_Information_Letter
      Me.picInfor2.Location = New System.Drawing.Point(270, 55)
      Me.picInfor2.Name = "picInfor2"
      Me.picInfor2.Size = New System.Drawing.Size(20, 20)
      Me.picInfor2.TabIndex = 35
      Me.picInfor2.TabStop = False
      '
      'picInfor
      '
      Me.picInfor.Image = Global.s3575984_Assignment02_HRRIS.My.Resources.Resources._1493456375_Info_Circle_Symbol_Information_Letter
      Me.picInfor.Location = New System.Drawing.Point(270, 25)
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
      Me.btnRefresh.Location = New System.Drawing.Point(363, 19)
      Me.btnRefresh.Name = "btnRefresh"
      Me.btnRefresh.Size = New System.Drawing.Size(25, 25)
      Me.btnRefresh.TabIndex = 33
      Me.btnRefresh.UseVisualStyleBackColor = True
      '
      'txtBookId
      '
      Me.txtBookId.Location = New System.Drawing.Point(143, 25)
      Me.txtBookId.Name = "txtBookId"
      Me.txtBookId.ReadOnly = True
      Me.txtBookId.Size = New System.Drawing.Size(121, 20)
      Me.txtBookId.TabIndex = 28
      '
      'lblBookId
      '
      Me.lblBookId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblBookId.Location = New System.Drawing.Point(6, 25)
      Me.lblBookId.Name = "lblBookId"
      Me.lblBookId.Size = New System.Drawing.Size(120, 20)
      Me.lblBookId.TabIndex = 27
      Me.lblBookId.Text = "Booking ID"
      Me.lblBookId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'MenuStrip1
      '
      Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataCaptureToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
      Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
      Me.MenuStrip1.Name = "MenuStrip1"
      Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
      Me.MenuStrip1.TabIndex = 29
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
      'btnNew
      '
      Me.btnNew.Location = New System.Drawing.Point(427, 52)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(75, 23)
      Me.btnNew.TabIndex = 47
      Me.btnNew.TabStop = False
      Me.btnNew.Text = "New"
      Me.btnNew.UseVisualStyleBackColor = True
      '
      'dgvBooking
      '
      Me.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvBooking.Location = New System.Drawing.Point(12, 356)
      Me.dgvBooking.Name = "dgvBooking"
      Me.dgvBooking.ReadOnly = True
      Me.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dgvBooking.Size = New System.Drawing.Size(610, 104)
      Me.dgvBooking.TabIndex = 48
      Me.dgvBooking.TabStop = False
      '
      'btnInvoice
      '
      Me.btnInvoice.Location = New System.Drawing.Point(465, 251)
      Me.btnInvoice.Name = "btnInvoice"
      Me.btnInvoice.Size = New System.Drawing.Size(117, 23)
      Me.btnInvoice.TabIndex = 49
      Me.btnInvoice.Text = "Invoice"
      Me.btnInvoice.UseVisualStyleBackColor = True
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
      'frmBooking
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(634, 472)
      Me.Controls.Add(Me.btnInvoice)
      Me.Controls.Add(Me.dgvBooking)
      Me.Controls.Add(Me.btnNew)
      Me.Controls.Add(Me.btnLast)
      Me.Controls.Add(Me.btnNext)
      Me.Controls.Add(Me.btnPrev)
      Me.Controls.Add(Me.btnFirst)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnUpdate)
      Me.Controls.Add(Me.btnFind)
      Me.Controls.Add(Me.MenuStrip1)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnCancel)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.Name = "frmBooking"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Booking"
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      CType(Me.picInfor2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picInfor, System.ComponentModel.ISupportInitialize).EndInit()
      Me.MenuStrip1.ResumeLayout(False)
      Me.MenuStrip1.PerformLayout()
      CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblRoomId As System.Windows.Forms.Label
    Friend WithEvents lblCustomerId As System.Windows.Forms.Label
    Friend WithEvents lblNumDays As System.Windows.Forms.Label
    Friend WithEvents lblNumGuests As System.Windows.Forms.Label
    Friend WithEvents lblCheckinDate As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtNumGuests As System.Windows.Forms.TextBox
    Friend WithEvents txtNumDays As System.Windows.Forms.TextBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents pckDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents pckCheckin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents bxRoomNumber As System.Windows.Forms.ComboBox
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
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
   Friend WithEvents lblBookId As System.Windows.Forms.Label
   Friend WithEvents txtBookId As System.Windows.Forms.TextBox
   Friend WithEvents btnLast As System.Windows.Forms.Button
   Friend WithEvents btnNext As System.Windows.Forms.Button
   Friend WithEvents btnPrev As System.Windows.Forms.Button
   Friend WithEvents btnFirst As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnUpdate As System.Windows.Forms.Button
   Friend WithEvents btnFind As System.Windows.Forms.Button
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents btnRefresh As System.Windows.Forms.Button
   Friend WithEvents picInfor As System.Windows.Forms.PictureBox
   Friend WithEvents dgvBooking As System.Windows.Forms.DataGridView
    Friend WithEvents picInfor2 As System.Windows.Forms.PictureBox
   Friend WithEvents btnInvoice As System.Windows.Forms.Button
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
