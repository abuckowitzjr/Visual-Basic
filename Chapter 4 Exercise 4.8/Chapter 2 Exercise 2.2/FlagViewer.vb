' Project:      Flag Viewer
' Programmer:   Arthur Buckowitz
' Date:         May 22, 2012
' Description:  Each radio button displays cooresponding flag image and country name, 
'               user may select which options are displayed on screen with checkboxes, 
'               print button to print the form, exit button to close the program.

Public Class FlagViewer

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Prints the form.
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' closes the program.

        Me.Close()
    End Sub

    Private Sub DisplayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayButton.Click
        ' Display button displays proper selected item, title, country name, and programmer are displayed if check boxes checked, specific 
        ' country flag displayed based on which radio button is selected.

        If TitleCheckBox.Checked = True Then
            TitleLabel.Visible = True
        Else
            TitleLabel.Visible = False
        End If

        If CountryNameCheckBox.Checked = True Then
            FlagMessageLabel.Visible = True
        Else
            FlagMessageLabel.Visible = False
        End If
        If ProgrammerCheckBox.Checked = True Then
            ProgrammerLabel.Visible = True
        Else
            ProgrammerLabel.Visible = False
        End If
        If USRadioButton.Checked Then
            USFlagPictureBox.Visible = True
            JapanPictureBox.Visible = False
            CanadaPictureBox.Visible = False
            MexicoPictureBox.Visible = False
            FlagMessageLabel.Text = "United States"
        ElseIf JapanRadioButton.Checked Then
            JapanPictureBox.Visible = True
            CanadaPictureBox.Visible = False
            MexicoPictureBox.Visible = False
            USFlagPictureBox.Visible = False
            FlagMessageLabel.Text = "Japan"
        ElseIf CanadaRadioButton.Checked Then
            CanadaPictureBox.Visible = True
            JapanPictureBox.Visible = False
            USFlagPictureBox.Visible = False
            MexicoPictureBox.Visible = False
            FlagMessageLabel.Text = "Canada"
        ElseIf MexicoRadioButton.Checked Then
            MexicoPictureBox.Visible = True
            USFlagPictureBox.Visible = False
            JapanPictureBox.Visible = False
            CanadaPictureBox.Visible = False
            FlagMessageLabel.Text = "Mexico"
        Else
            MexicoPictureBox.Visible = False
            USFlagPictureBox.Visible = False
            JapanPictureBox.Visible = False
            CanadaPictureBox.Visible = False
            FlagMessageLabel.Text = ""
        End If
    End Sub
End Class
