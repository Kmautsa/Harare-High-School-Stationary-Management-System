Public Class Inventory

    Private Sub NewStationeryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.NewStationeryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.New_StationeryDataSet)

    End Sub

    Private Sub Inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_StationeryDataSet.NewStationery' table. You can move, or remove it, as needed.
        Me.NewStationeryTableAdapter.Fill(Me.New_StationeryDataSet.NewStationery)

    End Sub

    Private Sub Item_IdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Item_IdTextBox.TextChanged

    End Sub

    
    Private Sub BTNBACK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBACK.Click
        Main_menu.Show()
        Me.Hide()

    End Sub

    Private Sub BTNNXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNXT.Click
        NewStationeryBindingSource.MoveNext()
    End Sub

    Private Sub BTNPRV_Click(sender As System.Object, e As System.EventArgs) Handles BTNPRV.Click
        NewStationeryBindingSource.MovePrevious()
    End Sub

    Private Sub BTNFST_Click(sender As System.Object, e As System.EventArgs) Handles BTNFST.Click
        NewStationeryBindingSource.MoveFirst()
    End Sub

    Private Sub BTNLST_Click(sender As System.Object, e As System.EventArgs) Handles BTNLST.Click
        NewStationeryBindingSource.MoveLast()
    End Sub
End Class