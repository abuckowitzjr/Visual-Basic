Public MustInherit Class Vehicle
    Private _make As String
    Private _model As String
    Private _year As Integer
    Private _speed As Integer
    Private _direction As VehicleDirection
    Private _brakes As VehicleBrakes
    Private _horsepower As Integer
    Private _running As Boolean
    Protected ReadOnly SlowdownFactor As Integer
    Protected ReadOnly SpeedupFactor As Integer

    Public Sub New()
        Me.New("Ford", "Focus")
    End Sub

    Public Sub New(Make As String, Model As String, Optional ByVal Year As Integer = 0, Optional ByVal Brakes As VehicleBrakes = VehicleBrakes.Disc, Optional ByVal HorsePower As Integer = 250)
        Me.Make = Make
        Me.Model = Model
        If Year = 0 Then
            Year = Now().Year
        End If
        Me.Year = Year
        Me.Direction = VehicleDirection.Park
        Me.Speed = 0
        Me._brakes = Brakes
        Select Case Me.Brakes
            Case VehicleBrakes.Disc
                Me.SlowdownFactor = 5
            Case VehicleBrakes.Drum
                Me.SlowdownFactor = 2
            Case VehicleBrakes.Mechanical
                Me.SlowdownFactor = 1
        End Select
        If HorsePower >= 50 AndAlso HorsePower <= 1200 Then
            Me._horsepower = HorsePower
        Else
            Throw New Exception("Invalid Horsepower : " & HorsePower)
        End If
        Me.SpeedupFactor = 1 + (Me.HorsePower \ 200)
        Me._running = False
    End Sub

    Public Property Make As String
        Get
            Return Me._make
        End Get
        Set(value As String)
            If value.Trim <> "" Then
                Me._make = value
            End If
        End Set
    End Property

    Public Property Model As String
        Get
            Return Me._model
        End Get
        Set(value As String)
            If value.Trim <> "" Then
                Me._model = value
            End If
        End Set
    End Property

    Public Property Year As Integer
        Get
            Return Me._year
        End Get
        Set(value As Integer)
            If value >= 1900 AndAlso value <= Now().Year + 1 Then
                Me._year = value
            Else
                Throw New Exception("Invalid Year : " & value)
            End If
        End Set
    End Property

    Public Property Speed As Integer
        Get
            Return Me._speed
        End Get
        Protected Set(value As Integer)
            If value >= 0 Then
                Me._speed = value
            Else
                Throw New Exception("Invalid Speed : " & value)
            End If
        End Set
    End Property

    Public Property Direction As VehicleDirection
        Get
            Return Me._direction
        End Get
        Private Set(value As VehicleDirection)
            Me._direction = value
        End Set
    End Property

    Public ReadOnly Property Brakes As VehicleBrakes
        Get
            Return Me._brakes
        End Get
    End Property

    Public ReadOnly Property HorsePower As Integer
        Get
            Return Me._horsepower
        End Get
    End Property

    Public ReadOnly Property IsRunning As Boolean
        Get
            Return Me._running
        End Get
    End Property

    Public Function GetAge() As Integer
        Return Now().Year - Me.Year
    End Function

    Public Function Start() As Boolean
        Dim success As Boolean = False
        If Not Me.IsRunning Then
            success = True
            Me._running = True
        End If
        Return success
    End Function

    Public Function TurnOff() As Boolean
        Dim success As Boolean = False
        If Me.IsRunning AndAlso Me.Direction = VehicleDirection.Park Then
            success = True
            Me._running = False
        End If
        Return success
    End Function

    Public Function Drive() As Boolean
        Dim success As Boolean = False
        If Me.IsRunning AndAlso Me.Speed = 0 AndAlso Me.Direction <> VehicleDirection.Forward Then
            success = True
            Me.Direction = VehicleDirection.Forward
        End If
        Return success
    End Function

    Public Function Reverse() As Boolean
        Dim success As Boolean = False
        If Me.IsRunning AndAlso Me.Speed = 0 AndAlso Me.Direction <> VehicleDirection.Reverse Then
            success = True
            Me.Direction = VehicleDirection.Reverse
        End If
        Return success
    End Function

    Public MustOverride Sub SpeedUp()
    Public MustOverride Sub Slowdown()

End Class
Public Enum VehicleDirection
    Forward = 1
    Reverse = 2
    Park = 3
End Enum

Public Enum VehicleBrakes
    Mechanical
    Drum
    Disc
End Enum

