<%@ Page Title="About Us" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="AboutUs_AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 411px;
            height: 249px;
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" runat="Server">

    <div id="floatleft">
        <h2>River City Art Gallery</h2>
        <p>The River City Art Gallery, located in beautiful downtown River City has an impressive display of art from local artists! Founded in 1970 with a grant from the Art is Inspiration Foundation, the River City Art Gallery has been promoting local artisans and artwork by featuring their creations during exhibits.
    Many local artists have realized their fame utilizing our gallery, including Salvedore Dali, the Artist Known as Prince, and many others...
        </p>
        <p>Recently other local artists have started at the River City Art Gallery and gone on to national fame. These artists include John Buhrmann, John Schmidt, Nathan Jochum, Craig D., Chris Torske, and Brandon Welch.</p>
        <br />
        <asp:HyperLink ID="lnkContactUs" runat="server" NavigateUrl="~/ContactUs/ContactUs.aspx">Contact Us</asp:HyperLink>
        <br />
    </div>

    <div id="floatright">
        &nbsp;<img alt="Artwork by John Schmidt" class="auto-style1" src="../Images/JohnSchmidtArt.png" />
    </div>
</asp:Content>

