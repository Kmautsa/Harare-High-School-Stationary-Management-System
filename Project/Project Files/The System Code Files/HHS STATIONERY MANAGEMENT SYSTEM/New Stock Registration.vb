Imports System.Data.OleDb
Public Class New_Stock_Registration

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub NewStationeryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.NewStationeryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.New_StationeryDataSet)

    End Sub

    Private Sub New_Stock_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_StationeryDataSet.NewStationery' table. You can move, or remove it, as needed.
        Me.NewStationeryTableAdapter.Fill(Me.New_StationeryDataSet.NewStationery)
    End Sub

    Private Sub Contact_NumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnback.Click
        Main_menu.Show()
        Me.Hide()
    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        
        NewStationeryBindingSource.AddNew()
    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Try
            NewStationeryBindingSource.EndEdit()
            NewStationeryTableAdapter.Update(New_StationeryDataSet.NewStationery)
            MessageBox.Show("New Stationery Saved")
        Catch ex As Exception
            MessageBox.Show("Error Occured While Saving")
        End Try

    End Sub

    Private Sub Supplier_AdressTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Supplier_AdressTextBox.TextChanged

    End Sub

    Private Sub Supplier_AdressLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Supplier_NameLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Btnclear_Click(sender As System.Object, e As System.EventArgs) Handles Btnclear.Click

        Item_IdTextBox.Clear()
        Item_NameTextBox.Clear()
        Item_TypeTextBox.Clear()
        Unit_PriceTextBox.Clear()
        Unit_SizeTextBox.Clear()
        QuantityTextBox.Clear()
        Supplier_AdressTextBox.Clear()
        Supplier_IdTextBox.Clear()
        Supplier_NameTextBox.Clear()
        Contact_NumberTextBox.Clear()
    End Sub
End Class