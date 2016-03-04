'Project:       Sales Calculator Class
'Programmer:    Arthur Buckowitz
'Date:          August 6, 2012
'Description:   Business Logic for sales calculator

Public Class SalesCommission
    Const DECBASEPAY As Decimal = 250
    Const DECQUOTA As Decimal = 1000
    Const DECCOMMISSION As Decimal = 0.15
    Private _name As String
    Private _sales As Decimal
    Private Shared EarnedCommission As Decimal
    Private Shared Earned As Decimal
    Private Shared TotalSales As Decimal
    Private Shared TotalCommission As Decimal
    Private Shared TotalEarned As Decimal

    Public Sub New(Name As String, Sales As Decimal)
        Me.Name = Name
        Me.Sales = Sales
        EarnedCommission = CalculateCommission()
        Earned = CalculateEarned()
        TotalSales = TotalSales + Sales
        TotalCommission = TotalCommission + CalculateCommission()
        TotalEarned = TotalEarned + CalculateEarned()

    End Sub

    Shared ReadOnly Property Pay As Decimal
        Get
            Return Earned
        End Get
    End Property

    Shared ReadOnly Property Commission As Decimal
        Get
            Return EarnedCommission
        End Get
    End Property

    Public Property Name As String
        Get
            Return Me._name
        End Get
        Set(value As String)
            If value.Trim <> "" Then
                Me._name = value
            End If
        End Set
    End Property

    Public Property Sales As Decimal
        Get
            Return Me._sales
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                Me._sales = value
            End If
        End Set
    End Property

    Shared ReadOnly Property SalesTotal As Decimal
        Get
            Return TotalSales
        End Get
    End Property

    Shared ReadOnly Property CommissionTotal As Decimal
        Get
            Return TotalCommission
        End Get
    End Property

    Shared ReadOnly Property EarnedTotal As Decimal
        Get
            Return TotalEarned
        End Get
    End Property

    Protected Function CalculateCommission() As Decimal
        Dim Commission As Decimal
        If _sales >= DECQUOTA Then
            Commission = _sales * DECCOMMISSION
        Else
            Commission = 0
        End If
        Return Commission
    End Function

    Protected Function CalculateEarned() As Decimal
        Dim Earned As Decimal
        Earned = DECBASEPAY + CalculateCommission()
        Return Earned
    End Function


End Class
