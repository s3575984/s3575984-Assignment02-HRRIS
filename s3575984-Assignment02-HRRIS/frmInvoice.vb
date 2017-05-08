Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: fmInvoice
' Description: this form is to show invoice information
' Author: Pham Hoang Phuc
' Date: 06/05/2017

Public Class frmInvoice


   Private Sub frmInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      txtBookID.Text = frmBooking.txtBookId.Text
   End Sub


   Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
      Me.Close()
   End Sub

   Private Sub txtBookID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBookID.TextChanged
      getInvoice(CInt(txtBookID.Text))
   End Sub

   Private Sub getInvoice(ByVal bId As Integer)

      'get invoice infor
      Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
      Dim lsData As New Hashtable
      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open connection to database
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO: get all the record from table booking
         oCommand.CommandText = "select * from invoice where booking_id = " & bId & ""
         oCommand.Prepare()
         Dim oDataReader = oCommand.ExecuteReader()

         'save all the result to the list lsData
         Do While oDataReader.Read() = True
            lsData("booking_id") = CStr(oDataReader("booking_id"))
            lsData("dateinvoice") = CDate(oDataReader("dateinvoice"))
            lsData("amount") = CDbl(oDataReader("amount"))
         Loop

         Debug.Print("The records were found.")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occurred. The records could not be found!")
      Finally
         oConnection.Close()
      End Try

      'populate form
      pckDate.Value = CDate(lsData("dateinvoice"))
      txtAmount.Text = CStr(lsData("amount"))

   End Sub
End Class