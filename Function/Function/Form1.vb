Public Class Form1
    Dim total As Integer = sum(15, 13)
    Private Function sum(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim sum As Integer
        sum = num1 + num2
        Return sum
    End Function
End Class