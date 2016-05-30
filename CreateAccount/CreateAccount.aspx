<%@ Page Title="Create Account" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateAccount.aspx.cs" Inherits="CreateAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style7 {
            width: 127px;
        }

        .auto-style12 {
            width: 199px;
        }

        .auto-style13 {
            width: 127px;
        }

        .auto-style14 {
            width: 199px;
        }

        .auto-style16 {
            width: 159px;
        }

        .auto-style17 {
            width: 168px;
        }

        .auto-style19 {
            width: 159px;
        }

        .auto-style20 {
            width: 168px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" runat="Server">
    <asp:Label ID="lblCreateAccount" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Create an Account"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:Label ID="lblPassword" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Change Password"></asp:Label>
    <br />
    <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1" DefaultMode="Insert" CellPadding="4" ForeColor="#333333">
        <EditRowStyle BackColor="transparent" CssClass="validator" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <InsertItemTemplate>
            <table class="validator">
                <tr>
                    <td class="auto-style13">First Name:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FirstNameTextBox" ErrorMessage="First name is required" ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Last Name:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="LastNameTextBox" ErrorMessage="Last name is required" ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Address:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="AddressTextBox" ErrorMessage="Address is required" ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">City:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="CityTextBox" ErrorMessage="City is required" ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">State:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="StateTextBox" runat="server" Text='<%# Bind("State") %>' />
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="StateTextBox" ErrorMessage="State is required" ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Zipcode:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="ZipTextBox" runat="server" Text='<%# Bind("Zip") %>' />
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ZipTextBox" ErrorMessage="Zipcode is required" ForeColor="#990000" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="ZipTextBox" Display="Dynamic" ErrorMessage="Must be a valid zip code" ForeColor="#990000" ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Phone Number:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="PhoneTextBox" ErrorMessage="Phone number is required" ForeColor="#990000" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="PhoneTextBox" Display="Dynamic" ErrorMessage="Must be a valid phone number" ForeColor="#990000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Email Address:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="EmailAddressTextBox" runat="server" Text='<%# Bind("EmailAddress") %>' />
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="EmailAddressTextBox" ErrorMessage="Email address is required" ForeColor="#990000" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="EmailAddressTextBox" Display="Dynamic" ErrorMessage="Must be a valid email address" ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Username:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="UserNameTextBox" runat="server" Text='<%# Bind("UserName") %>' />
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="UserNameTextBox" ErrorMessage="Username is required" ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Password:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="PasswordTextBox" runat="server" Text='<%# Bind("Password") %>' TextMode="Password" />
                    </td>
                    <td class="validator">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="Password is required" ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Confirm Password:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="validator">
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
                    <td class="validator">
                        <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </InsertItemTemplate>
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
    </asp:FormView>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Panel ID="pnlChange" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style17">Username:</td>
                <td class="auto-style16">
                    <asp:TextBox ID="txtChangeUsername" runat="server" Style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td class="validator">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtChangeUsername" ErrorMessage="Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">Current Password:</td>
                <td class="auto-style19">
                    <asp:TextBox ID="txtCurrentPassword" runat="server" Style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td class="validator">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtCurrentPassword" ErrorMessage="Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">New Password:</td>
                <td class="auto-style19">
                    <asp:TextBox ID="txtNewPassword" runat="server" Style="margin-bottom: 0px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="validator">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtNewPassword" ErrorMessage="Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">Confirm New Password:</td>
                <td class="auto-style19">
                    <asp:TextBox ID="txtConfirmNew" runat="server" Style="margin-bottom: 0px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="validator">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtConfirmNew" Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtNewPassword" ControlToValidate="txtConfirmNew" ErrorMessage="Passwords Don't Match" ForeColor="#CC0000"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style19">
                    <asp:Button ID="btnChange" runat="server" OnClick="btnChange_Click" Text="Change Password" />
                </td>
                <td class="validator">&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    &nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblChanged" runat="server" Text="Label" Visible="False"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Customer" InsertMethod="InsertCustomer" OldValuesParameterFormatString="original_{0}" TypeName="FrontBoardDA"></asp:ObjectDataSource>

</asp:Content>
