<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WebShop.aspx.cs" Inherits="Pages_WebShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <asp:DropDownList style="float:left" ID="ddlList" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True">
            <asp:ListItem Value="(All)"></asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZHUW15sqlserver1ConnectionString %>" DeleteCommand="DELETE FROM [Category] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Category] ([Name], [Description]) VALUES (@Name, @Description)" SelectCommand="SELECT * FROM [Category]" UpdateCommand="UPDATE [Category] SET [Name] = @Name, [Description] = @Description WHERE [ID] = @ID">
            
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    <asp:Panel ID="panAllProduct" runat="server" align="center" style="margin-top:40px">

    </asp:Panel>

    <div style="clear: both">
    </div>
</asp:Content>

