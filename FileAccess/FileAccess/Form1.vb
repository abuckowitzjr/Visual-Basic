'NEXT
Imports Microsoft.VisualBasic.FileIO
'SAVE
Public Class Form1
    Private strFileName As String = "Student.txt"
    '~~~~~~
    Private strAllLines() As String
    Private intLineNum As Integer = 0
    'NEXT
    Private tfp As New TextFieldParser(strFileName)
    '~~~~~~
    'SAVE
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim strData As String
        strData = txtID.Text & "|" & txtFName.Text & "|" & txtLName.Text & "|" & txtPhone.Text & Environment.NewLine
        My.Computer.FileSystem.WriteAllText(strFileName, strData, True)
        txtID.Text = ""
        txtFName.Text = ""
        txtLName.Text = ""
        txtPhone.Text = ""
        txtID.Focus()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'txtContent.Text = My.Computer.FileSystem.ReadAllText(strFileName)
        txtContent.Text = System.IO.File.ReadAllText(strFileName)
        '~~~~~~
        'NEXT
        tfp.TextFieldType = FieldType.Delimited
        tfp.SetDelimiters("|")
        btnNext_Click(sender, e)
        '~~~~~~
        strAllLines = System.IO.File.ReadAllLines(strFileName)
        Display()
    End Sub
    'For Next Click
    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        'If Not tfp.EndOfData Then
        'Dim strFields() As String = tfp.ReadFields
        'txtID.Text = strFields(0)
        'txtFName.Text = strFields(1)
        'txtLName.Text = strFields(2)
        'txtPhone.Text = strFields(3)
        'End If

        'Display(Integer.Parse(txtID.Text))
        If intLineNum < strAllLines.Length - 1 Then
            intLineNum += 1
            Display()
        End If
    End Sub
    '~~~~~~
    Private Sub Display()  '(Optional ByVal Index As Integer = 0)
        If intLineNum < strAllLines.Length And intLineNum >= 0 Then
            Dim line As String = strAllLines(intLineNum)
            Dim fields() As String = line.Split(CChar("|"))
            txtID.Text = fields(0)
            txtFName.Text = fields(1)
            txtLName.Text = fields(2)
            txtPhone.Text = fields(3)
        End If


    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        If intLineNum > 0 Then
            intLineNum -= 1
            Display()
        End If
    End Sub
End Class
