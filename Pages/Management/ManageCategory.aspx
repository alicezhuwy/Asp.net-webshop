<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageCategory.aspx.cs" Inherits="Pages_Management_ManageCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="text-align:left;">
    <p > Category Name:</p>

    <p style="font-weight: 700" >
        <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
    </p>

    <p > Category Description:</p>

    <p style="text-decoration: underline" >
        <asp:TextBox ID="txtDescription" runat="server" Height="90px" TextMode="MultiLine" Width="393px"></asp:TextBox>
    </p>

    <p > 
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /> 
    </p>

    <p >
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label> 
    </p>
    </div>
   
</asp:Content>

