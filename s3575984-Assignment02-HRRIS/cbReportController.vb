Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: cbReportController.vb
' Description: this class hold functions that control generating report functions
' Author: Pham Hoang Phuc
' Date: 30/04/2017

Public Class cbReportController

    Dim oControl As New controller



    Private Sub saveReport(ByVal sReportContent As String, ByVal sReportFilename As String)
        Debug.Print("saveReport: " & sReportFilename)
        Dim oReportFile As StreamWriter = New StreamWriter(Application.StartupPath & "\" & sReportFilename)

        ' Check if the file is open before starting to write to it
        If Not (oReportFile Is Nothing) Then
            oReportFile.Write(sReportContent)
            oReportFile.Close()
        End If
    End Sub

    'function search database for control break report 1
    Public Function findCBReport1(ByVal month As Integer, ByVal year As Integer) As List(Of Hashtable)
        'get all booking in the selected time frame
        Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            'open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO: get all the record from table booking
            oCommand.CommandText = "select * from booking where format(datebook, 'm') = " & month & " and format(datebook, 'yyyy') = " & year & " order by booking_id"
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

    Public Sub createBreakReport1(ByVal month As Integer, ByVal year As Integer)
        Debug.Print("CreateBreakReport ...")

        Dim lsData = findCBReport1(month, year)
        If lsData.Count > 0 Then
            Dim sReportTitle = "Control Break Report 1"
            Dim sReportContent = generateBreakReport1(lsData, sReportTitle)
            Dim sReportFilename = "ControlBreakReport1.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("There is no record match your criteria", MsgBoxStyle.OkOnly)
            frmCBReport1.refreshFrm()
        End If


        

    End Sub


    'generate html frame for the report
    Private Function generateBreakReport1(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        Debug.Print("GenerateBreakReport ...")

        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle _
         & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        ' 2. Generate the product table and its rows
        Dim sTable = generateControlBreakTable1(lsData)
        sReportContent &= sTable & vbCrLf

        ' 3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent

    End Function



    Private Function generateControlBreakTable1(ByVal lsData As List(Of Hashtable)) As String
        ' Generate the start of the table
        Dim sTable = "<table border=""1"">" & vbCrLf
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
        sTable &= generateTableRows1(lsData, lsKeys)

        ' Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable
    End Function




    Private Function generateTableRows1(ByVal lsData As List(Of Hashtable), ByVal lsKeys As List(Of String)) As String

        '1. Initialisation
        Dim sRows As String = ""
        Dim sTableRow As String
        Dim iCountRecordsPerCategory As Integer = 0
        Dim bFirstTime As Boolean = True
        Dim sCurrentControlField As String = ""
        Dim sPreviousControlField As String = ""

        '2. Loop through the list of hashtables
        For Each record In lsData

            '2a. Get a booking and set the current key
            Dim booking As Hashtable = record
            sCurrentControlField = CStr(booking("room_id"))

            '2b. Do not check for control break on the first iteration of the loop
            If bFirstTime Then
                bFirstTime = False
            Else
                'Output total row if change in control field
                'And reset the total
                If sCurrentControlField <> sPreviousControlField Then

                    Dim oControl As New controller
                    Dim foundRoom As List(Of Hashtable)
                    foundRoom = oControl.findRoom("room_id", sPreviousControlField)
                    Dim roomDetail As Hashtable = foundRoom(0)

                    'sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                    '& " Total bookings in room " & sPreviousControlField _
                    '& " : " & iCountRecordsPerCategory _
                    '& "</td></tr>" _
                    '& vbCrLf & _

                    sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & "<p> Total bookings in room " & sPreviousControlField _
                        & " : " & iCountRecordsPerCategory _
                        & "</p>" _
                        & vbCrLf & _
                        "<p>Room detail: </p>" _
                        & "<p> " _
                        & "ID: " & CStr(roomDetail("roomId")) _
                        & " | Number: " & CStr(roomDetail("roomNumber")) _
                        & " | Type: " & CStr(roomDetail("type")) _
                        & " | Price: " & CStr(roomDetail("price")) _
                        & " | No. of beds: " & CStr(roomDetail("numBeds")) _
                        & " | Availability: " & CStr(roomDetail("availability")) _
                        & " | Floor: " & CStr(roomDetail("floor")) _
                        & " | Description: " & CStr(roomDetail("description")) & "</p>" _
                        & "</td></tr>"


                    sRows &= sTableRow
                    iCountRecordsPerCategory = 0
                End If
            End If

            ' 2c. Output a normal row for every pass thru' the list
            sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(booking(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sRows &= sTableRow

            '2d. Update control field and increment total
            sPreviousControlField = sCurrentControlField
            iCountRecordsPerCategory += 1
        Next

        '3. After the loop, need to output the last total row
        Dim foundRoom0 As List(Of Hashtable)
        foundRoom0 = oControl.findRoom("room_id", sPreviousControlField)
        Dim roomDetail0 As Hashtable = foundRoom0(0)
        sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                     & "<p> Total bookings in room " & sCurrentControlField _
                     & " : " & iCountRecordsPerCategory _
                     & "</p>" _
                     & vbCrLf & _
                     "<p>Room detail: </p>" _
                     & "<p> " _
                     & "ID: " & CStr(roomDetail0("roomId")) _
                     & " | Number: " & CStr(roomDetail0("roomNumber")) _
                     & " | Type: " & CStr(roomDetail0("type")) _
                     & " | Price: " & CStr(roomDetail0("price")) _
                     & " | No. of beds: " & CStr(roomDetail0("numBeds")) _
                     & " | Availability: " & CStr(roomDetail0("availability")) _
                     & " | Floor: " & CStr(roomDetail0("floor")) _
                     & " | Description: " & CStr(roomDetail0("description")) & "</p>" _
                     & "</td></tr>"
        sRows &= sTableRow

        Return sRows

    End Function




    '======================================== Control break report 2 =======================================================================

    Public Sub createBreakReport2()
        Debug.Print("CreateBreakReport ...")



        Dim lsData = findCBReport2()
        Dim sReportTitle = "Control Break Report 2"
        Dim sReportContent = generateBreakReport2(lsData, sReportTitle)
        Dim sReportFilename = "ControlBreakReport2.html"
        saveReport(sReportContent, sReportFilename)

        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
        Debug.Print("sParam: " & sParam)
        System.Diagnostics.Process.Start(sParam)

    End Sub



    Private Function generateBreakReport2(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        Debug.Print("GenerateBreakReport ...")

        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle _
         & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        ' 2. Generate the product table and its rows
        Dim sTable = generateControlBreakTable2(lsData)
        sReportContent &= sTable & vbCrLf

        ' 3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent

    End Function


    'function search database for control break report 1
    Public Function findCBReport2() As List(Of Hashtable)
        'get all booking in the selected time frame
        Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            'open connection to database
            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO: get all the record from table booking
            oCommand.CommandText = "select * from invoice where year(dateinvoice) = year(now())"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            'save all the result to the list lsData
            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("booking_id") = CStr(oDataReader("booking_id"))
                htTempData("dateinvoice") = CDate(oDataReader("dateinvoice"))
                htTempData("amount") = CStr(oDataReader("amount"))
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


    Private Function generateControlBreakTable2(ByVal lsData As List(Of Hashtable)) As String
        ' Generate the start of the table
        Dim sTable = "<table border=""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("booking_id")
        lsKeys.Add("dateinvoice")
        lsKeys.Add("amount")

        ' Generate the header row
        Dim sHeaderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeaderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeaderRow)
        sTable &= sHeaderRow

        ' Generate the table rows
        sTable &= generateTableRows2(lsData, lsKeys)

        ' Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable
    End Function


    Private Function generateTableRows2(ByVal lsData As List(Of Hashtable), ByVal lsKeys As List(Of String)) As String

        '1. Initialisation
        Dim sRows As String = ""
        Dim sTableRow As String
        Dim iCountRecordsPerCategory As Integer = 0
        Dim bFirstTime As Boolean = True
        Dim sCurrentControlField As String = ""
        Dim sPreviousControlField As String = ""

        '2. Loop through the list of hashtables
        For Each record In lsData

            '2a. Get a booking and set the current key
            Dim invoice As Hashtable = record
         sCurrentControlField = CStr(Format(CDate(invoice("dateinvoice")), "MMMM"))

            '2b. Do not check for control break on the first iteration of the loop
            If bFirstTime Then
                bFirstTime = False
            Else
                'Output total row if change in control field
                'And reset the total
                If sCurrentControlField <> sPreviousControlField Then


                    sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & "<p> Total bookings in " & sPreviousControlField _
                        & " : " & iCountRecordsPerCategory _
                        & "</p>" _
                        & "</td></tr> "

                    sRows &= sTableRow
                    iCountRecordsPerCategory = 0
                End If
            End If

            ' 2c. Output a normal row for every pass thru' the list
            sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(invoice(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sRows &= sTableRow

            '2d. Update control field and increment total
            sPreviousControlField = sCurrentControlField
            iCountRecordsPerCategory += 1
        Next

        '3. After the loop, need to output the last total row
        sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & "<p> Total bookings in " & sPreviousControlField _
                        & " : " & iCountRecordsPerCategory _
                        & "</p>" _
                        & "</td></tr> "
        sRows &= sTableRow

        Return sRows

    End Function

End Class
