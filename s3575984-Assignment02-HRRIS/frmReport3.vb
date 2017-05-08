Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing

' Name:        frmReport3
' Description: get input for report 3
' Author:      Pham Hoang Phuc
' Date:        2/5/2017

Public Class frmReport3


    Private Sub frmReport3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
        Dim ds As DataSet
        Dim da As OleDbDataAdapter
        Dim tables As DataTableCollection
        Try
            oConnection.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT customer_id from customer", oConnection)
            da.Fill(ds, "customer_id")
            Dim view1 As New DataView(tables(0))

            boxCusId.DataSource = ds.Tables("customer_id")
            boxCusId.DisplayMember = "customer_id"
            boxCusId.ValueMember = "customer_id"
            boxCusId.SelectedIndex = -1

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Function checkInput() As Boolean
      Dim isAllValid As Boolean = True
      Dim tt As New ToolTip

      If boxCusId.SelectedIndex > -1 Then
         picCust.Visible = False
      Else
         picCust.Visible = True
         isAllValid = False
         tt.SetToolTip(picCust, "Please select customer ID")
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

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim oController As New reportContoller
        If checkInput() Then
            oController.createReport3(CInt(boxCusId.SelectedValue), CInt(boxMonth.SelectedItem), CInt(txtYear.Text))
      Else : MsgBox("Your input is invalid", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Public Sub refreshFrm()
        txtYear.Clear()
        boxMonth.SelectedIndex = -1
        boxCusId.SelectedIndex = -1
    End Sub
End Class