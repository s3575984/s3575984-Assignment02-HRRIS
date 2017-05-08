Option Explicit On
Option Strict On

Imports System.Drawing

' Name:        frmCBReport1
' Description: this class is for requiring input for control break report 1
' Author:      Pham Hoang Phuc
' Date:        2/5/2017

Public Class frmCBReport1


   Private Sub frmCBReport1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub


   Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim oController As New cbReportController
      If checkInput() Then
            oController.createBreakReport1(CInt(boxMonth.SelectedItem), CInt(txtYear.Text))
      Else : MsgBox("Your input is invalid", MsgBoxStyle.OkOnly)
      End If
   End Sub

   Private Function checkInput() As Boolean
      Dim isAllValid As Boolean = True
      Dim tt As New ToolTip
        If boxMonth.SelectedIndex > -1 Then
            picMonth.Visible = False
        Else : picMonth.Visible = True
            isAllValid = False
            tt.SetToolTip(picMonth, "Please select month")
        End If
        'If txtYear.Text.Length > 0 And CInt(txtYear.Text) > 2010 And CInt(txtYear.Text) < 2100 And IsNumeric(txtYear.Text) Then
        '   picYear.Visible = False
        'Else : picYear.Visible = True
        '   isAllValid = False
        '   tt.SetToolTip(picYear, "The input month is invalid" & vbCrLf & "The valid month is only from 2010 to 2100")
        '  End If
        If txtYear.Text.Length > 0 And IsNumeric(txtYear.Text) Then
         If CInt(txtYear.Text) < 2010 Or CInt(txtYear.Text) > 2100 Then
            picYear.Visible = True
            isAllValid = False
            tt.SetToolTip(picYear, "The input year is invalid" & vbCrLf & "The valid year is only from 2010 to 2100")
         Else : picYear.Visible = False
         End If
        Else
            picYear.Visible = True
            isAllValid = False
            tt.SetToolTip(picYear, "The input year is invalid" & vbCrLf & "The valid year is only from 2010 to 2100")
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