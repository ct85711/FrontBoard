<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="CreateAccount_ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 93%;
        }
        .auto-style2 {
            width: 158px;
        }
        .auto-style3 {
            width: 142px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Username:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtUsername" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Current Password:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtCurrentPassword" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCurrentPassword" ErrorMessage="Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">New Password:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtNewPassword" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNewPassword" ErrorMessage="Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Confirm New Password:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtConfirmPassword" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtConfirmPassword" Display="Dynamic" ErrorMessage="Required"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Passwords Don't Match"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

