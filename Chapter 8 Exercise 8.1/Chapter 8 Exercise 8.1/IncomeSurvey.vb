'Project:       Income Survey
'Programmer:    Arthur Buckowitz
'Date:          June 27, 2012
'Description:   A survey that stores user input for id numbers, members of the houshold, and yearly income. The stored 
'               information can be printed by three different menu item.  The input data menu item prints all data that has been 
'               entered into the form.  The above average menu item prints id code and income for all households who earn a yearly income
'               above the average income of all surveys.  The below poverty menu item prints the percentage of the surveys that have
'               a yearly income below the poverty guidelines for 2008.

Public Class IncomeSurvey
    Dim AverageIncome As Decimal
    Dim PercentBelow As Decimal
    Dim intIndex As Integer = 0
    Dim Survey(0) As IncomeSurvey
    Const POVERTY1 As Decimal = 10210
    Const POVERTY2 As Decimal = 13690
    Const POVERTY3 As Decimal = 17170
    Const POVERTY4 As Decimal = 20650
    Const POVERTY5 As Decimal = 24130
    Const POVERTY6 As Decimal = 27610
    Const POVERTY7 As Decimal = 31090
    Const POVERTY8 As Decimal = 34570
    Const OVER8 As Decimal = 3480
    Structure IncomeSurvey
        'structure for the array.
        Dim IdentificationCode As Integer
        Dim HouseholdMembers As Integer
        Dim YearlyIncome As Decimal
    End Structure
    Private Sub EnterDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnterDataToolStripMenuItem.Click
        'stores the input data into the array, clears fields for next survey.
        Dim NewSurvey As IncomeSurvey
        If txtIDCode.Text = "" Then
            MessageBox.Show("Please enter the Identification Code for the survey.", "Input Error", MessageBoxButtons.OK)
            txtIDCode.Focus()
        ElseIf txtNumberHouse.Text = "" Then
            MessageBox.Show("Please enter the Number of Members In Household.", "Input Error", MessageBoxButtons.OK)
            txtNumberHouse.Focus()
        ElseIf txtYearlyIncome.Text = "" Then
            MessageBox.Show("Please enter the Yearly Income.", "Input Error", MessageBoxButtons.OK)
            txtYearlyIncome.Focus()
        Else
            If intIndex = 0 Then
                NewSurvey.IdentificationCode = Integer.Parse(txtIDCode.Text)
                NewSurvey.HouseholdMembers = Integer.Parse(txtNumberHouse.Text)
                NewSurvey.YearlyIncome = Decimal.Parse(txtYearlyIncome.Text)
                Survey(0) = NewSurvey
                intIndex += 1
            Else
                ReDim Preserve Survey(intIndex)
                NewSurvey.IdentificationCode = Integer.Parse(txtIDCode.Text)
                NewSurvey.HouseholdMembers = Integer.Parse(txtNumberHouse.Text)
                NewSurvey.YearlyIncome = Decimal.Parse(txtYearlyIncome.Text)
                Survey(intIndex) = NewSurvey
                intIndex += 1
            End If
            txtIDCode.Text = ""
            txtNumberHouse.Text = ""
            txtYearlyIncome.Text = ""
            txtIDCode.Focus()
        End If
    End Sub
    Private Sub InputDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InputDataToolStripMenuItem.Click
        'sets print document 1 to print preview and displays print preview.
        If intIndex = 0 Then
            MessageBox.Show("Survey information must be entered to print Input Data.", "Input Error", MessageBoxButtons.OK)
        Else
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'designates information for print document 1 retrieving all information from the array.
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Static PageNum As Integer = 1
        For Each SurveyItem As IncomeSurvey In Survey
            If PageNum <= 2 Then
                e.Graphics.DrawString("Identification Code: " & SurveyItem.IdentificationCode.ToString, PrintFont, Brushes.Black,
                                                      HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
                VerticalPrintLocationSingle += LineHeightSingle
                e.Graphics.DrawString("Number of Household Members: " & SurveyItem.HouseholdMembers.ToString, PrintFont, Brushes.Black,
                                          HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
                VerticalPrintLocationSingle += LineHeightSingle
                e.Graphics.DrawString("Yearly Income: " & SurveyItem.YearlyIncome.ToString("C"), PrintFont, Brushes.Black,
                                          HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
                VerticalPrintLocationSingle += LineHeightSingle + LineHeightSingle
            Else
                e.HasMorePages = False
            End If
            If VerticalPrintLocationSingle >= e.MarginBounds.Bottom Then
                e.HasMorePages = True
                VerticalPrintLocationSingle = e.MarginBounds.Top
                PageNum += 1
            End If
        Next
    End Sub

    Private Sub BelowPovertyLevelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BelowPovertyLevelToolStripMenuItem.Click
        'scans array for surveys that are below poverty level and calculates percentage, sets print document 2 to the print preview dialog.
        Dim TotalSurveys As Integer
        Dim intBelowPoverty As Integer
        If intIndex = 0 Then
            MessageBox.Show("Survey information must be entered to print Below Poverty Level.", "Input Error", MessageBoxButtons.OK)
        Else
            For Each SurveyItem As IncomeSurvey In Survey
                TotalSurveys += 1
                If SurveyItem.HouseholdMembers = 1 And SurveyItem.YearlyIncome < POVERTY1 Then
                    intBelowPoverty += 1
                ElseIf SurveyItem.HouseholdMembers = 2 And SurveyItem.YearlyIncome < POVERTY2 Then
                    intBelowPoverty += 1
                ElseIf SurveyItem.HouseholdMembers = 3 And SurveyItem.YearlyIncome < POVERTY3 Then
                    intBelowPoverty += 1
                ElseIf SurveyItem.HouseholdMembers = 4 And SurveyItem.YearlyIncome < POVERTY4 Then
                    intBelowPoverty += 1
                ElseIf SurveyItem.HouseholdMembers = 5 And SurveyItem.YearlyIncome < POVERTY5 Then
                    intBelowPoverty += 1
                ElseIf SurveyItem.HouseholdMembers = 6 And SurveyItem.YearlyIncome < POVERTY6 Then
                    intBelowPoverty += 1
                ElseIf SurveyItem.HouseholdMembers = 7 And SurveyItem.YearlyIncome < POVERTY7 Then
                    intBelowPoverty += 1
                ElseIf SurveyItem.HouseholdMembers = 8 And SurveyItem.YearlyIncome < POVERTY8 Then
                    intBelowPoverty += 1
                ElseIf SurveyItem.HouseholdMembers > 8 And SurveyItem.YearlyIncome < (POVERTY8 + ((SurveyItem.HouseholdMembers - 8) * OVER8)) Then
                    intBelowPoverty += 1
                End If
            Next
            PercentBelow = CDec(intBelowPoverty / TotalSurveys)
            PrintPreviewDialog1.Document = PrintDocument2
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub
    Private Sub PrintDocument2_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        'designates information to print document 2 for printing, contains below poverty information.
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top

        e.Graphics.DrawString(PercentBelow.ToString("p"), PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                              VerticalPrintLocationSingle)
    End Sub

    Private Sub AboveAverageIncomeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboveAverageIncomeToolStripMenuItem.Click
        'adds the total income of all surveys, calculates average income, sets print document 3 to print preview.
        Dim TotalIncome As Decimal
        Dim TotalSurveys As Integer
        If intIndex = 0 Then
            MessageBox.Show("Survey information must be entered to print Above Average Income.", "Input Error", MessageBoxButtons.OK)
        Else
            For Each SurveyItem As IncomeSurvey In Survey
                TotalSurveys += 1
                TotalIncome = TotalIncome + SurveyItem.YearlyIncome
            Next
            AverageIncome = TotalIncome / TotalSurveys
            PrintPreviewDialog1.Document = PrintDocument3
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub
    Private Sub PrintDocument3_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        'designates information to print document 3 based on any survey in the array above an average yearly income.
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Static PageNum As Integer = 1
        For Each SurveyItem As IncomeSurvey In Survey
            If PageNum <= 2 Then
                If SurveyItem.YearlyIncome > AverageIncome Then
                    e.Graphics.DrawString("Identification Code: " & SurveyItem.IdentificationCode.ToString, PrintFont, Brushes.Black,
                                                                          HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
                    VerticalPrintLocationSingle += LineHeightSingle
                    e.Graphics.DrawString("Yearly Income: " & SurveyItem.YearlyIncome.ToString("C"), PrintFont, Brushes.Black,
                                                              HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
                    VerticalPrintLocationSingle += LineHeightSingle + LineHeightSingle
                End If
            Else
                e.HasMorePages = False
            End If
            If VerticalPrintLocationSingle >= e.MarginBounds.Bottom Then
                e.HasMorePages = True
                VerticalPrintLocationSingle = e.MarginBounds.Top
                PageNum += 1
            End If
        Next
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the program.
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'displays the about item.
        AboutBox1.Show()
    End Sub

    Private Sub txtIDCode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtIDCode.TextChanged
        'validates the user input in the id code field
        If Not IsNumeric(txtIDCode.Text) And txtIDCode.Text <> "" Then
            MessageBox.Show("Letters cannot be entered for Identification Code.", "Input Error", MessageBoxButtons.OK)
            txtIDCode.Text = ""
            txtIDCode.Focus()
        End If
    End Sub

    Private Sub txtNumberHouse_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumberHouse.TextChanged
        'validates the user input in the number of members field
        If Not IsNumeric(txtNumberHouse.Text) And txtNumberHouse.Text <> "" Then
            MessageBox.Show("Letters cannot be entered for Number of Members In Household.", "Input Error", MessageBoxButtons.OK)
            txtNumberHouse.Text = ""
            txtNumberHouse.Focus()
        End If
    End Sub

    Private Sub txtYearlyIncome_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtYearlyIncome.TextChanged
        'validates the user input in the yearly income field
        If Not IsNumeric(txtYearlyIncome.Text) And txtYearlyIncome.Text <> "" Then
            MessageBox.Show("Letters cannot be entered for Yearly Income.", "Input Error", MessageBoxButtons.OK)
            txtYearlyIncome.Text = ""
            txtYearlyIncome.Focus()
        End If
    End Sub
End Class


