﻿using System;
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
            pnlCreate.Visible = false;
        }
        else
        {
            lblCreateAccount.Visible = true;
            pnlCreate.Visible = true;
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

    protected void btnCreateAccount_Click(object sender, EventArgs e)
    {
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string address = txtAddress.Text;
        string city = txtCity.Text;
        string state = txtState.Text;
        string zipcode = txtZip.Text;
        string phone = txtPhone.Text;
        string email = txtEmail.Text;
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        try
        {
            var cust = FrontBoardDA.GetCustomerByUsername(username);

            if (cust == null)
            {
                lblErrorMessage.Text = string.Empty;

                Customer newCustomer = new Customer(firstName, lastName, address, city, state, zipcode, phone, email, username, password);

                FrontBoardDA.InsertCustomer(newCustomer);

                // TODO - Create a Customer in the Database
                Session["createAccount"] = newCustomer;

                Server.Transfer("~/Default.aspx");
            }
            else
            {
                lblErrorMessage.Text = "That username already exists. Please choose a different one.";
            }
        }
        catch (Exception ex)
        {
            lblErrorMessage.Text = "Sorry, there was an error connecting to the database. Try again later.";
        }
    }

    protected void btnChangePasswod_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/CreateAccount/ChangePassword.aspx");
    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        Customer oldPass = FrontBoardDA.GetCustomerByUsername(txtUsername.Text);
        if (oldPass != null)
        {
            if (oldPass.Password.Equals(txtCurrentPassword.Text))
            {
                oldPass.Password = txtConfirmPassword.Text;
                FrontBoardDA.UpdateCustomer(oldPass);
                lblChanged.Text = "Changed Password!";
            }
        }
    }
} // End of class