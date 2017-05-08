Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing

' Name: fmRoom
' Description: this form is to add room information
' Author: Pham Hoang Phuc
' Date: 28/03/2017

Public Class frmRoom

   '================================== Declare global variable ========================================================

   Dim avai As String

   Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3575984-dtb.accdb"

   Dim iCurIndex As Integer = 0
   Dim findRoomField As String
   Dim lsDataLoad As New List(Of Hashtable)
   Dim lsDataFind As New List(Of Hashtable)
   Dim isDefaultLoad As Boolean


   '================================== Button file and data capture of menu strip ==========================================================

   Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
      If MsgBox("Are you sure to close the form?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
         Me.Close()
      End If
   End Sub

   Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
      My.Forms.frmCustomer.Show()
   End Sub

   Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
      My.Forms.frmBooking.Show()
   End Sub




   '======================================= report button on menu strip =================================================

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


   '=================================== help and about =================================================

   Private Sub ViewHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click
      Dim sParam As String = """" & Application.StartupPath & "\HelpPage.html"""
      Debug.Print("sParam: " & sParam)
      System.Diagnostics.Process.Start(sParam)
   End Sub

   Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
      My.Forms.frmAbout.Show()
   End Sub


   '================================= Code for form load =======================================================

   Private Sub frmRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oController As controller = New controller
      isDefaultLoad = True
      lsDataLoad = oController.findAllRoom()
      Dim iIndex As Integer
      'set what record showed at start up, here is first record
      iIndex = 0
      'set public variable iCurIndex
      iCurIndex = iIndex
      'Get the first record
      populateFormFields(lsDataLoad.Item(iIndex))

      Dim tt As New ToolTip
      tt.SetToolTip(picInfor, "Changing this field only work when finding record")

   End Sub



   '================================ Code for button in the form =================================================


   Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure to close the form?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
   End Sub

   Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdYes.CheckedChanged
      avai = "Yes"
   End Sub

   Private Sub rdNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdNo.CheckedChanged
      avai = "No"
   End Sub

   Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

      Try

         'input data will be validated through function validateForm() below
         'bind value to hashtable will be done throught function getFormData()

         'insert into database if all fields is true
         If validateForm() Then
            Dim oRoom As addToDB = New addToDB
            oRoom.insertRoom(getFormData)
         Else
            MessageBox.Show("please check the inputs again")
         End If

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occurred. The record wasn't inserted.")

      End Try

   End Sub



   Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
      Me.Controls.Clear() 'removes all the controls on the form
      InitializeComponent() 'load all the controls again
      frmRoom_Load(e, e) 'Load everything in your form load event again
   End Sub



   Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
      'this button willl clear all the form
      Me.Controls.Clear() 'removes all the controls on the form
      InitializeComponent() 'load all the controls again
      frmRoom_Load(e, e) 'Load everything in your form load event again
      clearForm()
   End Sub

   Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
      Dim findInfor As Integer = 0
      Dim check As validation = New validation
      Dim oController As controller = New controller
      Dim key As String = ""
      iCurIndex = 0
      isDefaultLoad = False

      'limit to find base on 1 criteria only, and also validate the input data
      If txtRoomId.Text.Length > 0 And txtRoomId.Text.Length < 50 And IsNumeric(txtRoomId.Text) Then
         findInfor = findInfor + 1
         findRoomField = "room_id"
         key = CStr(txtRoomId.Text)
      End If
      If txtRoomNumber.Text.Length > 0 And txtRoomNumber.Text.Length < 5 And IsNumeric(txtRoomNumber.Text) Then
         findInfor = findInfor + 1
         findRoomField = "room_number"
         key = CStr(txtRoomNumber.Text)
      End If
      If boxType.SelectedIndex > -1 Then
         findInfor = findInfor + 1
         findRoomField = "type"
         key = CStr(boxType.Text)
      End If
      If txtPrice.Text.Length > 0 And IsNumeric(txtPrice.Text) Then
         findInfor = findInfor + 1
         findRoomField = "price"
         key = CStr(txtPrice.Text)
      End If
      If boxNumBeds.SelectedIndex > -1 Then
         findInfor = findInfor + 1
         findRoomField = "num_beds"
         key = CStr(boxNumBeds.Text)
      End If
      If boxFloor.SelectedIndex > -1 Then
         findInfor = findInfor + 1
         findRoomField = "floor"
         key = CStr(boxFloor.Text)
      End If

      If findInfor = 0 Then
         MsgBox("No keyword to search or keyword is invalid" & vbCrLf & "Please enter ONE valid searching criteria (Room ID, Room Number, Type, Price, Number of beds or Floor)", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Invalid Information")
      ElseIf findInfor > 1 Then
         MsgBox("You can only search by one criteria at a time" & vbCrLf & "The valid searching criteria are Room ID, Room Number, Type, Price, Number of beds and Floor", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Please check again...")
         findRoomField = ""
         key = ""
      Else
         Debug.Print("ok now")
         lsDataFind = oController.findRoom(findRoomField, key)

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
               Select Case findRoomField
                  Case "num_beds"
                     da = New OleDbDataAdapter("SELECT * from room where " & findRoomField & " = " & key & "", oConnect)
                  Case "price"
                     da = New OleDbDataAdapter("SELECT * from room where " & findRoomField & " = " & key & "", oConnect)
                  Case Else
                     da = New OleDbDataAdapter("SELECT * from room where " & findRoomField & " = '" & key & "'", oConnect)
               End Select

               da.Fill(ds)

               dgvRoom.DataSource = ds

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
         Dim iResult = oController.updateRoom(getFormData)
         If iResult = 1 Then
            MsgBox("The record was updated." & vbCrLf & "Use the find button to check ...", MsgBoxStyle.OkOnly)
         Else
            MsgBox("The record was not updated!")
         End If
      Else : MsgBox("Inserted field(s) invalid", MsgBoxStyle.OkOnly, "Error")
      End If
   End Sub



   Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
      If MsgBox("Are you sure to delete this record?", MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
         Dim oController As New controller
         Dim rId = txtRoomId.Text
         Dim iResult = oController.deleteRoom(rId)

         If iResult = 1 Then
            clearForm()
            MsgBox("The record was deleted." & vbCrLf & "Use the find button to check ...", MsgBoxStyle.OkOnly)
         Else
            MsgBox("The record was not deleted!")
         End If
      End If
   End Sub



   '------------------------------ navigation button ----------------------------------------------------------------------

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
      If dgvRoom.RowCount > 1 Then
         dgvRoom.ClearSelection()
         dgvRoom.Rows(iIndex).Selected = True
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

      If dgvRoom.RowCount > 1 Then
         dgvRoom.ClearSelection()
         dgvRoom.Rows(iIndex).Selected = True
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

      If dgvRoom.RowCount > 1 Then
         dgvRoom.ClearSelection()
         dgvRoom.Rows(iIndex).Selected = True
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

      If dgvRoom.RowCount > 1 Then
         dgvRoom.ClearSelection()
         dgvRoom.Rows(iIndex).Selected = True
      End If
   End Sub



   '======================================== This is for sub and functions ============================================


   '----- populated data to fields of the form ----------------------------------
   Private Sub populateFormFields(ByVal htdata As Hashtable)
      txtRoomId.Text = CStr(htdata("roomId"))
      txtRoomNumber.Text = CStr(htdata("roomNumber"))
      boxType.Text = CStr(htdata("type"))
      txtPrice.Text = CStr(htdata("price"))
      boxNumBeds.Text = CStr(htdata("numBeds"))
      If CStr(htdata("availability")) = "Yes" Then
         rdYes.Checked = True And rdNo.Checked = False
      Else : rdNo.Checked = True And rdYes.Checked = False
      End If
      boxFloor.Text = CStr(htdata("floor"))
      txtDescription.Text = CStr(htdata("description"))
      txtRoomId.ReadOnly = True
      txtRoomNumber.ReadOnly = True
   End Sub


   '--------- clear field of the form ------------------------------------------
   Public Sub clearForm()
      txtRoomId.Clear()
      txtDescription.Clear()
      txtPrice.Clear()
      txtRoomNumber.Clear()
      boxFloor.SelectedIndex = -1
      boxNumBeds.SelectedIndex = -1
      boxType.SelectedIndex = -1
      rdNo.Checked = False
      rdYes.Checked = False
      txtRoomId.ReadOnly = False
      txtRoomNumber.ReadOnly = False
   End Sub


   '--- pull data from form to hastable --------------------------------------
   Private Function getFormData() As Hashtable
      'bind value to hashtable
      Dim htRoom As Hashtable = New Hashtable
      If txtRoomId.Text.Length > 0 Then
         htRoom("room_id") = txtRoomId.Text
      End If
      htRoom("room_number") = txtRoomNumber.Text
      htRoom("type") = boxType.Text
      htRoom("price") = txtPrice.Text
      htRoom("num_beds") = boxNumBeds.Text
      htRoom("availability") = avai
      htRoom("floor") = boxFloor.Text
      htRoom("description") = txtDescription.Text
      Return htRoom
   End Function


   '------ validate form for insert -------------------------------------------------------------
   Private Function validateForm() As Boolean
      Dim tt As New ToolTip()
      Dim isAllValid As Boolean = True

      'validate form

      'room number 
      Try
         Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
         oConnection.Open()
         Dim qry As OleDbCommand = New OleDbCommand("SELECT room_number from room where room_number=" & "'" & txtRoomNumber.Text & "'", oConnection)
         Dim rd As OleDbDataReader = qry.ExecuteReader
         Dim found As Boolean = False
         While rd.Read
            found = True
         End While
         If txtRoomNumber.Text.Length > 0 And txtRoomNumber.Text.Length < 5 And IsNumeric(txtRoomNumber.Text) And found = False Then
            PictureBox1.Visible = False
         ElseIf txtRoomNumber.Text.Length > 0 And txtRoomNumber.Text.Length < 5 And IsNumeric(txtRoomNumber.Text) And found = True Then
            PictureBox1.Visible = True
            tt.SetToolTip(PictureBox1, "This room number has been used")
            isAllValid = False
         Else
            PictureBox1.Visible = True
            tt.SetToolTip(PictureBox1, "Please fill in room number")
            isAllValid = False
         End If
         oConnection.Close()
      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
      End Try

      'type
      If boxType.SelectedIndex > -1 Then
         PictureBox2.Visible = False
      Else
         PictureBox2.Visible = True
         tt.SetToolTip(PictureBox2, "Please select type of room")
         isAllValid = False
      End If

      'price
      If txtPrice.Text.Length > 0 And IsNumeric(txtPrice.Text) Then
         PictureBox3.Visible = False
      Else
         PictureBox3.Visible = True
         tt.SetToolTip(PictureBox3, "Please fill in price")
         isAllValid = False
      End If

      'number of beds, assumming that one bed is for one customer only
      If boxNumBeds.SelectedIndex > -1 Then
         PictureBox4.Visible = False
      Else
         PictureBox4.Visible = True
         tt.SetToolTip(PictureBox4, "Please select number of beds")
         isAllValid = False
      End If

      'availability
      If rdNo.Checked = True Or rdYes.Checked = True Then
         PictureBox5.Visible = False
      Else
         PictureBox5.Visible = True
         tt.SetToolTip(PictureBox5, "Please select availability")
         isAllValid = False
      End If

      'floor
      If boxFloor.SelectedIndex > -1 Then
         PictureBox6.Visible = False
      Else
         PictureBox6.Visible = True
         tt.SetToolTip(PictureBox6, "Please select floor")
         isAllValid = False
      End If

      'description
      Dim oValidate As New validation
      Dim isValid As Boolean = oValidate.isAlphaNum(txtDescription.Text)
      If isValid Then
         PictureBox7.Visible = False
      Else
         PictureBox7.Visible = True
         tt.SetToolTip(PictureBox7, "Please select fill in description for the room")
         isAllValid = False
      End If

      If isAllValid Then
         Return True
      Else : Return False
      End If
   End Function


   '----------- validate form when update ---------------------------------------
   Private Function validateFormUpdate() As Boolean
      Dim tt As New ToolTip()
      Dim isAllValid As Boolean = True

      'validate form

      'room number 
      'Try
      '   Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      '   oConnection.Open()
      '   Dim qry As OleDbCommand = New OleDbCommand("SELECT room_number from room where room_number=" & "'" & txtRoomNumber.Text & "'", oConnection)
      '   Dim rd As OleDbDataReader = qry.ExecuteReader
      '   Dim found As Boolean = False
      '   While rd.Read
      '      found = True
      '   End While
      '   If txtRoomNumber.Text.Length > 0 And txtRoomNumber.Text.Length < 5 And IsNumeric(txtRoomNumber.Text) And found = False Then
      '      PictureBox1.Visible = False
      '   ElseIf txtRoomNumber.Text.Length > 0 And txtRoomNumber.Text.Length < 5 And IsNumeric(txtRoomNumber.Text) And found = True Then
      '      PictureBox1.Visible = True
      '      tt.SetToolTip(PictureBox1, "This room number has been used")
      '      isAllValid = False
      '   Else
      '      PictureBox1.Visible = True
      '      tt.SetToolTip(PictureBox1, "Please fill in room number")
      '      isAllValid = False
      '   End If
      '   oConnection.Close()
      'Catch ex As Exception
      '   Debug.Print("ERROR: " & ex.Message)
      'End Try

      'type
      If boxType.SelectedIndex > -1 Then
         PictureBox2.Visible = False
      Else
         PictureBox2.Visible = True
         tt.SetToolTip(PictureBox2, "Please select type of room")
         isAllValid = False
      End If

      'price
      If txtPrice.Text.Length > 0 And IsNumeric(txtPrice.Text) Then
         PictureBox3.Visible = False
      Else
         PictureBox3.Visible = True
         tt.SetToolTip(PictureBox3, "Please fill in price")
         isAllValid = False
      End If

      'number of beds, assumming that one bed is for one customer only
      If boxNumBeds.SelectedIndex > -1 Then
         PictureBox4.Visible = False
      Else
         PictureBox4.Visible = True
         tt.SetToolTip(PictureBox4, "Please select number of beds")
         isAllValid = False
      End If

      'availability
      If rdNo.Checked = True Or rdYes.Checked = True Then
         PictureBox5.Visible = False
      Else
         PictureBox5.Visible = True
         tt.SetToolTip(PictureBox5, "Please select availability")
         isAllValid = False
      End If

      'floor
      If boxFloor.SelectedIndex > -1 Then
         PictureBox6.Visible = False
      Else
         PictureBox6.Visible = True
         tt.SetToolTip(PictureBox6, "Please select floor")
         isAllValid = False
      End If

      'description
      Dim oValidate As New validation
      Dim isValid As Boolean = oValidate.isAlphaNum(txtDescription.Text)
      If isValid Then
         PictureBox7.Visible = False
      Else
         PictureBox7.Visible = True
         tt.SetToolTip(PictureBox7, "Please select fill in description for the room")
         isAllValid = False
      End If

      If isAllValid Then
         Return True
      Else : Return False
      End If
   End Function






   '======================== handle when clicking navigation button -> change to another record =====================================

   Private Sub txtRoomId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomId.TextChanged
      If iCurIndex = 0 Then
         btnPrev.Enabled = False
      Else : btnPrev.Enabled = True
      End If

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


End Class