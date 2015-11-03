<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SingleProduct.aspx.cs" Inherits="Pages_SingleProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table >
        <tr>
            <td style="width: 400px" rowspan="7" >
                <asp:Image ID="imgProdcut" runat="server" class="detailImage " />
            </td>
            <td class="auto-style9">
                <h2 >
                    <asp:Label ID="lblTitle" runat="server" class="productName" ></asp:Label>
                </h2>
                <h3 >
                     <asp:Label ID="lblSupplier" runat="server" class="supplierName" ></asp:Label>
                </h3>
            </td>
        </tr>

        <tr>

            <td  style="width: 600px; margin-left: 50px" class="auto-style9">
                <p class="titleDescription">Description</p>
                <asp:Label ID="lblDescription" runat="server" class="productDescription" ></asp:Label>
                <br />
                <br />
            </td>
            </br>         
            
        </tr>

        <tr>
            <td class="auto-style9">
                <asp:Label ID="lblProductNum" runat="server" class="productNumber"></asp:Label>
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style9">
                Available Color<asp:Label ID="lblColor" runat="server" class="productPrice" > </asp:Label>
                <br />
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style9">
                Hot Price<asp:Label ID="lblPrice" runat="server" class="productPrice" ></asp:Label>
                <br />
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style9">
                 Quantity:
                <asp:DropDownList ID="ddlQuantity" runat="server" ></asp:DropDownList>
                 <br />
                 <br />
                <asp:Button ID="btnAdd" runat="server" CssClass="button-management" OnClick="btnAdd_Click" Text="Add to Cart" />
                 <br />
            </td>
        </tr>

        <tr>
             <td class="auto-style9">
                 <asp:Label ID="lblResult" runat="server" class="productPrice" Font-Bold="True" Font-Size="X-Large" >Available!</asp:Label>
                  <asp:Label ID="lbltest1" runat="server" class="productPrice" Font-Bold="True" Font-Size="X-Large" ></asp:Label>
                 <asp:Label ID="lbltest2" runat="server" class="productPrice" Font-Bold="True" Font-Size="X-Large" ></asp:Label>
                 <br />
            </td>
        </tr>
    </table>

</asp:Content>

