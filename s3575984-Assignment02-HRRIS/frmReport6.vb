Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing

' Name:        frmReport6
' Description: get input for report 6
' Author:      Pham Hoang Phuc
' Date:        2/5/2017

Public Class frmReport6

    Private Sub frmReport6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
        Dim ds As DataSet
        Dim da As OleDbDataAdapter
        Dim tables As DataTableCollection
        Try
            oConnection.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT room_id from room", oConnection)
            da.Fill(ds, "room_id")
            Dim view1 As New DataView(tables(0))

            boxRoomId.DataSource = ds.Tables("room_id")
            boxRoomId.DisplayMember = "room_id"
            boxRoomId.ValueMember = "room_id"
            boxRoomId.SelectedIndex = -1

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub




    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim oController As New reportContoller
        If checkInput() Then
         oController.createReport6(CInt(boxRoomId.SelectedValue), CInt(boxMonth.SelectedItem), CInt(txtYear.Text))
      Else : MsgBox("Your input is invalid", MsgBoxStyle.OkOnly)
        End If
    End Sub




   Private Function checkInput() As Boolean
      Dim isAllValid As Boolean = True
      Dim tt As New ToolTip

      If boxRoomId.SelectedIndex > -1 Then
         picRoom.Visible = False
      Else
         picRoom.Visible = True
         isAllValid = False
         tt.SetToolTip(picRoom, "Please select room ID")
      End If

      If boxMonth.SelectedIndex > -1 Then
         picMonth.Visible = False
      Else
         picMonth.Visible = True
         isAllValid = False
         tt.SetToolTip(picMonth, "Please select month")
      End If

      If txtYear.Text.Length > 0 And IsNumeric(txtYear.Text) Then
         If CInt(txtYear.Text) > 2010 And CInt(txtYear.Text) < 2100 Then
            picYear.Visible = False
         Else
            isAllValid = False
            picYear.Visible = True
            tt.SetToolTip(picYear, "Please select year" & vbCrLf & "The valid year is only from 2010 to 2100")
         End If
      Else : isAllValid = False
         picYear.Visible = True
         tt.SetToolTip(picYear, "Please select year" & vbCrLf & "The valid year is only from 2010 to 2100")
      End If

      If isAllValid Then
         Return True
      Else : Return False
      End If
   End Function

   Public Sub refreshFrm()
      txtYear.Clear()
      boxMonth.SelectedIndex = -1
      boxRoomId.SelectedIndex = -1
   End Sub
End Class