'Project:       Quiz 3
'Programmer:    Arthur Buckowitz
'Date:          June 26, 2012
'Description:   Allows the user to hire a new person with input and clicking hire button, fire current employees, moving their name 
'               to the past employees list, or re-hire past employess, moving their name to the current employee list, about menu 
'               item displays progrma info, exit menu item exits the program.

Public Class frmQuiz3

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the program.
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'displays the about item.
        AboutBox1.Show()
    End Sub

    Private Sub btnHire_Click(sender As System.Object, e As System.EventArgs) Handles btnHire.Click
        'validates user input is present in new person textbox, adds entered text into the current employee list, update total current 
        'employee label.
        If txtNewPerson.Text = "" Then
            MessageBox.Show("Please enter name of person to hire.", "Input Error", MessageBoxButtons.OK)
            txtNewPerson.Text = ""
            txtNewPerson.Focus()
        Else
            lstboxCurrentEmployees.Items.Add(StrConv(txtNewPerson.Text, VbStrConv.ProperCase))
            txtNewPerson.Text = ""
            txtNewPerson.Focus()
            lblTotalCurrentEmployees.Text = lstboxCurrentEmployees.Items.Count & " Employees"
        End If
    End Sub

    Private Sub btnFire_Click(sender As System.Object, e As System.EventArgs) Handles btnFire.Click
        'validates selected name in current employee listbox, moves name to past employee list, update labels for list totals.
        If lstboxCurrentEmployees.SelectedItem Is Nothing Then
            MessageBox.Show("Please select employee to be fired.", "Input Error", MessageBoxButtons.OK)
            lstboxCurrentEmployees.Focus()
        Else
            lstboxPastEmployees.Items.Add(lstboxCurrentEmployees.SelectedItem)
            lstboxCurrentEmployees.Items.Remove(lstboxCurrentEmployees.SelectedItem)
            lblTotalCurrentEmployees.Text = lstboxCurrentEmployees.Items.Count & " Employees"
            lblTotalPastEmployees.Text = lstboxPastEmployees.Items.Count & " People"
        End If
    End Sub

    Private Sub btnReHire_Click(sender As System.Object, e As System.EventArgs) Handles btnReHire.Click
        'validates selected name in past employee listbox, moves name to current employee list, update labels for list totals.
        If lstboxPastEmployees.SelectedItem Is Nothing Then
            MessageBox.Show("Please select person to re-hire.", "Input Error", MessageBoxButtons.OK)
            lstboxPastEmployees.Focus()
        Else
            lstboxCurrentEmployees.Items.Add(lstboxPastEmployees.SelectedItem)
            lstboxPastEmployees.Items.Remove(lstboxPastEmployees.SelectedItem)
            lblTotalCurrentEmployees.Text = lstboxCurrentEmployees.Items.Count & " Employees"
            lblTotalPastEmployees.Text = lstboxPastEmployees.Items.Count & " People"
        End If
    End Sub

    Private Sub frmQuiz3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'displays total for lists in label when form loads.
        lblTotalCurrentEmployees.Text = lstboxCurrentEmployees.Items.Count & " Employees"
        lblTotalPastEmployees.Text = lstboxPastEmployees.Items.Count & " People"
    End Sub

    Private Sub txtNewPerson_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNewPerson.TextChanged
        'validates user input in new person textbox.
        If IsNumeric(txtNewPerson.Text) Then
            MessageBox.Show("Numbers cannot be entered for New Person.", "Input Error", MessageBoxButtons.OK)
        End If
    End Sub
End Class
