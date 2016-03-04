' Project:      Elementary VB Quiz1
' Programmer:   Arthur Buckowitz
' Date:         May 23, 2012
' Description:  Form advances to the next screen when Next button is clicked, 
'               previous return to previous screen, both screens have two seperate questions, 
'               when the user selects option 2, the light bulb turns on, there is a print button to print the form, 
'               and an exit button to close the program.

Public Class QuizForm

    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click

        ' Advances form to the second question, changes question number and question message, 
        ' changes radio button messages, enables previous and disables next button for second question, 
        ' clears previous answer from radio buttons, resets light bulb image to bulb off.

        QuestionNumberLabel.Text = "Question 2"
        QuestionLabel.Text = "Which of the following event runs when a windows application starts?"
        Answer1RadioButton.Text = "Button click Event"
        Answer2RadioButton.Text = "Form Load Event"
        Answer3RadioButton.Text = "Radio Button Checked Event"
        Answer4RadioButton.Text = "Check Box Checked Event"
        PreviousButton.Enabled = True
        NextButton.Enabled = False
        Answer1RadioButton.Checked = False
        Answer2RadioButton.Checked = False
        Answer3RadioButton.Checked = False
        Answer4RadioButton.Checked = False
        LightBulbOnPictureBox.Visible = False
        LightBulbOffPictureBox.Visible = True
    End Sub

    ' Moves back to the first question, changes question number and question message, 
    ' changes radio button messages, enables next and disables previous button for first question, 
    ' clears previous answer from radio buttons, resets light bulb image to bulb off.

    Private Sub PreviousButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PreviousButton.Click
        QuestionNumberLabel.Text = "Question 1"
        QuestionLabel.Text = "Which of the following controls would be best for multiple choice questions?"
        Answer1RadioButton.Text = "Check Boxes"
        Answer2RadioButton.Text = "Radio Buttons"
        Answer3RadioButton.Text = "List Box"
        Answer4RadioButton.Text = "Text Boxes"
        PreviousButton.Enabled = False
        NextButton.Enabled = True
        Answer1RadioButton.Checked = False
        Answer2RadioButton.Checked = False
        Answer3RadioButton.Checked = False
        Answer4RadioButton.Checked = False
        LightBulbOnPictureBox.Visible = False
        LightBulbOffPictureBox.Visible = True
    End Sub

    ' Activates print preview for form.

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    ' Closes the program.

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    ' Makes light on picture visible when selected.

    Private Sub Answer2RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Answer2RadioButton.CheckedChanged
        LightBulbOnPictureBox.Visible = True
        LightBulbOffPictureBox.Visible = False
    End Sub

    ' Makes light off picture visible when selected.

    Private Sub Answer1RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Answer1RadioButton.CheckedChanged
        LightBulbOnPictureBox.Visible = False
        LightBulbOffPictureBox.Visible = True
    End Sub

    ' Makes light off picture visible when selected.

    Private Sub Answer3RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Answer3RadioButton.CheckedChanged
        LightBulbOnPictureBox.Visible = False
        LightBulbOffPictureBox.Visible = True
    End Sub

    ' Makes light off picture visible when selected.

    Private Sub Answer4RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Answer4RadioButton.CheckedChanged
        LightBulbOnPictureBox.Visible = False
        LightBulbOffPictureBox.Visible = True
    End Sub
End Class
