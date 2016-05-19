﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContactUs_ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreateAccount_Click(object sender, EventArgs e)
    {
        string text;
        text = "Name: " + txtFirstName.Text + " " + txtLastName.Text +
               Environment.NewLine + "Phone: " + txtPhone.Text +
               Environment.NewLine + "Email: " + txtEmail.Text +
               Environment.NewLine + "Question: " + txtBox.Text.Trim();
        File.AppendAllText(HttpContext.Current.Server.MapPath("/Questions.txt"), text);
        File.AppendAllText(HttpContext.Current.Server.MapPath("/Questions.txt"), Environment.NewLine);
    }
}