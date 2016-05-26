﻿<%@ Page Title="Create Account" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateAccount.aspx.cs" Inherits="CreateAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style7 {
            width: 127px;
            height: 80px;
        }
        .auto-style8 {
            height: 80px;
        }
        .auto-style12 {
            height: 80px;
            width: 199px;
        }
        .auto-style13 {
            width: 127px;
            height: 30px;
        }
        .auto-style14 {
            width: 199px;
            height: 30px;
        }
        .auto-style15 {
            height: 30px;
        }
        </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" Runat="Server">
    <asp:Label ID="lblCreateAccount" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Create an Account"></asp:Label>
    <br />
    <br />
    <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1" DefaultMode="Insert">
        <InsertItemTemplate>
            <table class="auto-style1">
                <tr>
            <td class="auto-style13">First Name:</td>
            <td class="auto-style14">
                <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FirstNameTextBox" ErrorMessage="First name is required" ForeColor="#990000"></asp:RequiredFieldValidator>
            </td>
        </tr>
                <tr>
            <td class="auto-style13">Last Name:</td>
            <td class="auto-style14">
                <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="LastNameTextBox" ErrorMessage="Last name is required" ForeColor="#990000"></asp:RequiredFieldValidator>
            </td>
        </tr>
                <tr>
            <td class="auto-style13">Address:</td>
            <td class="auto-style14">
                <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="AddressTextBox" ErrorMessage="Address is required" ForeColor="#990000"></asp:RequiredFieldValidator>
            </td>
        </tr>
                        <tr>
            <td class="auto-style13">City:</td>
            <td class="auto-style14">
                <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="CityTextBox" ErrorMessage="City is required" ForeColor="#990000"></asp:RequiredFieldValidator>
            </td>
        </tr>
                        <tr>
            <td class="auto-style13">State:</td>
            <td class="auto-style14">
                <asp:TextBox ID="StateTextBox" runat="server" Text='<%# Bind("State") %>' />
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="StateTextBox" ErrorMessage="State is required" ForeColor="#990000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Zipcode:</td>
            <td class="auto-style14">
                <asp:TextBox ID="ZipTextBox" runat="server" Text='<%# Bind("Zip") %>' />
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ZipTextBox" ErrorMessage="Zipcode is required" ForeColor="#990000" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="ZipTextBox" Display="Dynamic" ErrorMessage="Must be a valid zip code" ForeColor="#990000" ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Phone Number:</td>
            <td class="auto-style14">
                <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="PhoneTextBox" ErrorMessage="Phone number is required" ForeColor="#990000" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="PhoneTextBox" Display="Dynamic" ErrorMessage="Must be a valid phone number" ForeColor="#990000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Email Address:</td>
            <td class="auto-style14">
                <asp:TextBox ID="EmailAddressTextBox" runat="server" Text='<%# Bind("EmailAddress") %>' />
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="EmailAddressTextBox" ErrorMessage="Email address is required" ForeColor="#990000" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="EmailAddressTextBox" Display="Dynamic" ErrorMessage="Must be a valid email address" ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Username:</td>
            <td class="auto-style14">
                <asp:TextBox ID="UserNameTextBox" runat="server" Text='<%# Bind("UserName") %>' />
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="UserNameTextBox" ErrorMessage="Username is required" ForeColor="#990000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Password:</td>
            <td class="auto-style14">
                <asp:TextBox ID="PasswordTextBox" runat="server" Text='<%# Bind("Password") %>' />
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="Password is required" ForeColor="#990000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Confirm Password:</td>
            <td class="auto-style14">
                <asp:TextBox ID="txtConfirmPassword" runat="server" Width="178px" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="You must confirm your password" ForeColor="#990000" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="PasswordTextBox" ControlToValidate="txtConfirmPassword" Display="Dynamic" ErrorMessage="Both passwords must be the same" ForeColor="#990000"></asp:CompareValidator>
            </td>
        </tr>
                <tr>
            <td class="auto-style7">
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Create Account" />
            </td>
            <td class="auto-style12">
                <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                <%--<asp:Button ID="btnCreateAccount" runat="server" OnClick="btnCreateAccount_Click" Text="Create Account" Width="158px" />--%>
            </td>
            <td class="auto-style8">
                <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
            </table>
        </InsertItemTemplate>
       
    </asp:FormView>
<%--    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Customer" InsertMethod="InsertCustomer" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCustomers" TypeName="FrontBoardDA"></asp:ObjectDataSource>--%>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Customer" InsertMethod="InsertCustomer" OldValuesParameterFormatString="original_{0}" TypeName="FrontBoardDA"></asp:ObjectDataSource>

    <br />
    <br />
    <table class="auto-style1">
        
        
     
        
    </table>
</asp:Content>