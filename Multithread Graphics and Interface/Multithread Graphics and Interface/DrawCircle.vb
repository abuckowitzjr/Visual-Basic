Public Class DrawCircle
    Implements DrawShapes
    Private surface As Control
    Private drawColor As Color = Color.Blue

    Public Sub New(surface As Control)
        Me.surface = surface
    End Sub

    Public Sub Draw1() Implements DrawShapes.Draw
        Dim gr As Graphics = surface.CreateGraphics()
        For i As Integer = 0 To 100
            gr.DrawEllipse(New Pen(drawColor), New Rectangle(0, 0, i, i))
            Threading.Thread.Sleep(100)
        Next
    End Sub

    Private Function getColor() As System.Drawing.Color Implements DrawShapes
        Return Me.getColor
    End Function


    Public Interface DrawShapes
        Sub Draw()
        Function getColor() As Color
        Sub setColor(ByVal clr As Color)
    End Interface
End Class
