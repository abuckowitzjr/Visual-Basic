'Project:       Survey
'Programmer:    Arthur Buckowitz
'Date:          June 1, 2012
'Description:   The user provides answers to the 10 questions, answers are stored in an array, print summary displays the total amount of
'               answers for each type.

Public Class frmSurvey
    Dim Answers(9, 4) As Integer
    Private Sub btnEnterData_Click(sender As System.Object, e As System.EventArgs) Handles btnEnterData.Click
        'validates that all questions have a valid answer, if so, stores the date in the cooresponding location of the array. all the radio
        'buttons are cleard for the next survey.
        If rbQ1Always.Checked = False And rbQ1Usually.Checked = False And rbQ1Sometimes.Checked = False And rbQ1Seldom.Checked = False And
            rbQ1Never.Checked = False Then
            MessageBox.Show("Please complete every question before entering data", "Input Error", MessageBoxButtons.OK)
        ElseIf rbQ2Always.Checked = False And rbQ2Usually.Checked = False And rbQ2Sometimes.Checked = False And rbQ2Seldom.Checked = False And
            rbQ2Never.Checked = False Then
            MessageBox.Show("Please complete every question before entering data", "Input Error", MessageBoxButtons.OK)
        ElseIf rbQ3Always.Checked = False And rbQ3Usually.Checked = False And rbQ3Sometimes.Checked = False And rbQ3Seldom.Checked = False And
            rbQ3Never.Checked = False Then
            MessageBox.Show("Please complete every question before entering data", "Input Error", MessageBoxButtons.OK)
        ElseIf rbQ4Always.Checked = False And rbQ4Usually.Checked = False And rbQ4Sometimes.Checked = False And rbQ4Seldom.Checked = False And
            rbQ4Never.Checked = False Then
            MessageBox.Show("Please complete every question before entering data", "Input Error", MessageBoxButtons.OK)
        ElseIf rbQ5Always.Checked = False And rbQ5Usually.Checked = False And rbQ5Sometimes.Checked = False And rbQ5Seldom.Checked = False And
            rbQ5Never.Checked = False Then
            MessageBox.Show("Please complete every question before entering data", "Input Error", MessageBoxButtons.OK)
        ElseIf rbQ6Always.Checked = False And rbQ6Usually.Checked = False And rbQ6Sometimes.Checked = False And rbQ6Seldom.Checked = False And
            rbQ6Never.Checked = False Then
            MessageBox.Show("Please complete every question before entering data", "Input Error", MessageBoxButtons.OK)
        ElseIf rbQ7Always.Checked = False And rbQ7Usually.Checked = False And rbQ7Sometimes.Checked = False And rbQ7Seldom.Checked = False And
            rbQ7Never.Checked = False Then
            MessageBox.Show("Please complete every question before entering data", "Input Error", MessageBoxButtons.OK)
        ElseIf rbQ8Always.Checked = False And rbQ8Usually.Checked = False And rbQ8Sometimes.Checked = False And rbQ8Seldom.Checked = False And
            rbQ8Never.Checked = False Then
            MessageBox.Show("Please complete every question before entering data", "Input Error", MessageBoxButtons.OK)
        ElseIf rbQ9Always.Checked = False And rbQ9Usually.Checked = False And rbQ9Sometimes.Checked = False And rbQ9Seldom.Checked = False And
            rbQ9Never.Checked = False Then
            MessageBox.Show("Please complete every question before entering data", "Input Error", MessageBoxButtons.OK)
        ElseIf rbQ10Always.Checked = False And rbQ10Usually.Checked = False And rbQ10Sometimes.Checked = False And rbQ10Seldom.Checked = False And
            rbQ10Never.Checked = False Then
            MessageBox.Show("Please complete every question before entering data", "Input Error", MessageBoxButtons.OK)
        Else
            If rbQ1Always.Checked = True Then
                Answers(0, 0) = Answers(0, 0) + 1
            ElseIf rbQ1Usually.Checked = True Then
                Answers(0, 1) = Answers(0, 1) + 1
            ElseIf rbQ1Sometimes.Checked = True Then
                Answers(0, 2) = Answers(0, 2) + 1
            ElseIf rbQ1Seldom.Checked = True Then
                Answers(0, 3) = Answers(0, 3) + 1
            ElseIf rbQ1Never.Checked = True Then
                Answers(0, 4) = Answers(0, 4) + 1
            End If
            If rbQ2Always.Checked = True Then
                Answers(1, 0) = Answers(1, 0) + 1
            ElseIf rbQ2Usually.Checked = True Then
                Answers(1, 1) = Answers(1, 1) + 1
            ElseIf rbQ2Sometimes.Checked = True Then
                Answers(1, 2) = Answers(1, 2) + 1
            ElseIf rbQ2Seldom.Checked = True Then
                Answers(1, 3) = Answers(1, 3) + 1
            ElseIf rbQ2Never.Checked = True Then
                Answers(1, 4) = Answers(1, 4) + 1
            End If
            If rbQ3Always.Checked = True Then
                Answers(2, 0) = Answers(2, 0) + 1
            ElseIf rbQ3Usually.Checked = True Then
                Answers(2, 1) = Answers(2, 1) + 1
            ElseIf rbQ3Sometimes.Checked = True Then
                Answers(2, 2) = Answers(2, 2) + 1
            ElseIf rbQ3Seldom.Checked = True Then
                Answers(2, 3) = Answers(2, 3) + 1
            ElseIf rbQ3Never.Checked = True Then
                Answers(2, 4) = Answers(2, 4) + 1
            End If
            If rbQ4Always.Checked = True Then
                Answers(3, 0) = Answers(3, 0) + 1
            ElseIf rbQ4Usually.Checked = True Then
                Answers(3, 1) = Answers(3, 1) + 1
            ElseIf rbQ4Sometimes.Checked = True Then
                Answers(3, 2) = Answers(3, 2) + 1
            ElseIf rbQ4Seldom.Checked = True Then
                Answers(3, 3) = Answers(3, 3) + 1
            ElseIf rbQ4Never.Checked = True Then
                Answers(3, 4) = Answers(3, 4) + 1
            End If
            If rbQ5Always.Checked = True Then
                Answers(4, 0) = Answers(4, 0) + 1
            ElseIf rbQ5Usually.Checked = True Then
                Answers(4, 1) = Answers(4, 1) + 1
            ElseIf rbQ5Sometimes.Checked = True Then
                Answers(4, 2) = Answers(4, 2) + 1
            ElseIf rbQ5Seldom.Checked = True Then
                Answers(4, 3) = Answers(4, 3) + 1
            ElseIf rbQ5Never.Checked = True Then
                Answers(4, 4) = Answers(4, 4) + 1
            End If
            If rbQ6Always.Checked = True Then
                Answers(5, 0) = Answers(5, 0) + 1
            ElseIf rbQ6Usually.Checked = True Then
                Answers(5, 1) = Answers(5, 1) + 1
            ElseIf rbQ6Sometimes.Checked = True Then
                Answers(5, 2) = Answers(5, 2) + 1
            ElseIf rbQ6Seldom.Checked = True Then
                Answers(5, 3) = Answers(5, 3) + 1
            ElseIf rbQ6Never.Checked = True Then
                Answers(5, 4) = Answers(5, 4) + 1
            End If
            If rbQ7Always.Checked = True Then
                Answers(6, 0) = Answers(6, 0) + 1
            ElseIf rbQ7Usually.Checked = True Then
                Answers(6, 1) = Answers(6, 1) + 1
            ElseIf rbQ7Sometimes.Checked = True Then
                Answers(6, 2) = Answers(6, 2) + 1
            ElseIf rbQ7Seldom.Checked = True Then
                Answers(6, 3) = Answers(6, 3) + 1
            ElseIf rbQ7Never.Checked = True Then
                Answers(6, 4) = Answers(6, 4) + 1
            End If
            If rbQ8Always.Checked = True Then
                Answers(7, 0) = Answers(7, 0) + 1
            ElseIf rbQ8Usually.Checked = True Then
                Answers(7, 1) = Answers(7, 1) + 1
            ElseIf rbQ8Sometimes.Checked = True Then
                Answers(7, 2) = Answers(7, 2) + 1
            ElseIf rbQ8Seldom.Checked = True Then
                Answers(7, 3) = Answers(7, 3) + 1
            ElseIf rbQ8Never.Checked = True Then
                Answers(7, 4) = Answers(7, 4) + 1
            End If
            If rbQ9Always.Checked = True Then
                Answers(8, 0) = Answers(8, 0) + 1
            ElseIf rbQ9Usually.Checked = True Then
                Answers(8, 1) = Answers(8, 1) + 1
            ElseIf rbQ9Sometimes.Checked = True Then
                Answers(8, 2) = Answers(8, 2) + 1
            ElseIf rbQ9Seldom.Checked = True Then
                Answers(8, 3) = Answers(8, 3) + 1
            ElseIf rbQ9Never.Checked = True Then
                Answers(8, 4) = Answers(8, 4) + 1
            End If
            If rbQ10Always.Checked = True Then
                Answers(9, 0) = Answers(9, 0) + 1
            ElseIf rbQ10Usually.Checked = True Then
                Answers(9, 1) = Answers(9, 1) + 1
            ElseIf rbQ10Sometimes.Checked = True Then
                Answers(9, 2) = Answers(9, 2) + 1
            ElseIf rbQ10Seldom.Checked = True Then
                Answers(9, 3) = Answers(9, 3) + 1
            ElseIf rbQ10Never.Checked = True Then
                Answers(9, 4) = Answers(9, 4) + 1
            End If
        End If
        rbQ1Always.Checked = False
        rbQ1Usually.Checked = False
        rbQ1Sometimes.Checked = False
        rbQ1Seldom.Checked = False
        rbQ1Never.Checked = False
        rbQ2Always.Checked = False
        rbQ2Usually.Checked = False
        rbQ2Sometimes.Checked = False
        rbQ2Seldom.Checked = False
        rbQ2Never.Checked = False
        rbQ3Always.Checked = False
        rbQ3Usually.Checked = False
        rbQ3Sometimes.Checked = False
        rbQ3Seldom.Checked = False
        rbQ3Never.Checked = False
        rbQ4Always.Checked = False
        rbQ4Usually.Checked = False
        rbQ4Sometimes.Checked = False
        rbQ4Seldom.Checked = False
        rbQ4Never.Checked = False
        rbQ5Always.Checked = False
        rbQ5Usually.Checked = False
        rbQ5Sometimes.Checked = False
        rbQ5Seldom.Checked = False
        rbQ5Never.Checked = False
        rbQ6Always.Checked = False
        rbQ6Usually.Checked = False
        rbQ6Sometimes.Checked = False
        rbQ6Seldom.Checked = False
        rbQ6Never.Checked = False
        rbQ7Always.Checked = False
        rbQ7Usually.Checked = False
        rbQ7Sometimes.Checked = False
        rbQ7Seldom.Checked = False
        rbQ7Never.Checked = False
        rbQ8Always.Checked = False
        rbQ8Usually.Checked = False
        rbQ8Sometimes.Checked = False
        rbQ8Seldom.Checked = False
        rbQ8Never.Checked = False
        rbQ9Always.Checked = False
        rbQ9Usually.Checked = False
        rbQ9Sometimes.Checked = False
        rbQ9Seldom.Checked = False
        rbQ9Never.Checked = False
        rbQ10Always.Checked = False
        rbQ10Usually.Checked = False
        rbQ10Sometimes.Checked = False
        rbQ10Seldom.Checked = False
        rbQ10Never.Checked = False
    End Sub
    Private Sub PrintSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintSummaryToolStripMenuItem.Click
        'displays print preview dialog, validates that there is information to send to printer.
        If Answers(0, 0) = 0 And Answers(0, 1) = 0 And Answers(0, 2) = 0 And Answers(0, 3) = 0 And Answers(0, 4) = 0 Then
            MessageBox.Show("No surveys have been completed, please complete at least one survey to display summary.", "Input Error", MessageBoxButtons.OK)
        Else
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'designates information on print document 1 to send to the printer, uses for next loop to print all the items in the array.
        Dim AlwaysHLocation As Single = e.MarginBounds.Left + 200
        Dim UsuallyHLocation As Single = e.MarginBounds.Left + 300
        Dim SometimesHLocation As Single = e.MarginBounds.Left + 400
        Dim SeldomHLocation As Single = e.MarginBounds.Left + 500
        Dim NeverHLocation As Single = e.MarginBounds.Left + 600
        Dim intCount As Integer = 1
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        e.Graphics.DrawString("Always", PrintFont, Brushes.Black, AlwaysHLocation, VerticalPrintLocationSingle)
        e.Graphics.DrawString("Usually", PrintFont, Brushes.Black, UsuallyHLocation, VerticalPrintLocationSingle)
        e.Graphics.DrawString("Sometimes", PrintFont, Brushes.Black, SometimesHLocation, VerticalPrintLocationSingle)
        e.Graphics.DrawString("Seldom", PrintFont, Brushes.Black, SeldomHLocation, VerticalPrintLocationSingle)
        e.Graphics.DrawString("Never", PrintFont, Brushes.Black, NeverHLocation, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        For i As Integer = 0 To 9
            e.Graphics.DrawString("Question " & intCount.ToString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                                  VerticalPrintLocationSingle)
            e.Graphics.DrawString(Answers(i, 0).ToString, PrintFont, Brushes.Black, AlwaysHLocation, VerticalPrintLocationSingle)
            e.Graphics.DrawString(Answers(i, 1).ToString, PrintFont, Brushes.Black, UsuallyHLocation, VerticalPrintLocationSingle)
            e.Graphics.DrawString(Answers(i, 2).ToString, PrintFont, Brushes.Black, SometimesHLocation, VerticalPrintLocationSingle)
            e.Graphics.DrawString(Answers(i, 3).ToString, PrintFont, Brushes.Black, SeldomHLocation, VerticalPrintLocationSingle)
            e.Graphics.DrawString(Answers(i, 4).ToString, PrintFont, Brushes.Black, NeverHLocation, VerticalPrintLocationSingle)
            intCount += 1
            VerticalPrintLocationSingle += LineHeightSingle
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the application
        Application.Exit()
    End Sub
End Class
