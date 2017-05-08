Option Explicit On
Option Strict On

Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports s3575984_Assignment02_HRRIS.validation

' Name: TestValidation.vb
' Description: this is file to test the validation
' Author: Pham Hoang Phuc
' Date: 30/04/2017

<TestClass()>
Public Class TestValidation

   <TestInitialize()> Public Sub setup()
      Debug.Print("Setting up ...")
   End Sub

   <TestCleanup()> Public Sub cleanup()
      Debug.Print("Cleaning up ...")
   End Sub

   <TestMethod()>
   Public Sub TestIsEmail()
      Dim oValidation As New s3575984_Assignment02_HRRIS.validation
      Dim sEmail = "this is email"
      Assert.AreEqual(False, oValidation.isEmail(sEmail))
    End Sub

    <TestMethod()>
    Public Sub TestIsEmail2()
        Dim oValidation As New s3575984_Assignment02_HRRIS.validation
        Dim sEmail = "phuc@gmail.com"
        Assert.AreEqual(True, oValidation.isEmail(sEmail))
    End Sub

   <TestMethod()>
   Public Sub TestIsAlpha()
      Dim oValidation As New s3575984_Assignment02_HRRIS.validation
      Dim sAlpha = "this is email"
      Assert.AreEqual(True, oValidation.isAplha(sAlpha))
    End Sub

    <TestMethod()>
    Public Sub TestIsAlpha2()
        Dim oValidation As New s3575984_Assignment02_HRRIS.validation
        Dim sAlpha = "this is 3 email"
        Assert.AreEqual(False, oValidation.isAplha(sAlpha))
    End Sub

   <TestMethod()>
   Public Sub TestisAlphaNum()
      Dim oValidation As New s3575984_Assignment02_HRRIS.validation
      Dim sAlphaNum = "this is email 232523"
      Assert.AreEqual(True, oValidation.isAlphaNum(sAlphaNum))
    End Sub

    <TestMethod()>
    Public Sub TestisAlphaNum2()
        Dim oValidation As New s3575984_Assignment02_HRRIS.validation
        Dim sAlphaNum = " 123 this is email"
        Assert.AreEqual(True, oValidation.isAlphaNum(sAlphaNum))
    End Sub

End Class
