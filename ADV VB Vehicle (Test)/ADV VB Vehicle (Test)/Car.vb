Public Class Car
    Private _make As String
    Private _model As String
    Private _year As Integer
    Public Sub New(make As String, model As String, year As Integer)
        Me.Make = make
        Me.Model = model
        Me.Year = year
    End Sub

    Public Sub New()

    End Sub

    Public Property Make As String
        Get
            Return _make
        End Get
        Set(value As String)
            _make = value
        End Set
    End Property

    Public Property Model As String
        Get
            Return _model
        End Get
        Set(value As String)
            _model = value
        End Set
    End Property

    Public Property Year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
        End Set
    End Property

    Public ReadOnly Property Age As Integer
        Get
            Return Now.Year - Year
        End Get
    End Property
End Class
