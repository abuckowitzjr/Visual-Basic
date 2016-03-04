Public Class SummaryForm

    Private Sub Summary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtTotalSales.Text = SalesCommission.SalesTotal.ToString("C")
        txtTotalCommission.Text = SalesCommission.CommissionTotal.ToString("C")
        txtTotalPay.Text = SalesCommission.EarnedTotal.ToString("C")
    End Sub
End Class