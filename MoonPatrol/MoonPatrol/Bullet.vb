Public Class Bullet
    Public Property X As Integer

    Public Property Y As Integer

    Public Property Direction As Char

    Public Sub New(X As Integer, Y As Integer, Direction As Char)
        Me.X = X
        Me.Y = Y
        Me.Direction = Direction
    End Sub
End Class
