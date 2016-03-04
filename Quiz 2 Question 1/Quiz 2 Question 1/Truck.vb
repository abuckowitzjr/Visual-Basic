Public Class Truck
    Inherits Vehicle
    Dim _bedsize As Double

    Public Sub New(Make As String, Model As String, Year As Date, ByVal BedSize As Double)
        MyBase.New(Make, Model, Year)
        Me.BedSize = BedSize
    End Sub

    Private Property BedSize As Double
        Get
            Return _bedsize
        End Get
        Set(value As Double)
            Me._bedsize = value
        End Set
    End Property

    Public Overrides Function GetInfo() As String
        Dim tmp As String = "feet"
        If _bedsize = 1 Then
            tmp = "foot"
        End If

        Return "This is a " & _year.Year & " " & _make & " " & _model & " with a trunk capacity of " & _bedsize & " " & tmp
    End Function
End Class
