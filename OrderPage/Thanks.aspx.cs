﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderPage_Thanks : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        string theme = (string)Session["theme"];

        if (theme == null || theme.Equals("Default"))
        {
            Session["theme"] = "Default";
            Page.Theme = "Default";
        }
        else if (theme.Equals("Dark"))
        {
            Page.Theme = "Dark";
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        var invoice = (Invoice)Session["order"];

        if (invoice == null)
            Response.Redirect("~/Default.aspx");

        lblItem.Text = invoice.ItemId.ToString();
        lblOrderNumber.Text = invoice.OrderId.ToString();

        var cust = (Customer)Session["createAccount"];

        if(cust == null)
            Response.Redirect("~/Default.aspx");
        lblCustName.Text = cust.FirstName + " " + cust.LastName;
    }
}