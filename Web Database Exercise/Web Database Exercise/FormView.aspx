<%@ Page Title="Form View" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="FormView.aspx.vb" Inherits="Web_Database_Exercise._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
    
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="ISBN" 
            DataSourceID="SqlDataSource1" Height="174px" Width="206px" 
            AllowPaging="True" CellPadding="4" ForeColor="#333333">
            <EditItemTemplate>
                ISBN:
                <asp:Label ID="ISBNLabel1" runat="server" Text='<%# Eval("ISBN") %>' />
                <br />
                Title:
                <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' />
                <br />
                Author:
                <asp:TextBox ID="AuthorTextBox" runat="server" Text='<%# Bind("Author") %>' />
                <br />
                Publisher:
                <asp:TextBox ID="PublisherTextBox" runat="server" 
                    Text='<%# Bind("Publisher") %>' />
                <br />
                Subject_Code:
                <asp:TextBox ID="Subject_CodeTextBox" runat="server" 
                    Text='<%# Bind("Subject_Code") %>' />
                <br />
                Shelf_Location:
                <asp:TextBox ID="Shelf_LocationTextBox" runat="server" 
                    Text='<%# Bind("Shelf_Location") %>' />
                <br />
                Fiction:
                <asp:CheckBox ID="FictionCheckBox" runat="server" 
                    Checked='<%# Bind("Fiction") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                    CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                ISBN:
                <asp:TextBox ID="ISBNTextBox" runat="server" Text='<%# Bind("ISBN") %>' />
                <br />
                Title:
                <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' />
                <br />
                Author:
                <asp:TextBox ID="AuthorTextBox" runat="server" Text='<%# Bind("Author") %>' />
                <br />
                Publisher:
                <asp:TextBox ID="PublisherTextBox" runat="server" 
                    Text='<%# Bind("Publisher") %>' />
                <br />
                Subject_Code:
                <asp:TextBox ID="Subject_CodeTextBox" runat="server" 
                    Text='<%# Bind("Subject_Code") %>' />
                <br />
                Shelf_Location:
                <asp:TextBox ID="Shelf_LocationTextBox" runat="server" 
                    Text='<%# Bind("Shelf_Location") %>' />
                <br />
                Fiction:
                <asp:CheckBox ID="FictionCheckBox" runat="server" 
                    Checked='<%# Bind("Fiction") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                    CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                ISBN:
                <asp:Label ID="ISBNLabel" runat="server" Text='<%# Eval("ISBN") %>' />
                <br />
                Title:
                <asp:Label ID="TitleLabel" runat="server" Text='<%# Bind("Title") %>' />
                <br />
                Author:
                <asp:Label ID="AuthorLabel" runat="server" Text='<%# Bind("Author") %>' />
                <br />
                Publisher:
                <asp:Label ID="PublisherLabel" runat="server" Text='<%# Bind("Publisher") %>' />
                <br />
                Subject_Code:
                <asp:Label ID="Subject_CodeLabel" runat="server" 
                    Text='<%# Bind("Subject_Code") %>' />
                <br />
                Shelf_Location:
                <asp:Label ID="Shelf_LocationLabel" runat="server" 
                    Text='<%# Bind("Shelf_Location") %>' />
                <br />
                Fiction:
                <asp:CheckBox ID="FictionCheckBox" runat="server" 
                    Checked='<%# Bind("Fiction") %>' Enabled="false" />
                <br />

            </ItemTemplate>
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:RnrBooksConnectionString %>" 
            SelectCommand="SELECT [ISBN], [Title], [Author], [Publisher], [Subject_Code], [Shelf_Location], [Fiction] FROM [Books]">
        </asp:SqlDataSource>
    
    </div>
</asp:Content>
