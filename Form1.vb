Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNewItem.TextChanged

    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        itemList.Items.Add(txtNewItem.Text)
        txtNewItem.Clear()
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If itemList.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item to delete.")
            Exit Sub
        End If
        itemList.Items.Remove(itemList.SelectedItem)

    End Sub
End Class
