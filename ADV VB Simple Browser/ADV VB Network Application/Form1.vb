Imports System.Net
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'button click will display url in textbox into the rich text box.
        Dim req As WebRequest = WebRequest.Create("http://" & TextBox1.Text)  'creates the request for website.
        Dim resp As WebResponse = req.GetResponse()  'uses get response on req website and stores in resp.
        RichTextBox1.Text = New StreamReader(resp.GetResponseStream).ReadToEnd
    End Sub
End Class
