Public Class NewTester

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'stores information in variables to use for summary form, validate user input, clears fields of form for new tester.
        If txtPrunePunch.Text = "" Then
            MessageBox.Show("Please enter rating for Prune Punch", "Input Error", MessageBoxButtons.OK)
        ElseIf txtAppleAde.Text = "" Then
            MessageBox.Show("Please enter rating for Apple Ade", "Input Error", MessageBoxButtons.OK)
        Else
            TasteTestStatistics.intPrunePunchTotal = TasteTestStatistics.intPrunePunchTotal + Integer.Parse(txtPrunePunch.Text)
            TasteTestStatistics.intAppleAdeTotal = TasteTestStatistics.intAppleAdeTotal + Integer.Parse(txtAppleAde.Text)
            TasteTestStatistics.intTotalTesters = TasteTestStatistics.intTotalTesters + 1
            txtAppleAde.Text = ""
            txtPrunePunch.Text = ""
            txtPrunePunch.Focus()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'closes new tester form and sets focus to main form.
        Me.Close()
        TasteTestStatistics.Focus()
    End Sub

    Private Sub txtPrunePunch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrunePunch.TextChanged
        'validates user input.
        If Not IsNumeric(txtPrunePunch.Text) And txtPrunePunch.Text <> "" Then
            MessageBox.Show("Letters may not be entered for number rating, please correct.", "Input Error", MessageBoxButtons.OK)
            txtPrunePunch.Text = ""
        ElseIf IsNumeric(txtPrunePunch.Text) Then
            If CDbl(txtPrunePunch.Text) < 1 Or CDbl(txtPrunePunch.Text) > 10 Then
                MessageBox.Show("Rating scale is 1 to 10, please correct input.", "Input Error", MessageBoxButtons.OK)
                txtPrunePunch.Text = ""
            End If
        End If
    End Sub

    Private Sub txtAppleAde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAppleAde.TextChanged
        'validates user input.
        If Not IsNumeric(txtAppleAde.Text) And txtAppleAde.Text <> "" Then
            MessageBox.Show("Letters may not be entered for number rating, please correct.", "Input Error", MessageBoxButtons.OK)
            txtAppleAde.Text = ""
        ElseIf IsNumeric(txtAppleAde.Text) Then
            If CDbl(txtAppleAde.Text) < 1 Or CDbl(txtAppleAde.Text) > 10 Then
                MessageBox.Show("Rating scale is 1 to 10, please correct input.", "Input Error", MessageBoxButtons.OK)
                txtAppleAde.Text = ""
            End If
        End If
    End Sub
End Class