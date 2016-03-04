Imports System.Threading
Public Class Ball
    Private _xPosition As Integer
    Private _yPosition As Integer
    Private _xSpeed As Integer
    Private _ySpeed As Integer
    Private _radius As Integer
    Private _color As Color
    Private _containerHeight As Integer
    Private _containerWidth As Integer
    Private rnd As New Random
    Private rw As New ReaderWriterLockSlim

    Public Sub New(ByVal xPosition As Integer, ByVal yPosition As Integer, ByVal containerHeight As Integer, ByVal containerWidth As Integer)
        Me.XPosition = xPosition
        Me.YPosition = yPosition
        Me.ContainerHeight = containerHeight
        Me.Containerwidth = containerWidth
        Randomize()
        Me.Radius = rnd.Next(8, 21)
        Me.XSpeed = rnd.Next(10, 21)
        Me.YSpeed = rnd.Next(10, 21)
        If rnd.Next(2) = 0 Then
            Me.XSpeed = -Me.XSpeed
        End If
        If rnd.Next(2) = 0 Then
            Me.YSpeed = -Me.YSpeed
        End If
        Me.BallColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
    End Sub

    Public Property XPosition As Integer
        Get
            Return Me._xPosition
        End Get
        Private Set(value As Integer)
            Me._xPosition = value
        End Set
    End Property

    Public Property YPosition As Integer
        Get
            Return Me._yPosition
        End Get
        Private Set(value As Integer)
            Me._yPosition = value
        End Set
    End Property

    Public Property XSpeed As Integer
        Get
            Return Me._xSpeed
        End Get
        Private Set(value As Integer)
            Me._xSpeed = value
        End Set
    End Property

    Public Property YSpeed As Integer
        Get
            Return Me._ySpeed
        End Get
        Private Set(value As Integer)
            Me._ySpeed = value
        End Set
    End Property

    Public Property Radius As Integer
        Get
            Return Me._radius
        End Get
        Private Set(value As Integer)
            Me._radius = value
        End Set
    End Property

    Private Property ContainerHeight As Integer
        Get
            Return Me._containerHeight
        End Get
        Set(value As Integer)
            Me._containerHeight = value
        End Set
    End Property

    Private Property Containerwidth As Integer
        Get
            Return Me._containerWidth
        End Get
        Set(value As Integer)
            Me._containerWidth = value
        End Set
    End Property

    Public Property BallColor As Color
        Get
            Return Me._color
        End Get
        Private Set(value As Color)
            Me._color = value
        End Set
    End Property

    Public Sub MoveBall()
        While True
            UpdateSpeed()
            UpdatePosition()
            Threading.Thread.Sleep(50)
        End While
    End Sub


    Private Sub UpdatePosition()
        Me.XPosition += Me.XSpeed
        Me.YPosition += Me.YSpeed
    End Sub

    Private Sub UpdateSpeed()
        If Me.YPosition <= Me.Radius Then
            Me.YSpeed = -Me.YSpeed
        End If
        If Me.YPosition >= Me.ContainerHeight - (Me.Radius) Then
            Me.YPosition = Me.ContainerHeight - (Me.Radius)
            Me.YSpeed = -Me.YSpeed
        End If
        If Me.XPosition <= Me.Radius Then
            Me.XSpeed = -Me.XSpeed
        End If
        If Me.XPosition >= Me.Containerwidth - (Me.Radius) Then
            Me.XPosition = Me.Containerwidth - (Me.Radius)
            Me.XSpeed = -Me.XSpeed
        End If
    End Sub

    Private Function Collision() As Boolean
        Dim col As Boolean = False
        rw.EnterWriteLock()
        '1: rw.enterreadlock()
        '2: rw.enterupgradeablereadlock()
        '3: SyncLock (AppForm.ballCollection)
        Try
            For Each Ball1 As Ball In AppForm.ballCollection
            Next
            '2: rw.enterwritelock()
        Catch ex As Exception
        Finally
            rw.ExitWriteLock()
            '1: rw.exitreadlock()
            '2: rw.exitwritelock()
        End Try
        Return col

        '3: End SyncLock

    End Function
End Class
