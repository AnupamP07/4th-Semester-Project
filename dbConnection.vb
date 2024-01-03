Imports MySql.Data.MySqlClient
Imports System.IO

Module dbConnection
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As DataTable
    Public ds As DataSet
    Public i As Integer
    Public j As Integer
    Public result As Boolean
    Public Pro_Title As String = "Store Management System"

    Public Function DBconn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;username=root;password=;database=stock_db"
                result = True
            End If

        Catch ex As Exception
            result = False
            MsgBox("Server Not Found!", vbExclamation)
        End Try
        Return result
    End Function




End Module
