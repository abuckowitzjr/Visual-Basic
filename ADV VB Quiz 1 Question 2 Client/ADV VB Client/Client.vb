Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text

<Serializable()> Public Class ClientForm
    Private Ip As IPAddress
    Private port As Integer
    Private client As New TcpClient

    Private Sub ClientForm_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        txtServer.Text = Environment.MachineName
        port = 30000
        txtPort.Text = port.ToString
        Dim ips As IPAddress = IPAddress.Loopback
        'Dim ips() As IPAddress = Dns.GetHostAddresses(Environment.MachineName)
        Ip = ips
        'Ip = ips(1)
        client.Connect(Ip, port)
        RichTextBox1.Text = "Connected to the server" & vbCrLf
        Dim t1 As New Thread(AddressOf doWork)
        t1.Start()
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub doWork()
        While True
            Dim data(1024) As Byte
            Dim ns As NetworkStream = client.GetStream()
            ns.Read(data, 0, data.Length)
            RichTextBox1.Text &= "Server: " & Encoding.ASCII.GetString(data) & vbCrLf
        End While
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim data() As Byte
        Dim ns As NetworkStream = client.GetStream()
        data = Encoding.ASCII.GetBytes(txtMessage.Text)
        ns.Write(data, 0, data.Length)
        RichTextBox1.Text &= "Client: " & Encoding.ASCII.GetString(data) & vbCrLf
    End Sub

End Class