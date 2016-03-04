<Serializable()>
Public Class Cars
    Private _make As String
    Private _model As String
    Private _year As Integer

    Public Sub New()
        Me.New("Ford", "Focus", 2012)
    End Sub

    Public Sub New(ByVal Make As String, ByVal Model As String, ByVal Year As Integer)
        Me.Make = Make
        Me.Model = Model
        Me.Year = Year
    End Sub

    Public Property Make As String
        Get
            Return _make
        End Get
        Set(value As String)
            If value.Trim.Length > 0 And IsNumeric(value) = False Then
                _make = value
            Else
                Throw New Exception("Invalid Make value : " & value)
            End If
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
        'Private Set(value As Integer) (Makes readonly)
        Set(value As Integer)
            _year = value
        End Set
    End Property

    Public ReadOnly Property Age As Integer
        Get
            Return Now().Year - Me.Year
        End Get
    End Property

    Public Function DisplayData() As String
        Return Me.Year & " " & Me.Make & " " & Me.Model
    End Function

End Class
