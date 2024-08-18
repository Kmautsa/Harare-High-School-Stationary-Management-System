Partial Class LoginDataSet1
    Partial Class LoginDataTable

        Private Sub LoginDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.UserNameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
