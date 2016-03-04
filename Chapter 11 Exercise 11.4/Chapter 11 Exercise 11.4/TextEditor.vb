'Project:       Text Editor
'Programmer:    Arthur Buckowitz
'Date:          July 28, 2012
'Description:   Loads contents of selected file into the content textbox, allows the user to update the displayed text, and save updated info
'               back to the file.

Imports System.IO
Imports System.IO.File
Public Class frmTextEditor
    Private Sub SelectCreateFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectCreateFileToolStripMenuItem.Click
        'Displays the information in the selected file via Readdata sub. Stores filename in hidden label.
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            lblHidden.Text = OpenFileDialog1.FileName
            ReadData()
        End If
    End Sub
    Private Sub ReadData()
        'Displays the contents of the selected file into the content textbox.
        Try
            txtContents.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub WriteData()
        'Writes updated text entered to the selected file.
        Try
            My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, txtContents.Text, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'Allows user to call on the writedata sub by clicking the save menu item.
        If lblHidden.Text = "" Then
            MsgBox("Please select file you wish to write to.")
        Else
            WriteData()
        End If

    End Sub
End Class
