Imports System.Data.OleDb

Public Class WebForm1
    Inherits System.Web.UI.Page

    Private Sub WebForm1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            Exit Sub
        End If
        Dim conn As New OleDb.OleDbConnection()
        Dim sql As String = ""
        Try
            Dim ip As String = Request.UserHostAddress
            Dim dt As DateTime = Now()
            Dim count As Integer = getCount(ip)
            Dim comment As String = ""
            If count = 0 Then
                sql = "INSERT INTO clients([IPAddress], Date_Time, [Count]) VALUES('" & ip & "','" & dt & "',1)"
            Else
                sql = "UPDATE Clients SET [Count] = [Count] + 1,Date_Time='" & dt & "' WHERE [IPAddress] = '" & ip & "'"
            End If
            Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\Mike\Desktop\vb2012.mdb"
            conn = New OleDb.OleDbConnection(connString)
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch
            MsgBox("Fail")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function getCount(IP As String) As Integer
        Dim retVal As Integer = 0
        Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\Mike\Desktop\vb2012.mdb"
        Dim sql As String = "SELECT [Count] FROM Clients WHERE [IPAddress]='" & IP & "'"
        Dim conn As New OleDb.OleDbConnection(connString)
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim rdr As OleDbDataReader = cmd.ExecuteReader()

            If rdr.Read() Then
                retVal = Integer.Parse(CStr(rdr.Item(0)))
            Else
                retVal = 0
            End If
        Catch
            MsgBox("Read Failed")
        Finally
            conn.Close()
        End Try
        Return retVal
    End Function
End Class