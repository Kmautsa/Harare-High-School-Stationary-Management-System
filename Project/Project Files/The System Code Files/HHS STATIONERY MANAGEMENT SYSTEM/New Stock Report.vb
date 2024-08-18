Imports System.Data.OleDb
Public Class New_Stock_Report
    Dim da As New OleDb.OleDbDataAdapter
    Dim con As New OleDb.OleDbConnection
    Dim dt As New DataTable
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Private Sub NewStationeryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.NewStationeryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.New_StationeryDataSet)

    End Sub

    Private Sub New_Stock_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_StationeryDataSet.NewStationery' table. You can move, or remove it, as needed.
        Me.NewStationeryTableAdapter.Fill(Me.New_StationeryDataSet.NewStationery)
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\TOSHIBA\Documents\A Level Zimsec Database\Login.mdb"
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Main_menu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPrnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrnt.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub
End Class