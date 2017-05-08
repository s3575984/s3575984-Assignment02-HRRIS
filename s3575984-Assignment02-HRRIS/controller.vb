Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.Reflection

' Name: controller.vb
' Description: this class hold functions that control data flows
' Author: Pham Hoang Phuc
' Date: 28/04/2017

Public Class controller

   Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3575984-dtb.accdb"


   '========================================= FORM CUSTOMER ==========================================
   '-------------------------------------------------------------------------------------------------


   'Funtion to get all the record from the databse
   Public Function findAllCustomer() As List(Of Hashtable)

      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim lsData As New List(Of Hashtable)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open connection to database
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO: get all the record from table customer
         oCommand.CommandText = "select * from customer order by customer_id"
         oCommand.Prepare()
         Dim oDataReader = oCommand.ExecuteReader()

         'save all the result to the list lsData
         Dim htTempData As Hashtable
         Do While oDataReader.Read() = True
            htTempData = New Hashtable
            htTempData("customerId") = CStr(oDataReader("customer_id"))
            htTempData("title") = CStr(oDataReader("title"))
            htTempData("gender") = CStr(oDataReader("gender"))
            htTempData("firstname") = CStr(oDataReader("firstname"))
            htTempData("lastname") = CStr(oDataReader("lastname"))
            htTempData("phone") = CStr(oDataReader("phone"))
            htTempData("address") = CStr(oDataReader("address"))
            htTempData("email") = CStr(oDataReader("email"))
            htTempData("dob") = CDate(oDataReader("dob"))
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



   'function to find customer based on given keyword
   Public Function findCustomer(ByVal findField As String, ByVal keyword As String) As List(Of Hashtable)

      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim lsData As New List(Of Hashtable)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open connection to database
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO: find customer base on searching criteria
         oCommand.CommandText = "select * from customer where " & findField & " = ? order by customer_id"
         Select Case findField
            Case "customer_id"
               oCommand.Parameters.Add(findField, OleDbType.Integer, 8)
               oCommand.Parameters("customer_id").Value = CInt(keyword)
               'Case "dob"
               '   oCommand.Parameters.Add(findField, OleDbType.Date)
               '   oCommand.Parameters("dob").Value = CDate(keyword)
            Case Else
               oCommand.Parameters.Add(findField, OleDbType.VarChar, 255)
               oCommand.Parameters(findField).Value = CStr(keyword)
         End Select

         oCommand.Prepare()
         Dim oDataReader = oCommand.ExecuteReader()

         'save all the result to the list lsData
         Dim htTempData As Hashtable
         Do While oDataReader.Read() = True
            htTempData = New Hashtable
            htTempData("customerId") = CStr(oDataReader("customer_id"))
            htTempData("title") = CStr(oDataReader("title"))
            htTempData("gender") = CStr(oDataReader("gender"))
            htTempData("firstname") = CStr(oDataReader("firstname"))
            htTempData("lastname") = CStr(oDataReader("lastname"))
            htTempData("phone") = CStr(oDataReader("phone"))
            htTempData("address") = CStr(oDataReader("address"))
            htTempData("email") = CStr(oDataReader("email"))
            htTempData("dob") = CDate(oDataReader("dob"))
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



   'function update customer infor to the database
   Public Function updateCustomer(ByVal htData As Hashtable) As Integer
      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim result As Integer
      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open a connection to db
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         oCommand.CommandText = "UPDATE customer SET title = ?, gender = ?, firstname = ?, lastname = ?, phone = ?, address = ?, email = ?, dob = ? WHERE customer_id = ?;"

         oCommand.Parameters.Add("title", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("gender", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("firstname", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("lastname", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("phone", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("address", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("email", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("dob", OleDbType.Date)
         oCommand.Parameters.Add("customerId", OleDbType.Integer, 8)

         oCommand.Parameters("title").Value = CStr(htData("title"))
         oCommand.Parameters("gender").Value = CStr(htData("gender"))
         oCommand.Parameters("firstname").Value = CStr(htData("firstname"))
         oCommand.Parameters("lastname").Value = CStr(htData("lastname"))
         oCommand.Parameters("phone").Value = CStr(htData("phone"))
         oCommand.Parameters("address").Value = CStr(htData("address"))
         oCommand.Parameters("email").Value = CStr(htData("email"))
         oCommand.Parameters("dob").Value = CDate(htData("dob"))
         oCommand.Parameters("customerId").Value = CInt(htData("customerId"))

         oCommand.Prepare()

         Debug.Print("SQL: " & oCommand.CommandText)

         result = oCommand.ExecuteNonQuery()

         Debug.Print("The record was updated.")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occured. The record wasn't updated.")
      Finally
         oConnection.Close()
      End Try

      Return result
   End Function




   'function to delete record from the database
   Public Function deleteCustomer(ByVal cId As String) As Integer
      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim result As Integer

      Try
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO
         oCommand.CommandText = _
            "DELETE FROM customer WHERE customer_id = ?;"
         oCommand.Parameters.Add("customerId", OleDbType.Integer, 8)
         oCommand.Parameters("customerId").Value = CInt(cId)
         oCommand.Prepare()
         result = oCommand.ExecuteNonQuery()

         Debug.Print("The record was deleted.")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occurred. The record was not deleted!")
      Finally
         oConnection.Close()
      End Try

      Return result

   End Function




   '============================================== FORM ROOM =================================================================
   '--------------------------------------------------------------------------------------------------------------------------

   'function to get all the record from database
   Public Function findAllRoom() As List(Of Hashtable)
      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim lsData As New List(Of Hashtable)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open connection to database
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO: get all the record from table room
         oCommand.CommandText = "select * from room order by room_id"
         oCommand.Prepare()
         Dim oDataReader = oCommand.ExecuteReader()

         'save all the result to the list lsData
         Dim htTempData As Hashtable
         Do While oDataReader.Read() = True
            htTempData = New Hashtable
            htTempData("roomId") = CStr(oDataReader("room_id"))
            htTempData("roomNumber") = CStr(oDataReader("room_number"))
            htTempData("type") = CStr(oDataReader("type"))
            htTempData("price") = CDbl(oDataReader("price"))
            htTempData("numBeds") = CInt(oDataReader("num_beds"))
            htTempData("availability") = CStr(oDataReader("availability"))
            htTempData("floor") = CStr(oDataReader("floor"))
            htTempData("description") = CStr(oDataReader("description"))
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




   'function to find room based on given keyword
   Public Function findRoom(ByVal findField As String, ByVal keyword As String) As List(Of Hashtable)
      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim lsData As New List(Of Hashtable)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open connection to database
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO: find room base on searching criteria
         oCommand.CommandText = "select * from room where " & findField & " = ? order by room_id"
         Select Case findField
            Case "room_id"
               oCommand.Parameters.Add(findField, OleDbType.Integer, 8)
               oCommand.Parameters("room_id").Value = CInt(keyword)
            Case "price"
               oCommand.Parameters.Add(findField, OleDbType.Double)
               oCommand.Parameters("price").Value = CDbl(keyword)
            Case "num_beds"
               oCommand.Parameters.Add(findField, OleDbType.Integer, 1)
               oCommand.Parameters("num_beds").Value = CInt(keyword)
            Case Else
               oCommand.Parameters.Add(findField, OleDbType.VarChar, 255)
               oCommand.Parameters(findField).Value = CStr(keyword)
         End Select

         oCommand.Prepare()
         Dim oDataReader = oCommand.ExecuteReader()

         'save all the result to the list lsData
         Dim htTempData As Hashtable
         Do While oDataReader.Read() = True
            htTempData = New Hashtable
            htTempData("roomId") = CStr(oDataReader("room_id"))
            htTempData("roomNumber") = CStr(oDataReader("room_number"))
            htTempData("type") = CStr(oDataReader("type"))
            htTempData("price") = CDbl(oDataReader("price"))
            htTempData("numBeds") = CInt(oDataReader("num_beds"))
            htTempData("availability") = CStr(oDataReader("availability"))
            htTempData("floor") = CStr(oDataReader("floor"))
            htTempData("description") = CStr(oDataReader("description"))
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



   'function update room infor to the database
   Public Function updateRoom(ByVal htData As Hashtable) As Integer
      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim result As Integer
      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open a connection to db
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         oCommand.CommandText = "UPDATE room SET room_number = ?, type = ?, price = ?, num_beds = ?, availability = ?, floor = ?, description = ? WHERE room_id = ?;"

         oCommand.Parameters.Add("room_number", OleDbType.VarChar, 20)
         oCommand.Parameters.Add("type", OleDbType.VarChar, 50)
         oCommand.Parameters.Add("price", OleDbType.Double, 8)
         oCommand.Parameters.Add("num_beds", OleDbType.Integer, 1)
         oCommand.Parameters.Add("availability", OleDbType.VarChar, 20)
         oCommand.Parameters.Add("floor", OleDbType.VarChar, 20)
         oCommand.Parameters.Add("description", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)

         oCommand.Parameters("room_number").Value = CStr(htData("room_number"))
         oCommand.Parameters("type").Value = CStr(htData("type"))
         oCommand.Parameters("price").Value = CDbl(htData("price"))
         oCommand.Parameters("num_beds").Value = CInt(htData("num_beds"))
         oCommand.Parameters("availability").Value = CStr(htData("availability"))
         oCommand.Parameters("floor").Value = CStr(htData("floor"))
         oCommand.Parameters("description").Value = CStr(htData("description"))
         oCommand.Parameters("room_id").Value = CStr(htData("room_id"))

         oCommand.Prepare()

         Debug.Print("SQL: " & oCommand.CommandText)

         result = oCommand.ExecuteNonQuery()

         Debug.Print("The record was updated.")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occured. The record wasn't updated.")
      Finally
         oConnection.Close()
      End Try

      Return result
   End Function



   'function to delete record from the database
   Public Function deleteRoom(ByVal Id As String) As Integer
      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim result As Integer

      Try
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO
         oCommand.CommandText = _
            "DELETE FROM room WHERE room_id = ?;"
         oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)
         oCommand.Parameters("room_id").Value = CInt(Id)
         oCommand.Prepare()
         result = oCommand.ExecuteNonQuery()

         Debug.Print("The record was deleted.")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occurred. The record was not deleted!")
      Finally
         oConnection.Close()
      End Try

      Return result

   End Function



   '============================================== FORM BOOKING =============================================================
   '-------------------------------------------------------------------------------------------------------------------------


   'Funtion to get all the record from the databse
   Public Function findAllBooking() As List(Of Hashtable)

      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim lsData As New List(Of Hashtable)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open connection to database
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO: get all the record from table booking
         oCommand.CommandText = "select * from booking order by booking_id"
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




   'function to find booking based on given keyword
   Public Function findBooking(ByVal findField As String, ByVal keyword As String) As List(Of Hashtable)
      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim lsData As New List(Of Hashtable)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open connection to database
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO: find room base on searching criteria
         'oCommand.CommandText = "select * from booking where " & findField & " = ? order by booking_id"
         Select Case findField
            Case "booking_id", "customer_id", "room_id"
               oCommand.CommandText = "select * from booking where " & findField & " = ? order by booking_id"
               oCommand.Parameters.Add(findField, OleDbType.Integer, 8)
               oCommand.Parameters(findField).Value = CInt(keyword)
            Case "datebook", "checkin_date"
               oCommand.CommandText = "select * from booking where datediff('d', " & findField & ", ?) = 0 order by booking_id"
               oCommand.Parameters.Add(findField, OleDbType.Date)
               oCommand.Parameters(findField).Value = CDate(keyword)
            Case "num_days", "num_guests"
               oCommand.CommandText = "select * from booking where " & findField & " = ? order by booking_id"
               oCommand.Parameters.Add(findField, OleDbType.Integer, 3)
               oCommand.Parameters(findField).Value = CInt(keyword)
            Case Else
               oCommand.CommandText = "select * from booking where " & findField & " like ? order by booking_id"
               oCommand.Parameters.Add(findField, OleDbType.VarChar, 255)
               oCommand.Parameters(findField).Value = CStr("%" & keyword & "%")
         End Select

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



   'function update booking infor to the database
   Public Function updateBooking(ByVal htData As Hashtable) As Integer
      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim result As Integer
      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         'open a connection to db
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         oCommand.CommandText = "UPDATE booking SET datebook = ?, room_id = ?, customer_id = ?, num_days = ?, num_guests = ?, checkin_date = ?, total_price = ?, comments = ? WHERE booking_id = ?;"

         oCommand.Parameters.Add("datebook", OleDbType.Date)
         oCommand.Parameters.Add("room_id", OleDbType.Integer, 255)
         oCommand.Parameters.Add("customer_id", OleDbType.Integer, 255)
         oCommand.Parameters.Add("num_days", OleDbType.Integer, 5)
         oCommand.Parameters.Add("num_guests", OleDbType.Integer, 5)
         oCommand.Parameters.Add("checkin_date", OleDbType.Date)
         oCommand.Parameters.Add("total_price", OleDbType.Double, 8)
         oCommand.Parameters.Add("comments", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("booking_id", OleDbType.Integer, 8)

         oCommand.Parameters("datebook").Value = CDate(htData("datebook"))
         oCommand.Parameters("room_id").Value = CInt(htData("room_id"))
         oCommand.Parameters("customer_id").Value = CInt(htData("customer_id"))
         oCommand.Parameters("num_days").Value = CInt(htData("num_days"))
         oCommand.Parameters("num_guests").Value = CInt(htData("num_guests"))
         oCommand.Parameters("checkin_date").Value = CDate(htData("checkin_date"))
         oCommand.Parameters("total_price").Value = CDbl(htData("total_price"))
         oCommand.Parameters("comments").Value = CStr(htData("comments"))
         oCommand.Parameters("booking_id").Value = CInt(htData("booking_id"))

         oCommand.Prepare()

         Debug.Print("SQL: " & oCommand.CommandText)

         result = oCommand.ExecuteNonQuery()

         Debug.Print("The record was updated.")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occured. The record wasn't updated.")
      Finally
         oConnection.Close()
      End Try

      Return result
   End Function



   'function to delete record from the database
   Public Function deleteBooking(ByVal Id As String) As Integer
      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
      Dim result As Integer

      Try
         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         'TODO
         oCommand.CommandText = _
            "DELETE FROM booking WHERE booking_id = ?;"
         oCommand.Parameters.Add("booking_id", OleDbType.Integer, 8)
         oCommand.Parameters("booking_id").Value = CInt(Id)
         oCommand.Prepare()
         result = oCommand.ExecuteNonQuery()

         Debug.Print("The record was deleted.")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occurred. The record was not deleted!")
      Finally
         oConnection.Close()
      End Try

      Return result

    End Function



   'function to create new invoice
   Public Sub insertInvoice(ByVal htBook As Hashtable)

      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         oCommand.CommandText = _
            "INSERT INTO invoice (booking_id, dateinvoice, amount) VALUES (?, ?, ?);"

         oCommand.Parameters.Add("booking_id", OleDbType.Integer, 8)
         oCommand.Parameters.Add("dateinvoice", OleDbType.Date)
         oCommand.Parameters.Add("amount", OleDbType.Double, 12)

         oCommand.Parameters("booking_id").Value = CInt(htBook("booking_id"))
         oCommand.Parameters("dateinvoice").Value = Format(Now(), "dd/MM/yyyy")
         oCommand.Parameters("amount").Value = CDbl(htBook("amount"))

         oCommand.Prepare()

         Debug.Print("SQL: " & oCommand.CommandText)

         oCommand.ExecuteNonQuery()

         Debug.Print("The record was inserted.")
         MessageBox.Show("Insert successfully")

      Catch ex As Exception
         Debug.Print("insert booking ERROR: " & ex.Message)
         MsgBox("An error occured. The record wasn't inserted.")
      Finally
         oConnection.Close()
      End Try
   End Sub



   'function to update invoice
   Public Sub updateInvoice(ByVal htBook As Hashtable)

      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         oCommand.CommandText = _
            "update invoice set dateinvoice = ?, amount = ? where booking_id = ?"

         oCommand.Parameters.Add("dateinvoice", OleDbType.Date)
         oCommand.Parameters.Add("amount", OleDbType.Double, 12)
         oCommand.Parameters.Add("booking_id", OleDbType.Integer, 8)

         oCommand.Parameters("dateinvoice").Value = Format(Now(), "dd/MM/yyyy")
         oCommand.Parameters("amount").Value = CDbl(htBook("amount"))
         oCommand.Parameters("booking_id").Value = CInt(htBook("booking_id"))

         oCommand.Prepare()

         Debug.Print("SQL: " & oCommand.CommandText)

         oCommand.ExecuteNonQuery()

         Debug.Print("The invoice record was update.")
         'MessageBox.Show("Insert successfully")

      Catch ex As Exception
         Debug.Print("update invoice ERROR: " & ex.Message)
         MsgBox("An error occured. The record wasn't inserted.")
      Finally
         oConnection.Close()
      End Try
   End Sub

End Class
