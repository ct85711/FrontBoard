<%@ Page Title="Order" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="OrderPage_Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 96%;
        }
        .auto-style2 {
            width: 205px;
        }
    .auto-style3 {
        width: 205px;
        height: 30px;
    }
    .auto-style4 {
        height: 30px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" Runat="Server">
    <asp:Label ID="lblLogin" runat="server" Text="You Must Create an Account to Order Items." ForeColor="Red"></asp:Label>
<br />
&nbsp;
<br />
    <asp:Table ID="Table1" runat="server" BorderWidth="1px" GridLines="Both">
    </asp:Table>
<br />
<br />
</asp:Content>

