Imports System.Windows.Threading

Public Class ButtKickingHeroes
    Inherits Person

    Public Sub New(ByVal Speed As Integer, ByVal XPos As Integer, ByVal YPos As Integer,
                    ByVal Moving As Boolean, ByVal DirLeft As Boolean, ByVal DirRight As Boolean,
                        ByVal DirUp As Boolean, ByVal DirDown As Boolean,
                            ByVal ObjectImage As Canvas, ByVal Health As Integer)
        MyBase.New(Speed, XPos, YPos, False, False, False, False, False, ObjectImage, Health)
    End Sub

    Public Overrides Sub MoveObject(elapsed As Integer)
        If DirRight Then
            XPos += (Me.Speed * (elapsed / 1000))
        Else
            XPos -= (Me.Speed * (elapsed / 1000))
        End If

        Canvas.SetLeft(Me.ObjectImage, Me.XPos)
        Canvas.SetTop(Me.ObjectImage, Me.YPos)
    End Sub

End Class