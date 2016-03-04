'Project:       Sales Calculator Class
'Programmer:    Arthur Buckowitz
'Date:          August 6, 2012
'Description:   Business Logic for sales calculator

Public MustInherit Class SalesCommission
    Private Shared _name As String
    Private Shared _sales As Decimal
    Private Shared TotalSales As Decimal
   Private Shared ProgramName As String = "Sales Calculator v2.5"
    Private Shared ProgrammerName As String = "Programmed By: Arthur Buckowitz"

    Public Sub New(Name As String, Sales As Decimal)
        Name = Name
        Sales = Sales
        TotalSales = TotalSales + Sales
    End Sub

    Shared ReadOnly Property Program As String
        Get
            Return ProgramName
        End Get
    End Property

    Shared ReadOnly Property Programmer As String
        Get
            Return ProgrammerName
        End Get
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            If value.Trim <> "" Then
                _name = value
            End If
        End Set
    End Property

    Shared Property Sales As Decimal
        Get
            Return _sales
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                _sales = value
            End If
        End Set
    End Property

    Shared ReadOnly Property SalesTotal As Decimal
        Get
            Return TotalSales
        End Get
    End Property
End Class
