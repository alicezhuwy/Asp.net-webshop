<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="AboutUs.aspx.cs" Inherits="Pages_AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick">
            </asp:Timer>
            <asp:Image ID="Image1" Width="1000px" Height="500px" margin="auto" runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
