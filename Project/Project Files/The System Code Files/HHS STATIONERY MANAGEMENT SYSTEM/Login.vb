Imports System.Data
Imports System.Data.OleDb
Public Class Login
    Dim con As New OleDbConnection(My.Settings.LoginConnectionString1)
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim UserName As String
    Dim Password As String

    Private Sub UserNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserNameComboBox.SelectedIndexChanged
        UserNameComboBox.Text = UserNameComboBox.Text
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LoginTableAdapter.Fill(Me.LoginDataSet1.Login)
        UserNameComboBox.Items.Clear()
        PasswordTextBox.Clear()
        Dim ctr, i As Integer
        ds.Clear()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Module1.conn()
        con.Open()
        str = "select * from Login"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Login")
        ctr = ds.Tables("Login").Rows.Count - 1
        For i = 0 To ctr
            UserNameComboBox.Items.Add(ds.Tables("Login").Rows(i)(0).ToString)
        Next
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click

        Dim ctr, i As Integer
        Dim che As Integer = 0
        Dim emp As String = ""

        Dim Login As New DataTable
        ds.Clear()
        'cn.Open()
        str = "select * from Login"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Login")
        ctr = ds.Tables("Login").Rows.Count - 1
        With cmd
            .Connection = con
            .CommandText = str
        End With
        da.SelectCommand = cmd
        If Login.Rows.Count > 0 Then
        End If
        For i = 0 To ctr
            If ds.Tables("Login").Rows(i)(0).ToString = UserNameComboBox.Text And ds.Tables("Login").Rows(i)(1).ToString = PasswordTextBox.Text Then
                che = 1
                emp = ds.Tables("Login").Rows(i)(1).ToString
            End If
        Next
        If che = 1 Then
            con.Close()
            MsgBox("success" & UserName)
            Main_menu.Show()
            Me.Hide()
            UserNameComboBox.ResetText()
            PasswordTextBox.Clear()
        Else
            MsgBox("Password Incorect for Selected User.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PasswordTextBox.PasswordChar = ("*")
        Else
            PasswordTextBox.PasswordChar = ("*")
        End If
    End Sub

    Private Sub Btnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnext.Click
        If MessageBox.Show("Are you sure you want to exit?", "Application name", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class