using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Hide Log In controls when we are logged in
        if (HttpContext.Current.Session["createAccount"] != null)
        {
            lblUserName.Visible = false;
            txtUserName.Visible = false;
            lblPassWord.Visible = false;
            txtPassword.Visible = false;
            btnLogin.Visible = false;
            btnCreateAcct.Visible = false;
            btnLogOut.Visible = true;
        }
    }

    protected void btnCreateAcct_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/CreateAccount/CreateAccount.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            try
            {
                var customer = FrontBoardDA.GetCustomerByUsername(txtUserName.Text);
                if (customer != null)
                {
                    Session.Add("createAccount", customer);
                    var meta = new HtmlMeta();
                    meta.HttpEquiv = "refresh";
                }
                else
                {
                    Response.Redirect("~/CreateAccount/CreateAccount.aspx");
                }
            }
            catch (Exception ex)
            {
                string msg = "Sorry, there was an error connecting to the database. Try again later.";
                Response.Write("<script>alert('" + msg + "')</script>");
            }
        }
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        // Clear user info
        Session.Remove("createAccount");

        // Show Log In controls
        lblUserName.Visible = true;
        txtUserName.Visible = true;
        lblPassWord.Visible = true;
        txtPassword.Visible = true;
        btnLogin.Visible = true;
        btnCreateAcct.Visible = true;
        btnLogOut.Visible = false;
        Response.Redirect("~/Default.aspx");
    }
}
