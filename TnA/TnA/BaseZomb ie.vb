Imports System.Windows.Threading
Imports TnA.GameObject

Public Class BaseZombie
    Inherits Person

    Dim _zombie_Attack As Boolean
    Private NewBaseZombieGraphics As BaseZombieGraphics

    Public Sub New(ByVal Speed As Integer, ByVal XPos As Integer, ByVal YPos As Integer,
                ByVal Moving As Boolean, ByVal DirLeft As Boolean, ByVal DirRight As Boolean,
                    ByVal DirUp As Boolean, ByVal DirDown As Boolean,
                        ByVal ObjectImage As Canvas, Health As Integer, ByRef Lunch As ButtKickingHeroes, ByVal Zombie_Attack As Boolean)
        MyBase.New(Speed, XPos, YPos, Moving, DirLeft, DirRight, False, False, ObjectImage, Health)
        ' This is EXTREMELY EXTREMELY HACKY CODE!
        ObjectImage.Visibility = Visibility.Collapsed
        NewBaseZombieGraphics = New BaseZombieGraphics
        'Dim myScaleTransform As ScaleTransform = New ScaleTransform
        '    myScaleTransform.ScaleY = RandomNumberGenerator.GetInstance.NextDouble() * 0.1 + 0.4
        '    myScaleTransform.ScaleX = RandomNumberGenerator.GetInstance.NextDouble() * 0.1 + 0.4
        NewBaseZombieGraphics.RenderTransform = New RotateTransform()

        GameSurface.GetInstance.Children.Add(NewBaseZombieGraphics)
        Canvas.SetLeft(NewBaseZombieGraphics, Me.XPos)
        Canvas.SetTop(NewBaseZombieGraphics, Me.YPos)
        Me.NewBaseZombieGraphics.Zombie1Animation.Begin()
        Me.Lunch = Lunch
        Me.Zombie_Attack = Zombie_Attack
    End Sub

    Public Property Zombie_Attack As Boolean
        Get
            Return Me._zombie_Attack
        End Get
        Set(value As Boolean)
            Me._zombie_Attack = value
        End Set
    End Property

    Private Lunch As ButtKickingHeroes

    Public Overrides Sub MoveObject(elapsed As Integer)
        If Moving Then
            If Me.XPos > Lunch.XPos Then
                Me.XPos -= Me.Speed * (elapsed / 1000)
            Else
                Me.XPos += Me.Speed * (elapsed / 1000)
            End If
            Canvas.SetLeft(NewBaseZombieGraphics, Me.XPos)
            Canvas.SetTop(NewBaseZombieGraphics, Me.YPos)
            Canvas.SetLeft(Me.ObjectImage, Me.XPos)
            Canvas.SetTop(Me.ObjectImage, Me.YPos)
        End If
    End Sub

End Class