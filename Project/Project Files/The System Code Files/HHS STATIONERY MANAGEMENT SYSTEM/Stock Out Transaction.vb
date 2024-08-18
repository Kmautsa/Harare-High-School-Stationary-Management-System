Public Class Stock_Out_Transaction

    Private Sub NewStationeryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.NewStationeryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.New_StationeryDataSet)

    End Sub

    Private Sub Stock_Out_Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_StationeryDataSet.NewStationery' table. You can move, or remove it, as needed.
        Me.NewStationeryTableAdapter.Fill(Me.New_StationeryDataSet.NewStationery)

    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Main_menu.Show()
        Me.Hide()

    End Sub

    Private Sub Btndeduct_Click(sender As System.Object, e As System.EventArgs) Handles Btndeduct.Click
        NewStationeryBindingSource.RemoveCurrent()

    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        Try
            NewStationeryBindingSource.EndEdit()
            NewStationeryTableAdapter.Update(New_StationeryDataSet.NewStationery)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Txrsrch_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txrsrch.TextChanged
        Me.NewStationeryBindingSource.Filter = "[Item Name] like '%" & Txrsrch.Text & "%'"
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub
End Class