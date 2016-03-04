Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text

Public Class ServerForm
    Private MyServer As TcpListener
    Private Ip As IPAddress
    Private port As Integer
    Private clientNumber As Integer = 1
    Private clients As New List(Of TcpClient)

    Private Sub ServerForm_Load1(sender As Object, e As System.EventArgs) Handles Me.Load
        lblServerName.Text = Environment.MachineName
        port = Integer.Parse(txtPort.Text)
        Dim ips() As IPAddress = Dns.GetHostAddresses(lblServerName.Text)
        Ip = ips(1)
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        MyServer = New TcpListener(Ip, port)
        btnStart.Enabled = False
        btnStop.Enabled = True
        MyServer.Start()
        Dim t1 As New Thread(AddressOf doWork)
        t1.Start()
        RichTextBox1.Text = "Server Started" & vbCrLf
    End Sub

    Public Sub doWork()
        While True
            Dim client As TcpClient = MyServer.AcceptTcpClient
            If Not client Is Nothing Then
                RichTextBox1.Text &= "Client" & clientNumber & " connected " & vbCrLf
                Dim data() As Byte
                Dim ns As NetworkStream = client.GetStream()
                data = Encoding.ASCII.GetBytes(clientNumber.ToString)
                ns.Write(data, 0, data.Length)
                SyncLock clients
                    clients.Add(client)
                End SyncLock
                Dim clientThread As New Thread(AddressOf ProcessClient)
                clientThread.Name = "Client" & clientNumber
                clientThread.Start()
            End If
        End While
    End Sub

    Private Sub ProcessClient()
        Dim i As Integer = Integer.Parse(Thread.CurrentThread.Name.Substring(6))
        Dim c1 As TcpClient
        SyncLock clients
            c1 = clients(i - 1)
        End SyncLock
        While True
            Dim data(1024) As Byte
            Dim ns As NetworkStream = c1.GetStream()
            ns.Read(data, 0, data.Length)
            RichTextBox1.Text &= Encoding.ASCII.GetString(data) & vbCrLf
            ns.Write(data, 0, data.Length)
        End While
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        MyServer.Stop()
    End Sub

    'Public Function IsPrime(number As Integer)
    '    Dim result As Integer
    '    Return result
    'End Function

End Class