<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Page3.aspx.vb" Inherits="IVB_Quiz_1_Exercise_31.Page3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            text-align: center;
        }
        .style3
        {
            width: 176px;
        }
        .style4
        {
            width: 785px;
            text-align: right;
        }
        .style5
        {
            text-align: center;
            height: 31px;
        }
        .style7
        {
            width: 768px;
        }
        .style8
        {
            width: 785px;
            text-align: right;
            height: 31px;
        }
        .style9
        {
            width: 768px;
            height: 31px;
        }
        .style10
        {
            width: 206px;
            text-align: right;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtFirstName" ErrorMessage="Required Field" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style10">
                <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </td>
            <td class="style7">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ControlToValidate="txtFirstName" ErrorMessage="Incorrect Format" 
                    ForeColor="Red" ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtLastName" ErrorMessage="Required Field" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style10">
                <asp:Label ID="Label3" runat="server" Text="Last Name:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </td>
            <td class="style7">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                    ControlToValidate="txtLastName" ErrorMessage="Incorrect Format" ForeColor="Red" 
                    ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtDateOfBirth" ErrorMessage="Required Field" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style10">
                <asp:Label ID="Label4" runat="server" Text="Date Of Birth:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
            </td>
            <td class="style7">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtDateOfBirth" ErrorMessage="Incorrect Format" 
                    ForeColor="Red" 
                    ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style2" colspan="2">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
            </td>
            <td class="style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                </td>
            <td class="style5" colspan="2">
                &nbsp;</td>
            <td class="style9">
                </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style2" colspan="2">
                <asp:Label ID="lblFirstName" runat="server"></asp:Label>
            </td>
            <td class="style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style2" colspan="2">
                <asp:Label ID="lblLastName" runat="server"></asp:Label>
            </td>
            <td class="style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style2" colspan="2">
                <asp:Label ID="lblDateOfBirth" runat="server"></asp:Label>
            </td>
            <td class="style7">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
