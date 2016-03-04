Public Class Supervisor
    Inherits SalesCommission
    Const DECBASEPAY As Decimal = 500
    Const DECQUOTA As Decimal = 2000
    Const DECCOMMISSION As Decimal = 0.2
    Public Shared TotalCommission As Decimal
    Public Shared TotalEarned As Decimal
    Public Shared TotalSales As Decimal
    Public Shared Commission As Decimal
    Public Shared Earned As Decimal

    Public Sub New(ByVal Name As String, ByVal Sales As Decimal)
        MyBase.New(Name, Sales)
        TotalCommission = TotalCommission + SupCommission(Sales)
        Commission = SupCommission(Sales)
        TotalEarned = TotalEarned + SupEarned(Sales)
        Earned = SupEarned(Sales)
        TotalSales = TotalSales + SupSales(Sales)
    End Sub

    Shared ReadOnly Property SupCommissionTotal As Decimal
        Get
            Return TotalCommission
        End Get
    End Property

    Shared ReadOnly Property SupEarnedTotal As Decimal
        Get
            Return TotalEarned
        End Get
    End Property

    Protected Function SupCommission(num1 As Decimal) As Decimal
        Dim Commission As Decimal
        If num1 >= DECQUOTA Then
            Commission = num1 * DECCOMMISSION
        Else
            Commission = 0
        End If
        Return Commission
    End Function

    Protected Function SupEarned(num1 As Decimal) As Decimal
        Dim Earned As Decimal
        Earned = DECBASEPAY + SupCommission(num1)
        Return Earned
    End Function

    Protected Function SupSales(num1 As Decimal) As Decimal
        Dim Sales As Decimal
        Sales = num1
        Return Sales
    End Function

End Class
