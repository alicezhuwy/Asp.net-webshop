﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageSupplier.aspx.cs" Inherits="Pages_Management_ManageSupplier" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    <div style="text-align:left;">
    <p> Supplier Name:</p>

    <p >
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </p>

    <p> Phone Number:</p>

    <p >
        <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
    </p>

    <p> Email Address:</p>

    <p >
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </p>

    <p > 
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /> 
    </p>

    <p >
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label> 
    </p>

    </div>
</asp:Content>

