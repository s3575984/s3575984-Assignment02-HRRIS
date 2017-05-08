Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing

' Name:        frmReport4
' Description: get input for report 4
' Author:      Pham Hoang Phuc
' Date:        2/5/2017

Public Class frmReport4

   Private Sub frmReport4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
      Dim oController As New reportContoller
      If checkInput() Then
         oController.createReport4(CInt(boxMonth.SelectedItem), CInt(txtYear.Text))
      Else : MsgBox("Your input is invalid", MsgBoxStyle.OkOnly)
      End If
   End Sub

   Private Function checkInput() As Boolean
      Dim isAllValid As Boolean = True
      Dim tt As New ToolTip

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
   End Sub

End Class