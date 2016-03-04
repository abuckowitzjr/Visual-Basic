Public Class Rover

    Public Property Model As Image

    Public Property Speed As Integer

    Public Property JumpHeight As Integer

    Public Property JumpDistance As Integer

    Public Property RateOfFire As Integer

    Public Property HitPoints As Integer
    Public Sub New(JumpHeight As Integer, Jumpdistance As Integer, HitPoints As Integer, Speed As Integer)
        Me.JumpHeight = JumpHeight
        Me.JumpDistance = Jumpdistance
        Me.HitPoints = HitPoints
        Me.Speed = Speed
    End Sub
    Public Sub Fire()
        MessageBox.Show("Fire")
    End Sub

    Public Sub Jump()
        MessageBox.Show("Jump")
    End Sub

    Public Sub MoveLeft()

    End Sub

    Public Sub MoveRight()

    End Sub


End Class
