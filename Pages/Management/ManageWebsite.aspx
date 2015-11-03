<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageWebsite.aspx.cs" Inherits="Pages_Management_ManageWebsite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align:left; color: #FF00FF; text-decoration: underline;">
        <br />
        <br />
        <br />
        <asp:LinkButton ID="lbtnProduct" runat="server" Class="button-management" PostBackUrl="~/Pages/Management/ManageProduct.aspx">Add New Product</asp:LinkButton>

        <br />
        <br />

        <asp:GridView ID="gvProducts" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2" Width="99%" OnRowEditing="gvProducts_RowEditing1" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" SortExpression="SupplierID" />
                <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
                <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ZHUW15sqlserver1ConnectionString %>" DeleteCommand="DELETE FROM [Product] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Product] ([CategoryID], [Name], [Price], [Description], [SupplierID], [Color], [Image]) VALUES (@CategoryID, @Name, @Price, @Description, @SupplierID, @Color, @Image)" SelectCommand="SELECT * FROM [Product]" UpdateCommand="UPDATE [Product] SET [CategoryID] = @CategoryID, [Name] = @Name, [Price] = @Price, [Description] = @Description, [SupplierID] = @SupplierID, [Color] = @Color, [Image] = @Image WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Price" Type="Int32" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="SupplierID" Type="Int32" />
                <asp:Parameter Name="Color" Type="String" />
                <asp:Parameter Name="Image" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Price" Type="Int32" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="SupplierID" Type="Int32" />
                <asp:Parameter Name="Color" Type="String" />
                <asp:Parameter Name="Image" Type="String" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <asp:LinkButton ID="lbtnCategory" runat="server" Class="button-management" PostBackUrl="~/Pages/Management/ManageCategory.aspx" >Add New Category</asp:LinkButton>

        <br />
        <br />

        <asp:GridView ID="gvCategory" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource3" Width="70%" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="359px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ZHUW15sqlserver1ConnectionString %>" DeleteCommand="DELETE FROM [Category] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Category] ([Name], [Description]) VALUES (@Name, @Description)" SelectCommand="SELECT * FROM [Category]" UpdateCommand="UPDATE [Category] SET [Name] = @Name, [Description] = @Description WHERE [ID] = @ID">
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
        <br />
        <br />
        <br />
        <br />
        <asp:LinkButton ID="lbtnSupplier" runat="server" Class="button-management" PostBackUrl="~/Pages/Management/ManageSupplier.aspx" >Add New Supplier</asp:LinkButton>

        <br />
        <br />

        <asp:GridView ID="gvSupplier" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource4" Width="70%" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" >
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
                <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ZHUW15sqlserver1ConnectionString %>" DeleteCommand="DELETE FROM [Supplier] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Supplier] ([Name], [PhoneNumber], [EmailAddress]) VALUES (@Name, @PhoneNumber, @EmailAddress)" SelectCommand="SELECT * FROM [Supplier]" UpdateCommand="UPDATE [Supplier] SET [Name] = @Name, [PhoneNumber] = @PhoneNumber, [EmailAddress] = @EmailAddress WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="PhoneNumber" Type="String" />
                <asp:Parameter Name="EmailAddress" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="PhoneNumber" Type="String" />
                <asp:Parameter Name="EmailAddress" Type="String" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <br />
        <br />
        <br />
        <br />
        MODIFY A USER<br />
        <br />

        <asp:GridView ID="gvClient" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal" style="margin-right: 0px" Width="749px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
                <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress" />
                <asp:BoundField DataField="HomeAddress" HeaderText="HomeAddress" SortExpression="HomeAddress" />
                <asp:CheckBoxField DataField="ActiveUser" HeaderText="ActiveUser" SortExpression="ActiveUser" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZHUW15sqlserver1ConnectionString %>" DeleteCommand="DELETE FROM [Client] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Client] ([Name], [Password], [PhoneNumber], [EmailAddress], [HomeAddress], [ActiveUser]) VALUES (@Name, @Password, @PhoneNumber, @EmailAddress, @HomeAddress, @ActiveUser)" SelectCommand="SELECT * FROM [Client]" UpdateCommand="UPDATE [Client] SET [Name] = @Name, [Password] = @Password, [PhoneNumber] = @PhoneNumber, [EmailAddress] = @EmailAddress, [HomeAddress] = @HomeAddress, [ActiveUser] = @ActiveUser WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="PhoneNumber" Type="String" />
                <asp:Parameter Name="EmailAddress" Type="String" />
                <asp:Parameter Name="HomeAddress" Type="String" />
                <asp:Parameter Name="ActiveUser" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="PhoneNumber" Type="String" />
                <asp:Parameter Name="EmailAddress" Type="String" />
                <asp:Parameter Name="HomeAddress" Type="String" />
                <asp:Parameter Name="ActiveUser" Type="Boolean" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        MODIFY A ORDER<br />
        <br />
        <asp:GridView ID="gvORDER" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource5" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="ClientID" HeaderText="ClientID" SortExpression="ClientID" />
                <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:BoundField DataField="TotalAmount" HeaderText="TotalAmount" SortExpression="TotalAmount" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:ZHUW15sqlserver1ConnectionString %>" DeleteCommand="DELETE FROM [Order] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Order] ([ClientID], [OrderDate], [Status], [TotalAmount]) VALUES (@ClientID, @OrderDate, @Status, @TotalAmount)" SelectCommand="SELECT * FROM [Order]" UpdateCommand="UPDATE [Order] SET [ClientID] = @ClientID, [OrderDate] = @OrderDate, [Status] = @Status, [TotalAmount] = @TotalAmount WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ClientID" Type="Int32" />
                <asp:Parameter Name="OrderDate" Type="DateTime" />
                <asp:Parameter Name="Status" Type="String" />
                <asp:Parameter Name="TotalAmount" Type="Double" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ClientID" Type="Int32" />
                <asp:Parameter Name="OrderDate" Type="DateTime" />
                <asp:Parameter Name="Status" Type="String" />
                <asp:Parameter Name="TotalAmount" Type="Double" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        MODIFY A SHOPPING CART CONTENT<br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource6" ForeColor="Black" GridLines="Horizontal" Width="829px">
            <Columns>
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="ClientID" HeaderText="ClientID" SortExpression="ClientID" />
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" SortExpression="ProductID" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:BoundField DataField="TotalCost" HeaderText="TotalCost" SortExpression="TotalCost" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:BoundField DataField="DataPurchased" HeaderText="DataPurchased" SortExpression="DataPurchased" />
                <asp:CheckBoxField DataField="IsInCart" HeaderText="IsInCart" SortExpression="IsInCart" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:ZHUW15sqlserver1ConnectionString %>" DeleteCommand="DELETE FROM [Cart] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Cart] ([ClientID], [ProductID], [Status], [TotalCost], [Quantity], [DataPurchased], [IsInCart]) VALUES (@ClientID, @ProductID, @Status, @TotalCost, @Quantity, @DataPurchased, @IsInCart)" SelectCommand="SELECT * FROM [Cart]" UpdateCommand="UPDATE [Cart] SET [ClientID] = @ClientID, [ProductID] = @ProductID, [Status] = @Status, [TotalCost] = @TotalCost, [Quantity] = @Quantity, [DataPurchased] = @DataPurchased, [IsInCart] = @IsInCart WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ClientID" Type="Int32" />
                <asp:Parameter Name="ProductID" Type="Int32" />
                <asp:Parameter Name="Status" Type="String" />
                <asp:Parameter Name="TotalCost" Type="Int32" />
                <asp:Parameter Name="Quantity" Type="Int32" />
                <asp:Parameter Name="DataPurchased" Type="DateTime" />
                <asp:Parameter Name="IsInCart" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ClientID" Type="Int32" />
                <asp:Parameter Name="ProductID" Type="Int32" />
                <asp:Parameter Name="Status" Type="String" />
                <asp:Parameter Name="TotalCost" Type="Int32" />
                <asp:Parameter Name="Quantity" Type="Int32" />
                <asp:Parameter Name="DataPurchased" Type="DateTime" />
                <asp:Parameter Name="IsInCart" Type="Boolean" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />

    </div>
    
</asp:Content>

