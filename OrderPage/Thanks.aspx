﻿<%@ Page Title="Thanks" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Thanks.aspx.cs" Inherits="OrderPage_Thanks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" Runat="Server">
    Thank you for your order, <asp:Label ID="lblCustName" runat="server" Text="Label" />.

    Your item, item #<asp:Label ID="lblItem" runat="server" Text="Label" />, is on its way!
    <br /> <br />
    Your order number is <asp:Label ID="lblOrderNumber" runat="server" Text="Label" />. Please keep this for your records.
      
</asp:Content>

