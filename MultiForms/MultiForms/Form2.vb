Public Class Form2

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        MultiForm.strName = NameTextBox.Text
        MultiForm.decScore = Decimal.Parse(ScoreTextBox.Text)
        Me.Close()
    End Sub
End Class