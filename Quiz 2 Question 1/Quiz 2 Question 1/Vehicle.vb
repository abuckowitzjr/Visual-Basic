Public MustInherit Class Vehicle
    Public _make As String
    Public _model As String
    Public _year As Date
    Shared _count As Integer
    Dim _age As Integer
    Public Sub New(ByVal Make As String, ByVal Model As String, ByVal Year As Date)
        _count += 1
        Me.Make = Make
        Me.Model = Model
        Me.Year = Year
    End Sub

    Private Property Make As String
        Get
            Return _make
        End Get
        Set(value As String)
            Me._make = value
        End Set
    End Property

    Private Property Model As String
        Get
            Return _model
        End Get
        Set(value As String)
            Me._model = value
        End Set
    End Property

    Private Property Year As Date
        Get
            Return _year
        End Get
        Set(value As Date)
            Me._year = value
        End Set
    End Property

    Shared ReadOnly Property Count As Integer
        Get
            Return _count
        End Get
    End Property

    Private ReadOnly Property Age As Integer
        Get
            Return _age
        End Get
    End Property

    Public MustOverride Function GetInfo() As String

End Class
