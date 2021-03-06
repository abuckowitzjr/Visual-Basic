﻿Imports System.Net.Sockets
Imports System.Threading
Imports System.Net

Public Class Listener
    Implements IDisposable

    Private main As ConnectForm
    Private listener As TcpListener
    Private thread As Thread

    Public Sub New(ByVal main As ConnectForm)
        main = main
    End Sub

    Public Sub SpinUp()
        'create and start the new thread...
        thread = New Thread(AddressOf ThreadEntryPoint)
        thread.Start()
    End Sub

    'ThreadEntryPoint...
    Protected Sub ThreadEntryPoint()
        'Create a socket...
        listener = New TcpListener(IPAddress.Loopback, ConnectForm.ServicePort)
        listener.Start()
        'Loop infinitely, waiting for connections.
        Try
            Do While True
                'Get a connection...
                Dim client As TcpClient = listener.AcceptTcpClient()
                If client Is Nothing Then
                    Exit Do
                End If
                'Process it...
                main.ReceiveInboundConnection(client)
            Loop
        Catch
            'eat anyexceptions
        End Try
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
