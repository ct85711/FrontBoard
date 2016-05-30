using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateAccount_ChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
            }
        }
    }
}