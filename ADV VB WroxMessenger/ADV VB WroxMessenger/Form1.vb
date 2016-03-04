Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class ConnectForm

    Private Shared _mainTreadId As Integer
    Public Const ServicePort As Integer = 10101

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _mainTreadId = System.Threading.Thread.CurrentThread.GetHashCode()
        Text &= "-" & _mainTreadId.ToString()
    End Sub

End Class
