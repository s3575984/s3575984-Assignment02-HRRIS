Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name:        frmReport2
' Description: get input for report 2
' Author:      Pham Hoang Phuc
' Date:        2/5/2017

Public Class frmReport2

   Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
      Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
      Dim oController As New reportContoller
      Dim lsData As New List(Of Hashtable)
      Dim result As New Hashtable
      Dim rId As Integer
      

      If txtRoomNum.Text.Length > 0 And IsNumeric(txtRoomNum.Text) Then

         Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            'open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO: get all the record from table booking
            oCommand.CommandText = "select room_id from room where room_number = """ & CStr(txtRoomNum.Text) & """"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            'save all the result to the list lsData
            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
               htTempData = New Hashtable
               htTempData("room_id") = CStr(oDataReader("room_id"))
               lsData.Add(htTempData)
            Loop

            Debug.Print("The records were found.")

         Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")
         Finally
            oConnection.Close()
         End Try

         

         If lsData.Count = 0 Then
            MsgBox("Can't find a record of this room number")
            Else
                result = lsData(0)
                rId = CInt(result("room_id"))
                oController.createReport2(rId)
         End If
      Else : MsgBox("Please fill in room number")
      End If

   End Sub

    Public Sub refreshFrm()
        txtRoomNum.Clear()
    End Sub
 
End Class