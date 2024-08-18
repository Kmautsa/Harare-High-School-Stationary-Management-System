Public Class New_User

    Private Sub LoginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoginDataSet1)

    End Sub

    Private Sub New_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDataSet1.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.LoginDataSet1.Login)

    End Sub

    Private Sub Btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnback.Click
        Main_menu.Show()
        Me.Hide()
    End Sub

    Private Sub Btnadd_Click(sender As System.Object, e As System.EventArgs) Handles Btnadd.Click
       
        LoginBindingSource.AddNew()

    End Sub

    Private Sub Btnsave_Click(sender As System.Object, e As System.EventArgs) Handles Btnsave.Click
        If UserNameTextBox.Text = "" Then
            MsgBox("Enter Username To Proceed", MsgBoxStyle.Exclamation)
        ElseIf PasswordTextBox.Text = "" Then
            MsgBox("Enter Password To Proceed", MsgBoxStyle.Exclamation)
        ElseIf MsgBox("Are You Sure You Want To Save", vbQuestion + vbYesNo) = vbYes Then
            LoginBindingSource.EndEdit()
            LoginTableAdapter.Update(LoginDataSet1.Login)
            MsgBox("New User Saved", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub BtnClear_Click(sender As System.Object, e As System.EventArgs) Handles BtnClear.Click
        UserNameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub UserNameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles UserNameTextBox.TextChanged

    End Sub
End Class