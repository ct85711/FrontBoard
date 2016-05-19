<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" Runat="Server">
    <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="btnCustomers" runat="server" OnClick="btnCustomers_Click" Text="Customer List" Visible="False" Width="121px" />
    &nbsp;
    <asp:Button ID="btnQuestions" runat="server" Text="Customer Questions" Width="139px" OnClick="btnQuestions_Click" Visible="False" />
    &nbsp;<asp:Button ID="btnOrders" runat="server" OnClick="btnOrders_Click" Text="Orders" Visible="False" Width="149px" />
<br />
<asp:ListView ID="ListView1" runat="server" DataKeyNames="OrderId" DataSourceID="SqlDataSource3" Visible="False">
    <AlternatingItemTemplate>
        <tr style="background-color: #FFF8DC;">
            <td>
                <asp:Label ID="OrderIdLabel" runat="server" Text='<%# Eval("OrderId") %>' />
            </td>
            <td>
                <asp:Label ID="ItemIdLabel" runat="server" Text='<%# Eval("ItemId") %>' />
            </td>
            <td>
                <asp:Label ID="UserIdLabel" runat="server" Text='<%# Eval("UserId") %>' />
            </td>
            <td>
                <asp:Label ID="OrderDateLabel" runat="server" Text='<%# Eval("OrderDate") %>' />
            </td>
        </tr>
    </AlternatingItemTemplate>
    <EditItemTemplate>
        <tr style="background-color: #008A8C; color: #FFFFFF;">
            <td>
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            </td>
            <td>
                <asp:Label ID="OrderIdLabel1" runat="server" Text='<%# Eval("OrderId") %>' />
            </td>
            <td>
                <asp:TextBox ID="ItemIdTextBox" runat="server" Text='<%# Bind("ItemId") %>' />
            </td>
            <td>
                <asp:TextBox ID="UserIdTextBox" runat="server" Text='<%# Bind("UserId") %>' />
            </td>
            <td>
                <asp:TextBox ID="OrderDateTextBox" runat="server" Text='<%# Bind("OrderDate") %>' />
            </td>
        </tr>
    </EditItemTemplate>
    <EmptyDataTemplate>
        <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
            <tr>
                <td>No data was returned.</td>
            </tr>
        </table>
    </EmptyDataTemplate>
    <InsertItemTemplate>
        <tr style="">
            <td>
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:TextBox ID="ItemIdTextBox" runat="server" Text='<%# Bind("ItemId") %>' />
            </td>
            <td>
                <asp:TextBox ID="UserIdTextBox" runat="server" Text='<%# Bind("UserId") %>' />
            </td>
            <td>
                <asp:TextBox ID="OrderDateTextBox" runat="server" Text='<%# Bind("OrderDate") %>' />
            </td>
        </tr>
    </InsertItemTemplate>
    <ItemTemplate>
        <tr style="background-color: #DCDCDC; color: #000000;">
            <td>
                <asp:Label ID="OrderIdLabel" runat="server" Text='<%# Eval("OrderId") %>' />
            </td>
            <td>
                <asp:Label ID="ItemIdLabel" runat="server" Text='<%# Eval("ItemId") %>' />
            </td>
            <td>
                <asp:Label ID="UserIdLabel" runat="server" Text='<%# Eval("UserId") %>' />
            </td>
            <td>
                <asp:Label ID="OrderDateLabel" runat="server" Text='<%# Eval("OrderDate") %>' />
            </td>
        </tr>
    </ItemTemplate>
    <LayoutTemplate>
        <table runat="server">
            <tr runat="server">
                <td runat="server">
                    <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
                        <tr runat="server" style="background-color: #DCDCDC; color: #000000;">
                            <th runat="server">OrderId</th>
                            <th runat="server">ItemId</th>
                            <th runat="server">UserId</th>
                            <th runat="server">OrderDate</th>
                        </tr>
                        <tr id="itemPlaceholder" runat="server">
                        </tr>
                    </table>
                </td>
            </tr>
            <tr runat="server">
                <td runat="server" style="text-align: center; background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000000;">
                    <asp:DataPager ID="DataPager1" runat="server">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                        </Fields>
                    </asp:DataPager>
                </td>
            </tr>
        </table>
    </LayoutTemplate>
    <SelectedItemTemplate>
        <tr style="background-color: #008A8C; font-weight: bold; color: #FFFFFF;">
            <td>
                <asp:Label ID="OrderIdLabel" runat="server" Text='<%# Eval("OrderId") %>' />
            </td>
            <td>
                <asp:Label ID="ItemIdLabel" runat="server" Text='<%# Eval("ItemId") %>' />
            </td>
            <td>
                <asp:Label ID="UserIdLabel" runat="server" Text='<%# Eval("UserId") %>' />
            </td>
            <td>
                <asp:Label ID="OrderDateLabel" runat="server" Text='<%# Eval("OrderDate") %>' />
            </td>
        </tr>
    </SelectedItemTemplate>
</asp:ListView>
<asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [OrderId], [ItemId], [UserId], [OrderDate] FROM [Invoice]"></asp:SqlDataSource>
<br />
    <br />
<asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource2" Visible="False">
    <ItemTemplate>
        FirstName:
        <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
        <br />
        LastName:
        <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
        <br />
        Email:
        <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
        <br />
        Question:
        <asp:Label ID="QuestionLabel" runat="server" Text='<%# Eval("Question") %>' />
        <br />
<br />
    </ItemTemplate>
</asp:DataList>
<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [FirstName], [LastName], [Email], [Question] FROM [Questions]"></asp:SqlDataSource>
<br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Visible="False">
    <Columns>
        <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
        <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
        <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
        <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
        <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
        <asp:BoundField DataField="Zip" HeaderText="Zip" SortExpression="Zip" />
        <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
        <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress" />
        <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
        <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
    </Columns>
</asp:GridView>
<br />
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [FirstName], [LastName], [Address], [City], [State], [Zip], [Phone], [EmailAddress], [UserName], [Password] FROM [Customer]"></asp:SqlDataSource>
<br />
</asp:Content>

