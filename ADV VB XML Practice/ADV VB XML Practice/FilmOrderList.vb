Public Class FilmOrderList

    Public FilmOrders() As FilmOrder

    Public Sub New()

    End Sub

    Public Sub New(multiFilmOrders() As FilmOrder)
        Me.FilmOrders = multiFilmOrders
    End Sub
End Class