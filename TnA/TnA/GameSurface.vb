Imports System
Imports System.Windows.Threading


Public Class GameSurface
    Inherits Canvas

    Public Event RenderFrame(sender As Object, e As EventArgs)

    Private _gameLoop As DispatcherTimer
    Private _lastTick As DateTime = DateTime.Now

    ' Singelton pattern
    Private Shared ReadOnly _instance As GameSurface = New GameSurface()

    ' This class can't be instantiated more than once and
    ' the instance is created when the program runs
    Private Sub New()
        Me._gameLoop = New DispatcherTimer()
        Me._gameLoop.Interval = TimeSpan.Zero
        AddHandler Me._gameLoop.Tick, AddressOf GameLoopTick
    End Sub

    'Return the instance of the class
    Public Shared Function GetInstance() As GameSurface
        Return _instance
    End Function


    Private Sub GameLoopTick(sender As Object, e As EventArgs)
        Dim rfEvent As RenderFrameEventArgs = New RenderFrameEventArgs
        rfEvent.ElapsedTime = DateTime.Now - Me._lastTick
        Me._lastTick = DateTime.Now

        RaiseEvent RenderFrame(Me, rfEvent)

        'if (this.RenderFrame != null)
        '{
        '    this.RenderFrame(this, eventArgs);
        '}
    End Sub

    Public Sub StartGame()
        Me._gameLoop.Start()
    End Sub

    Public Sub StopGame()
        Me._gameLoop.Stop()
    End Sub


End Class