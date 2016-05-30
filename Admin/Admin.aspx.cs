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
        if (Session["createAccount"] == null)
        {
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "refresh";
            meta.Content = "5;url=../Default.aspx";
            this.Page.Controls.Add(meta);
            lblMsg.Text = "You must login before accessing this page. Redirecting you in 5 seconds.";
            btnQuestions.Visible = false;
        }
        else
        {
            Customer login = (Customer)Session["createAccount"];
            if (login.UserName.Equals("Admin") && login.Password.Equals("Admin"))
            {
                lblMsg.Visible = false;
                btnCustomers.Visible = true;
                btnQuestions.Visible = true;
                btnOrders.Visible = true;
                btnProducts.Visible = true;
            }
            else
            {
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "refresh";
                meta.Content = "5;url=../Default.aspx";
                this.Page.Controls.Add(meta);
                lblMsg.Text = "You must login before accessing this page. Redirecting you in 5 seconds";
            }
        }
    }
    protected void btnCustomers_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        DataList1.Visible = false;
        ListView1.Visible = false;
        DetailsView1.Visible = false;
    }
    protected void btnQuestions_Click(object sender, EventArgs e)
    {
        DataList1.Visible = true;
        GridView1.Visible = false;
        ListView1.Visible = false;
        DetailsView1.Visible = false;
    }
    protected void btnOrders_Click(object sender, EventArgs e)
    {
        DataList1.Visible = false;
        GridView1.Visible = false;
        ListView1.Visible = true;
        DetailsView1.Visible = false;
    }
    protected void btnProducts_Click(object sender, EventArgs e)
    {
        DataList1.Visible = false;
        GridView1.Visible = false;
        ListView1.Visible = false;
        DetailsView1.Visible = true;
    }
}