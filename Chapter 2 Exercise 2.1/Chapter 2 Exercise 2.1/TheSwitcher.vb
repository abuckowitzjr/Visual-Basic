' Project:      The Switcher
' Programmer:   Arthur Buckowitz
' Date:         May 21, 2012
' Description:  Allows user name entry, displayed in message below light bulb picture, 
'               message has designated color in reference to radio button selection, 
'               light bulb picture turns on and off when clicked, has print button to print the form, 
'               and exit button to close program.

Public Class TheSwitcher

    Private Sub LightOffPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LightOffPictureBox.Click
        ' Changes visibility of LightOff picture to invisible

        LightOffPictureBox.Visible = False
        LightOnPictureBox.Visible = True
        OperationLabel.Text = "Turn the light off " & NameTextBox.Text
    End Sub

    Private Sub LightOnPictureBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LightOnPictureBox.Click
        ' Changes visibility of LightOn picture to invisible

        LightOnPictureBox.Visible = False
        LightOffPictureBox.Visible = True
        OperationLabel.Text = "Turn the light on " & NameTextBox.Text
    End Sub

    Private Sub BlackRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BlackRadioButton.CheckedChanged
        ' Changes Operation message color to black.

        OperationLabel.ForeColor = Color.Black
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BlueRadioButton.CheckedChanged
        ' Changes Operation message to blue.

        OperationLabel.ForeColor = Color.Blue
    End Sub

    Private Sub GreenRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GreenRadioButton.CheckedChanged
        ' Changes Operation message to green.

        OperationLabel.ForeColor = Color.Green
    End Sub

    Private Sub RedRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RedRadioButton.CheckedChanged
        ' Changes Operation message to red.

        OperationLabel.ForeColor = Color.Red
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
