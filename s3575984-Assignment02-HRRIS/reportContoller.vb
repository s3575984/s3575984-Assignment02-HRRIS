Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: creportController.vb
' Description: this class hold functions that control generating report functions
' Author: Pham Hoang Phuc
' Date: 30/04/2017

Public Class reportContoller
    Dim oControl As New controller

   'save report to project bin/deubg folder
    Private Sub saveReport(ByVal sReportContent As String, ByVal sReportFilename As String)
        Debug.Print("saveReport: " & sReportFilename)
        Dim oReportFile As StreamWriter = New StreamWriter(Application.StartupPath & "\" & sReportFilename)

        ' Check if the file is open before starting to write to it
        If Not (oReportFile Is Nothing) Then
            oReportFile.Write(sReportContent)
            oReportFile.Close()
        End If
    End Sub





    '========================================== report 1 ==================================================================================================================
    'Given a customer ID (selected from a dropdown box created when the form is loaded), when was the last time a booking made and for how many days?


   'create file in and save file, open in the default browser
    Public Sub createReport1(ByVal cId As Integer)
        Debug.Print("CreateBreakReport ...")

        Dim lsData = findReport1(cId)
        If lsData.Count > 0 Then
            Dim sReportTitle = "Report 1"
            Dim sReportContent = generateReport1(lsData, sReportTitle, cId)
            Dim sReportFilename = "Report1.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else : MsgBox("There is no record match your criteria", MsgBoxStyle.OkOnly)
            frmReport1.refreshFrm()
        End If

    End Sub

    'function search database for report 1
    Public Function findReport1(ByVal cId As Integer) As List(Of Hashtable)
        'get last booking by customerID
        Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            'open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO: get all the record from table booking
            oCommand.CommandText = "select * from booking where customer_id = " & cId & " and datebook = (select max(datebook) from booking where customer_id = " & cId & " )"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            'save all the result to the list lsData
            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("booking_id") = CStr(oDataReader("booking_id"))
                htTempData("datebook") = CDate(oDataReader("datebook"))
                htTempData("room_id") = CStr(oDataReader("room_id"))
                htTempData("customer_id") = CStr(oDataReader("customer_id"))
                htTempData("num_days") = CInt(oDataReader("num_days"))
                htTempData("num_guests") = CInt(oDataReader("num_guests"))
                htTempData("checkin_date") = CDate(oDataReader("checkin_date"))
                htTempData("total_price") = CDbl(oDataReader("total_price"))
                htTempData("comments") = CStr(oDataReader("comments"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")
        Finally
            oConnection.Close()
        End Try
        Return lsData
    End Function


    'generate html frame for the report
    Private Function generateReport1(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String, ByVal cId As Integer) _
   As String

        Debug.Print("GenerateReport01 ...")

        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf _
          & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        ' 2. Generate the product table and its rows
        Dim sTable = generateTable1(lsData, cId)
        sReportContent &= sTable & vbCrLf


        ' 3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent

    End Function

    'generate table with rows filled with record
    Private Function generateTable1(ByVal lsData As List(Of Hashtable), ByVal cId As Integer) As String

        'generate first sentence
        Dim oControl As New controller
        Dim foundCust As List(Of Hashtable)
        foundCust = oControl.findCustomer("customer_id", CStr(cId))
        Dim custDetail As Hashtable = foundCust.Item(0)
        Dim sTable = "<h4>Detail about the last time " & CStr(custDetail("firstname")) & " " & CStr(custDetail("lastname")) & " made an order: </h4>"


        ' Generate the start of the table
        sTable &= "<table border=""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("booking_id")
        lsKeys.Add("datebook")
        'lsKeys.Add("room_id")
        'lsKeys.Add("customer_id")
        lsKeys.Add("num_days")
        'lsKeys.Add("num_guests")
        'lsKeys.Add("checkin_date")
        'lsKeys.Add("total_price")
        'lsKeys.Add("comments")



        ' Generate the header row
        Dim sHeaderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeaderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeaderRow)
        sTable &= sHeaderRow

        ' Generate the table rows
        For Each record In lsData
            Dim product As Hashtable = record
            Dim sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sTable &= sTableRow
        Next

        ' Generate the end of the table
        sTable &= "</table>" & vbCrLf

        'generate conclusion
        'Dim summ As Hashtable = lsData(0)
        'sTable &= "<p> The last time a booking made is on " & CStr(summ("datebook")) & " for a total price of $" & CStr(summ("total_price")) & "</p>"

        Return sTable
    End Function






   '========================================== report 2 ==================================================================================================================
   'Given a room number, when was the last time the room booked and what was the total price paid?

   'create file in and save file, open in the default browser
   Public Sub createReport2(ByVal rId As Integer)
      Debug.Print("CreateBreakReport ...")



      Dim lsData = findReport2(rId)
      If lsData.Count > 0 Then
         Dim sReportTitle = "Report 2"
         Dim sReportContent = generateReport2(lsData, sReportTitle)
         Dim sReportFilename = "Report2.html"
         saveReport(sReportContent, sReportFilename)

         Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
         Debug.Print("sParam: " & sParam)
         System.Diagnostics.Process.Start(sParam)
      Else : MsgBox("There is no record match your criteria", MsgBoxStyle.OkOnly)
            frmReport2.refreshFrm()
      End If

   End Sub


   'function search database for report 2
    Public Function findReport2(ByVal rId As Integer) As List(Of Hashtable)
        'get last booking by room ID
        Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            'open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO: get all the record from table booking
            oCommand.CommandText = "select * from booking where room_id = " & rId & " and datebook = (select max(datebook) from booking where room_id = " & rId & " )"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            'save all the result to the list lsData
            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("booking_id") = CStr(oDataReader("booking_id"))
                htTempData("datebook") = CDate(oDataReader("datebook"))
                htTempData("room_id") = CStr(oDataReader("room_id"))
                htTempData("customer_id") = CStr(oDataReader("customer_id"))
                htTempData("num_days") = CInt(oDataReader("num_days"))
                htTempData("num_guests") = CInt(oDataReader("num_guests"))
                htTempData("checkin_date") = CDate(oDataReader("checkin_date"))
                htTempData("total_price") = CDbl(oDataReader("total_price"))
                htTempData("comments") = CStr(oDataReader("comments"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")
        Finally
            oConnection.Close()
        End Try
        Return lsData
    End Function


   'generate html frame for the report
   Private Function generateReport2(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) _
  As String

      Debug.Print("GenerateReport02 ...")

      Dim sReportContent As String

      ' 1. Generate the start of the HTML file
      Dim sDoctype As String = "<!DOCTYPE html>"
      Dim sHtmlStartTag As String = "<html lang=""en"">"
      Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
      Dim sBodyStartTag As String = "<body>"
      Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
      sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf _
        & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

      ' 2. Generate the product table and its rows
      Dim sTable = generateTable2(lsData)
      sReportContent &= sTable & vbCrLf


      ' 3. Generate the end of the HTML file
      Dim sBodyEndTag As String = "</body>"
      Dim sHTMLEndTag As String = "</html>"
      sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

      Return sReportContent

   End Function

   'generate table with rows filled with record
   Private Function generateTable2(ByVal lsData As List(Of Hashtable)) As String

      Dim firstInfo As Hashtable = lsData.Item(0)

      'generate first sentence
      Dim oControl As New controller
      Dim foundR As List(Of Hashtable)
      foundR = oControl.findRoom("room_id", CStr(firstInfo("room_id")))
      Dim rDetail As Hashtable = foundR.Item(0)
      Dim sTable = "<h4>Detail about last booking for room number " & CStr(rDetail("roomNumber")) & " and total price : </h4>"

      ' Generate the start of the table
      sTable &= "<table border=""1"">" & vbCrLf
      Dim htSample As Hashtable = lsData.Item(0)
      'Dim lsKeys = htSample.Keys
      Dim lsKeys As List(Of String) = New List(Of String)
      lsKeys.Add("booking_id")
      lsKeys.Add("datebook")
      'lsKeys.Add("room_id")
      lsKeys.Add("customer_id")
      'lsKeys.Add("num_days")
      'lsKeys.Add("num_guests")
      lsKeys.Add("checkin_date")
      lsKeys.Add("total_price")
      'lsKeys.Add("comments")


      ' Generate the header row
      Dim sHeaderRow = "<tr>" & vbCrLf
      For Each key In lsKeys
         sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
      Next
      sHeaderRow &= "</tr>" & vbCrLf
      Debug.Print("sHeaderRow: " & sHeaderRow)
      sTable &= sHeaderRow

      ' Generate the table rows
      For Each record In lsData
         Dim product As Hashtable = record
         Dim sTableRow = "<tr>" & vbCrLf
         For Each key In lsKeys
            sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
         Next
         sTableRow &= "</tr>" & vbCrLf
         Debug.Print("sTableRow: " & sTableRow)
         sTable &= sTableRow
      Next

      ' Generate the end of the table
      sTable &= "</table>" & vbCrLf

      'generate conclusion
      'Dim summ As Hashtable = lsData(0)
      'Dim oControl As New controller
      'Dim foundR As List(Of Hashtable)
      'foundR = oControl.findRoom("room_id", CStr(htSample("room_id")))
      'Dim rDetail As Hashtable = foundR.Item(0)
      'sTable &= "<h4> The last time room number " & CStr(rDetail("roomNumber")) & " was booked is on " & CStr(summ("datebook")) & " for a total price of $" & CStr(summ("total_price")) & "</h4>"

      Return sTable
   End Function







   '============================================== report 3 ==============================================================================================================
    'how many rooms were booked by a given customer for a given period (year entered in a textbox and month selected from a dropdown box)?


    'create file in and save file, open in the default browser
    Public Sub createReport3(ByVal cId As Integer, ByVal month As Integer, ByVal year As Integer)
        Debug.Print("CreateBreakReport ...")



        Dim lsData = findReport3(cId, month, year)
        If lsData.Count > 0 Then
            Dim sReportTitle = "Report 3"
            Dim sReportContent = generateReport3(lsData, sReportTitle)
            Dim sReportFilename = "Report3.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else : MsgBox("There is no record match your criteria", MsgBoxStyle.OkOnly)
            frmReport3.refreshFrm()
        End If
    End Sub


   'function search database for report 3
    Public Function findReport3(ByVal cId As Integer, ByVal month As Integer, ByVal year As Integer) As List(Of Hashtable)
        'get last booking by room ID
        Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            'open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO: get all the record from table booking
            oCommand.CommandText = "select * from booking where customer_id = " & cId & " and month(datebook) = " & month & " and year(datebook) = " & year & ""
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            'save all the result to the list lsData
            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("booking_id") = CStr(oDataReader("booking_id"))
                htTempData("datebook") = CDate(oDataReader("datebook"))
                htTempData("room_id") = CStr(oDataReader("room_id"))
                htTempData("customer_id") = CStr(oDataReader("customer_id"))
                htTempData("num_days") = CInt(oDataReader("num_days"))
                htTempData("num_guests") = CInt(oDataReader("num_guests"))
                htTempData("checkin_date") = CDate(oDataReader("checkin_date"))
                htTempData("total_price") = CDbl(oDataReader("total_price"))
                htTempData("comments") = CStr(oDataReader("comments"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")
        Finally
            oConnection.Close()
        End Try
        Return lsData
    End Function


    'generate html frame for the report
    Private Function generateReport3(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) _
   As String

      Debug.Print("GenerateReport03 ...")

        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf _
          & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        ' 2. Generate the product table and its rows
        Dim sTable = generateTable3(lsData)
        sReportContent &= sTable & vbCrLf


        ' 3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent

    End Function

    'generate table with rows filled with record
   Private Function generateTable3(ByVal lsData As List(Of Hashtable)) As String

      Dim firstInfo As Hashtable = lsData.Item(0)

      'generate first sentence
      Dim oControl As New controller
      Dim foundCust As List(Of Hashtable)
      foundCust = oControl.findCustomer("customer_id", CStr(firstInfo("customer_id")))
      Dim custDetail As Hashtable = foundCust.Item(0)
      Dim sTable = "<h4>Detail about the booking(s) made by " & CStr(custDetail("title")) & " " & CStr(custDetail("firstname")) & " " & CStr(custDetail("lastname")) & " during " & CStr(Format(firstInfo("datebook"), "MMMM")) & " " & CStr(Format(firstInfo("datebook"), "yyyy")) & ": </h4>"

      ' Generate the start of the table
      sTable &= "<table border=""1"">" & vbCrLf
      Dim htSample As Hashtable = lsData.Item(0)
      'Dim lsKeys = htSample.Keys
      Dim lsKeys As List(Of String) = New List(Of String)
      lsKeys.Add("booking_id")
      lsKeys.Add("datebook")
      lsKeys.Add("room_id")
      lsKeys.Add("customer_id")
      lsKeys.Add("num_days")
      lsKeys.Add("num_guests")
      lsKeys.Add("checkin_date")
      lsKeys.Add("total_price")
      lsKeys.Add("comments")


      ' Generate the header row
      Dim sHeaderRow = "<tr>" & vbCrLf
      For Each key In lsKeys
         sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
      Next
      sHeaderRow &= "</tr>" & vbCrLf
      Debug.Print("sHeaderRow: " & sHeaderRow)
      sTable &= sHeaderRow

      ' Generate the table rows
      For Each record In lsData
         Dim product As Hashtable = record
         Dim sTableRow = "<tr>" & vbCrLf
         For Each key In lsKeys
            sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
         Next
         sTableRow &= "</tr>" & vbCrLf
         Debug.Print("sTableRow: " & sTableRow)
         sTable &= sTableRow
      Next

      ' Generate the end of the table
      sTable &= "</table>" & vbCrLf

      'generate conclusion
      Dim summ As Integer = lsData.Count()
      sTable &= "<h4>So the total number of booking made by this customer during the given time frame is: " & summ & "</h4>"

      Return sTable
   End Function





   '==================================================== report 4 =========================================================================================================
   'Show all the bookings made in a given month of a given year.


   'create file in and save file, open in the default browser
   Public Sub createReport4(ByVal month As Integer, ByVal year As Integer)
      Debug.Print("CreateBreakReport ...")



      Dim lsData = findReport4(month, year)
      If lsData.Count > 0 Then
         Dim sReportTitle = "Report 4"
         Dim sReportContent = generateReport4(lsData, sReportTitle)
         Dim sReportFilename = "Report4.html"
         saveReport(sReportContent, sReportFilename)

         Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
         Debug.Print("sParam: " & sParam)
         System.Diagnostics.Process.Start(sParam)
      Else : MsgBox("There is no record match your criteria", MsgBoxStyle.OkOnly)
            frmReport4.refreshFrm()
      End If
   End Sub


   'function search database for report 4
   Public Function findReport4(ByVal month As Integer, ByVal year As Integer) As List(Of Hashtable)
      'get last booking by room ID
      Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
      Dim lsData As New List(Of Hashtable)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open connection to database
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO: get all the record from table booking
         oCommand.CommandText = "select * from booking where month(datebook) = " & month & " and year(datebook) = " & year & ""
         oCommand.Prepare()
         Dim oDataReader = oCommand.ExecuteReader()

         'save all the result to the list lsData
         Dim htTempData As Hashtable
         Do While oDataReader.Read() = True
            htTempData = New Hashtable
            htTempData("booking_id") = CStr(oDataReader("booking_id"))
            htTempData("datebook") = CDate(oDataReader("datebook"))
            htTempData("room_id") = CStr(oDataReader("room_id"))
            htTempData("customer_id") = CStr(oDataReader("customer_id"))
            htTempData("num_days") = CInt(oDataReader("num_days"))
            htTempData("num_guests") = CInt(oDataReader("num_guests"))
            htTempData("checkin_date") = CDate(oDataReader("checkin_date"))
            htTempData("total_price") = CDbl(oDataReader("total_price"))
            htTempData("comments") = CStr(oDataReader("comments"))
            lsData.Add(htTempData)
         Loop

         Debug.Print("The records were found.")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occurred. The records could not be found!")
      Finally
         oConnection.Close()
      End Try
      Return lsData
   End Function

   'generate html frame for the report
   Private Function generateReport4(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) _
  As String

      Debug.Print("GenerateReport04 ...")

      Dim sReportContent As String

      ' 1. Generate the start of the HTML file
      Dim sDoctype As String = "<!DOCTYPE html>"
      Dim sHtmlStartTag As String = "<html lang=""en"">"
      Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
      Dim sBodyStartTag As String = "<body>"
      Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
      sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf _
        & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

      ' 2. Generate the product table and its rows
      Dim sTable = generateTable4(lsData)
      sReportContent &= sTable & vbCrLf


      ' 3. Generate the end of the HTML file
      Dim sBodyEndTag As String = "</body>"
      Dim sHTMLEndTag As String = "</html>"
      sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

      Return sReportContent

   End Function

   'generate table with rows filled with record
   Private Function generateTable4(ByVal lsData As List(Of Hashtable)) As String

      Dim firstInfo As Hashtable = lsData.Item(0)

      'generate first sentence
      Dim sTable = "<h4>Detail about all bookings made in " & CStr(Format(firstInfo("datebook"), "MMMM")) & " " & CStr(Format(firstInfo("datebook"), "yyyy")) & ": </h4>"

      ' Generate the start of the table
      sTable &= "<table border=""1"">" & vbCrLf
      Dim htSample As Hashtable = lsData.Item(0)
      'Dim lsKeys = htSample.Keys
      Dim lsKeys As List(Of String) = New List(Of String)
      lsKeys.Add("booking_id")
      lsKeys.Add("datebook")
      lsKeys.Add("room_id")
      lsKeys.Add("customer_id")
      lsKeys.Add("num_days")
      lsKeys.Add("num_guests")
      lsKeys.Add("checkin_date")
      lsKeys.Add("total_price")
      lsKeys.Add("comments")


      ' Generate the header row
      Dim sHeaderRow = "<tr>" & vbCrLf
      For Each key In lsKeys
         sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
      Next
      sHeaderRow &= "</tr>" & vbCrLf
      Debug.Print("sHeaderRow: " & sHeaderRow)
      sTable &= sHeaderRow

      ' Generate the table rows
      For Each record In lsData
         Dim product As Hashtable = record
         Dim sTableRow = "<tr>" & vbCrLf
         For Each key In lsKeys
            sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
         Next
         sTableRow &= "</tr>" & vbCrLf
         Debug.Print("sTableRow: " & sTableRow)
         sTable &= sTableRow
      Next

      ' Generate the end of the table
      sTable &= "</table>" & vbCrLf

      Return sTable
   End Function











   '===================================================== report 5 ===================================================================================================
   'show all the customers who are due for checkin for a given month of a given year. This could be used for sending them email reminders.

   'create file in and save file, open in the default browser
   Public Sub createReport5(ByVal month As Integer, ByVal year As Integer)
      Debug.Print("CreateBreakReport ...")



      Dim lsData = findReport5(month, year)
      If lsData.Count > 0 Then
         Dim sReportTitle = "Report 5"
         Dim sReportContent = generateReport5(lsData, sReportTitle, month, year)
         Dim sReportFilename = "Report5.html"
         saveReport(sReportContent, sReportFilename)

         Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
         Debug.Print("sParam: " & sParam)
         System.Diagnostics.Process.Start(sParam)
      Else : MsgBox("There is no record match your criteria", MsgBoxStyle.OkOnly)
            frmReport5.refreshFrm()
      End If

   End Sub


   'function search database for report 5
   Public Function findReport5(ByVal month As Integer, ByVal year As Integer) As List(Of Hashtable)
      'get last booking by room ID
      Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
      Dim lsCus As New List(Of Hashtable)
      Dim lsData As New List(Of Hashtable)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open connection to database
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO: get customer ID from table booking
         oCommand.CommandText = "select customer_id from booking where month(checkin_date) = " & month & " and year(checkin_date) = " & year & ""
         oCommand.Prepare()
         Dim oDataReader = oCommand.ExecuteReader()

         'save all the result to the list lsData
         Dim htTempData As Hashtable
         Do While oDataReader.Read() = True
            htTempData = New Hashtable
            htTempData("customer_id") = CStr(oDataReader("customer_id"))
            lsCus.Add(htTempData)
         Loop

         For Each cust In lsCus
            Dim oCommand2 As OleDbCommand = New OleDbCommand
            oCommand2.Connection = oConnection
            Dim infor As Hashtable = cust
            'TODO: get customer data from table customer
            oCommand2.CommandText = "select * from customer where customer_id = " & CInt(infor("customer_id")) & ""
            oCommand2.Prepare()
            Dim oDataReader2 = oCommand2.ExecuteReader()

            'save all the result to the list lsData
            Dim htTempData2 As Hashtable
            Do While oDataReader2.Read() = True
               htTempData2 = New Hashtable
               htTempData2("customer_id") = CStr(oDataReader2("customer_id"))
               htTempData2("title") = CStr(oDataReader2("title"))
               htTempData2("gender") = CStr(oDataReader2("gender"))
               htTempData2("firstname") = CStr(oDataReader2("firstname"))
               htTempData2("lastname") = CStr(oDataReader2("lastname"))
               htTempData2("phone") = CStr(oDataReader2("phone"))
               htTempData2("address") = CStr(oDataReader2("address"))
               htTempData2("email") = CStr(oDataReader2("email"))
               htTempData2("dob") = CStr(oDataReader2("dob"))
               lsData.Add(htTempData2)
            Loop
         Next

         Debug.Print("The records were found.")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occurred. The records could not be found!")
      Finally
         oConnection.Close()
      End Try
      Return lsData
   End Function

   'generate html frame for the report
   Private Function generateReport5(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String, ByVal month As Integer, ByVal year As Integer) _
  As String

      Debug.Print("GenerateReport05 ...")

      Dim sReportContent As String

      ' 1. Generate the start of the HTML file
      Dim sDoctype As String = "<!DOCTYPE html>"
      Dim sHtmlStartTag As String = "<html lang=""en"">"
      Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
      Dim sBodyStartTag As String = "<body>"
      Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
      sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf _
        & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

      ' 2. Generate the product table and its rows
      Dim sTable = generateTable5(lsData, month, year)
      sReportContent &= sTable & vbCrLf


      ' 3. Generate the end of the HTML file
      Dim sBodyEndTag As String = "</body>"
      Dim sHTMLEndTag As String = "</html>"
      sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

      Return sReportContent

   End Function


   'generate table with rows filled with record
   Private Function generateTable5(ByVal lsData As List(Of Hashtable), ByVal month As Integer, ByVal year As Integer) As String

      'generate first sentence
      Dim sTable = "<h4>Detail about all customers who are due for checkin during " & CStr(MonthName(month, True)) & " " & CStr(year) & ": </h4>"

      ' Generate the start of the table
      sTable &= "<table border=""1"">" & vbCrLf
      Dim htSample As Hashtable = lsData.Item(0)
      'Dim lsKeys = htSample.Keys
      Dim lsKeys As List(Of String) = New List(Of String)
      lsKeys.Add("customer_id")
      lsKeys.Add("title")
      lsKeys.Add("gender")
      lsKeys.Add("firstname")
      lsKeys.Add("lastname")
      lsKeys.Add("phone")
      lsKeys.Add("address")
      lsKeys.Add("email")
      lsKeys.Add("dob")


      ' Generate the header row
      Dim sHeaderRow = "<tr>" & vbCrLf
      For Each key In lsKeys
         sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
      Next
      sHeaderRow &= "</tr>" & vbCrLf
      Debug.Print("sHeaderRow: " & sHeaderRow)
      sTable &= sHeaderRow

      ' Generate the table rows
      For Each record In lsData
         Dim product As Hashtable = record
         Dim sTableRow = "<tr>" & vbCrLf
         For Each key In lsKeys
            sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
         Next
         sTableRow &= "</tr>" & vbCrLf
         Debug.Print("sTableRow: " & sTableRow)
         sTable &= sTableRow
      Next

      ' Generate the end of the table
      sTable &= "</table>" & vbCrLf

      Return sTable
   End Function















   '======================================================= report 6 ==================================================================================================
   'Show all the bookings for a particular room in a given month of a given year.


   'create file in and save file, open in the default browser
   Public Sub createReport6(ByVal rId As Integer, ByVal month As Integer, ByVal year As Integer)
      Debug.Print("CreateBreakReport ...")



      Dim lsData = findReport6(rId, month, year)
      If lsData.Count > 0 Then
         Dim sReportTitle = "Report 6"
         Dim sReportContent = generateReport6(lsData, sReportTitle)
         Dim sReportFilename = "Report6.html"
         saveReport(sReportContent, sReportFilename)

         Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
         Debug.Print("sParam: " & sParam)
         System.Diagnostics.Process.Start(sParam)
      Else : MsgBox("There is no record match your criteria", MsgBoxStyle.OkOnly)
         frmReport6.refreshFrm()
      End If

   End Sub


   'function search database for report 6
   Public Function findReport6(ByVal rId As Integer, ByVal month As Integer, ByVal year As Integer) As List(Of Hashtable)
      'get last booking by room ID
      Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
      Dim lsData As New List(Of Hashtable)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open connection to database
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO: get all the record from table booking
         oCommand.CommandText = "select * from booking where room_id = " & rId & " and month(datebook) = " & month & " and year(datebook) = " & year & ""
         oCommand.Prepare()
         Dim oDataReader = oCommand.ExecuteReader()

         'save all the result to the list lsData
         Dim htTempData As Hashtable
         Do While oDataReader.Read() = True
            htTempData = New Hashtable
            htTempData("booking_id") = CStr(oDataReader("booking_id"))
            htTempData("datebook") = CDate(oDataReader("datebook"))
            htTempData("room_id") = CStr(oDataReader("room_id"))
            htTempData("customer_id") = CStr(oDataReader("customer_id"))
            htTempData("num_days") = CInt(oDataReader("num_days"))
            htTempData("num_guests") = CInt(oDataReader("num_guests"))
            htTempData("checkin_date") = CDate(oDataReader("checkin_date"))
            htTempData("total_price") = CDbl(oDataReader("total_price"))
            htTempData("comments") = CStr(oDataReader("comments"))
            lsData.Add(htTempData)
         Loop

         Debug.Print("The records were found.")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occurred. The records could not be found!")
      Finally
         oConnection.Close()
      End Try
      Return lsData
   End Function

   'generate html frame for the report
   Private Function generateReport6(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) _
  As String

      Debug.Print("GenerateReport06 ...")

      Dim sReportContent As String

      ' 1. Generate the start of the HTML file
      Dim sDoctype As String = "<!DOCTYPE html>"
      Dim sHtmlStartTag As String = "<html lang=""en"">"
      Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
      Dim sBodyStartTag As String = "<body>"
      Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
      sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf _
        & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

      ' 2. Generate the product table and its rows
      Dim sTable = generateTable6(lsData)
      sReportContent &= sTable & vbCrLf


      ' 3. Generate the end of the HTML file
      Dim sBodyEndTag As String = "</body>"
      Dim sHTMLEndTag As String = "</html>"
      sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

      Return sReportContent

   End Function


   'generate table with rows filled with record
   Private Function generateTable6(ByVal lsData As List(Of Hashtable)) As String

      Dim firstInfo As Hashtable = lsData.Item(0)

      'generate first sentence
      'Dim oControl As New controller
      'Dim foundR As List(Of Hashtable)
      'foundR = oControl.findRoom("room_id", CStr(firstInfo("room_id")))
      'Dim rDetail As Hashtable = foundR.Item(0)
      Dim sTable = "<h4>Detail about all bookings for room ID " & CStr(firstInfo("room_id")) & " in " & CStr(Format(firstInfo("datebook"), "MMMM")) & " " & CStr(Format(firstInfo("datebook"), "yyyy")) & ": </h4>"

      ' Generate the start of the table
      sTable &= "<table border=""1"">" & vbCrLf
      Dim htSample As Hashtable = lsData.Item(0)
      'Dim lsKeys = htSample.Keys
      Dim lsKeys As List(Of String) = New List(Of String)
      lsKeys.Add("booking_id")
      lsKeys.Add("datebook")
      lsKeys.Add("room_id")
      lsKeys.Add("customer_id")
      lsKeys.Add("num_days")
      lsKeys.Add("num_guests")
      lsKeys.Add("checkin_date")
      lsKeys.Add("total_price")
      lsKeys.Add("comments")


      ' Generate the header row
      Dim sHeaderRow = "<tr>" & vbCrLf
      For Each key In lsKeys
         sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
      Next
      sHeaderRow &= "</tr>" & vbCrLf
      Debug.Print("sHeaderRow: " & sHeaderRow)
      sTable &= sHeaderRow

      ' Generate the table rows
      For Each record In lsData
         Dim product As Hashtable = record
         Dim sTableRow = "<tr>" & vbCrLf
         For Each key In lsKeys
            sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
         Next
         sTableRow &= "</tr>" & vbCrLf
         Debug.Print("sTableRow: " & sTableRow)
         sTable &= sTableRow
      Next

      ' Generate the end of the table
      sTable &= "</table>" & vbCrLf

      Return sTable
   End Function


End Class
