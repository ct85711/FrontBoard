using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
    private static int UserIDCount = 100;

    //properties
    public int UserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string EmailAddress { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    //constructors
	public Customer()
	{
		
	}
    public Customer(int id, string fname, string lname, string address,
        string city, string state, string zipCode, string email,
        string userName, string passwd)
    {
        this.UserID = id;
        this.FirstName = fname;
        this.LastName = lname;
        this.Address = address;
        this.City = city;
        this.State = state;
        this.Zip = zipCode;
        this.EmailAddress = email;
        this.UserName = userName;
        this.Password = passwd;
    }

    //methods
    
}