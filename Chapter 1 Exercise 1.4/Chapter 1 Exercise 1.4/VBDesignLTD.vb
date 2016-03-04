' Project:      VB Design LTD
' Programmer:   Arthur Buckowitz
' Date:         May 18, 2012
' Description:  Provides pertinent info about company, designated buttons display 
'               cooresponding info in labels such as contact person, department, 
'               and telephone number. Has print button to print form and exit button 
'               to close program.

Public Class VBDesignLTD

    Private Sub HeadDesignerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeadDesignerButton.Click
        ' Displays name of Head Designer.

        HeadDesignerLabel.Text = "Arthur Buckowitz"
        DepartmentLabel.Text = ""
        TelephoneLabel.Text = ""
    End Sub

    Private Sub DeptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeptButton.Click
        ' Displays name of the department.

        DepartmentLabel.Text = "Design Department"
        HeadDesignerLabel.Text = ""
        TelephoneLabel.Text = ""
    End Sub

    Private Sub PhoneButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhoneButton.Click
        ' Displays the telephone number.

        TelephoneLabel.Text = "314.987.6543"
        HeadDesignerLabel.Text = ""
        DepartmentLabel.Text = ""
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
