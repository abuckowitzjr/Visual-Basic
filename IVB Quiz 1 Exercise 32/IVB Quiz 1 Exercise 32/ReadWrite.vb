'Project:       Quiz 1 Exercise 32
'Programmer:    Arthur Buckowitz
'Date:          July 28, 2012
'Description:   Loads text from text file into textbox, allows user to input text and add the text to the file, 
'               displaying it in the content textbox.

Public Class frmReadWrite

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        'allows user to select the file to open, calls on the readtext sub to display info on the file.
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                txtFileName.Text = OpenFileDialog1.FileName
                btnAppend.Enabled = True
                ReadText()
            End If
        Catch ex As Exception
            MsgBox("Error Opening")
        End Try
    End Sub

    Private Sub ReadText()
        'Loads info in the file into the content textbox.
        Try
            txtContent.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        Catch ex As Exception
            MsgBox("Error Reading")
        End Try
    End Sub

    Private Sub btnAppend_Click(sender As System.Object, e As System.EventArgs) Handles btnAppend.Click
        'Writes the user input into the file, redisplys the new info in the textbox.
        Try
            My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, txtInputText.Text & Environment.NewLine, True)
        Catch ex As Exception
            MsgBox("Error Writing")
        End Try
        ReadText()
    End Sub
End Class
