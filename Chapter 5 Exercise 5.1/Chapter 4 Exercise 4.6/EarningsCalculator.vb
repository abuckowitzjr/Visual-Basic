' Project:      Earnings Calculator
' Programmer:   Arthur Buckowitz
' Date          May 6, 2012
' Description:  Allows user to input completed pieces per employee, calculate button calculates total dollars earned for completed pieces,
'               clear button clears input employee information, summary button displays the accumulated totals of pieces completed and total dollars
'               earned for all employees entered, also show average pay for all employees, clear all button clears every field of the form.

Public Class EarningsCalculatorForm
    Const DEC600PLUS As Decimal = 0.65
    Const DEC400TO599 As Decimal = 0.6
    Const DEC200TO399 As Decimal = 0.55
    Const DEC1TO199 As Decimal = 0.5
    Dim decTotalPay As Decimal
    Dim decTotalEmployees As Decimal
    Dim decAvgPay As Decimal
    Dim decTotalNumberOfPieces As Decimal
    Dim ResultDialogFont As Font
    Dim ResultDialogColor As Color


   Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged
        ' Validates user input for text, displays error message if input is incorrect.

        If IsNumeric(NameTextBox.Text) And NameTextBox.Text <> "" Then
            MessageBox.Show("Name may not consist of numbers, please correct.", "Entry Error", MessageBoxButtons.OK)
            NameTextBox.Text = ""
        End If
    End Sub



    Private Sub CompletedPiecesTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompletedPiecesTextBox.TextChanged
        ' Validates user input for numeric, displays error message if input is incorrect.

        If Not IsNumeric(CompletedPiecesTextBox.Text) And CompletedPiecesTextBox.Text <> "" Then
            MessageBox.Show("Please enter number for completed pieces.", "Entry Error", MessageBoxButtons.OK)
            CompletedPiecesTextBox.Text = ""
        End If
    End Sub

    Private Sub CalculatePayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatePayToolStripMenuItem.Click
        ' Calculates total pay for employee based on completed pieces, displays total in textbox. Keeps tally of total
        ' employees entered, total pay, and completed pieces for all employees.

        Dim decTotalAmountEarned As Decimal
        CompletedPiecesTextBox.Text = Math.Floor(Decimal.Parse(CompletedPiecesTextBox.Text))
        decTotalAmountEarned = PayRateCalculation(CompletedPiecesTextBox.Text) * CompletedPiecesTextBox.Text
        lblAmountEarned.Text = decTotalAmountEarned.ToString("C")
        decTotalEmployees += 1
        decTotalPay += decTotalAmountEarned
        decTotalNumberOfPieces += Decimal.Parse(CompletedPiecesTextBox.Text)
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Calculates average pay of all workers and displays information in a message box.

        If decTotalEmployees = 0 Then
            MessageBox.Show("Summary cannot be processed with no completed pieces entered.", "Input Error", MessageBoxButtons.OK)
        Else
            decAvgPay = decTotalPay / decTotalEmployees
            MessageBox.Show("Total Number of Workers: " & decTotalEmployees.ToString & Environment.NewLine & "Total Number of Pieces: " &
                            decTotalNumberOfPieces.ToString & Environment.NewLine & "Total Pay: " & decTotalPay.ToString("C") &
                            Environment.NewLine & "Average Pay of All Workers: " & decAvgPay.ToString("C"), "Summary", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clears employees information fields, but not summary information.

        lblAmountEarned.Text = ""
        CompletedPiecesTextBox.Text = ""
        NameTextBox.Text = ""
        NameTextBox.Focus()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        ' Reads and stores result font of font dialog box.

        FontDialog1.ShowDialog()
        ResultDialogFont = FontDialog1.Font
        lblAmountEarned.Font = ResultDialogFont
        Label3.Font = ResultDialogFont
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ' Reads and stores result color of color dialog box.

        ColorDialog1.ShowDialog()
        ResultDialogColor = ColorDialog1.Color
        lblAmountEarned.ForeColor = ResultDialogColor
        Label3.ForeColor = ResultDialogColor
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' Displays messagebox containing information about the program.

        MessageBox.Show("Earnings Calculator v1.2.4" & Environment.NewLine & "Programmed By: Arthur Buckowitz", "About", MessageBoxButtons.OK)
    End Sub
    Private Function PayRateCalculation(ByVal num1 As Decimal) As Decimal
        ' Determines what pay rate to supply to other event procedures in calculating total amount earned based on completed pieces.

        Dim PayRate As Decimal
        If num1 >= 600 Then
            PayRate = DEC600PLUS
        ElseIf num1 >= 400 And num1 <= 599 Then
            PayRate = DEC400TO599
        ElseIf num1 >= 200 And num1 <= 399 Then
            PayRate = DEC200TO399
        ElseIf num1 >= 1 And num1 <= 199 Then
            PayRate = DEC1TO199
        End If
        Return PayRate.ToString("C")
    End Function

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exits the program.

        Application.Exit()
    End Sub

End Class

