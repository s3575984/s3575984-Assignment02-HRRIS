Option Explicit On
Option Strict On

' Name:        Menu
' Description: this is menu page
' Author:      Pham Hoang Phuc
' Date:        27/04/2017

Public Class frmMenu



   Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   '=============================== data capture and file tab on menu strip =================================

   Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
      My.Forms.frmCustomer.Show()
   End Sub

   Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
      My.Forms.frmRoom.Show()
   End Sub

   Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
      My.Forms.frmBooking.Show()
   End Sub

   Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
      Me.Close()
   End Sub





   '====================================== report tab on menu strip ==========================================================

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
      Me.btnCBReport2.PerformClick()
   End Sub




   '========================== help and about =====================================================================

   Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
      My.Forms.frmAbout.Show()
   End Sub


   Private Sub ViewHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click
      Dim sParam As String = """" & Application.StartupPath & "\HelpPage.html"""
      Debug.Print("sParam: " & sParam)
      System.Diagnostics.Process.Start(sParam)
   End Sub



   '================================== menu display ============================================================================

   Private Sub btnNewCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCus.Click
      My.Forms.frmCustomer.Show()
      My.Forms.frmCustomer.btnNew.PerformClick()
   End Sub

   Private Sub btnNewRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRoom.Click
      My.Forms.frmRoom.Show()
      My.Forms.frmRoom.btnNew.PerformClick()
   End Sub

   Private Sub btnNewBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewBook.Click
      My.Forms.frmBooking.Show()
      My.Forms.frmBooking.btnNew.PerformClick()
   End Sub




   '======================== normal report =======================================================================================

   Private Sub btnReport1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport1.Click
        My.Forms.frmReport1.Show()
   End Sub

   Private Sub btnReport2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport2.Click
      My.Forms.frmReport2.Show()
   End Sub

   Private Sub btnReport3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport3.Click
        My.Forms.frmReport3.Show()
   End Sub

   Private Sub btnReport4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport4.Click
      My.Forms.frmReport4.Show()
   End Sub

   Private Sub btnReport5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport5.Click
      My.Forms.frmReport5.Show()
   End Sub

   Private Sub btnReport6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport6.Click
      My.Forms.frmReport6.Show()
   End Sub




   '====================== control break report =========================================================================================

   Private Sub btnCBReport1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCBReport1.Click
      My.Forms.frmCBReport1.Show()
   End Sub

   Private Sub btnCBReport2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCBReport2.Click
        Dim oController As New cbReportController
        oController.createBreakReport2()
   End Sub

   
End Class