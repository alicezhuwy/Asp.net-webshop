<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Accounts_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    
    <table class="table" >
        <caption class="tableHead">&#9812 REGIST AS OUR CUSTOMER &#9812</caption>
        <tr>
            <td class="auto-style6">Account Name:</td>
            <td class="auto-style7" >
                <asp:TextBox ID="txtName" runat="server" style="margin-left: 0px" Width="221px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="valName" runat="server" ControlToValidate="txtName" ErrorMessage="Account name is required." ForeColor="Aqua"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Password:</td>
            <td class="auto-style7" >
                <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 0px" TextMode="Password" Width="221px"> </asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="valPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required." ForeColor="#9900FF"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Confirm Password:</td>
            <td class="auto-style7" >
                <asp:TextBox ID="txtConfirmPassword" runat="server" style="margin-left: 0px" TextMode="Password" Width="221px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="valConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Please re-enter password." ForeColor="#FF3399"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="valComparePassword" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Please enter the same password." ForeColor="#660066"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Phone Number:</td>
            <td class="auto-style7" >
                <asp:TextBox ID="txtPhoneNumber" runat="server" style="margin-left: 0px" Width="221px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="valPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" ErrorMessage="Phone number is required." ForeColor="#FF9933"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Email Address:</td>
            <td class="auto-style7" >
                <asp:TextBox ID="txtEmailAddress" runat="server" style="margin-left: 0px" Width="221px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="valEmailAddress" runat="server" ControlToValidate="txtEmailAddress" ErrorMessage="Email address is required." ForeColor="#999999"></asp:RequiredFieldValidator>
            </td>
        </tr>
 

        <tr>
            <td class="auto-style6">Home Address:</td>
            <td class="auto-style7" >
                <asp:TextBox ID="txtHomeAddress" runat="server" style="margin-left: 0px" Width="221px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="valHomeAddress0" runat="server" ControlToValidate="txtHomeAddress" ErrorMessage="Home address is required." ForeColor="#999999"></asp:RequiredFieldValidator>
            </td>
        </tr>
 

        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td >
                <asp:Button  style="margin-right:30px" class="button-secondary " ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <input  class="button-secondary " id="Reset1" type="reset" value="Reset" /></td>
            <td class="auto-style8">
                &nbsp;</td>
        </tr>
 

        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td >
                <asp:Label ID="lblResult" runat="server" Font-Bold="True" ForeColor="#FF3399"></asp:Label>
            </td>
            <td class="auto-style8">
                &nbsp;</td>
        </tr>
 

    </table>

    
</asp:Content>

