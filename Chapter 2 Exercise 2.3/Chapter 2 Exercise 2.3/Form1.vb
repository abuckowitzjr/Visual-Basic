' Project:      Weather Report
' Programmer:   Arthur Buckowitz
' Date:         May 22, 2012
' Description:  Displays cooresponding weather icon and message for each radio button selected, 
'               displays users entered name from upper text box in message, has print button to print the form, 
'               and an exit button to close the program.

Public Class Form1

    Private Sub SunnyRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SunnyRadioButton.CheckedChanged
        ' Displays sun icon and message about a sunny day, username included.

        MessageLabel.Text = "It looks like a sunny day today, " & NameTextBox.Text
        SunPictureBox.Visible = True
        SnowPictureBox.Visible = False
        RainPictureBox.Visible = False
        CloudPictureBox.Visible = False
    End Sub

    Private Sub SnowyRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SnowyRadioButton.CheckedChanged
        ' Displays snow icon and message about a snowy day, username included.

        MessageLabel.Text = "It looks like a snowy day today, " & NameTextBox.Text
        SnowPictureBox.Visible = True
        RainPictureBox.Visible = False
        CloudPictureBox.Visible = False
        SunPictureBox.Visible = False
    End Sub

    Private Sub RainyRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RainyRadioButton.CheckedChanged
        ' Displays rain icon and message about a rainy day, username included.

        MessageLabel.Text = "It looks like a rainy day today, " & NameTextBox.Text
        SnowPictureBox.Visible = False
        RainPictureBox.Visible = True
        CloudPictureBox.Visible = False
        SunPictureBox.Visible = False
    End Sub

    Private Sub CloudyRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudyRadioButton.CheckedChanged
        ' Displays cloud icon and message about a cloudy day, username included.

        MessageLabel.Text = "It looks like a cloudy day today, " & NameTextBox.Text
        SnowPictureBox.Visible = False
        RainPictureBox.Visible = False
        CloudPictureBox.Visible = True
        SunPictureBox.Visible = False
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Prints the form.

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Exits the program.

        Me.Close()
    End Sub
End Class
