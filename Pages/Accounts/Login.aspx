<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Accounts_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="table" Style="width:354px; margin-top:40px">
        <caption class="tableHead">&#9812 WELCOME BACK! &#9812</caption>
        <tr>
            <td class="auto-style10">Account Name:</td>
            <td class="auto-style11" >
                <asp:TextBox ID="txtName" runat="server" style="margin-left: 0px" Width="221px"></asp:TextBox>
            </td>            
        </tr>

        <tr>
            <td class="auto-style10">Password:</td>
            <td class="auto-style11" >
                <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 0px" TextMode="Password" Width="221px">
                </asp:TextBox>
            </td>
        </tr>

        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td style="text-align:right">
                <asp:button  style="margin-right:30px" class="button-secondary " id="btnlogin" runat="server" text="Login" onclick="btnsubmit_click" />
                <input  class="button-secondary " id="Reset1" type="reset" value="Reset" /> </td>     
        </tr>

        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td style="text-align:right">
                <asp:Label ID="lblResult" runat="server" Text="" Font-Bold="True" ForeColor="#FF3399"></asp:Label> </td>     
        </tr>
    </table>
</asp:Content>

