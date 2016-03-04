Public Class Projectile
    Inherits GameObject

    Public Sub New(ByVal Speed As Integer, ByVal XPos As Integer, ByVal YPos As Integer,
        ByVal Moving As Boolean, ByVal DirLeft As Boolean, ByVal DirRight As Boolean,
        ByVal DirUp As Boolean, ByVal DirDown As Boolean, ByVal ObjectImage As Canvas,
        ByRef Player As ButtKickingHeroes)
        MyBase.New(Speed, XPos, YPos, False, False, False, False, False, ObjectImage)
        Me.Player = Player

    End Sub

    Private Player As ButtKickingHeroes

    Public Overrides Sub MoveObject(elapsed As Integer)

        Me.XPos += Me.Speed * (elapsed / 1000)

        Canvas.SetLeft(Me.ObjectImage, Me.XPos)
        Canvas.SetTop(Me.ObjectImage, Me.YPos)

    End Sub
End Class