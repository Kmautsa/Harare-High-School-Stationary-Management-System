Public Class Main_menu

    Private Sub Btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnew.Click
        New_Stock_Registration.Show()
        Me.Hide()
    End Sub

    Private Sub BtnOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOut.Click
        Stock_Out_Transaction.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInvntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvntry.Click
        Inventory.Show()
        Me.Show()
    End Sub

    Private Sub Btnadduser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadduser.Click
        New_User.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDltuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDltuser.Click
        Delete_User.Show()
        Me.Hide()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
        Me.Hide()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()
        Me.Hide()
    End Sub

    Private Sub InventoryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryReportToolStripMenuItem.Click
        Inventory_Report.Show()
        Me.Hide()
    End Sub

    Private Sub NewStockReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewStockReportToolStripMenuItem.Click
        New_Stock_Report.Show()
        Me.Hide()
    End Sub
End Class