Public Class About

    Private Sub About_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBack_Click_1(sender As System.Object, e As System.EventArgs) Handles BtnBack.Click
        Main_menu.Show()
        Me.Hide()
    End Sub
End Class