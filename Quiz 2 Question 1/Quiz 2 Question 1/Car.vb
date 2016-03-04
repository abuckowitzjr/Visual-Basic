
Public Class Car
    Inherits Vehicle
    Dim _trunkcapacity As Double

    Public Sub New(Make As String, Model As String, Year As Date, ByVal TrunkCapacity As Double)
        MyBase.New(Make, Model, Year)
        Me.TrunkCapacity = TrunkCapacity
    End Sub

    Private Property TrunkCapacity As Double
        Get
            Return _trunkcapacity
        End Get
        Set(value As Double)
            Me._trunkcapacity = value
        End Set
    End Property

    Public Overrides Function GetInfo() As String
        Dim tmp As String = " cubic feet"
        If _trunkcapacity = 1 Then
            tmp = " cubic foot"
        End If

        Return "This is a " & _year.Year & " " & _make & " " & _model & " with a trunk capacity of " & _trunkcapacity & tmp
    End Function

End Class
