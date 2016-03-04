<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="Final_Exam_Question_62._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 74px;
        }
        .style3
        {
            width: 933px;
        }
        .style4
        {
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table style="width:100%;">
        <tr>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style4">
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    DataSourceID="SqlDataSource1" DataTextField="StudentId" 
                    DataValueField="StudentId">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:studentsConnectionString3 %>" 
                    SelectCommand="SELECT [StudentId], [FirstName], [LastName], [DOB] FROM [students] WHERE ([StudentId] = @StudentId) ORDER BY [StudentId]">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="StudentId" 
                            PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1" colspan="2" rowspan="2">
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
                    DataSourceID="SqlDataSource2" Height="50px" Width="125px">
                    <Fields>
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" 
                            SortExpression="FirstName" />
                        <asp:BoundField DataField="LastName" HeaderText="LastName" 
                            SortExpression="LastName" />
                        <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
                    </Fields>
                </asp:DetailsView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:studentsConnectionString3 %>" 
                    SelectCommand="SELECT [FirstName], [LastName], [DOB] FROM [students]">
                </asp:SqlDataSource>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
        </tr>
    </table>
    </asp:Content>
