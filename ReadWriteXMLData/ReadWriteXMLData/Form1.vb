Imports System
Imports System.Xml
Imports System.Xml.Schema

Public Class Form1

    Dim xmlRead As XmlReader


    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim XMLSettings As New XmlWriterSettings()
        XMLSettings.Indent = True

        ' Initialize the xmlwriter
        Dim xmlWrt As XmlWriter
            xmlWrt = XmlWriter.Create(txtFilePath.Text, XMLSettings)


    With xmlWrt
        ' Write the xml declaration.
        .WriteStartDocument()

        ' Write a comment.
        .WriteComment("XML Student Information.")

        ' Write the root element.
        .WriteStartElement("Student")

        'First Student

        ' Student ID
        .WriteStartElement("StudentID")
        .WriteString(txtID.Text.ToString())
        .WriteEndElement()
        ' Student Name
        .WriteStartElement("Name")
        .WriteString(txtName.Text.ToString())
        .WriteEndElement()
        ' CourseCode
        .WriteStartElement("CourseCode")
        .WriteString(txtCourseCode.Text.ToString())
        .WriteEndElement()
        ' Credit Hours
        .WriteStartElement("CreditHours")
        .WriteString(txtCreditHours.Text.ToString())
        .WriteEndElement()
        ' Grade
        .WriteStartElement("Grade")
        .WriteString(txtGrade.Text.ToString())
        .WriteEndElement()

        ' End the Student data
        .WriteEndElement()

        ' Close the xmlTextWriter
        .WriteEndDocument()
        .Close()
    End With

        DisplaySelectedFile()

    End Sub

    Private Sub btnSelectFile_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectFile.Click
        OpenFileDialog1.ShowDialog()
        DisplaySelectedFile()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtFilePath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub DisplaySelectedFile()
        If System.IO.File.Exists(txtFilePath.Text) = True Then
            Dim objreader As New System.IO.StreamReader(txtFilePath.Text)
           rtbXML.Text = objreader.ReadToEnd
            objreader.Close()
        Else
            MessageBox.Show("That file does not exist!")
        End If
    End Sub

End Class
