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

    // this method inserts the new customer into the database
    public static void InsertCustomer(Customer newCust)
    {
        string ins = "insert into Customer (FirstName, LastName, Address, City, State, Zip, Phone, EmailAddress, UserName, Password) values "
            + " (@FirstName, @LastName, @Address, @City, @State, @Zip, @Phone, @EmailAddress, @UserName, @Password)";
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
        insCmd.Parameters.AddWithValue("EmailAddress", newCust.EmailAddress);
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

    public static Customer GetCustomerByUsername(string username)
    {
        string query = "SELECT * FROM CUSTOMER WHERE username = '" + username +"'";
        var dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        var getCmd = new SqlCommand(query, dbCon);
        var customer = new Customer();

        try
        {
            dbCon.Open();

            using (var dr = getCmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    customer = new Customer()
                    {
                        UserID = (int)dr["id"],
                        FirstName = dr["FirstName"].ToString(),
                        LastName = dr["LastName"].ToString(),
                        Address = dr["Address"].ToString(),
                        City = dr["City"].ToString(),
                        State = dr["State"].ToString(),
                        Zip = dr["Zip"].ToString(),
                        Phone = dr["Phone"].ToString(),
                        EmailAddress = dr["EmailAddress"].ToString(),
                        UserName = dr["UserName"].ToString(),
                        Password = dr["Password"].ToString(),
                    };
                }
                else
                    customer = null; // return null if no customer with a matching username is found
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            dbCon.Close();
        }

        return customer;
    }

    //this method gets all of the customers in the database and returns a list collection of all of them
    public static List<Customer> GetCustomers()
    {
        List<Customer> customers = new List<Customer>();
        string get = "Select * from customer";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand getCmd = new SqlCommand(get, dbCon);

        try
        {
            dbCon.Open();
            SqlDataReader reader = getCmd.ExecuteReader();

            while (reader.Read())
            {
                Customer aCust = new Customer();
                aCust.UserID = (int)reader["id"];
                aCust.FirstName = reader["FirstName"].ToString();
                aCust.LastName = reader["LastName"].ToString();
                aCust.Address = reader["Address"].ToString();
                aCust.City = reader["City"].ToString();
                aCust.State = reader["State"].ToString();
                aCust.Zip = reader["Zip"].ToString();
                aCust.Phone = reader["Phone"].ToString();
                aCust.EmailAddress = reader["EmailAddress"].ToString();
                aCust.UserName = reader["UserName"].ToString();
                aCust.Password = reader["Password"].ToString();

                customers.Add(aCust);
            }
        }
        catch (SqlException err)
        {

        }
        catch (Exception err)
        {

        }
        finally
        {
            dbCon.Close();
        }

        return customers;
    }

    // this method deletes the selected customer from the database
    public static void DeleteCustomer(Customer cust)
    {
        string del = "delete from Customer where id = @id";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand delCmd = new SqlCommand(del, dbCon);

        delCmd.Parameters.AddWithValue("id", cust.UserID);

        // open the connection to the database
        dbCon.Open();

        delCmd.ExecuteNonQuery();

        dbCon.Close();
    }

    //this method updates the customer record in the database
    public static void UpdateCustomer(Customer cust)
    {
        string upd = "update customer set"
        + "FirstName = @FirstName"
        + "LastName = @LastName"
        + "Address = @Address"
        + "City = @City"
        + "State = @State"
        + "Zip = @Zip"
        + "Phone = @Phone"
        + "EmailAddress = @Email"
        + "UserName = @UserName"
        + "Password = @Password"
        + "where id = @Id";

        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand updCmd = new SqlCommand(upd, dbCon);

        updCmd.Parameters.AddWithValue("FirstName", cust.FirstName);
        updCmd.Parameters.AddWithValue("LastName", cust.LastName);
        updCmd.Parameters.AddWithValue("Address", cust.Address);
        updCmd.Parameters.AddWithValue("City", cust.City);
        updCmd.Parameters.AddWithValue("State", cust.State);
        updCmd.Parameters.AddWithValue("Zip", cust.Zip);
        updCmd.Parameters.AddWithValue("Phone", cust.Phone);
        updCmd.Parameters.AddWithValue("Email", cust.EmailAddress);
        updCmd.Parameters.AddWithValue("UserName", cust.UserName);
        updCmd.Parameters.AddWithValue("Password", cust.Password);
        updCmd.Parameters.AddWithValue("Id", cust.UserID);

        // open the connection to the database
        dbCon.Open();

        updCmd.ExecuteNonQuery();

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
