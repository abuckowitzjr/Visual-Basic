<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TicketOrder.aspx.vb" Inherits="Chapter_9_Exercise_9._2.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-family: "AR BONNIE";
            font-size: x-large;
        }
        .style4
        {
            height: 26px;
        }
        .style14
        {
            width: 155px;
        }
        .style22
        {
            width: 395px;
        }
        .style24
        {
            height: 26px;
            text-align: left;
            width: 239px;
        }
        .style32
        {
            width: 127px;
            text-align: right;
        }
        .style33
        {
            height: 26px;
            width: 127px;
            text-align: right;
        }
        .style34
        {
            height: 26px;
            width: 110px;
        }
        .style37
        {
            text-align: left;
            width: 239px;
        }
        .style38
        {
            height: 26px;
            width: 155px;
            text-align: center;
        }
        .style39
        {
            width: 179px;
            text-align: right;
        }
        .style40
        {
            height: 26px;
            width: 179px;
            text-align: right;
        }
        .style41
        {
            text-align: left;
            width: 110px;
        }
    </style>
</head>
<body bgcolor="#000000">
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1" colspan="5" style="text-align: center; color: #FFFFFF">
                    Order Tickets</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style32">
                    &nbsp;</td>
                <td class="style41">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style22" colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style32">
                    <asp:Label ID="Label1" runat="server" ForeColor="White" 
                        style="font-family: 'AR BONNIE'; font-size: large" Text="Number of Tickets:"></asp:Label>
                </td>
                <td class="style41">
                    <asp:TextBox ID="txtNumberOfTickets" runat="server"></asp:TextBox>
                </td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style22" colspan="2" 
                    style="text-align: center; color: #FFFFFF; font-family: 'AR BONNIE'; font-size: x-large">
                    Credit Card Information</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style32">
                    &nbsp;</td>
                <td class="style41">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style39">
                    <asp:Label ID="Label6" runat="server" 
                        style="color: #FFFFFF; font-family: 'AR BONNIE'; font-size: large" 
                        Text="Credit Card Number:"></asp:Label>
                </td>
                <td class="style37">
                    <asp:TextBox ID="txtCreditCardNumber" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                </td>
                <td class="style33">
                    <asp:Label ID="Label2" runat="server" ForeColor="White" 
                        style="font-family: 'AR BONNIE'; font-size: large" Text="Shipping Address:"></asp:Label>
                </td>
                <td class="style34">
                    <asp:TextBox ID="txtShippingAddress" runat="server" style="margin-right: 15px" 
                        Width="270px"></asp:TextBox>
                </td>
                <td class="style38">
                </td>
                <td class="style40">
                    <asp:Label ID="Label7" runat="server" 
                        style="color: #FFFFFF; font-family: 'AR BONNIE'; font-size: large" 
                        Text="Expiration Date:"></asp:Label>
                </td>
                <td class="style24">
                    <asp:TextBox ID="txtExpirationDate" runat="server"></asp:TextBox>
                </td>
                <td class="style4">
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style33">
                    <asp:Label ID="Label3" runat="server" 
                        style="color: #FFFFFF; font-family: 'AR BONNIE'; font-size: large" Text="City:"></asp:Label>
                </td>
                <td class="style34">
                    <asp:TextBox ID="txtCity" runat="server" Width="113px"></asp:TextBox>
                </td>
                <td class="style38">
                    &nbsp;</td>
                <td class="style40">
                    <asp:Label ID="Label8" runat="server" 
                        style="color: #FFFFFF; font-family: 'AR BONNIE'; font-size: large" 
                        Text="Card Type:"></asp:Label>
                </td>
                <td class="style24">
                    <asp:DropDownList ID="ddlCardType" runat="server">
                        <asp:ListItem>VISA</asp:ListItem>
                        <asp:ListItem>Mastercard</asp:ListItem>
                        <asp:ListItem>Discover</asp:ListItem>
                        <asp:ListItem>American Express</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style33">
                    <asp:Label ID="Label4" runat="server" 
                        style="color: #FFFFFF; font-size: large; font-family: 'AR BONNIE'" 
                        Text="State:"></asp:Label>
                </td>
                <td class="style34">
                    <asp:TextBox ID="txtState" runat="server" Width="31px"></asp:TextBox>
                </td>
                <td class="style38">
                    &nbsp;</td>
                <td class="style40">
                    &nbsp;</td>
                <td class="style24">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style33">
                    <asp:Label ID="Label5" runat="server" 
                        style="font-family: 'AR BONNIE'; font-size: large; color: #FFFFFF" 
                        Text="Zip Code:"></asp:Label>
                </td>
                <td class="style34">
                    <asp:TextBox ID="txtZipCode" runat="server" Width="77px"></asp:TextBox>
                </td>
                <td class="style38">
                    &nbsp;</td>
                <td class="style40">
                    &nbsp;</td>
                <td class="style24">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style33">
                    &nbsp;</td>
                <td class="style34">
                    &nbsp;</td>
                <td class="style38">
                    <asp:HyperLink ID="SubmitOrder" runat="server" 
                        NavigateUrl="~/OrderConfirmation.aspx" 
                        style="color: #FFFFFF; font-family: 'AR BONNIE'; font-size: xx-large">Submit</asp:HyperLink>
                </td>
                <td class="style40">
                    &nbsp;</td>
                <td class="style24">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
