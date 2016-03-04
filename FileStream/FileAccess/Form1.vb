'NEXT
Imports System.IO
'SAVE
Public Class Form1
    Private strFileName As String = "Student.txt"
    Private strLines() As String
    Private intLine As Integer = 0 'Marker in the file
    Private intMaxLineNum As Integer = 0
    'Private StudentReader As New StreamReader(strFileName)
    '~~~~~~
    'Private strAllLines() As String
    'Private intLineNum As Integer = 0
    'NEXT
    'Private tfp As New TextFieldParser(strFileName)
    '~~~~~~
    'SAVE
    'Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
    '    Dim strData As String
    '    strData = txtID.Text & "|" & txtFName.Text & "|" & txtLName.Text & "|" & txtPhone.Text & Environment.NewLine
    '    My.Computer.FileSystem.WriteAllText(strFileName, strData, True)
    '    txtID.Text = ""
    '    txtFName.Text = ""
    '    txtLName.Text = ""
    '    txtPhone.Text = ""
    '    txtID.Focus()
    'End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'read first five lines into an array
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            strFileName = OpenFileDialog1.FileName
            JohnnyFive()
            Display()
        End If

        'split the field values for the first line

        'display
    End Sub
    Private Sub JohnnyFive()
        strLines = Nothing
        Dim StudentReader As New StreamReader(strFileName)
        Dim i As Integer = 0
        Dim j As Integer = 0
        While Not StudentReader.EndOfStream
            Dim line As String = StudentReader.ReadLine()
            If i >= intLine And j < 5 Then
                If strLines Is Nothing Then
                    ReDim strLines(0)
                   Else
                    ReDim Preserve strLines(strLines.Length)
                End If
                strLines(strLines.Length - 1) = line
                j += 1
            End If
            i += 1
        End While
        intMaxLineNum = i
        StudentReader.Close()
    End Sub
    Private Sub Display()
        If intLine <= intMaxLineNum Then
            Dim line As String = strLines(intLine Mod 5)
            Dim fields() As String = line.Split(CChar("|"))
            txtID.Text = fields(0)
            txtFName.Text = fields(1)
            txtLName.Text = fields(2)
            txtPhone.Text = fields(3)
        End If
    End Sub
    'For Next Click
    'Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
    '    Display()
    'End Sub
    '    'If Not tfp.EndOfData Then
    '    'Dim strFields() As String = tfp.ReadFields
    '    'txtID.Text = strFields(0)
    '    'txtFName.Text = strFields(1)
    '    'txtLName.Text = strFields(2)
    '    'txtPhone.Text = strFields(3)
    '    'End If

    '    'Display(Integer.Parse(txtID.Text))
    '    If intLineNum < strAllLines.Length - 1 Then
    '        intLineNum += 1
    '        Display()
    '    End If
    'End Sub
    '~~~~~~
    'Private Sub Display()
    '    If Not StudentReader.EndOfStream Then
    '        Dim line As String = StudentReader.ReadLine()
    '        Dim fields() As String = line.Split(CChar("|"))
    '        txtID.Text = fields(0)
    '        txtFName.Text = fields(1)
    '        txtLName.Text = fields(2)
    '        txtPhone.Text = fields(3)
    '    End If
    'End Sub

    'Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
    '    If intLineNum > 0 Then
    '        intLineNum -= 1
    '        Display()
    '    End If
    'End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        If intLine < intMaxLineNum Then
            If intLine Mod 5 = 4 Then
                JohnnyFive()
            End If
            intLine += 1
            Display()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        If intLine > 0 Then
            If intLine Mod 5 = 0 Then
                intLine -= 5
                JohnnyFive()
                intLine += 5
            End If
            intLine -= 1
            Display()
        End If
    End Sub
End Class
