Imports System.Data
Imports System.Xml
Imports System.Text

Public Class Form1

    Private ds As New DataSet
    Dim write As XmlTextWriter
    Dim myList As New List(Of Integer)

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'FillDataset()
        Dim xdoc As XDocument = XDocument.Load("c:\temp\students.xml")
        Dim query = From stu In xdoc.Descendants("Student")
                    Where stu.Attribute("Id").Value = "1"
                    Select stu.Value
        For Each item In query
            MsgBox(item)
        Next
    End Sub

    Private Sub FillDataset()
        Dim connString As String = My.Settings.dbConnString
        Dim sqlCmd As String = "SELECT id, make, model, year FROM Cars"
        Dim conn As New SqlClient.SqlConnection(connString)
        Try
            conn.Open()
            Dim cmd As New SqlClient.SqlCommand(sqlCmd)
            Dim dr As New SqlClient.SqlDataAdapter(cmd)
            dr.Fill(ds)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnWrite_Click(sender As System.Object, e As System.EventArgs) Handles btnWrite.Click
        ds.WriteXml("c:/Temp/cars.xml")
    End Sub

    Private Sub AddStudent(ByVal id As Integer, ByVal FName As String, ByVal LName As String)
        write.WriteStartElement("Student")
        write.WriteAttributeString("Id", id.ToString)
        write.WriteStartElement("FName")
        write.WriteString(FName)
        write.WriteEndElement()
        write.WriteStartElement("LName")
        write.WriteString(LName)
        write.WriteEndElement()
        write.WriteEndElement()
    End Sub

    Private Sub btnNewFile_Click(sender As System.Object, e As System.EventArgs) Handles btnNewFile.Click
        write = New XmlTextWriter("c:\temp\students.xml", Encoding.UTF8)
        write.Formatting = Formatting.Indented
        write.Indentation = 4
        write.WriteStartDocument()
        write.WriteStartElement("Students")
        AddStudent(1, "Mike", "Buckowitz")
        AddStudent(2, "Jack", "Black")
        AddStudent(3, "Mick", "Jagger")
        AddStudent(4, "Paul", "Bunyon")
        AddStudent(5, "Green", "Giant")
        AddStudent(6, "Brandon", "Huff")
        AddStudent(7, "Dale", "Doback")
        AddStudent(8, "Bob", "Hope")
        write.WriteEndElement()
        write.WriteEndDocument()
        write.Close()
    End Sub
End Class
