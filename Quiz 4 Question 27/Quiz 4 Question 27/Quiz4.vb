'Project:       Quiz 4 Question 27
'Programmer:    Arthur Buckowitz
'Date:          July 5, 2012
'Description:   Allows the user to add pictures into the program with the open file dialog box, and remove selected picture from the program,
'               the size mode of the picture can be changed with 3 radio buttons.

Public Class Quiz4
    Dim Check As Boolean = False
    Dim PictureInfo(0) As Picture
    Dim OpenFileResult As String
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        'adds selected file to the program, storing it in an array. Displays the picture of the file in the picture box.  Also calls on the
        'check for duplicate sub to verify the file was not already stored.
        OpenFileDialog1.ShowDialog()
        OpenFileResult = OpenFileDialog1.FileName
        If lstboxPictureFiles.Items.Count = 0 Then
            lstboxPictureFiles.Items.Add(OpenFileResult)
            pbPicture.ImageLocation = OpenFileResult
            pbPicture.Show()
            ArrayEntry()
        Else
            CheckForDuplicate()
            If Check = False Then
                lstboxPictureFiles.Items.Add(OpenFileResult)
                pbPicture.ImageLocation = OpenFileResult
                pbPicture.Show()
                ArrayEntry()
            End If
            Check = False
        End If
    End Sub
    Private Sub CheckForDuplicate()
        'checks to ensure the selected file being added is not already loaded into the program.
        For i As Integer = 0 To lstboxPictureFiles.Items.Count - 1
            If OpenFileResult = lstboxPictureFiles.Items(i).ToString Then
                MessageBox.Show("File is already stored.", "Input Error", MessageBoxButtons.OK)
                Check = True
            End If
        Next
    End Sub

    Private Sub rbStretch_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbStretch.CheckedChanged
        'changes sizemode of picture to stretch
        pbPicture.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub rbZoom_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbZoom.CheckedChanged
        'changes sizemode of picture to zoom
        pbPicture.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub rbNormal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNormal.CheckedChanged
        'changes sizemode of picture to normal
        pbPicture.SizeMode = PictureBoxSizeMode.Normal
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        'removes selected item from the list, clears the description, removes the picture, and clears the memory of the array for that
        'particular item.
        If lstboxPictureFiles.SelectedItem Is Nothing Then
            MessageBox.Show("Please select the file you wish to remove.", "Input Error", MessageBoxButtons.OK)
        Else
            For i As Integer = 0 To PictureInfo.Length - 1
                If PictureInfo(i).File = lstboxPictureFiles.SelectedItem.ToString Then
                    PictureInfo(i).File = ""
                    PictureInfo(i).Description = ""
                End If
            Next
            lstboxPictureFiles.Items.Remove(lstboxPictureFiles.SelectedItem)
            pbPicture.Image = Nothing
            txtDescription.Text = ""
        End If
    End Sub

    Private Sub lstboxPictureFiles_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstboxPictureFiles.SelectedIndexChanged
        'displays correct picture and description associated with the item selected.
        Try
            txtDescription.Focus()
            DescriptionStorage()
            pbPicture.ImageLocation = lstboxPictureFiles.SelectedItem.ToString
            For i As Integer = 0 To PictureInfo.Length - 1
                If pbPicture.ImageLocation = PictureInfo(i).File Then
                    txtDescription.Text = PictureInfo(i).Description
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Structure Picture
        Dim File As String
        Dim Description As String
    End Structure
    Private Sub ArrayEntry()
        'stores file information in the array
        Try
            PictureInfo(PictureInfo.Length - 1).File = OpenFileResult
            ReDim Preserve PictureInfo(PictureInfo.Length)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DescriptionStorage()
        'stores description information in the array
        Try
            For i As Integer = 0 To PictureInfo.Length - 1
                If pbPicture.ImageLocation = PictureInfo(i).File Then
                    PictureInfo(i).Description = txtDescription.Text
                    Exit For
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class
