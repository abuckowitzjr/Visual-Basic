Public Class MyMath
    Implements IMath

    Public Function add(num1 As Integer, num2 As Integer) As Long Implements IMath.add
        Return num1 + num2
    End Function

    Public Function subtract(num1 As Integer, num2 As Integer) As Long Implements IMath.subtract
        Return num1 - num2
    End Function
End Class
