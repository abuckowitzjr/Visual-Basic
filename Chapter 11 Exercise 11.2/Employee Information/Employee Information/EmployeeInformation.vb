Imports System.IO.File
Public Class frmEmployeeInformation

    Private Sub btnSelectFile_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectFile.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtFileName.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            txtFileName.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim strFirstName As String = txtFirstName.Text
        Dim strLastName As String = txtLastName.Text
        Dim strEmployeeNumber As String = txtEmpNumber.Text
        Dim strHourlyPayRate As String = txtHourlyRate.Text
        Dim strLine As String = strFirstName & "|" & strLastName & "|" & strEmployeeNumber & "|" & strHourlyPayRate & Environment.NewLine
        Try
            My.Computer.FileSystem.WriteAllText(txtFileName.Text, strLine, True)
        Catch ex As Exception
            MsgBox("Error Writing")
        End Try
    End Sub
End Class
