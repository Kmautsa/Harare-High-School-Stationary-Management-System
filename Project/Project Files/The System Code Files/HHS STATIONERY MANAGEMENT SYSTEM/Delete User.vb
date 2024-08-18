Public Class Delete_User

    Private Sub LoginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoginDataSet1)

    End Sub

    Private Sub Delete_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDataSet1.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.LoginDataSet1.Login)

    End Sub

    Private Sub Btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnback.Click
        Main_menu.Show()
        Me.Hide()
    End Sub

    Private Sub Btndlte_Click(sender As System.Object, e As System.EventArgs) Handles Btndlte.Click

    End Sub

    Private Sub BtnClear_Click(sender As System.Object, e As System.EventArgs) Handles BtnClear.Click
        UserNameComboBox.Update()
        PasswordTextBox.Clear()
    End Sub
End Class