Public Class SummaryForm

    Private Sub Summary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim TotalSales As Decimal = RegularEmployee.TotalSales + Supervisor.TotalSales
        Dim TotalCommission As Decimal = RegularEmployee.TotalCommission + Supervisor.TotalCommission
        Dim TotalPay As Decimal = RegularEmployee.TotalEarned + Supervisor.TotalEarned
        txtTotalSales.Text = TotalSales.ToString("C")
        txtTotalCommission.Text = TotalCommission.ToString("C")
        txtTotalPay.Text = TotalPay.ToString("C")
    End Sub
End Class