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
    <asp:Label ID="lblLogin" runat="server" Text="You Must Create an Account to Order Items."></asp:Label>
    <br />
&nbsp;
    <br />
    <asp:Panel ID="TabelPanel" runat="server">
        <table class="auto-style1" id="Table1">
            <tr>
                <td class="auto-style2">Item</td>
                <td>Price</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Art Thing #123</td>
                <td class="auto-style4">$48.59</td>
                <td class="auto-style4">
                    <asp:Button ID="btnOrder1" runat="server" Text="Order Me!" OnClick="btnOrder1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Art Thing #234</td>
                <td>$345.45</td>
                <td>
                    <asp:Button ID="btnOrder2" runat="server" Text="Order Me!" OnClick="btnOrder2_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Art Thing #345</td>
                <td>$35.23</td>
                <td>
                    <asp:Button ID="btnOrder3" runat="server" Text="Order Me!" OnClick="btnOrder3_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Art Thing #456</td>
                <td>$34.54</td>
                <td>
                    <asp:Button ID="btnOrder4" runat="server" Text="Order Me!" OnClick="btnOrder4_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />
    <br />
</asp:Content>

