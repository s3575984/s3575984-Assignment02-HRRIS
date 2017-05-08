Option Explicit On
Option Strict On

' Name: validation.vb
' Description: this class hold functions to validate input data
' Author: Pham Hoang Phuc
' Date: 28/04/2017

Imports System.Text.RegularExpressions

Public Class validation

   Public Function isAlphaNum(ByVal descr As String) As Boolean

      Dim pattern As Regex = New Regex("^[a-zA-Z]+[0-9-_ ]")
      Dim pattern2 As Regex = New Regex("^[0-9]+[a-zA-Z-_ ]")
      Dim pattern3 As Regex = New Regex("^[a-zA-Z]")

      If 255 > descr.Length And descr.Length > 0 And (pattern.IsMatch(descr) Or pattern2.IsMatch(descr) Or pattern3.IsMatch(descr)) Then
         Return True
      Else : Return False
      End If
   End Function

   Public Function isEmail(ByVal email As String) As Boolean

      Dim emailRegex As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

      If email.Length < 255 And email.Length > 0 And emailRegex.IsMatch(email) Then
         Return True
      Else : Return False
      End If
   End Function

   Public Function isAplha(ByVal txt As String) As Boolean
      Dim pattern As Regex = New Regex("^[a-zA-Z\s]+$")
      If txt.Length < 255 And txt.Length > 0 And pattern.IsMatch(txt) Then
         Return True
      Else : Return False
      End If
   End Function

End Class
