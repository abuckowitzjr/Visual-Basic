Public Class Summary

    Private Sub Summary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'reads and displays summary information for all jobs.
        txtPartsTotal.Text = frmPatsAutoRepair.decTotalParts.ToString("C")
        txtLaborTotal.Text = frmPatsAutoRepair.decTotalLabor.ToString("C")
        txtSalesTaxTotal.Text = frmPatsAutoRepair.decTotalSalesTax.ToString("C")
        txtTotalsTotal.Text = frmPatsAutoRepair.decTotalTotal.ToString("C")
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'closes summary form and sets focus on main form.
        Me.Close()
        frmPatsAutoRepair.Focus()
    End Sub
End Class