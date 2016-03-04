Public Class FilmOrder
    Public Name As String
    Public FilmId As Integer
    Public Quantity As Integer

    Public Sub New()

    End Sub

    Public Sub New(name As String, filmId As Integer, quantity As Integer)
        Me.Name = name
        Me.FilmId = filmId
        Me.Quantity = quantity
    End Sub
End Class
