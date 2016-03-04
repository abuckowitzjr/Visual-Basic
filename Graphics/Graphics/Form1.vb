Imports System.Drawing
Public Structure Circles
    Dim CircleCenter As Point
    Dim CircleColor As Color
End Structure

Public Class Form1
    Dim allCircles() As Circles
    Dim allPoints() As Point
    Private Sub Form1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Dim x As Integer = e.Location.X
        Dim y As Integer = e.Location.Y
        If allCircles Is Nothing Then
            ReDim allCircles(0)
            ReDim allPoints(0)
        Else
            ReDim Preserve allCircles(allCircles.Length)
            ReDim Preserve allPoints(allPoints.Length)
        End If
        Dim selectedColor As Color
        If rbBlue.Checked Then
            selectedColor = Color.Blue
        ElseIf rbGreen.Checked Then
            selectedColor = Color.Green
        Else
            selectedColor = Color.Red
        End If
        allCircles(allCircles.Length - 1).CircleCenter = New Point(x, y)
        allCircles(allCircles.Length - 1).CircleColor = selectedColor
        allPoints(allPoints.Length - 1) = New Point(x, y)
        Me.Refresh()
    End Sub
    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'If allCircles Is Nothing OrElse allCircles.Length < 4 Then
        'Exit Sub
        'End If
        Dim surface As Drawing.Graphics = Me.CreateGraphics()
        'surface.DrawRectangle(Pens.Aqua, New Rectangle(New Point(100, 100), New Size(200, 30)))
        For Each p As Circles In allCircles
            'surface.DrawPolygon(Pens.Firebrick, allPoints)

            'surface.DrawString("Hello There", New Font("Arial", 15), Brushes.Bisque, New Point(p.CircleCenter.X - 40, p.CircleCenter.Y - 40))

            'surface.DrawPie(New Pen(Color.Green, 5), New Rectangle(New Point(p.CircleCenter.X - 40, p.CircleCenter.Y - 40), New Size(80, 80)), 0, 250)
            'surface.FillPie(New SolidBrush(p.CircleColor), New Rectangle(New Point(p.CircleCenter.X - 40, p.CircleCenter.Y - 40), New Size(80, 80)), 0, 250)

            'surface.DrawEllipse(New Pen(Color.Green, 5), New Rectangle(New Point(p.CircleCenter.X - 40, p.CircleCenter.Y - 40), New Size(80, 80)))
            surface.FillEllipse(New SolidBrush(p.CircleColor), New Rectangle(New Point(p.CircleCenter.X - 40, p.CircleCenter.Y - 40), New Size(80, 80)))
        Next
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        allCircles = Nothing
        Me.Refresh()
    End Sub
End Class
