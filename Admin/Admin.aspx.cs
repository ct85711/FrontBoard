using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Admin_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] == null)
        {
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "refresh";
            meta.Content = "2;url=../Default.aspx";
            this.Page.Controls.Add(meta);
            lblMsg.Text = "You must login before accessing this page. Redirecting you in 5 seconds";
        }
        else
        {
            Customer login = (Customer)Session["login"];
            if (login.UserID.Equals("Admin") && login.Password.Equals("Admin"))
            {

            }
            else
            {
                lblMsg.Text = "You must login before accessing this page. Redirecting you in 5 seconds";
            }
        }
    }
    protected void btnCustomers_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
    }
}