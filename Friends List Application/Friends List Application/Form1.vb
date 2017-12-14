Public Class Form1
    Private lstNames As New List(Of String)

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click

        'Display all names in the list box'
        Dim strName As String
        lstFriends.Items.Clear()
        For Each strName In lstNames

            lstFriends.Items.Add(strName)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Add the name to the List.
        lstNames.Add(txtName.Text)

        ' Clear the text box.
        txtName.Clear()
        txtName.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub
End Class
