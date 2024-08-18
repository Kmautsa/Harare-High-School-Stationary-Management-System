Public Class loading_page

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Value = 100
            Timer1.Stop()
            ProgressBar1.Hide()

        End If
        Label2.Text = "PLEASE WAIT WHILE SYSTEM IS LOADING..."
        Label3.Text = ProgressBar1.Value & "%" & "COMPLETE"
        If ProgressBar1.Value = 100 Then
            Label3.Text = "LOADING COMPLETE PROCEED"
            BTNSTART.Enabled = True
            BTNSTART.Visible = True
        End If
    End Sub

    Private Sub BTNSTART_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSTART.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub BTNEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEXT.Click
        Application.Exit()
    End Sub

    Private Sub loading_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BTNSTART.Enabled = False
        BTNSTART.Visible = False
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
        Timer1.Start()
    End Sub
End Class