Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim NumberOfTickets As String
    Dim ShippingAddress As String
    Dim City As String
    Dim State As String
    Dim ZipCode As String
    Dim CreditCardNumber As String
    Dim CreditCardExp As String
    Dim CreditCardType As String
    Private Sub SubmitOrder_Init(sender As Object, e As System.EventArgs) Handles SubmitOrder.Init
        NumberOfTickets = txtNumberOfTickets.Text
        ShippingAddress = txtShippingAddress.Text
        City = txtCity.Text
        State = txtState.Text
        ZipCode = txtZipCode.Text
        CreditCardNumber = txtCreditCardNumber.Text
        CreditCardExp = txtExpirationDate.Text
        CreditCardType = ddlCardType.Text
    End Sub
End Class