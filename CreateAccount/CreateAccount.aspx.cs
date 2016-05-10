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
    }

    protected void btnCreateAccount_Click(object sender, EventArgs e)
    {
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        string zipcode;
        string phone;
        string email;
        string username;
        string password;

        firstName = txtFirstName.Text;
        lastName = txtLastName.Text;
        address = txtAddress.Text;
        city = txtCity.Text;
        state = txtState.Text;
        zipcode = txtZip.Text;
        phone = txtPhone.Text;
        email = txtEmail.Text;
        username = txtUsername.Text;
        password = txtPassword.Text;

        Customer newCustomer = new Customer(firstName, lastName, address, city, state, zipcode, phone, email, username, password);


        // TODO - Create a Customer in the Database
        Session["createAccount"] = newCustomer;

        Server.Transfer("~/Default.aspx");
    }

} // End of class