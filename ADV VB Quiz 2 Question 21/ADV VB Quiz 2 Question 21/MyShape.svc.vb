Public Class MyShape
    Implements IShape

    Public Function GetRectangle() As Shape Implements IShape.GetRectangle
        Return New Shape(Shape.ShapeOfType.Rectangle)
    End Function

    Public Function GetSquare() As Shape Implements IShape.GetSquare
        Return New Shape(Shape.ShapeOfType.Square)
    End Function

    Public Function GetTriangle() As Shape Implements IShape.GetTriangle
        Return New Shape(Shape.ShapeOfType.Triangle)
    End Function

End Class