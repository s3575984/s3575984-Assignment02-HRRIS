Option Explicit On
Option Strict On

Imports System.Data.OleDb

' Name:        clsAddToDB
' Description: this class contains function to add new record to database
' Author:      Pham Hoang Phuc
' Date:        27/03/2017


Public Class addToDB

    Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3575984-dtb.accdb"

   Public Sub insertCustomer(ByVal htData As Hashtable)
      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         oCommand.CommandText = _
            "INSERT INTO customer (title, gender, firstname, lastname, phone, address, email, dob) VALUES (?, ?, ?, ?, ?, ?, ?, ?);"

         oCommand.Parameters.Add("title", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("gender", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("firstname", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("lastname", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("phone", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("address", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("email", OleDbType.VarChar, 255)
         oCommand.Parameters.Add("dob", OleDbType.Date)

         oCommand.Parameters("title").Value = CStr(htData("title"))
         oCommand.Parameters("gender").Value = CStr(htData("gender"))
         oCommand.Parameters("firstname").Value = CStr(htData("firstname"))
         oCommand.Parameters("lastname").Value = CStr(htData("lastname"))
         oCommand.Parameters("phone").Value = CStr(htData("phone"))
         oCommand.Parameters("address").Value = CStr(htData("address"))
         oCommand.Parameters("email").Value = CStr(htData("email"))
         oCommand.Parameters("dob").Value = CDate(htData("dob"))

         oCommand.Prepare()

         Debug.Print("SQL: " & oCommand.CommandText)

         oCommand.ExecuteNonQuery()

         Debug.Print("The record was inserted.")
         MessageBox.Show("Insert successfully")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occured. The record wasn't inserted.")
      Finally
         oConnection.Close()
      End Try

   End Sub

   Public Sub insertRoom(ByVal htRoom As Hashtable)

      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         oCommand.CommandText = _
            "INSERT INTO room (room_number, type, price, num_beds, availability, floor, description) VALUES (?, ?, ?, ?, ?, ?, ?);"

         oCommand.Parameters.Add("room_number", OleDbType.VarChar, 20)
         oCommand.Parameters.Add("type", OleDbType.VarChar, 50)
         oCommand.Parameters.Add("price", OleDbType.Double, 8)
         oCommand.Parameters.Add("num_beds", OleDbType.Integer, 1)
         oCommand.Parameters.Add("availability", OleDbType.VarChar, 20)
         oCommand.Parameters.Add("floor", OleDbType.VarChar, 20)
         oCommand.Parameters.Add("description", OleDbType.VarChar, 255)

         oCommand.Parameters("room_number").Value = CStr(htRoom("room_number"))
         oCommand.Parameters("type").Value = CStr(htRoom("type"))
         oCommand.Parameters("price").Value = CDbl(htRoom("price"))
         oCommand.Parameters("num_beds").Value = CInt(htRoom("num_beds"))
         oCommand.Parameters("availability").Value = CStr(htRoom("availability"))
         oCommand.Parameters("floor").Value = CStr(htRoom("floor"))
         oCommand.Parameters("description").Value = CStr(htRoom("description"))

         oCommand.Prepare()

         Debug.Print("SQL: " & oCommand.CommandText)

         oCommand.ExecuteNonQuery()

         Debug.Print("The record was inserted.")
         MessageBox.Show("Insert successfully")

      Catch ex As Exception
         Debug.Print("ERROR: " & ex.Message)
         MsgBox("An error occured. The record wasn't inserted.")
      Finally
         oConnection.Close()
      End Try
   End Sub

   Public Sub insertBooking(ByVal htBook As Hashtable)

      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

      Try
         Debug.Print("Connection string: " & oConnection.ConnectionString)

         oConnection.Open()
         Dim oCommand As OleDbCommand = New OleDbCommand
         oCommand.Connection = oConnection

         oCommand.CommandText = _
            "INSERT INTO booking (datebook, room_id, customer_id, num_days, num_guests, checkin_date, total_price, comments) VALUES (?, ?, ?, ?, ?, ?, ?, ?);"

         oCommand.Parameters.Add("datebook", OleDbType.Date)
         oCommand.Parameters.Add("room_id", OleDbType.Integer, 255)
         oCommand.Parameters.Add("customer_id", OleDbType.Integer, 255)
         oCommand.Parameters.Add("num_days", OleDbType.Integer, 5)
         oCommand.Parameters.Add("num_guests", OleDbType.Integer, 5)
         oCommand.Parameters.Add("checkin_date", OleDbType.Date)
            oCommand.Parameters.Add("total_price", OleDbType.Double, 12)
         oCommand.Parameters.Add("comments", OleDbType.VarChar, 255)

         oCommand.Parameters("datebook").Value = CDate(htBook("datebook"))
         oCommand.Parameters("room_id").Value = CInt(htBook("room_id"))
         oCommand.Parameters("customer_id").Value = CInt(htBook("customer_id"))
         oCommand.Parameters("num_days").Value = CInt(htBook("num_days"))
         oCommand.Parameters("num_guests").Value = CInt(htBook("num_guests"))
         oCommand.Parameters("checkin_date").Value = CDate(htBook("checkin_date"))
         oCommand.Parameters("total_price").Value = CDbl(htBook("total_price"))
         oCommand.Parameters("comments").Value = CStr(htBook("comments"))

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


End Class
