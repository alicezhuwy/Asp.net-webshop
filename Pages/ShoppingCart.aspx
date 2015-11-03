<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Pages_ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlShoppingCart" runat="server" >

    </asp:Panel>

    <table>
        <tr>
            <td>
                <b>Total: </b>
            </td>
            <td>
                <asp:Literal ID="litTotal" runat="server" Text=""></asp:Literal>
            </td>
        </tr>

        <tr>
            <td>
                <b>Tax(15%): </b>
            </td>
            <td>
                <asp:Literal ID="litTax" runat="server" Text=""></asp:Literal>
            </td>
        </tr>

        <tr>
            <td>
                <b>Shipping Fee: </b>
            </td>
            <td>
                $10
            </td>
        </tr>

        <tr>
            <td>
                <b>Total Amount: </b>
            </td>
            <td>
                <asp:Literal ID="litTotalAmount" runat="server" Text=""></asp:Literal>
            </td>
        </tr>

        <tr>
            <td>
                <asp:LinkButton ID="linkContinue" runat="server" PostBackUrl="~/Pages/WebShop.aspx" Text="Continue Shopping"></asp:LinkButton>
                OR
                <asp:Button ID="btnCheckOut" runat="server" CssClass="button-management" Width="250px" Text="Continue to Checkout" OnClick="btnCheckOut_Click" />
            </td>
            <td>
                <asp:Button ID="btnClear" runat="server" CssClass="button-clear" Width="250px" Text="Empty My Cart" Color="" OnClick="btnClear_Click"/>

                <asp:Label ID="lblresult" runat="server" class="productPrice" Font-Bold="True" Font-Size="X-Large"></asp:Label>

            </td>
        </tr>
    </table>
</asp:Content>

