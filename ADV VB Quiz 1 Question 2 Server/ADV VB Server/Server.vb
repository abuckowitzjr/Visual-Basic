Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text

<Serializable()> Public Class ServerForm
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

    Public Function IsPrime(Num As Integer) As Boolean
        Dim result As Boolean
        Dim F As Integer
        For F = 2 To Num - 1
            If Num Mod F = 0 Then
                result = False
                Exit For
            End If
        Next
        Return result
    End Function

    Public Function GetFactorial(Num As Integer) As Long
        Dim result As Long = 0
        For i As Integer = 1 To Num
            If result = 0 Then
                result = i
            Else
                result = result * i
            End If
        Next
        Return result
    End Function

    Public Function GetSphereVolume(Radius As Integer) As Double
        Dim result As Double
        result = (4 / 3) * Math.PI * Math.Pow(Radius, 3)
        Return result
    End Function
End Class