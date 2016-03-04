Public Class RegularEmployee
    Inherits SalesCommission
    Const DECBASEPAY As Decimal = 250
    Const DECQUOTA As Decimal = 1000
    Const DECCOMMISSION As Decimal = 0.15
    Public Shared TotalCommission As Decimal
    Public Shared TotalEarned As Decimal
    Public Shared TotalSales As Decimal
    Public Shared Commission As Decimal
    Public Shared Earned As Decimal

    Public Sub New(ByVal Name As String, ByVal Sales As Decimal)
        MyBase.New(Name, Sales)
        TotalCommission = TotalCommission + RegEmpCommission(Sales)
        Commission = RegEmpCommission(Sales)
        TotalEarned = TotalEarned + RegEmpEarned(Sales)
        Earned = RegEmpEarned(Sales)
        TotalSales = TotalSales + RegSales(Sales)
    End Sub

    Shared ReadOnly Property RegEmpCommissionTotal As Decimal
        Get
            Return TotalCommission
        End Get
    End Property

    Shared ReadOnly Property RegEmpEarnedTotal As Decimal
        Get
            Return TotalEarned
        End Get
    End Property

    Protected Function RegEmpCommission(num1 As Decimal) As Decimal
        Dim Commission As Decimal
        If num1 >= DECQUOTA Then
            Commission = num1 * DECCOMMISSION
        Else
            Commission = 0
        End If
        Return Commission
    End Function

    Protected Function RegEmpEarned(num1 As Decimal) As Decimal
        Dim Earned As Decimal
        Earned = DECBASEPAY + RegEmpCommission(num1)
        Return Earned
    End Function

    Protected Function RegSales(num1 As Decimal) As Decimal
        Dim Sales As Decimal
        Sales = num1
        Return Sales
    End Function

End Class
