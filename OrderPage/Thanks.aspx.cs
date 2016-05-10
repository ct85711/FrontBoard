using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderPage_Thanks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Invoice invoice1 = (Invoice)Session["Order"];
        lblItem.Text = invoice1.ItemId.ToString();
    }
}