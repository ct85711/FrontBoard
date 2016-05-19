<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs_ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
        .auto-style2 {
            height: 131px;
        }
        .auto-style3 {
            width: 139px;
        }
        .auto-style4 {
            height: 131px;
            width: 139px;
        }
        #TextArea1 {
            height: 115px;
            width: 512px;
            margin-top: 0px;
        }
        .auto-style5 {
            width: 139px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" Runat="Server">
    <asp:Label ID="lblCreateAccount" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Ask Us A Question"></asp:Label>
    <br />
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">First Name:</td>
            <td class="auto-style14">
                <asp:TextBox ID="txtFirstName" runat="server" Width="178px"></asp:TextBox>
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First name is required" ForeColor="#990000" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Last Name:</td>
            <td class="auto-style14">
                <asp:TextBox ID="txtLastName" runat="server" Width="178px"></asp:TextBox>
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last name is required" ForeColor="#990000" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>


        <tr>
            <td class="auto-style5">Email Address:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtEmail" runat="server" Width="178px"></asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email address is required" ForeColor="#990000" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Must be a valid email address" ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Enter Your Question:</td>
            <td class="auto-style2" colspan="2">
                <asp:TextBox ID="txtBox" runat="server" Height="109px" TextMode="MultiLine" Width="386px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtBox" ErrorMessage="Please Enter A Message" ForeColor="#990000"></asp:RequiredFieldValidator>
            </td>
        </tr>
            
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style12">
                <asp:Button ID="btnCreateAccount" runat="server" OnClick="btnCreateAccount_Click" Text="Send Question" Width="158px" />
            </td>
            <td class="auto-style8">
                <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

