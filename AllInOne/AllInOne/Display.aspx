<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Display.aspx.vb" Inherits="AllInOne.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Id" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="IPAddress" HeaderText="IPAddress" 
                    SortExpression="IPAddress" />
                <asp:BoundField DataField="Date_Time" HeaderText="Date_Time" 
                    SortExpression="Date_Time" />
                <asp:BoundField DataField="Count" HeaderText="Count" SortExpression="Count" />
                <asp:BoundField DataField="Comments" HeaderText="Comments" 
                    SortExpression="Comments" />
            </Columns>
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/vb2012.mdb" 
            DeleteCommand="DELETE FROM [Clients] WHERE [Id] = ?" 
            InsertCommand="INSERT INTO [Clients] ([Id], [IPAddress], [Date_Time], [Count], [Comments]) VALUES (?, ?, ?, ?, ?)" 
            SelectCommand="SELECT [Id], [IPAddress], [Date_Time], [Count], [Comments] FROM [Clients]" 
            UpdateCommand="UPDATE [Clients] SET [IPAddress] = ?, [Date_Time] = ?, [Count] = ?, [Comments] = ? WHERE [Id] = ?">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Id" Type="Int32" />
                <asp:Parameter Name="IPAddress" Type="String" />
                <asp:Parameter Name="Date_Time" Type="DateTime" />
                <asp:Parameter Name="Count" Type="Int32" />
                <asp:Parameter Name="Comments" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="IPAddress" Type="String" />
                <asp:Parameter Name="Date_Time" Type="DateTime" />
                <asp:Parameter Name="Count" Type="Int32" />
                <asp:Parameter Name="Comments" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:AccessDataSource>
        <br />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
