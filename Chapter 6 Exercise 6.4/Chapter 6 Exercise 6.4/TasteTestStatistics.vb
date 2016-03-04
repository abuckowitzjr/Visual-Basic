'Project:       Taste Test Statistics
'Programmer:    Arthur Buckowitz
'Date:          June 19, 2012
'Description:   Uses user input rating for each drink to designate a winner between Prune Punch and Apple Ade.

Public Class TasteTestStatistics
    Friend intPrunePunchTotal As Integer
    Friend intAppleAdeTotal As Integer
    Friend intTotalTesters As Integer

    Private Sub NewTesterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTesterToolStripMenuItem.Click
        'displays new tester form.
        NewTester.Show()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        'displays summary form.
        Summary.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the program.
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'displays information about the program in a message box.
        MessageBox.Show("Taste Test Statistics" & Environment.NewLine & "Programmed By: Arthur Buckowitz", "About", MessageBoxButtons.OK)
    End Sub
End Class
