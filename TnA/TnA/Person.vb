Public MustInherit Class Person
    Inherits GameObject
    Private _health As Integer

    Public Sub New(ByVal Speed As Integer, ByVal XPos As Integer, ByVal YPos As Integer,
                    ByVal Moving As Boolean, ByVal DirLeft As Boolean, ByVal DirRight As Boolean,
                        ByVal DirUp As Boolean, ByVal DirDown As Boolean,
                            ByRef ObjectImage As Canvas, ByVal Health As Integer)
        MyBase.New(Speed, XPos, YPos, Moving, DirLeft, DirRight, False, False, ObjectImage)
        Me.Health = Health
    End Sub

    Public Property Health As Integer
        Get
            Return Me._health
        End Get
        Set(ByVal value As Integer)
            Me._health = value
        End Set
    End Property


End Class