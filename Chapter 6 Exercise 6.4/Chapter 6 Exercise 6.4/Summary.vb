Public Class Summary

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'closes the summary form and resets focus to main form.
        Me.Close()
        TasteTestStatistics.Focus()
    End Sub

    Private Sub Summary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'displays the summary information in the correct textboxes, using functions to declare a winner.
        Dim TotalPruneAverage As Decimal
        Dim TotalAppleAverage As Decimal
        TotalPruneAverage = AveragePruneRating()
        TotalAppleAverage = AverageAppleRating()
        txtTotalTesters.Text = TasteTestStatistics.intTotalTesters.ToString
        txtPrunePunchAverage.Text = TotalPruneAverage.ToString("F")
        txtAppleAdeAverage.Text = TotalAppleAverage.ToString("F")
        If TotalPruneAverage > TotalAppleAverage Then
            lblWinner.Text = "Prune Punch Wins"
        Else
            lblWinner.Text = "Apple Ade Wins"
        End If
    End Sub
    Private Function AveragePruneRating() As Decimal
        'function to calculate the average rating for Prune Punch.
        Dim decPruneAverage As Decimal
        decPruneAverage = Convert.ToDecimal(TasteTestStatistics.intPrunePunchTotal / TasteTestStatistics.intTotalTesters)
        Return decPruneAverage
    End Function
    Private Function AverageAppleRating() As Decimal
        'function to calculate the average rating for Apple Ade.
        Dim decAppleAverage As Decimal
        decAppleAverage = Convert.ToDecimal(TasteTestStatistics.intAppleAdeTotal / TasteTestStatistics.intTotalTesters)
        Return decAppleAverage
    End Function
End Class