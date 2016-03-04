<%@ Page Title="Details View" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="DetailsView.aspx.vb" Inherits="Web_Database_Exercise._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
            AutoGenerateRows="False" CellPadding="4" DataKeyNames="ISBN" 
            DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
            Height="50px" Width="520px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" ReadOnly="True" 
                    SortExpression="ISBN" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Author" HeaderText="Author" 
                    SortExpression="Author" />
                <asp:BoundField DataField="Publisher" HeaderText="Publisher" 
                    SortExpression="Publisher" />
                <asp:BoundField DataField="Subject_Code" HeaderText="Subject_Code" 
                    SortExpression="Subject_Code" />
                <asp:BoundField DataField="Shelf_Location" HeaderText="Shelf_Location" 
                    SortExpression="Shelf_Location" />
                <asp:CheckBoxField DataField="Fiction" HeaderText="Fiction" 
                    SortExpression="Fiction" />
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:RnrBooksConnectionString %>" 
            SelectCommand="SELECT * FROM [Books]"></asp:SqlDataSource>
    
    </div>
</asp:Content>
