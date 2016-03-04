<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Page2.aspx.vb" Inherits="FirstASPPage.Page2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 140px;
        }
        .style2
        {
            width: 182px;
        }
        .style4
        {
            width: 195px;
        }
        .style5
        {
            width: 298px;
        }
        font
        {
            font-family: "Segoe Script";
            font-size: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <!--Here is a comment-->
    <a href="Default.aspx">Home Page</a>
    <table style="width: 100%; height: 355px;">
        <tr>
            <td class="style1">
                Enter your name</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style5">
                <asp:Label ID="lblFullName" runat="server"></asp:Label>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td rowspan="8">
                <asp:Image ID="Image1" runat="server" Height="185px" 
                    ImageUrl="~/Images/Pong Background.jpg" Width="188px" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtFirstName" Display="None" ErrorMessage="Cannot be empty" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style4">
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtFirstName" ControlToValidate="txtLastName" Display="None" 
                    ErrorMessage="Not equal" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtLastName" Display="None" ErrorMessage="Cannot be empty" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style4">
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ControlToValidate="txtLastName" Display="None" 
                    ErrorMessage="Must be from 10 to 50" ForeColor="Red" MaximumValue="50" 
                    MinimumValue="10"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtEmail" Display="None" 
                    ErrorMessage="Input not in correct format" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                <asp:HiddenField ID="HiddenField1" runat="server" Visible="False" />
            </td>
            <td class="style5">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" 
                    HeaderText="Error" />
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                <asp:Button ID="btnSubmit" runat="server" Height="35px" Text="Submit" 
                    Width="97px" />
            </td>
            <td class="style5">
                &nbsp;</td>
            <td class="style4">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="lblRandDisplay" runat="server"></asp:Label>
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="btnRandom" runat="server" Height="43px" 
                            Text="Generate Random" />
                        <br />
                        <br />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
