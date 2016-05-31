using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Session["createAccount"] != null)
        {
            lblChanged.Visible = false;
            lblPassword.Visible = true;
            pnlChange.Visible = true;
            lblCreateAccount.Visible = false;
            FormView1.Visible = false;
        }
        else
        {
            lblCreateAccount.Visible = true;
            FormView1.Visible = true;
            lblChanged.Visible = false;
            lblPassword.Visible = false;
            pnlChange.Visible = false;
        }
    }

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

    protected void btnChangePasswod_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/CreateAccount/ChangePassword.aspx");
    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        Customer oldPass = FrontBoardDA.GetCustomerByUsername(txtChangeUsername.Text);
        if (oldPass != null)
        {
            if (oldPass.Password.Equals(txtCurrentPassword.Text))
            {
                oldPass.Password = txtConfirmNew.Text;
                FrontBoardDA.UpdateCustomer(oldPass);
                lblChanged.Text = "Changed Password!";
                lblChanged.Visible = true;
                txtChangeUsername.Text = " ";
                txtConfirmNew.Text = " ";
                txtCurrentPassword.Text = " ";
                txtNewPassword.Text = " ";
            }
            else
            {
                lblChanged.Visible = true;
                lblChanged.Text = "Password Not changed. Double check your Password entry.";
            }
        }
        else
        {
            lblChanged.Visible = true;
            lblChanged.Text = "Username not found in database";
        }
    }

    protected void InsertAccount(object sender, FormViewInsertedEventArgs e)
    {
        FormView item = sender as FormView;
        TextBox username = (TextBox)item.FindControl("UserNameTextBox");
        Customer loginCust = FrontBoardDA.GetCustomerByUsername(username.Text);

        Session["createAccount"] = loginCust;
        Response.Redirect("~/Default.aspx");
    }
} // End of class