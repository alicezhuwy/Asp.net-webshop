<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageProduct.aspx.cs" Inherits="Pages_Management_ManageProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align:left;">
    <p >Product Name</p>

    <p >
        <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
    </p>

    <p >Category</p>

    <p >
        <asp:DropDownList ID="ddlCategory" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZHUW15sqlserver1ConnectionString %>" SelectCommand="SELECT * FROM [Category] ORDER BY [Name]"></asp:SqlDataSource>
    </p>

    <p> Price</p>
    
    <p >
        <asp:TextBox ID="txtPrice" runat="server" ></asp:TextBox>
    </p>

    <p >Color</p>

    <p >
        <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
    </p>

    <p>
        Supplier</p>
    <p>
        <asp:DropDownList ID="ddlSupplier" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="ID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ZHUW15sqlserver1ConnectionString %>" SelectCommand="SELECT * FROM [Supplier] ORDER BY [Name]"></asp:SqlDataSource>
    </p>
    <p>
        Image</p>
    <p>
        <asp:DropDownList ID="ddlImage" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        Description</p>
    <p>
        <asp:TextBox ID="txtDescription" runat="server" Height="90px" TextMode="MultiLine" Width="393px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </p>
    <p>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>
    </div>
</asp:Content>

