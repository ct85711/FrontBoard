<%@ Page Title="Site Map" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Navigation.aspx.cs" Inherits="AboutUs_Navigation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" Runat="Server">
    <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
    </asp:TreeView>
    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false"/>
</asp:Content>

