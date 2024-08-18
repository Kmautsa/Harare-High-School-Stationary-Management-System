Imports System.Data
Imports System.Data.OleDb
Module Module1
    'Public cn as New OleDb.OleDbConnection
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public ds2 As New DataSet
    Public str As String
    Public c As New ComboBox

    Dim dbprovider, dbsource As String
    Dim sql As String
    Dim maxrows As Integer
    Public Sub conn()
        Dim conn As New OleDbConnection(My.Settings.LoginConnectionString1)
    End Sub
End Module
