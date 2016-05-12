<%@ Page Title="Thanks" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Thanks.aspx.cs" Inherits="OrderPage_Thanks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" Runat="Server">
    Thank you for your Order,
<asp:Label ID="lblCustName" runat="server" Text="Label"></asp:Label>
.
    Your item, item number
    <asp:Label ID="lblItem" runat="server" Text="Label"></asp:Label>
    , is on its way!  
</asp:Content>

