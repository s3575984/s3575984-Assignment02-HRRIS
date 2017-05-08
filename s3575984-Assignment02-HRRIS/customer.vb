Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing

' Name: fmRoom
' Description: this form is for use to input customer information
' Author: Pham Hoang Phuc
' Date: 25/03/2017

Public Class frmCustomer

   '==================== Make global variable ========================

   Public Const CONNECTION_STRING As String = _
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3575984-dtb.accdb"
   Dim iCurIndex As Integer = 0
   Dim findCustomerField As String
   Dim lsDataLoad As New List(Of Hashtable)
   Dim lsDataFind As New List(Of Hashtable)
   Dim isDefaultLoad As Boolean

   '================== This is for file and data capturebutton on menu strip ====================


   Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
      If MsgBox("Are you sure to close the form?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
         Me.Close()
      End If
   End Sub

   Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
      My.Forms.frmRoom.Show()
   End Sub

   Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
      My.Forms.frmBooking.Show()
   End Sub



   '====================================== report tab on menu strip ==========================================================


   Private Sub Report1ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report1ToolStripMenuItem.Click
      My.Forms.frmReport1.Show()
   End Sub

   Private Sub Report2ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report2ToolStripMenuItem.Click
      My.Forms.frmReport2.Show()
   End Sub

   Private Sub Report3ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report3ToolStripMenuItem.Click
      My.Forms.frmReport3.Show()
   End Sub

   Private Sub Report4ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report4ToolStripMenuItem.Click
      My.Forms.frmReport4.Show()
   End Sub

   Private Sub Report5ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report5ToolStripMenuItem.Click
      My.Forms.frmReport5.Show()
   End Sub

   Private Sub Report6ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report6ToolStripMenuItem.Click
      My.Forms.frmReport6.Show()
   End Sub




   Private Sub CBR1ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBR1ToolStripMenuItem.Click
      My.Forms.frmCBReport1.Show()
   End Sub

   Private Sub CBR2ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBR2ToolStripMenuItem.Click
      My.Forms.frmMenu.btnCBReport2.PerformClick()
   End Sub




   '========================== help and about =====================================================================

   Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
      Dim sParam As String = """" & Application.StartupPath & "\HelpPage.html"""
      Debug.Print("sParam: " & sParam)
      System.Diagnostics.Process.Start(sParam)
   End Sub

   Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
      My.Forms.frmAbout.Show()
   End Sub




   '--------This is done when form is loaded---------------------------------------------------------------------------------------


   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oController As controller = New controller
      isDefaultLoad = True
      lsDataLoad = oController.findAllCustomer()
      Dim iIndex As Integer
      'set what record showed at start up, here is first record
      iIndex = 0
      'set public variable iCurIndex
      iCurIndex = iIndex
      
      populateFormFields(lsDataLoad.Item(iIndex))

      Dim tt As New ToolTip
      tt.SetToolTip(picInfor, "Changing this field only work when finding record")

   End Sub


   '====================== This part is for buttons =====================

   ' button Cancel
   Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure to close the form?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
   End Sub

   'button Save
   Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
      Try
         'input data will be validated through function validateForm() below
         'bind value to hashtable will be done throught function getFormData()

         'insert into database if all fields is true
         If validateForm() Then
            Dim oCustomer As addToDB = New addToDB
            oCustomer.insertCustomer(getFormData)
         Else
            MessageBox.Show("please check the inputs again")
         End If

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occurred. The record wasn't inserted.")
         'Finally
         'oConnection.Close()
      End Try

   End Sub

   
   'Button Find
   Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
      Dim findInfor As Integer = 0
      Dim check As validation = New validation
      Dim oController As controller = New controller
      Dim key As String = ""
      iCurIndex = 0
      isDefaultLoad = False

      'limit to find base on 1 criteria only, and also validate the input data
      If txtCustId.Text.Length > 0 And txtCustId.Text.Length < 50 And IsNumeric(txtCustId.Text) Then
         findInfor = findInfor + 1
         findCustomerField = "customer_id"
         key = CStr(txtCustId.Text)
      End If
      If check.isAplha(txtFirstName.Text) Then
         findInfor = findInfor + 1
         findCustomerField = "firstname"
         key = CStr(txtFirstName.Text)
      End If
      If check.isAplha(txtLastName.Text) Then
         findInfor = findInfor + 1
         findCustomerField = "lastname"
         key = CStr(txtLastName.Text)
      End If
      If txtPhone.Text.Length > 0 And txtPhone.Text.Length < 15 And IsNumeric(txtPhone.Text) Then
         findInfor = findInfor + 1
         findCustomerField = "phone"
         key = CStr(txtPhone.Text)
      End If
      If check.isEmail(txtEmail.Text) Then
         findInfor = findInfor + 1
         findCustomerField = "email"
         key = CStr(txtEmail.Text)
      End If
      If pckDob.Checked = True Then
         findInfor = findInfor + 1
         findCustomerField = "dob"
         key = CStr(pckDob.Value)
      End If

      If findInfor = 0 Then
         MsgBox("No keyword to search or keyword is invalid" & vbCrLf & "Please enter ONE valid searching criteria (Customer ID, First name, Last name, Phone or Email)", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Invalid Information")
      ElseIf findInfor > 1 Then
         MsgBox("You can only search by one criteria at a time" & vbCrLf & "The valid searching criteria are Customer ID, First name, Last name, Phone and Email", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Please check again...")
         findCustomerField = ""
         key = ""
      Else
         Debug.Print("ok now")
         lsDataFind = oController.findCustomer(findCustomerField, key)

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
               da = New OleDbDataAdapter("SELECT * from customer where " & findCustomerField & " = '" & key & "'", oConnect)
               da.Fill(ds)

               dgvCustomer.DataSource = ds

            Catch ex As Exception
               Debug.Print("ERROR: " & ex.Message)
            Finally

            End Try

         Else
            MsgBox("No record found", MsgBoxStyle.OkOnly)
         End If

      End If

   End Sub


   'Button Update
   Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

      Dim oController As New controller
      If validateFormUpdate() Then
         Dim iResult = oController.updateCustomer(getFormData)
         If iResult = 1 Then
            MsgBox("The record was updated." & vbCrLf & "Use the find button to check ...", MsgBoxStyle.OkOnly)
         Else
            MsgBox("The record was not updated!")
         End If
      Else : MsgBox("Inserted field(s) invalid", MsgBoxStyle.OkOnly, "Error")
      End If

   End Sub


   'Button Delete
   Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

      If MsgBox("Are you sure to delete this record?", MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
         Dim oController As New controller
         Dim cId = txtCustId.Text
         Dim iResult = oController.deleteCustomer(cId)

         If iResult = 1 Then
            clearForm()
            MsgBox("The record was deleted." & vbCrLf & "Use the find button to check ...", MsgBoxStyle.OkOnly)
         Else
            MsgBox("The record was not deleted!")
         End If
      End If
   End Sub


   'Button New record
   Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
      'this button willl clear all the form
      Me.Controls.Clear() 'removes all the controls on the form
      InitializeComponent() 'load all the controls again
      Form1_Load(e, e) 'Load everything in your form load event again
      clearForm()
   End Sub


   'button to refresh form
   Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
      Me.Controls.Clear() 'removes all the controls on the form
      InitializeComponent() 'load all the controls again
      Form1_Load(e, e) 'Load everything in your form load event again
   End Sub


   '-----------navigation button------------------------------------------------------------------------------------------------

   Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
      'Dim htData As Hashtable
      Dim iIndex As Integer
      iIndex = 0
      iCurIndex = iIndex

      'handle for loading all records or finding records
      If isDefaultLoad Then
         populateFormFields(lsDataLoad.Item(iIndex))
      Else : populateFormFields(lsDataFind.Item(iIndex))
      End If

      'to select the row of datagridview to match with the form
      If dgvCustomer.RowCount > 1 Then
         dgvCustomer.ClearSelection()
         dgvCustomer.Rows(iIndex).Selected = True
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

      If dgvCustomer.RowCount > 1 Then
         dgvCustomer.ClearSelection()
         dgvCustomer.Rows(iIndex).Selected = True
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

      If dgvCustomer.RowCount > 1 Then
         dgvCustomer.ClearSelection()
         dgvCustomer.Rows(iIndex).Selected = True
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

      If dgvCustomer.RowCount > 1 Then
         dgvCustomer.ClearSelection()
         dgvCustomer.Rows(iIndex).Selected = True
      End If
   End Sub



   '==================== This part contains function and method sub ==============



   'this method is used to fill data to the form----------------------------------------------------------------------------
   Private Sub populateFormFields(ByVal htdata As Hashtable)
      txtCustId.Text = CStr(htdata("customerId"))
      bxTitle.Text = CStr(htdata("title"))
      bxGender.Text = CStr(htdata("gender"))
      txtFirstName.Text = CStr(htdata("firstname"))
      txtLastName.Text = CStr(htdata("lastname"))
      txtAddress.Text = CStr(htdata("address"))
      txtPhone.Text = CStr(htdata("phone"))
      txtEmail.Text = CStr(htdata("email"))
      pckDob.Value = CDate(htdata("dob"))
      txtCustId.ReadOnly = True
      'txtPhone.ReadOnly = True
   End Sub



   'this function is used to collect input data from the form to the hastable---------------------------------------------------
   Private Function getFormData() As Hashtable
      Dim htData As Hashtable = New Hashtable
      If txtCustId.Text.Length > 0 Then
         htData("customerId") = txtCustId.Text
      End If
      htData("title") = bxTitle.Text
      htData("gender") = bxGender.Text
      htData("firstname") = txtFirstName.Text
      htData("lastname") = txtLastName.Text
      htData("phone") = txtPhone.Text
      htData("address") = txtAddress.Text
      htData("email") = txtEmail.Text
      htData("dob") = Format(pckDob.Value, "dd/MM/yyyy")

      Return htData
   End Function




   'this function is to validate input data----------------------------------------------------------------------------------
   Private Function validateForm() As Boolean
      Dim tt As New ToolTip()
      Dim isAllValid As Boolean = True

      Dim check As validation = New validation

      'validate form

      'title
      If bxTitle.SelectedIndex > -1 Then
         PictureBox1.Visible = False
      Else
         PictureBox1.Visible = True
         tt.SetToolTip(PictureBox1, "Please select title")
         isAllValid = False
      End If

      'gender
      If bxGender.SelectedIndex > -1 Then
         PictureBox2.Visible = False
      Else
         PictureBox2.Visible = True
         tt.SetToolTip(PictureBox2, "Please select in gender")
         isAllValid = False
      End If

      'first name
      If check.isAplha(txtFirstName.Text) Then
         PictureBox3.Visible = False
      Else
         PictureBox3.Visible = True
         tt.SetToolTip(PictureBox3, "Please fill in first name")
         isAllValid = False
      End If

      'last name
      If check.isAplha(txtLastName.Text) Then
         PictureBox4.Visible = False
      Else
         PictureBox4.Visible = True
         tt.SetToolTip(PictureBox4, "Please fill in last name")
         isAllValid = False
      End If

      'phone
      Try
         Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
         oConnection.Open()
         Dim qry As OleDbCommand = New OleDbCommand("SELECT phone from customer where phone=" & "'" & txtPhone.Text & "'", oConnection)
         Dim rd As OleDbDataReader = qry.ExecuteReader
         Dim found As Boolean = False
         While rd.Read
            found = True
         End While
         If txtPhone.Text.Length > 0 And txtPhone.Text.Length < 15 And IsNumeric(txtPhone.Text) And found = False Then
            PictureBox5.Visible = False
         ElseIf txtPhone.Text.Length > 0 And txtPhone.Text.Length < 15 And IsNumeric(txtPhone.Text) And found = True Then
            PictureBox5.Visible = True
            tt.SetToolTip(PictureBox5, "This phone number has been used")
            isAllValid = False
         Else
            PictureBox5.Visible = True
            tt.SetToolTip(PictureBox5, "Please fill in phone number")
            isAllValid = False
         End If
         oConnection.Close()
      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
      End Try

      'address
      If check.isAlphaNum(txtAddress.Text) Then
         PictureBox6.Visible = False
      Else
         PictureBox6.Visible = True
         tt.SetToolTip(PictureBox6, "Please fill in address")
         isAllValid = False
      End If

      'email
      If check.isEmail(txtEmail.Text) Then
         PictureBox7.Visible = False
      Else
         PictureBox7.Visible = True
         tt.SetToolTip(PictureBox7, "Please fill in correct email")
         isAllValid = False
      End If

      'DOB
      If pckDob.Value < Now() And pckDob.Checked = True Then
         PictureBox8.Visible = False
      Else
         PictureBox8.Visible = True
         tt.SetToolTip(PictureBox8, "Please check your date of birth")
         isAllValid = False
      End If

      If isAllValid Then
         Return True
      Else : Return False
      End If
   End Function

   'this sub this to clear the form---------------------------------------------------------------------------
   Private Sub clearForm()
      txtCustId.Clear()
      bxTitle.SelectedIndex = -1
      bxGender.SelectedIndex = -1
      txtFirstName.Clear()
      txtLastName.Clear()
      txtAddress.Clear()
      txtPhone.Clear()
      txtEmail.Clear()
      pckDob.Value = Now()
      pckDob.Checked = False
      txtCustId.ReadOnly = False
      txtPhone.ReadOnly = False
   End Sub


   'this function is to validate input data for update function ----------------------------------------------------------------------------------
   Private Function validateFormUpdate() As Boolean
      Dim tt As New ToolTip()
      Dim isAllValid As Boolean = True

      Dim check As validation = New validation

      'validate form

      'title
      If bxTitle.SelectedIndex > -1 Then
         PictureBox1.Visible = False
      Else
         PictureBox1.Visible = True
         tt.SetToolTip(PictureBox1, "Please select title")
         isAllValid = False
      End If

      'gender
      If bxGender.SelectedIndex > -1 Then
         PictureBox2.Visible = False
      Else
         PictureBox2.Visible = True
         tt.SetToolTip(PictureBox2, "Please select in gender")
         isAllValid = False
      End If

      'first name
      If check.isAplha(txtFirstName.Text) Then
         PictureBox3.Visible = False
      Else
         PictureBox3.Visible = True
         tt.SetToolTip(PictureBox3, "Please fill in first name")
         isAllValid = False
      End If

      'last name
      If check.isAplha(txtLastName.Text) Then
         PictureBox4.Visible = False
      Else
         PictureBox4.Visible = True
         tt.SetToolTip(PictureBox4, "Please fill in last name")
         isAllValid = False
      End If

      'phone
      Try
         Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
         oConnection.Open()
         Dim oldPhone As String
         Dim comparePhone As String
         Dim newPhone As String = txtPhone.Text

         Dim qry2 As OleDbCommand = New OleDbCommand("SELECT * from customer where customer_id =" & CInt(txtCustId.Text) & "", oConnection)
         Dim rd2 As OleDbDataReader = qry2.ExecuteReader
         While rd2.Read
            oldPhone = CStr(rd2("phone"))
         End While


         Dim qry As OleDbCommand = New OleDbCommand("SELECT phone from customer where phone =" & "'" & txtPhone.Text & "'", oConnection)
         Dim rd As OleDbDataReader = qry.ExecuteReader
         Dim found As Boolean = False
         While rd.Read
            found = True
            If found = True Then
               comparePhone = CStr(rd("phone"))
            End If
         End While
         

         If txtPhone.Text.Length > 0 And txtPhone.Text.Length < 15 And IsNumeric(txtPhone.Text) And found = False Then
            PictureBox5.Visible = False
         ElseIf txtPhone.Text.Length > 0 And txtPhone.Text.Length < 15 And IsNumeric(txtPhone.Text) And found = True And oldPhone = newPhone Then
            PictureBox5.Visible = False
         ElseIf txtPhone.Text.Length > 0 And txtPhone.Text.Length < 15 And IsNumeric(txtPhone.Text) And found = True And newPhone = comparePhone Then
            PictureBox5.Visible = True
            tt.SetToolTip(PictureBox5, "This phone number has been used")
            isAllValid = False
         Else
            PictureBox5.Visible = True
            tt.SetToolTip(PictureBox5, "Please fill in phone number")
            isAllValid = False
         End If

         oConnection.Close()
      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
      End Try

      'address
      If check.isAlphaNum(txtAddress.Text) Then
         PictureBox6.Visible = False
      Else
         PictureBox6.Visible = True
         tt.SetToolTip(PictureBox6, "Please fill in address")
         isAllValid = False
      End If

      'email
      If check.isEmail(txtEmail.Text) Then
         PictureBox7.Visible = False
      Else
         PictureBox7.Visible = True
         tt.SetToolTip(PictureBox7, "Please fill in correct email")
         isAllValid = False
      End If

      'DOB
      If pckDob.Value < Now() Then
         PictureBox8.Visible = False
      Else
         PictureBox8.Visible = True
         tt.SetToolTip(PictureBox8, "Please check your date of birth")
         isAllValid = False
      End If

      If isAllValid Then
         Return True
      Else : Return False
      End If
   End Function

   
   '======================== handle when clicking navigation button -> change to another record =====================================

   Private Sub txtCustId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustId.TextChanged
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

   
 
   
 
End Class
