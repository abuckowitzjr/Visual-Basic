Imports System.Drawing

<DataContract()> Public Class Shape
    Enum ShapeOfType
        Rectangle
        Triangle
        Square
    End Enum

    Public ShapePoints() As Point

    Public Sub New(ByVal Type As ShapeOfType)
        Select Case Type
            Case ShapeOfType.Rectangle
                ReDim ShapePoints(3)
                ShapePoints(0) = New Point(20, 20)
                ShapePoints(1) = New Point(20, 120)
                ShapePoints(2) = New Point(100, 120)
                ShapePoints(3) = New Point(100, 20)
            Case ShapeOfType.Square
                ReDim ShapePoints(3)
                ShapePoints(0) = New Point(20, 20)
                ShapePoints(1) = New Point(20, 120)
                ShapePoints(2) = New Point(120, 120)
                ShapePoints(3) = New Point(120, 20)
            Case Else
                ReDim ShapePoints(2)
                ShapePoints(0) = New Point(120, 120)
                ShapePoints(1) = New Point(20, 120)
                ShapePoints(2) = New Point(70, 20)
        End Select
    End Sub
End Class