Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name:        frmReport1
' Description: get input for report 1
' Author:      Pham Hoang Phuc
' Date:        2/5/2017

Public Class frmReport1

    Private Sub frmReport1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oConnection As OleDbConnection = New OleDbConnection(controller.CONNECTION_STRING)
        Dim ds As DataSet
        Dim da As OleDbDataAdapter
        Dim tables As DataTableCollection
        Try
            oConnection.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT customer_id from customer", oConnection)
            da.Fill(ds, "customer_id")
            Dim view1 As New DataView(tables(0))

            boxCusId.DataSource = ds.Tables("customer_id")
            boxCusId.DisplayMember = "customer_id"
            boxCusId.ValueMember = "customer_id"
            boxCusId.SelectedIndex = -1

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim oController As New reportContoller
        If boxCusId.SelectedIndex > -1 Then
            oController.createReport1(CInt(boxCusId.SelectedValue))
        Else : MsgBox("Please select customer ID", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Public Sub refreshFrm()
        boxCusId.SelectedIndex = -1
    End Sub

End Class