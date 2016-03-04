' Project:      Bucky's Bonanza
' Programmer:   Arthur Buckowitz
' Date:         May 18, 2012
' Description:  Features daily specials of Bucky's Bonanza diner, 
'               each button displays different specials, has a print button to 
'               print the form, and an exit button to close program.

Public Class BuckysBonanza

    Private Sub SoupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoupButton.Click
        ' Displays the Soup of the Day special.

        SpecialsLabel.Text = "Brocolli and Cheddar Soup"
    End Sub

    Private Sub ChefButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChefButton.Click
        ' Displays the Chef's Special special.

        SpecialsLabel.Text = "Chicken Primavera"
    End Sub

    Private Sub FishButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FishButton.Click
        ' Displays the Daily Fish Special.

        SpecialsLabel.Text = "Wood Grilled Smoked Salmon"
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Prints the form.

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Closes the program.

        Me.Close()

    End Sub
End Class
