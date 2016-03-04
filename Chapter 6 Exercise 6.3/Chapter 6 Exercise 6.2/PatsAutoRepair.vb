'Project:       Pat's Auto Repair Shop
'Programmer:    Arthur Buckowitz
'Date:          June 19, 2012
'Description:   Uses user input to display total cost via amount charged for parts, labor, and sales tax, allows user to display summary
'               information about all jobs.
Public Class frmPatsAutoRepair
    Friend decTotalParts As Decimal
    Friend decTotalLabor As Decimal
    Friend decTotalSalesTax As Decimal
    Friend decTotalTotal As Decimal
    Private Sub JobInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobInformationToolStripMenuItem.Click
        'displays job information form.
        frmJobInfo.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the program.
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'displays information about the program in messagebox.
        MessageBox.Show("Pat's Auto Repair Shop" & Environment.NewLine & "Version 1.0" & Environment.NewLine & "Programmed By: Arthur Buckowitz", "About", MessageBoxButtons.OK)
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        'validates input before displaying summary.
        If decTotalTotal = 0 Then
            MessageBox.Show("Summary cannot be processed until at least one job has been entered.", "Input Error", MessageBoxButtons.OK)
        Else
            Summary.Show()
        End If
    End Sub
End Class
