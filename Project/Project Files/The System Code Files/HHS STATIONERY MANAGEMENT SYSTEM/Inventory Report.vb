Public Class Inventory_Report

    Private Sub NewStationeryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.NewStationeryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.New_StationeryDataSet)

    End Sub

    Private Sub Inventory_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_StationeryDataSet.NewStationery' table. You can move, or remove it, as needed.
        Me.NewStationeryTableAdapter.Fill(Me.New_StationeryDataSet.NewStationery)

    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Main_menu.Show()
        Me.Hide()

    End Sub

    Private Sub BtnPrnt_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrnt.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub
End Class