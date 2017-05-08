Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing

' Name: fmBooking
' Description: this form is to add booking information
' Author: Pham Hoang Phuc
' Date: 28/03/2017

Public Class frmBooking


   '==================== Make global variable ========================

    Public Const CONNECTION_STRING As String = _
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3575984-dtb.accdb"
   Dim ds As DataSet
   Dim da As OleDbDataAdapter
   Dim tables As DataTableCollection
   Dim customerId As Integer

   Dim iCurIndex As Integer = 0
   Dim findBookingField As String
   Dim lsDataLoad As New List(Of Hashtable)
   Dim lsDataFind As New List(Of Hashtable)
   Dim isDefaultLoad As Boolean


   '================== This is for button on menu strip ====================

   Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
      If MsgBox("Are you sure to close the form?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
         Me.Close()
      End If
   End Sub

   Private Sub CustomerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
      My.Forms.frmCustomer.Show()
   End Sub

   Private Sub RoomToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
      My.Forms.frmRoom.Show()
   End Sub




   '============================================ report button on menu strip ==========================================

   Private Sub Report1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report1ToolStripMenuItem.Click
      My.Forms.frmReport1.Show()
   End Sub

   Private Sub Report2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report2ToolStripMenuItem.Click
      My.Forms.frmReport2.Show()
   End Sub

   Private Sub Report3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report3ToolStripMenuItem.Click
      My.Forms.frmReport3.Show()
   End Sub

   Private Sub Report4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report4ToolStripMenuItem.Click
      My.Forms.frmReport4.Show()
   End Sub

   Private Sub Report5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report5ToolStripMenuItem.Click
      My.Forms.frmReport5.Show()
   End Sub

   Private Sub Report6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report6ToolStripMenuItem.Click
      My.Forms.frmReport6.Show()
   End Sub

   Private Sub CBR1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBR1ToolStripMenuItem.Click
      My.Forms.frmCBReport1.Show()
   End Sub

   Private Sub CBR2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBR2ToolStripMenuItem.Click
      My.Forms.frmMenu.btnCBReport2.PerformClick()
   End Sub



   '=================================== help and about ========================================================

   Private Sub ViewHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click
      Dim sParam As String = """" & Application.StartupPath & "\HelpPage.html"""
      Debug.Print("sParam: " & sParam)
      System.Diagnostics.Process.Start(sParam)
   End Sub

   Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
      My.Forms.frmAbout.Show()
   End Sub




   '--------This is done when form is loaded---------------------------------------------------------------------------------------

   Private Sub frmBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      pckCheckin.Checked = False
      'make dropdown list contain room number, but will export room id
      Try
         oConnection.Open()
         ds = New DataSet
         tables = ds.Tables
         da = New OleDbDataAdapter("SELECT room_id, room_number from room", oConnection)
         da.Fill(ds, "room")
         Dim view1 As New DataView(tables(0))

         bxRoomNumber.DataSource = ds.Tables("room")
         bxRoomNumber.DisplayMember = "room_number"
         bxRoomNumber.ValueMember = "room_id"
         bxRoomNumber.SelectedIndex = -1

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
      Finally
         oConnection.Close()
      End Try

      Dim oController As controller = New controller
      isDefaultLoad = True
      lsDataLoad = oController.findAllBooking()
      Dim iIndex As Integer
      'set what record showed at start up, here is first record
      iIndex = 0
      'set public variable iCurIndex
      iCurIndex = iIndex

      populateFormFields(lsDataLoad.Item(iIndex))

      Dim tt As New ToolTip
      tt.SetToolTip(picInfor, "Changing this field only work when finding record")
      tt.SetToolTip(picInfor2, "Changing this only work when finding record" & vbCrLf & "It will record today while inserting and updating")
   End Sub



   Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bxRoomNumber.SelectedIndexChanged

      'if select room, total price will be updated
      Try
         Dim roomPrice As Integer
         Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
         oConnection.Open()
         Dim qry As OleDbCommand = New OleDbCommand("SELECT price from room where room_id=" & bxRoomNumber.SelectedValue.ToString & "", oConnection)
         Dim rd As OleDbDataReader = qry.ExecuteReader
         While rd.Read
            roomPrice = CInt(rd("price"))
            txtTotalPrice.Text = CStr(CDbl(rd("price")) * CDbl(txtNumDays.Text))
         End While
      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
      End Try
   End Sub



   Private Sub txtNumDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumDays.TextChanged

      'if num_day change, change total price
      If bxRoomNumber.SelectedIndex > -1 Then
         Try
            Dim roomPrice As Integer
            Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
            oConnection.Open()
            Dim qry As OleDbCommand = New OleDbCommand("SELECT price from room where room_id=" & bxRoomNumber.SelectedValue.ToString & "", oConnection)
            Dim rd As OleDbDataReader = qry.ExecuteReader
            'Dim found As Boolean = False
            While rd.Read
               'found = True
               roomPrice = CInt(rd("price"))
               txtTotalPrice.Text = CStr(CDbl(rd("price")) * CDbl(txtNumDays.Text))
            End While
         Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
         End Try
      End If

   End Sub


   '====================== This part is for buttons ==========================================================

   Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure to close the form?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
            End If 
    End Sub

    

    

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


      Try

         'Dim tt As New ToolTip()
         'Dim isAllValid As Boolean = True
         'Dim allowedGuests As Integer

         ''validate form
         ''room id
         'If bxRoomNumber.SelectedIndex > -1 Then
         '   PictureBox1.Visible = False
         'Else
         '   PictureBox1.Visible = True
         '   tt.SetToolTip(PictureBox1, "Please select room")
         '   isAllValid = False
         'End If

         ''fill in phone then get customer id
         'Try
         '   Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
         '   oConnection.Open()
         '   Dim qry As OleDbCommand = New OleDbCommand("SELECT customer_id, phone from customer where phone=" & "'" & txtCustomerId.Text & "'", oConnection)
         '   Dim rd As OleDbDataReader = qry.ExecuteReader
         '   Dim found As Boolean = False
         '   While rd.Read
         '      found = True
         '      customerId = CInt(rd("customer_id"))
         '   End While
         '   If txtCustomerId.Text.Length > 0 And IsNumeric(txtCustomerId.Text) And found = True Then
         '      PictureBox2.Visible = False
         '   Else
         '      PictureBox2.Visible = True
         '      tt.SetToolTip(PictureBox2, "Please check phone number again")
         '      isAllValid = False
         '   End If
         '   oConnection.Close()
         'Catch ex As Exception
         '   Debug.Print("ERROR: " & ex.Message)
         'End Try


         ''number of days
         'If txtNumDays.Text.Length > 0 And IsNumeric(txtNumDays.Text) Then
         '   PictureBox3.Visible = False
         'Else
         '   PictureBox3.Visible = True
         '   tt.SetToolTip(PictureBox3, "Please fill in number of days")
         '   isAllValid = False
         'End If

         ''number of guest must >= number of beds in room
         'Try
         '   Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
         '   oConnection.Open()
         '   Dim qry As OleDbCommand = New OleDbCommand("SELECT num_beds from room where room_id = " & CInt(bxRoomNumber.SelectedValue) & "", oConnection)
         '   Dim rd As OleDbDataReader = qry.ExecuteReader
         '   Dim found As Boolean = False
         '   While rd.Read
         '      found = True
         '      allowedGuests = CInt(rd("num_beds"))
         '   End While
         '   If txtNumGuests.Text.Length > 0 And IsNumeric(txtNumGuests.Text) Then
         '      If allowedGuests >= CInt(txtNumGuests.Text) Then
         '         PictureBox4.Visible = False
         '      ElseIf allowedGuests < CInt(txtNumGuests.Text) Then
         '         PictureBox4.Visible = True
         '         tt.SetToolTip(PictureBox4, "Number of guest is larger than allowed")
         '         isAllValid = False
         '      End If
         '   Else
         '      PictureBox4.Visible = True
         '      tt.SetToolTip(PictureBox4, "Please check guest number again")
         '      isAllValid = False
         '   End If

         '   oConnection.Close()
         'Catch ex As Exception
         '   Debug.Print("ERROR: " & ex.Message)
         'End Try

         ''check in date
         'If pckCheckin.Checked And pckCheckin.Value > Now() Then
         '   PictureBox5.Visible = False
         'Else
         '   PictureBox5.Visible = True
         '   tt.SetToolTip(PictureBox5, "Please select check-in date correctly")
         '   isAllValid = False
         'End If

         'Dim htBook As Hashtable = New Hashtable

         ''bind value to hastable
         'htBook("datebook") = Format(pckDate.Value, "dd/MM/yyyy")
         'htBook("room_id") = bxRoomNumber.SelectedValue
         'htBook("customer_id") = customerId
         'htBook("num_days") = txtNumDays.Text
         'htBook("num_guests") = txtNumGuests.Text
         'htBook("checkin_date") = Format(pckCheckin.Value, "dd/MM/yyyy")
         'htBook("total_price") = txtTotalPrice.Text
         'htBook("comments") = txtComments.Text

         ''insert into database if all field correct
         'If isAllValid Then
         '   Dim oCustomer As addToDB = New addToDB
         '   oCustomer.insertBooking(htBook)
         'Else
         '   MessageBox.Show("please check the inputs again")
         'End If
         If validateForm() Then
            Dim oBook As addToDB = New addToDB
            oBook.insertBooking(getFormData)
         Else
            MessageBox.Show("please check the inputs again")
         End If

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occurred. The record wasn't inserted.")
      End Try

    End Sub


   Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
      'this button willl clear all the form
      Me.Controls.Clear() 'removes all the controls on the form
      InitializeComponent() 'load all the controls again
      frmBooking_Load(e, e) 'Load everything in your form load event again
      clearForm()
   End Sub


   Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
      Me.Controls.Clear() 'removes all the controls on the form
      InitializeComponent() 'load all the controls again
      frmBooking_Load(e, e) 'Load everything in your form load event again
   End Sub


   Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
      Dim findInfor As Integer = 0
      Dim check As validation = New validation
      Dim oController As controller = New controller
      Dim key As String = ""
      iCurIndex = 0
      isDefaultLoad = False
      'limit to find base on 1 criteria only, and also validate the input data
      If txtBookId.Text.Length > 0 And txtBookId.Text.Length < 50 And IsNumeric(txtBookId.Text) Then
         findInfor = findInfor + 1
         findBookingField = "booking_id"
         key = CStr(txtBookId.Text)
        End If

      If pckDate.Checked = True Then
         findInfor = findInfor + 1
         findBookingField = "datebook"
         key = CStr(pckDate.Value)
        End If

      If bxRoomNumber.SelectedIndex > -1 Then
         findInfor = findInfor + 1
         findBookingField = "room_id"
         key = CStr(bxRoomNumber.SelectedValue)
        End If

      If txtCustomerId.Text.Length > 0 And txtCustomerId.Text.Length < 50 And IsNumeric(txtCustomerId.Text) Then
         findInfor = findInfor + 1
         findBookingField = "customer_id"
         Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
         Dim cIdTemp As String
         oConnection.Open()
            Dim qry As OleDbCommand = New OleDbCommand("SELECT customer_id, phone from customer where phone =""" & CStr(txtCustomerId.Text) & """", oConnection)
         Dim rd As OleDbDataReader = qry.ExecuteReader
         Dim found As Boolean = False
         While rd.Read
            found = True
                cIdTemp = CStr(rd("customer_id"))
         End While
         oConnection.Close()
         key = CStr(cIdTemp)
        End If

      If txtNumDays.Text.Length > 0 And IsNumeric(txtNumDays.Text) Then
         findInfor = findInfor + 1
         findBookingField = "num_days"
         key = CStr(txtNumDays.Text)
        End If

      If txtNumGuests.Text.Length > 0 And IsNumeric(txtNumGuests.Text) Then
         findInfor = findInfor + 1
         findBookingField = "num_guests"
         key = CStr(txtNumGuests.Text)
      End If
      If pckCheckin.Checked = True Then
         findInfor = findInfor + 1
         findBookingField = "checkin_date"
         key = CStr(pckCheckin.Value)
      End If
      If txtComments.Text.Length > 0 Then
         findInfor = findInfor + 1
         findBookingField = "comments"
         key = CStr(txtComments.Text)
      End If

      If findInfor = 0 Then
         MsgBox("No keyword to search" & vbCrLf & "Please enter ONE valid searching criteria", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Invalid Information")
      ElseIf findInfor > 1 Then
         MsgBox("You can only search by one criteria at a time", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Please check again...")
         findBookingField = ""
         key = ""
      Else
         Debug.Print("ok now")
         lsDataFind = oController.findBooking(findBookingField, key)

         If lsDataFind.Count = 1 Then
            populateFormFields(lsDataFind.Item(0))
         ElseIf lsDataFind.Count > 1 Then
            populateFormFields(lsDataFind.Item(0))

            'populate dgvCustomer
            Try
               Dim oConnect As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
               Dim ds As New DataTable
               Dim da As OleDbDataAdapter
               oConnect.Open()
               Select Case findBookingField
                  Case "booking_id", "customer_id", "room_id"
                     da = New OleDbDataAdapter("SELECT * from booking where " & findBookingField & " = " & CInt(key) & "", oConnect)
                  Case "datebook", "checkin_date"
                     da = New OleDbDataAdapter("SELECT * from booking where datediff('d'," & findBookingField & ", " & CDate(key) & " ) = 0", oConnect)
                  Case "num_days", "num_guests"
                     da = New OleDbDataAdapter("SELECT * from booking where " & findBookingField & " = " & CInt(key) & "", oConnect)
                  Case Else
                     da = New OleDbDataAdapter("SELECT * from booking where " & findBookingField & " like '%" & key & "%'", oConnect)
               End Select
               da.Fill(ds)
               dgvBooking.DataSource = ds

            Catch ex As Exception
               Debug.Print("ERROR: " & ex.Message)
            Finally

            End Try

         Else
            MsgBox("No record found", MsgBoxStyle.OkOnly)
         End If

      End If
   End Sub


   Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
      Dim oController As New controller
      If validateFormUpdate() Then

         If checkInvoice(CInt(txtBookId.Text)) Then

            If MsgBox("This booking's invoice is already created, updating this booking will result in updating its invoice too." & vbCrLf & "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
               Dim iResult = oController.updateBooking(getFormData)
               If iResult = 1 Then
                  MsgBox("The record was updated." & vbCrLf & "Use the find button to check ...", MsgBoxStyle.OkOnly)
               Else
                  MsgBox("The record was not updated!")
               End If

               Try
                  Dim invoi As New Hashtable

                  invoi("booking_id") = txtBookId.Text
                  invoi("amount") = txtTotalPrice.Text

                  Dim oInvoice As New controller
                  oInvoice.updateInvoice(invoi)

                  'My.Forms.frmInvoice.Show()

               Catch ex As Exception
                  Debug.Print("ERROR: " & ex.Message)
                  MsgBox("An error occurred. The record wasn't inserted.")
               End Try

            End If

         Else

            Dim iResult = oController.updateBooking(getFormData)
            If iResult = 1 Then
               MsgBox("The record was updated." & vbCrLf & "Use the find button to check ...", MsgBoxStyle.OkOnly)
            Else
               MsgBox("The record was not updated!")
            End If

         End If

         'Dim iResult = oController.updateBooking(getFormData)
         'If iResult = 1 Then
         '   MsgBox("The record was updated." & vbCrLf & "Use the find button to check ...", MsgBoxStyle.OkOnly)
         'Else
         '   MsgBox("The record was not updated!")
         'End If
      Else : MsgBox("Inserted field(s) invalid", MsgBoxStyle.OkOnly, "Error")
      End If

      'If checkInvoice(CInt(txtBookId.Text)) Then
      '   If MsgBox("This booking's invoice is already created, updating this booking will result in updating its invoice too." & vbCrLf & "Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

      '   End If
      'End If

   End Sub


   Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
      If MsgBox("Are you sure to delete this record?", MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
         Dim oController As New controller
         Dim bId = txtBookId.Text
         Dim iResult = oController.deleteBooking(bId)

         If iResult = 1 Then
            clearForm()
            MsgBox("The record was deleted." & vbCrLf & "Use the find button to check ...", MsgBoxStyle.OkOnly)
         Else
            MsgBox("The record was not deleted!")
         End If
      End If
   End Sub




   '-----------navigation button------------------------------------------------------------------------------------------------

   Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
      Dim iIndex As Integer
      iIndex = 0
      iCurIndex = iIndex

      'handle for loading all records or finding records
      If isDefaultLoad Then
         populateFormFields(lsDataLoad.Item(iIndex))
      Else : populateFormFields(lsDataFind.Item(iIndex))
      End If

      'to select the row of datagridview to match with the form
      If dgvBooking.RowCount > 1 Then
         dgvBooking.ClearSelection()
         dgvBooking.Rows(iIndex).Selected = True
      End If
   End Sub

   Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
      Dim iIndex As Integer
      iIndex = iCurIndex - 1
      iCurIndex = iIndex
      If isDefaultLoad Then
         populateFormFields(lsDataLoad.Item(iIndex))
      Else : populateFormFields(lsDataFind.Item(iIndex))
      End If

      If dgvBooking.RowCount > 1 Then
         dgvBooking.ClearSelection()
         dgvBooking.Rows(iIndex).Selected = True
      End If
   End Sub

   Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
      Dim iIndex As Integer
      iIndex = iCurIndex + 1
      iCurIndex = iIndex

      If isDefaultLoad Then
         populateFormFields(lsDataLoad.Item(iIndex))
      Else : populateFormFields(lsDataFind.Item(iIndex))
      End If

      If dgvBooking.RowCount > 1 Then
         dgvBooking.ClearSelection()
         dgvBooking.Rows(iIndex).Selected = True
      End If
   End Sub

   Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
      Dim iIndex As Integer

      If isDefaultLoad Then
         iIndex = lsDataLoad.Count - 1
      Else : iIndex = lsDataFind.Count - 1
      End If
      iCurIndex = iIndex

      If isDefaultLoad Then
         populateFormFields(lsDataLoad.Item(iIndex))
      Else : populateFormFields(lsDataFind.Item(iIndex))
      End If

      If dgvBooking.RowCount > 1 Then
         dgvBooking.ClearSelection()
         dgvBooking.Rows(iIndex).Selected = True
      End If
   End Sub

   
   '==================== This part contains function and method sub ==========================================================

   'this method is used to fill data to the form----------------------------------------------------------------------------
   Private Sub populateFormFields(ByVal htdata As Hashtable)
      txtBookId.Text = CStr(htdata("booking_id"))
      pckDate.Value = CDate(htdata("datebook"))
      bxRoomNumber.SelectedValue = CStr(htdata("room_id"))

      txtNumDays.Text = CStr(htdata("num_days"))
      txtNumGuests.Text = CStr(htdata("num_guests"))
      pckCheckin.Value = CDate(htdata("checkin_date"))
      txtTotalPrice.Text = CStr(htdata("total_price"))
      txtComments.Text = CStr(htdata("comments"))
      txtBookId.ReadOnly = True
      'txtCustomerId.ReadOnly = True

      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim phone As String
      oConnection.Open()
      Dim qry As OleDbCommand = New OleDbCommand("SELECT customer_id, phone from customer where customer_id =" & CStr(htdata("customer_id")) & "", oConnection)
      Dim rd As OleDbDataReader = qry.ExecuteReader
      Dim found As Boolean = False
      While rd.Read
         found = True
         phone = CStr(rd("phone"))
         txtCustomerId.Text = phone
      End While
      oConnection.Close()
      'txtCustomerId.Text = phone

   End Sub

   'this sub this to clear the form---------------------------------------------------------------------------
   Private Sub clearForm()
      txtBookId.Clear()
      txtComments.Clear()
      txtCustomerId.Clear()
      txtNumDays.Clear()
      txtNumGuests.Clear()
      txtTotalPrice.Clear()
      pckDate.Value = Now()
      pckCheckin.Value = Now()
      pckCheckin.Checked = False
      bxRoomNumber.SelectedIndex = -1
      'txtCustomerId.ReadOnly = False
      pckDate.Checked = False
      pckDate.Enabled = True
      txtBookId.ReadOnly = False
   End Sub


   'this function is used to collect input data from the form to the hastable---------------------------------------------------
   Private Function getFormData() As Hashtable
      Dim htBook As Hashtable = New Hashtable

      If txtBookId.Text.Length > 0 Then
         htBook("booking_id") = txtBookId.Text
      End If

      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      oConnection.Open()
      Dim qry As OleDbCommand = New OleDbCommand("SELECT customer_id, phone from customer where phone=" & "'" & txtCustomerId.Text & "'", oConnection)
      Dim rd As OleDbDataReader = qry.ExecuteReader
      Dim found As Boolean = False
      While rd.Read
         found = True
         customerId = CInt(rd("customer_id"))
      End While

      'bind value to hastable
      htBook("datebook") = Format(pckDate.Value, "dd/MM/yyyy")
      htBook("room_id") = bxRoomNumber.SelectedValue
      htBook("customer_id") = customerId
      htBook("num_days") = txtNumDays.Text
      htBook("num_guests") = txtNumGuests.Text
      htBook("checkin_date") = Format(pckCheckin.Value, "dd/MM/yyyy")
      htBook("total_price") = txtTotalPrice.Text
      htBook("comments") = txtComments.Text
      Return htBook
   End Function



   'this function is to validate input data----------------------------------------------------------------------------------
   Private Function validateForm() As Boolean
      Dim tt As New ToolTip()
      Dim isAllValid As Boolean = True
      Dim customerId As Integer
      Dim allowedGuests As Integer

      Dim htBook As Hashtable = New Hashtable

      'validate form

      'room id
      If bxRoomNumber.SelectedIndex > -1 Then
         PictureBox1.Visible = False
      Else
         PictureBox1.Visible = True
         tt.SetToolTip(PictureBox1, "Please select room")
         isAllValid = False
      End If

      'fill in phone then get customer id
      Try
         Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
         oConnection.Open()
         Dim qry As OleDbCommand = New OleDbCommand("SELECT customer_id, phone from customer where phone=" & "'" & txtCustomerId.Text & "'", oConnection)
         Dim rd As OleDbDataReader = qry.ExecuteReader
         Dim found As Boolean = False
         While rd.Read
            found = True
            customerId = CInt(rd("customer_id"))
         End While
         If txtCustomerId.Text.Length > 0 And IsNumeric(txtCustomerId.Text) And found = True Then
            PictureBox2.Visible = False
         Else
            PictureBox2.Visible = True
            tt.SetToolTip(PictureBox2, "Please check phone number again")
            isAllValid = False
         End If
         oConnection.Close()
      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
      End Try


      'number of days
      If txtNumDays.Text.Length > 0 And 4 > txtNumDays.Text.Length And IsNumeric(txtNumDays.Text) Then
         PictureBox3.Visible = False
      Else
         PictureBox3.Visible = True
         tt.SetToolTip(PictureBox3, "Please fill in number of days")
         isAllValid = False
      End If

      'number of guest must >= number of beds in room
      Try
         Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
         oConnection.Open()
         Dim qry As OleDbCommand = New OleDbCommand("SELECT num_beds from room where room_id = " & CInt(bxRoomNumber.SelectedValue) & "", oConnection)
         Dim rd As OleDbDataReader = qry.ExecuteReader
         Dim found As Boolean = False
         While rd.Read
            found = True
            allowedGuests = CInt(rd("num_beds"))
         End While
         If txtNumGuests.Text.Length > 0 And IsNumeric(txtNumGuests.Text) Then
            If allowedGuests >= CInt(txtNumGuests.Text) Then
               PictureBox4.Visible = False
            ElseIf allowedGuests < CInt(txtNumGuests.Text) Then
               PictureBox4.Visible = True
               tt.SetToolTip(PictureBox4, "This room only allows " & CStr(allowedGuests) & " guest(s) only")
               isAllValid = False
            End If
         Else
            PictureBox4.Visible = True
            tt.SetToolTip(PictureBox4, "Please check guest number again")
            isAllValid = False
         End If

         oConnection.Close()
      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
      End Try

      'check in date
      If pckCheckin.Checked And pckCheckin.Value > Now() Then
         PictureBox5.Visible = False
      Else
         PictureBox5.Visible = True
         tt.SetToolTip(PictureBox5, "Please select check-in date correctly")
         isAllValid = False
      End If
      If isAllValid Then
         Return True
      Else : Return False
      End If
   End Function



   '-------------- validate data for update function --------------------------------------------------------------
   Private Function validateFormUpdate() As Boolean
      Dim tt As New ToolTip()
      Dim isAllValid As Boolean = True
      Dim customerId As Integer
      Dim allowedGuests As Integer

      Dim htBook As Hashtable = New Hashtable

      'validate form

      'room id
      If bxRoomNumber.SelectedIndex > -1 Then
         PictureBox1.Visible = False
      Else
         PictureBox1.Visible = True
         tt.SetToolTip(PictureBox1, "Please select room")
         isAllValid = False
      End If

      'fill in phone then get customer id
      Try
         Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
         oConnection.Open()
         Dim qry As OleDbCommand = New OleDbCommand("SELECT customer_id, phone from customer where phone=" & "'" & txtCustomerId.Text & "'", oConnection)
         Dim rd As OleDbDataReader = qry.ExecuteReader
         Dim found As Boolean = False
         While rd.Read
            found = True
            customerId = CInt(rd("customer_id"))
         End While
         If txtCustomerId.Text.Length > 0 And IsNumeric(txtCustomerId.Text) And found = True Then
            PictureBox2.Visible = False
         Else
            PictureBox2.Visible = True
            tt.SetToolTip(PictureBox2, "Please check phone number again")
            isAllValid = False
         End If
         oConnection.Close()
      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
      End Try


      'number of days
      If txtNumDays.Text.Length > 0 And 4 > txtNumDays.Text.Length And IsNumeric(txtNumDays.Text) Then
         PictureBox3.Visible = False
      Else
         PictureBox3.Visible = True
         tt.SetToolTip(PictureBox3, "Please fill in number of days")
         isAllValid = False
      End If

      'number of guest must >= number of beds in room
      Try
         Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
         oConnection.Open()
         Dim qry As OleDbCommand = New OleDbCommand("SELECT num_beds from room where room_id = " & CInt(bxRoomNumber.SelectedValue) & "", oConnection)
         Dim rd As OleDbDataReader = qry.ExecuteReader
         Dim found As Boolean = False
         While rd.Read
            found = True
            allowedGuests = CInt(rd("num_beds"))
         End While
         If txtNumGuests.Text.Length > 0 And IsNumeric(txtNumGuests.Text) Then
            If allowedGuests >= CInt(txtNumGuests.Text) Then
               PictureBox4.Visible = False
            ElseIf allowedGuests < CInt(txtNumGuests.Text) Then
               PictureBox4.Visible = True
               tt.SetToolTip(PictureBox4, "This room only allows " & CStr(allowedGuests) & " guest(s) only")
               isAllValid = False
            End If
         Else
            PictureBox4.Visible = True
            tt.SetToolTip(PictureBox4, "Please check guest number again")
            isAllValid = False
         End If

         oConnection.Close()
      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
      End Try

      'check in date
      'If pckCheckin.Checked And pckCheckin.Value > Now() Then
      '   PictureBox5.Visible = False
      'Else
      '   PictureBox5.Visible = True
      '   tt.SetToolTip(PictureBox5, "Please select check-in date correctly")
      '   isAllValid = False
      'End If
      If isAllValid Then
         Return True
      Else : Return False
      End If
   End Function



   '======================== handle when clicking navigation button -> change to another record =====================================

   Private Sub txtBookId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBookId.TextChanged
      If iCurIndex = 0 Then
         btnPrev.Enabled = False
      Else : btnPrev.Enabled = True
      End If

      'If iCurIndex = lsDataLoad.Count - 1 Then
      '   btnNext.Enabled = False
      'Else : btnNext.Enabled = True
      'End If
      If isDefaultLoad Then
         If iCurIndex = lsDataLoad.Count - 1 Then
            btnNext.Enabled = False
         Else : btnNext.Enabled = True
         End If
      Else : If iCurIndex = lsDataFind.Count - 1 Then
            btnNext.Enabled = False
         Else : btnNext.Enabled = True
         End If
      End If

      If iCurIndex = 0 Then
         btnFirst.Enabled = False
      Else : btnFirst.Enabled = True
      End If

      'If iCurIndex = lsDataLoad.Count - 1 Then
      '   btnLast.Enabled = False
      'Else : btnLast.Enabled = True
      'End If
      If isDefaultLoad Then
         If iCurIndex = lsDataLoad.Count - 1 Then
            btnLast.Enabled = False
         Else : btnLast.Enabled = True
         End If
      Else : If iCurIndex = lsDataFind.Count - 1 Then
            btnLast.Enabled = False
         Else : btnLast.Enabled = True
         End If
      End If
   End Sub









   '============================================= For invoice part ======================================================================================


   'handle invoice button
    Private Sub btnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvoice.Click

      'if there is a record displayed, if it don't have invoice yet, create invoice, if already had, display invoice
      If validateFormUpdate() Then

         If checkInvoice(CInt(txtBookId.Text)) Then
            My.Forms.frmInvoice.Show()
         Else
            Try
               Dim invoi As New Hashtable

               invoi("booking_id") = txtBookId.Text
               invoi("amount") = txtTotalPrice.Text

               Dim oInvoice As New controller
               oInvoice.insertInvoice(invoi)

               My.Forms.frmInvoice.Show()

            Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The record wasn't inserted.")
         End Try
         End If
      Else
         MessageBox.Show("please check the inputs again")

      End If

      
   End Sub


   'function to check if the record have invoice or not
   Private Function checkInvoice(ByVal bID As Integer) As Boolean

      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      oConnection.Open()
      Dim qry As OleDbCommand = New OleDbCommand("SELECT * from invoice where booking_id =" & bID & "", oConnection)
      Dim rd As OleDbDataReader = qry.ExecuteReader
      Dim found As Boolean = False
      While rd.Read
         found = True
      End While


      If found Then
         Return True
      Else : Return False
      End If


   End Function

   
End Class







