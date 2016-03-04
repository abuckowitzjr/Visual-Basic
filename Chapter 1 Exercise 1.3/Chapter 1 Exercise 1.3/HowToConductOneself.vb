' Project:      How to Conduct Oneself
' Programmer:   Arthur Buckowitz
' Date:         May 18, 2012
' Description:  Features four buttons covering ways someone should 
'               conduct themselves in how they live, sing, dance, and laugh, 
'               a button to print the form, and an exit button to close the program.
Public Class HowToConductForm

    Private Sub LiveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiveButton.Click
        ' Display a message on how to live.

        MessageLabel.Text = "Live like there is no tomorrow"
    End Sub

    Private Sub SingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SingButton.Click
        ' Display a message on how to sing.

        MessageLabel.Text = "Sing as if no one can hear"
    End Sub

    Private Sub DanceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DanceButton.Click
        ' Display a message on how to dance.

        MessageLabel.Text = "Dance as if nobody is watching"
    End Sub

    Private Sub LaughButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaughButton.Click
        ' Display a message on how to laugh.

        MessageLabel.Text = "Laugh like no one is listening"
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
