using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for FrontBoardDA
/// </summary>
public static class FrontBoardDA
{
	private static string GetDBConnectionString()
    {
        string dbConnection = "";

        return dbConnection;
    }

    //customers
    public static void InsertCustomer(Customer newCust)
    {
        string ins = "insert into Customer (FirstName, LastName, Address, City, State, Zip, Phone, Email, UserName, Password) values "
            + " (@FirstName, @LastName, @Address, @City, @State, @Zip, @Phone, @Email, @UserName, @Password)";
        string getID = "Select id from Customer order by id desc limit 1";

        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);
        SqlCommand getIdCmd = new SqlCommand(getID, dbCon);

        insCmd.Parameters.AddWithValue("FirstName", newCust.FirstName);
        insCmd.Parameters.AddWithValue("LastName", newCust.LastName);
        insCmd.Parameters.AddWithValue("Address", newCust.Address);
        insCmd.Parameters.AddWithValue("City", newCust.City);
        insCmd.Parameters.AddWithValue("State", newCust.State);
        insCmd.Parameters.AddWithValue("Zip", newCust.Zip);
        insCmd.Parameters.AddWithValue("Phone", newCust.Phone);
        insCmd.Parameters.AddWithValue("Email", newCust.EmailAddress);
        insCmd.Parameters.AddWithValue("UserName", newCust.UserName);
        insCmd.Parameters.AddWithValue("Password", newCust.Password);

        //open the db connection
        dbCon.Open();

        //insert the customer into the table
        insCmd.ExecuteNonQuery();

        //update the customer userID
        newCust.UserID = (int)getIdCmd.ExecuteScalar();

        dbCon.Close();
    }

    public static List<Customer> GetCustomers()
    {
        List<Customer> customers = new List<Customer>();
        string ins = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);

        dbCon.Close();


        return customers;
    }

    public static void DeleteCustomer(Customer cust)
    {
        string ins = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);

        dbCon.Close();
    }

    public static void UpdateCustomer(Customer cust)
    {
        string ins = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);

        dbCon.Close();
    }

    //Items
    public static int InsertItem(Item newItem)
    {
        string ins = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);

        dbCon.Close();
        return 0;
    }

    public static List<Item> GetItem()
    {
        List<Item> items = new List<Item>();
        string ins = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);

        dbCon.Close();
        return items;
    }

    public static void DeleteItem(Item aItem)
    {
        string ins = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);

        dbCon.Close();
    }

    public static void UpdateItem(Item aItem)
    {
        string ins = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);

        dbCon.Close();
    }

    //Invoice
    public static int InsertInvoice(Invoice newInvoice)
    {
        string ins = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);

        dbCon.Close();
        return 0;
    }

    public static List<Invoice> GetInvoice()
    {
        List<Invoice> invoices = new List<Invoice>();
        string ins = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);

        dbCon.Close();
        return invoices;
    }

    public static void DeleteInvoice(Invoice aInvoice)
    {
        string ins = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);

        dbCon.Close();
    }

    public static void UpdateInvoice(Invoice aInvoice)
    {
        string ins = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);

        dbCon.Close();
    }
}