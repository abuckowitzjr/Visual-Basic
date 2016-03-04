Public Class _Default
    Inherits System.Web.UI.Page

    
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strConnection As String = "Data Source=myserveraddress;Initial Catalog=myDataBase;Integrated Security=SSPI;"
        Dim strSQL As String = "Insert into Students(FirstName, LastName, DOB) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
        Dim conn As New SqlClient.SqlConnection(strConnection)
        conn.Open()
        Dim cmd As New SqlClient.SqlCommand(strSQL, conn)

    End Sub
End Class