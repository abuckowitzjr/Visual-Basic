Imports System.IO.File
Imports System.IO

Public Class Form1
    Dim currentLine As Integer = 1
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            txtFileName.Text = OpenFileDialog1.FileName
            ReadData()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim strMake As String = txtMake.Text
        Dim strModel As String = txtModel.Text
        Dim strYear As String = txtYear.Text
        Dim strLine As String = strMake & "|" & strModel & "|" & strYear & Environment.NewLine
        Try
            My.Computer.FileSystem.WriteAllText(txtFileName.Text, strLine, True)
        Catch ex As Exception
            MsgBox("Error writing")
        End Try

    End Sub
    Private Function ReadData() As Boolean
        Dim eof As Boolean = True
        Try
            Dim streamRead As StreamReader = OpenText(txtFileName.Text)
            Dim strLine As String = ""
            Dim i As Integer = 1
            While Not streamRead.EndOfStream
                strLine = streamRead.ReadLine()
                If i = currentLine Then
                    eof = False
                    Exit While
                End If
                i += 1
            End While
            streamRead.Close()
            Display(strLine)
        Catch ex As Exception
            MsgBox("Error reading")
        End Try
        Return eof
    End Function
    Private Sub Display(ByVal line As String)
        Try
            Dim fields() As String = line.Split(CChar("|"))
            lblMake.Text = fields(0)
            lblModel.Text = fields(1)
            lblYear.Text = fields(2)
        Catch ex As Exception
            MsgBox("Invalid data")
        End Try
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        currentLine += 1
        If ReadData() = True Then
            currentLine -= 1
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        If currentLine > 1 Then
            currentLine -= 1
            ReadData()
        End If
    End Sub
End Class
