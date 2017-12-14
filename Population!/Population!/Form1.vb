Public Class Population

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPredict.Click
        Dim intCount As Integer = 1
        Dim dblTotal As Double

        lstPopulation.Items.Add("Day       Approximate Population")
        lstPopulation.Items.Add("-----------------------------------")
        dblTotal = 2
        lstPopulation.Items.Add(intCount & "         " & cboStartingNumber.Text)
        For intCount = intCount + 1 To cboDaysToMultiply.Text
            dblTotal = (txtBoxIncrease.Text / 100) * dblTotal + dblTotal
            lstPopulation.Items.Add(intCount.ToString & "        " & dblTotal.ToString("n"))
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
