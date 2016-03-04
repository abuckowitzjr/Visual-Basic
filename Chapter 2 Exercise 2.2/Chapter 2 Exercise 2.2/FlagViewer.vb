' Project:      Flag Viewer
' Programmer:   Arthur Buckowitz
' Date:         May 22, 2012
' Description:  Each radio button displays cooresponding flag image and country name, 
'               user may select which options are displayed on screen with checkboxes, 
'               print button to print the form, exit button to close the program.

Public Class FlagViewer

    Private Sub USRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USRadioButton.CheckedChanged
        ' Displays USA Flag and country name in message.

        USFlagPictureBox.Visible = True
        JapanPictureBox.Visible = False
        CanadaPictureBox.Visible = False
        MexicoPictureBox.Visible = False
        FlagMessageLabel.Text = "United States"
    End Sub

    Private Sub JapanRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JapanRadioButton.CheckedChanged
        ' Displays Japan flag and country name in message.

        JapanPictureBox.Visible = True
        CanadaPictureBox.Visible = False
        MexicoPictureBox.Visible = False
        USFlagPictureBox.Visible = False
        FlagMessageLabel.Text = "Japan"
    End Sub

    Private Sub CanadaRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanadaRadioButton.CheckedChanged
        ' Displays Canada flag and country name in message.

        CanadaPictureBox.Visible = True
        JapanPictureBox.Visible = False
        USFlagPictureBox.Visible = False
        MexicoPictureBox.Visible = False
        FlagMessageLabel.Text = "Canada"
    End Sub

    Private Sub MexicoRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MexicoRadioButton.CheckedChanged
        ' Displays Mexico flag and country name in message.

        MexicoPictureBox.Visible = True
        USFlagPictureBox.Visible = False
        JapanPictureBox.Visible = False
        CanadaPictureBox.Visible = False
        FlagMessageLabel.Text = "Mexico"
    End Sub

    Private Sub TitleCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleCheckBox.CheckedChanged
        ' Displays title if checked, if unchecked, hides title.
        TitleLabel.Visible = TitleCheckBox.Checked
    End Sub

    Private Sub CountryNameCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountryNameCheckBox.CheckedChanged
        ' Displays Country name if checked, if unchecked, hides country name.

        FlagMessageLabel.Visible = CountryNameCheckBox.Checked
    End Sub

    Private Sub ProgrammerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgrammerCheckBox.CheckedChanged
        ' Displays programmer info if checked, if unchecked, hides programmer message.

        ProgrammerLabel.Visible = ProgrammerCheckBox.Checked
    End Sub


    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Prints the form.
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' closes the program.

        Me.Close()
    End Sub
End Class
