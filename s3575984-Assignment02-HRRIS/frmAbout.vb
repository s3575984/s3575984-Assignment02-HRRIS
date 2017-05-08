Option Explicit On
Option Strict On

' Name:        frmAbout
' Description: this is about page
' Author:      Pham Hoang Phuc
' Date:        27/04/2017

Public Class frmAbout



   Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      txtAbout.Text = "This is the application for my assignment 2." & vbCrLf & _
         "Course information:" & vbCrLf & _
         "Course Code: ISYS 2116" & vbCrLf & _
         "Course Name: Information Systems Solutions and Design" & vbCrLf & _
         "Lecturer: Ashish Das" & vbCrLf & _
         "Semester 1, 2017" & vbCrLf
   End Sub

   Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
      Me.Close()
   End Sub

   Private Sub linkOnline_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkOnline.LinkClicked
      Dim sParam As String = """" & Application.StartupPath & "\AboutPage.html"""
      Debug.Print("sParam: " & sParam)
      System.Diagnostics.Process.Start(sParam)
   End Sub
End Class