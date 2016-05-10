using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderPage_Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["createAccount"] != null)
        {
            lblLogin.Visible = false;
            TabelPanel.Visible = true;
        }
        else
        {
            TabelPanel.Visible = false;
            lblLogin.Visible = true;
        }
    }

    private void orderItem(int itemID)
    {
        int userID = 1;
        Invoice newInvoice = new Invoice(itemID, userID);
        Session.Add("Order", newInvoice);

        // SEND AN EMAIL TO OURSELVES / CREATE AN ORDER IN THE DB

        Response.Redirect("~/OrderPage/Thanks.aspx");
    }
    protected void btnOrder1_Click(object sender, EventArgs e)
    {
        int itemID = 123;
        orderItem(itemID);
    }
    protected void btnOrder2_Click(object sender, EventArgs e)
    {
        int itemID = 234;
        orderItem(itemID);
    }
    protected void btnOrder3_Click(object sender, EventArgs e)
    {
        int itemID = 345;
        orderItem(itemID);
    }
    protected void btnOrder4_Click(object sender, EventArgs e)
    {
        int itemID = 456;
        orderItem(itemID);
    }
}