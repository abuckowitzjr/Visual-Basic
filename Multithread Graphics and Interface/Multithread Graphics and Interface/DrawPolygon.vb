Public Class DrawPolygon
    Private surface As Control

    Public Sub New(surface As Control)
        Me.surface = surface
    End Sub

    Public Sub draw()
        Dim gr As Graphics = surface.CreateGraphics()
        For i As Integer = 10 To 200
            Dim p As Point() = {New Point(i + 10, 10), New Point(i + 20, 20), New Point(i + 30, 30), New Point(i + 20, 40), New Point(i + 10, 30)}
            gr.DrawPolygon(Pens.Red, p)
            Threading.Thread.Sleep(100)
        Next
    End Sub
End Class
