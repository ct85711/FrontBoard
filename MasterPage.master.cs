﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if ()
        //{

        //}

    }
    protected void btnCreateAcct_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/CreateAccount/CreateAccount.aspx");
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

    }
}
