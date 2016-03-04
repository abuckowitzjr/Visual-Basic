Imports System
Imports System.Xml
Imports System.Xml.Schema
Imports System.IO
Imports System.Windows.Forms

Public Class XMLForm
    Dim Filename As String

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim XMLWriter As XmlWriter
        Dim Settings As New XmlWriterSettings()
        Settings.Indent = True
        XMLWriter = XMLWriter.Create(txtFile.Text, Settings)
        With XMLWriter
            .WriteStartDocument()
            .WriteComment("Student Data")
            .WriteStartElement("Student")
            .WriteStartElement("StudentID")
            .WriteString(txtID.Text.ToString())
            .WriteEndElement()
            .WriteStartElement("Name")
            .WriteString(txtName.Text.ToString())
            .WriteEndElement()
            .WriteStartElement("CourseCode")
            .WriteString(txtCourse.Text.ToString())
            .WriteEndElement()
            .WriteStartElement("CreditHours")
            .WriteString(txtCredit.Text.ToString())
            .WriteEndElement()
            .WriteStartElement("Grade")
            .WriteString(txtGrade.Text.ToString())
            .WriteEndElement()
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
        DisplayXMLFile()
    End Sub

    Private Sub btnFileSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnFileSelect.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If OpenFileDialog1.CheckFileExists = True Then
                txtFile.Text = OpenFileDialog1.FileName
                DisplayXMLFile()
            Else
                MessageBox.Show("That file does not exist.")
            End If
        End If
    End Sub

    Private Sub DisplayXMLFile()
        Try
            If Not txtFile.Text = "" Then
                Dim XMLTextReader As XmlTextReader = New XmlTextReader(Filename)
                While Not XMLTextReader.ReadState = ReadState.EndOfFile
                    rtxtXMLInfo.Text = XMLTextReader.ReadElementContentAsString
                    XMLTextReader.MoveToNextAttribute()
                End While
                XMLTextReader.Close()
            End If
        Catch
        End Try
    End Sub


    Private Sub btnNewFile_Click(sender As System.Object, e As System.EventArgs) Handles btnNewFile.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            File.Create(SaveFileDialog1.FileName & ".xml")
            txtFile.Text = SaveFileDialog1.FileName
            Filename = SaveFileDialog1.FileName
        End If
        DisplayXMLFile()
    End Sub
End Class
