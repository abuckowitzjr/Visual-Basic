Public Class Car
    Inherits Vehicle
    Private _TrunkCapacity As Decimal
    Private _SlowDownTimer As DateTime
    Private _SpeedUpTimer As DateTime

    Public Sub New()
        MyBase.New()
        Me.TrunkCapacity = 0
    End Sub

    Public Sub New(Make As String, Model As String, Optional ByVal Year As Integer = 0, Optional Brakes As VehicleBrakes = VehicleBrakes.Disc, Optional HorsePower As Integer = 250, Optional TrunkCapacity As Decimal = 0)
        MyBase.New(Make, Model, Year, Brakes, HorsePower)
        Me.TrunkCapacity = TrunkCapacity
    End Sub

    Public Property TrunkCapacity As Decimal
        Get
            Return Me._TrunkCapacity
        End Get
        Set(value As Decimal)
            If value >= 0 And value < 10 Then
                Me._TrunkCapacity = value
            Else
                Throw New Exception("Invalid Trunk Capacity : " & value)
            End If
        End Set
    End Property

   Public Overrides Sub Slowdown()
        If Me.Direction <> VehicleDirection.Park AndAlso Me.Speed >= 0 Then
            If Now().Ticks - Me._SlowDownTimer.Ticks > 830000 Then
                If Me.Speed > 0 Then
                    'The remaining amount will error out if less than 12, this corrects for that error.
                    If Me.Speed > Me.SlowdownFactor Then
                        Me.Speed -= Me.SlowdownFactor
                    Else
                        Me.Speed = 0
                    End If
                    Me._SlowDownTimer = Now()
                End If
            End If
        End If
    End Sub

   Public Overrides Sub SpeedUp()
        If Me.Direction <> VehicleDirection.Park AndAlso Me.Speed >= 0 Then
            If Now().Ticks - Me._SpeedUpTimer.Ticks > 830000 Then
                Me.Speed = Me.Speed - Me.SpeedupFactor
                Me._SpeedUpTimer = Now()
            End If
        End If
    End Sub
End Class

