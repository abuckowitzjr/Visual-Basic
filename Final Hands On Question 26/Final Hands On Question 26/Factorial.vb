'Project:       Final Hands On Question 26
'Programmer:    Arthur Buckowitz
'Date:          July 6, 2012
'Description:   Allows user to enter any numner from 1 to 29, calculate button gives the factorial of the number, and displays the 
'               number on label.

Public Class frmFactorial

    Private Function GetFactorial(num1 As Integer) As Double
        'function for calculating the factorial of number entered by user.
        Dim dblFactorial As Double = 1
        Try
            For i As Integer = 1 To num1
                dblFactorial = dblFactorial * i
            Next
        Catch ex As Exception
        End Try
        Return dblFactorial
    End Function
    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        'validates number entered by user to ensure it falls in the correct number range, calls on the getfactorial function, displays
        'factorial in label.
        If txtNumber.Text = "" Then
            MessageBox.Show("You must enter a valid number, entry cannot be blank", "Input Error", MessageBoxButtons.OK)
        Else
            If Integer.Parse(txtNumber.Text) < 1 Or Integer.Parse(txtNumber.Text) > 29 Then
                MessageBox.Show("Number entered is not in the correct range of numbers, please enter a positive integer smaller than 30.",
                                "Input Error", MessageBoxButtons.OK)
                txtNumber.Text = ""
                txtNumber.Focus()
            Else
                lblDisplay.Text = "Factorial of " & txtNumber.Text & " is " & GetFactorial(Integer.Parse(txtNumber.Text)).ToString("G")
                txtNumber.Focus()
            End If
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumber.TextChanged
        'validates that the information entered in textbox is number and not letter.
        If Not IsNumeric(txtNumber.Text) And txtNumber.Text <> "" Then
            MessageBox.Show("Letters may not be entered for number, please correct.", "Input Error", MessageBoxButtons.OK)
            txtNumber.Text = ""
            txtNumber.Focus()
        End If
    End Sub
End Class
