Public Class TrafficLight
    Private _redInt As Integer = 10
    Private _yellowInt As Integer = 2
    Private _greenInt As Integer = 20
    Private _i As Integer = 0

    Enum Light
        Red
        Green
        Yellow
    End Enum

    Public Property GreenInterval As Integer
        Get
            Return _greenInt
        End Get
        Set(value As Integer)
            If value > 0 Then
                _greenInt = value
            End If
        End Set
    End Property

    Public Property YellowInterval As Integer
        Get
            Return _yellowInt
        End Get
        Set(value As Integer)
            If value > 0 Then
                _yellowInt = value
            End If
        End Set
    End Property

    Public Property RedInterval As Integer
        Get
            Return _redInt
        End Get
        Set(value As Integer)
            If value > 0 Then
                _redInt = value
            End If
        End Set
    End Property

    Public Sub PowerUp()
        Timer1.Enabled = True
    End Sub

    Public Sub PowerDown()
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        If Me._i Mod 3 = 0 Then
            'green
            Me._i = 0
            Draw(Light.Green)
            Timer1.Interval = Me.GreenInterval * 1000
        Else
            If Me._i Mod 3 = 1 Then
                'yellow
                Draw(Light.Yellow)
                Timer1.Interval = Me.YellowInterval * 1000
            Else
                'red
                Draw(Light.Red)
                Timer1.Interval = Me.RedInterval * 1000
            End If
        End If
        Me._i += 1
    End Sub

    Private Sub Draw(ByVal lite As Light)
        Dim strLite As String = lite.ToString
        Dim gr As Graphics = Me.CreateGraphics
        Select Case strLite
            Case "Red"
                gr.DrawEllipse(Pens.Black, 25, 25, 50, 50)
                gr.FillEllipse(Brushes.Red, 25, 25, 50, 50)
                gr.DrawEllipse(Pens.Black, 25, 100, 50, 50)
                gr.FillEllipse(Brushes.Black, 25, 100, 50, 50)
                gr.DrawEllipse(Pens.Black, 25, 175, 50, 50)
                gr.FillEllipse(Brushes.Black, 25, 175, 50, 50)
            Case "Yellow"
                gr.DrawEllipse(Pens.Black, 25, 100, 50, 50)
                gr.FillEllipse(Brushes.Yellow, 25, 100, 50, 50)
                gr.DrawEllipse(Pens.Black, 25, 25, 50, 50)
                gr.FillEllipse(Brushes.Black, 25, 25, 50, 50)
                gr.DrawEllipse(Pens.Black, 25, 175, 50, 50)
                gr.FillEllipse(Brushes.Black, 25, 175, 50, 50)
            Case "Green"
                gr.DrawEllipse(Pens.Black, 25, 175, 50, 50)
                gr.FillEllipse(Brushes.Green, 25, 175, 50, 50)
                gr.DrawEllipse(Pens.Black, 25, 100, 50, 50)
                gr.FillEllipse(Brushes.Black, 25, 100, 50, 50)
                gr.DrawEllipse(Pens.Black, 25, 25, 50, 50)
                gr.FillEllipse(Brushes.Black, 25, 25, 50, 50)
        End Select
    End Sub
End Class
