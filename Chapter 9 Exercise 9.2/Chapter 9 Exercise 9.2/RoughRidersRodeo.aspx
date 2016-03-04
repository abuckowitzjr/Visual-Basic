<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RoughRidersRodeo.aspx.vb" Inherits="Chapter_9_Exercise_9._2.RoughRidersRodeo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-family: "AR BONNIE";
            font-size: xx-large;
            color: #FFFFFF;
        }
        .style2
        {
            text-align: center;
        }
        .style4
        {
            width: 37px;
        }
        #form1
        {
            height: 1042px;
            text-align: center;
        }
    </style>
</head>
<body bgcolor="#000000">
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style1" style="text-align: center">
                    Rough Riders Rodeo</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    <table style="width:100%;">
                        <tr>
                            <td class="style2">
                                <asp:HyperLink ID="TicketOrder" runat="server" NavigateUrl="~/TicketOrder.aspx" 
                                    style="color: #FFFFFF; font-family: 'AR BONNIE'; font-size: x-large">Order Tickets Now</asp:HyperLink>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <asp:Image ID="Image1" runat="server" Height="904px" 
        ImageUrl="~/Images/img7.jpg" Width="1375px" />
    <asp:Table ID="Table1" runat="server" Height="73px" Width="1376px">
    </asp:Table>
    </form>
</body>
</html>
