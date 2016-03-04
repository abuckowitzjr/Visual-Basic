Imports System.Threading
Public Class Circles
    Private _xposition As Integer
    Private _yposition As Integer
    Private _radius As Integer
    Private _color As Color

    Public Sub New(XPosition As Integer, YPosition As Integer, Radius As Integer, Color As Color)
        Me.XPosition = XPosition
        Me.YPosition = YPosition
        Me.Radius = Radius
        Me.Color = Color
    End Sub

    Public Property XPosition As Integer
        Get
            Return _xposition
        End Get
        Set(value As Integer)
            _xposition = value
        End Set
    End Property

    Public Property YPosition As Integer
        Get
            Return _yposition
        End Get
        Set(value As Integer)
            _yposition = value
        End Set
    End Property

    Public Property Radius As Integer
        Get
            Return _radius
        End Get
        Set(value As Integer)
            _radius = value
        End Set
    End Property

    Public Property Color As Color
        Get
            Return _color
        End Get
        Set(value As Color)
            _color = value
        End Set
    End Property
End Class
