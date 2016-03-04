' Project:      Mailing Label
' Programmer:   Arthur Buckowitz
' Date:         May 23, 2012
' Description:  Allows user to create mailing labels based on input data, 
'               customer completes required fields, hits accept to generate mailing label, 
'               clear button allows user to clear all fields, and exit button closes program.

Public Class MailLabel

    Private Sub AcceptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcceptButton.Click
        ' Displays full name of user input and full address of user input on 3 seperate labels.

        OutputNameLabel.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text
        OutputAddressLabel.Text = AddressTextBox.Text
        OutputCityStateZipLabel.Text = CityTextBox.Text & ", " & StateTextBox.Text & ", " & ZipMaskedTextBox.Text
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ' Clears all fields of the form.

        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipMaskedTextBox.Text = ""
        OutputAddressLabel.Text = ""
        OutputCityStateZipLabel.Text = ""
        OutputNameLabel.Text = ""
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Closes the program.

        Me.Close()
    End Sub
End Class
