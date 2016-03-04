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


    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        ' Calculates total pay for employee based on completed pieces, displays total in textbox. Keeps tally of total
        ' employees entered.

        Dim decDollarAmount As Decimal
        Dim decTotalPieces As Decimal
        If NameTextBox.Text = "" Or CompletedPiecesTextBox.Text = "" Then
            MessageBox.Show("Please enter Employee Name and Number of Pieces Completed.", "Invalid Input", MessageBoxButtons.OK)
        Else
            decTotalPieces = Decimal.Parse(CompletedPiecesTextBox.Text)

            Select Case decTotalPieces
                Case Is >= 600
                    decDollarAmount = decTotalPieces * DEC600PLUS
                    DollarAmountEarnedTextBox.Text = decDollarAmount.ToString("C")
                    decTotalPay += decDollarAmount
                    decTotalNumberOfPieces += decTotalPieces
                Case 400 To 599
                    decDollarAmount = decTotalPieces * DEC400TO599
                    DollarAmountEarnedTextBox.Text = decDollarAmount.ToString("C")
                    decTotalPay += decDollarAmount
                    decTotalNumberOfPieces += decTotalPieces
                Case 200 To 399
                    decDollarAmount = decTotalPieces * DEC200TO399
                    DollarAmountEarnedTextBox.Text = decDollarAmount.ToString("C")
                    decTotalPay += decDollarAmount
                    decTotalNumberOfPieces += decTotalPieces
                Case Else
                    decDollarAmount = decTotalPieces * DEC1TO199
                    DollarAmountEarnedTextBox.Text = decDollarAmount.ToString("C")
                    decTotalPay += decDollarAmount
                    decTotalNumberOfPieces += decTotalPieces
            End Select
            decTotalEmployees += 1
        End If


    End Sub

    Private Sub SummaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryButton.Click
        ' Displays total pieces completed, total dollar amount for all employees, and average pay for all employees.

        If DollarAmountEarnedTextBox.Text = "" Then
            MessageBox.Show("Please complete upper section before processing summary.", "Alert", MessageBoxButtons.OK)
        Else
            TotalPayTextBox.Text = decTotalPay.ToString("C")
            decAvgPay = decTotalPay / decTotalEmployees
            AveragePayTextBox.Text = decAvgPay.ToString("C")
            TotalPiecesTextBox.Text = decTotalNumberOfPieces.ToString
        End If
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ' Clears employees information fields, but not summary information.

        CompletedPiecesTextBox.Text = ""
        NameTextBox.Text = ""
        DollarAmountEarnedTextBox.Text = ""
    End Sub

    Private Sub ClearAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllButton.Click
        ' Clears all fields of the form as well as all stored memory.

        Dim MessageBoxResult As DialogResult
        MessageBoxResult = MessageBox.Show("Are you sure you want to clear all fields?", "Alert", MessageBoxButtons.YesNo)
        If MessageBoxResult = Windows.Forms.DialogResult.Yes Then
            TotalPiecesTextBox.Text = ""
            AveragePayTextBox.Text = ""
            TotalPayTextBox.Text = ""
            decTotalPay = 0
            decTotalEmployees = 0
            decAvgPay = 0
            decTotalNumberOfPieces = 0
            CompletedPiecesTextBox.Text = ""
            NameTextBox.Text = ""
            DollarAmountEarnedTextBox.Text = ""

        End If

    End Sub


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
End Class

