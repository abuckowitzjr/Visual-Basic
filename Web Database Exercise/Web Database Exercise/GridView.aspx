<%@ Page Title="Grid View" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="GridView.aspx.vb" Inherits="Web_Database_Exercise._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="ISBN" DataSourceID="SqlDataSource1" Width="920px">
            <Columns>
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
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:RnrBooksConnectionString %>" 
            SelectCommand="SELECT [ISBN], [Title], [Author], [Publisher], [Subject_Code], [Shelf_Location], [Fiction] FROM [Books]">
        </asp:SqlDataSource>
    
    </div>
</asp:Content>
