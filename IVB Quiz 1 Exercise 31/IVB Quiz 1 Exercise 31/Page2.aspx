<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Page2.aspx.vb" Inherits="IVB_Quiz_1_Exercise_31.Page2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 484px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>
            <td class="style1">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="2px" 
        CellPadding="4" DataKeyNames="StudentId" DataSourceID="StudentInfo" 
        Height="237px" HorizontalAlign="Left" Width="607px">
        <Columns>
            <asp:BoundField DataField="StudentId" HeaderText="Student Id" 
                InsertVisible="False" ReadOnly="True" SortExpression="StudentId" />
            <asp:BoundField DataField="FirstName" HeaderText="First Name" 
                SortExpression="FirstName" ApplyFormatInEditMode="True" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" 
                SortExpression="LastName" />
            <asp:BoundField DataField="DOB" HeaderText="Date of Birth" 
                SortExpression="DOB" DataFormatString="{0:d}" />
            <asp:CommandField ButtonType="Button" EditText="Modify" 
                ShowCancelButton="False" ShowEditButton="True" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <asp:SqlDataSource ID="StudentInfo" runat="server" 
        ConnectionString="<%$ ConnectionStrings:studentsConnectionString %>" 
        
        SelectCommand="SELECT [FirstName], [LastName], [StudentId], [DOB] FROM [students]" 
        DeleteCommand="DELETE FROM [students] WHERE [StudentId] = @StudentId" 
        InsertCommand="INSERT INTO [students] ([FirstName], [LastName], [DOB]) VALUES (@FirstName, @LastName, @DOB)" 
        UpdateCommand="UPDATE [students] SET [FirstName] = @FirstName, [LastName] = @LastName, [DOB] = @DOB WHERE [StudentId] = @StudentId">
        <DeleteParameters>
            <asp:Parameter Name="StudentId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="DOB" Type="DateTime" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="DOB" Type="DateTime" />
            <asp:Parameter Name="StudentId" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
