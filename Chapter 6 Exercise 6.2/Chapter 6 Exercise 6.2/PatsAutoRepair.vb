'Project:       Pat's Auto Repair Shop
'Programmer:    Arthur Buckowitz
'Date:          June 19, 2012
'Description:   Uses user input to display total cost via amount charged for parts, labor, and sales tax.
Public Class frmPatsAutoRepair

    Private Sub JobInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobInformationToolStripMenuItem.Click
        'Displays the job information form.
        frmJobInfo.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the program.
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'displays information about the program in a messagebox.
        MessageBox.Show("Pat's Auto Repair Shop" & Environment.NewLine & "Version 1.0" & Environment.NewLine & "Programmed By: Arthur Buckowitz", "About", MessageBoxButtons.OK)
    End Sub
End Class
