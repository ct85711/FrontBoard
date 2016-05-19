using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Summary description for FrontBoardDA
/// </summary>
public static class FrontBoardDA
{
    //this method retrieves the connection string to connect to the database
    private static string GetDBConnectionString()
    {
        string dbConnection = "";

        dbConnection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

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

        try
        {
            //open the db connection
            dbCon.Open();

            //insert the customer into the table
            insCmd.ExecuteNonQuery();

            //update the customer userID
            newCust.UserID = (int)getIdCmd.ExecuteScalar();
        }
        catch (Exception err)
        {
            //todo
        }
        finally
        {
            dbCon.Close();
        }
    }

    public static Customer GetCustomerByUsername(string username)
    {
        string query = "SELECT * FROM CUSTOMER WHERE username = '" + username +"'";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand getCmd = new SqlCommand(query, dbCon);
        Customer customer;

        try
        {
            dbCon.Open();

            using (SqlDataReader dr = getCmd.ExecuteReader())
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

    public static Customer GetCustomerById(int userID)
    {
        string query = "SELECT * FROM CUSTOMER WHERE ID = " + userID;
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand getCmd = new SqlCommand(query, dbCon);
        Customer customer = new Customer();

        try
        {
            dbCon.Open();

            using (SqlDataReader dr = getCmd.ExecuteReader())
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
        catch (Exception err)
        {
            //todo
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
        try
        {
            dbCon.Open();

            delCmd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            //todo
        }
        finally
        {
            dbCon.Close();
        }
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
        try
        {
            dbCon.Open();

            updCmd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            //todo
        }
        finally
        {
            dbCon.Close();
        }
    }

    //Items

    //insert a new product into the Products table
    public static void InsertItem(Item newItem)
    {
        string ins = "insert into Products (supplierId, artName, artType, price, descript, imageFile) values "
            + "(@supplierId, @artName, @artType, @price, @descript, @imageFile)";
        string getID = "Select artId from Products order by artId desc limit 1";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(ins, dbCon);
        SqlCommand getCmd = new SqlCommand(getID, dbCon);

        insCmd.Parameters.AddWithValue("supplierId", newItem.supplierId);
        insCmd.Parameters.AddWithValue("artName", newItem.artName);
        insCmd.Parameters.AddWithValue("artType", newItem.artType);
        insCmd.Parameters.AddWithValue("price", newItem.price);
        insCmd.Parameters.AddWithValue("descript", newItem.description);
        insCmd.Parameters.AddWithValue("imageFile", newItem.imageFile);

        try
        {
            dbCon.Open();
            insCmd.ExecuteNonQuery();
            newItem.artId = (int)getCmd.ExecuteScalar();
        }
        catch (Exception err)
        {
            //todo
        }
        finally
        {
            dbCon.Close();
        }
        
    }

    //get a list of items
    public static List<Item> GetItems()
    {
        List<Item> items = new List<Item>();
        string get = "select * from products";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand getCmd = new SqlCommand(get, dbCon);

        try
        {
            dbCon.Open();
            SqlDataReader reader = getCmd.ExecuteReader();

            while (reader.Read())
            {
                Item aItem = new Item();
                aItem.artId = (int)reader[0];
                aItem.supplierId = (int)reader[1];
                aItem.artName = reader[2].ToString();
                aItem.artType = reader[3].ToString();
                aItem.price = (decimal)reader[4];
                aItem.description = reader[5].ToString();
                aItem.imageFile = reader[6].ToString();

                items.Add(aItem);
            }
            
        }
        catch (Exception err)
        {
            //todo
        }
        finally
        {
            dbCon.Close();
        }
        return items;
    }

    public static Item GetItemById(int itemID)
    {
        Item aItem = new Item();
        string get = "select * from products where artId=" + itemID;
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand getCmd = new SqlCommand(get, dbCon);

        try
        {
            dbCon.Open();
            SqlDataReader reader = getCmd.ExecuteReader();

            if (reader.Read())
            {
                
                aItem.artId = (int)reader[0];
                aItem.supplierId = (int)reader[1];
                aItem.artName = reader[2].ToString();
                aItem.artType = reader[3].ToString();
                aItem.price = (decimal)reader[4];
                aItem.description = reader[5].ToString();
                aItem.imageFile = reader[6].ToString();

            }

        }
        catch (Exception err)
        {
            //todo
        }
        finally
        {
            dbCon.Close();
        }
        return aItem;
    }

    public static void DeleteItem(Item aItem)
    {
        string del = "delete from Products where artId = " + aItem.artId;
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand delCmd = new SqlCommand(del, dbCon);

        try
        {
            dbCon.Open();

            delCmd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            //todo
        }
        finally
        {
            dbCon.Close();
        }

    }

    public static void UpdateItem(Item aItem)
    {
        string upd = "update customer set"
        + "supplierId = @supplierId"
        + "artName = @artName"
        + "artType = @artType"
        + "price = @price"
        + "descript = @descript"
        + "imageFile = @imageFile"
        + "where artId  = @artId";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand updCmd = new SqlCommand(upd, dbCon);

        updCmd.Parameters.AddWithValue("supplierId", aItem.supplierId);
        updCmd.Parameters.AddWithValue("artName", aItem.artName);
        updCmd.Parameters.AddWithValue("artType", aItem.artType);
        updCmd.Parameters.AddWithValue("price", aItem.price);
        updCmd.Parameters.AddWithValue("descript", aItem.description);
        updCmd.Parameters.AddWithValue("imageFile", aItem.imageFile);
        updCmd.Parameters.AddWithValue("artId", aItem.artId);

        // open the connection to the database
        try
        {
            dbCon.Open();

            updCmd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            //todo
        }
        finally
        {
            dbCon.Close();
        }
    }

    public static void InsertInvoice(Invoice invoice)
    {
        // invoiceid should be auto-incrementing, so only need the other three fields
        string statement = "INSERT INTO INVOICE (ItemId, UserId, OrderDate) VALUES" +
            "(@ItemId, @UserId, @OrderDate)";
        string getID = "SELECT OrderId FROM invoice ORDER BY Orderid DESC";

        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(statement, dbCon);
        SqlCommand getIdCmd = new SqlCommand(getID, dbCon);

        insCmd.Parameters.AddWithValue("ItemId", invoice.ItemId);
        insCmd.Parameters.AddWithValue("UserId", invoice.UserId);
        insCmd.Parameters.AddWithValue("OrderDate", DateTime.Today);

        try
        {
            dbCon.Open();

            insCmd.ExecuteNonQuery();

            invoice.OrderId = (int)getIdCmd.ExecuteScalar();
        }
        catch (Exception ex)
        {

        }
        finally
        {
            dbCon.Close();
        }
    }

    public static List<Invoice> GetInvoice()
    {
        List<Invoice> invoices = new List<Invoice>();
        string get = "";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand getCmd = new SqlCommand(get, dbCon);

        dbCon.Close();
        return invoices;
    }

    public static void DeleteInvoice(Invoice aInvoice)
    {
        string del = "delete from Invoice where OrderID = " + aInvoice.OrderId;
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand delCmd = new SqlCommand(del, dbCon);

        try
        {
            dbCon.Open();

            delCmd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            //todo
        }
        finally
        {
            dbCon.Close();
        }
    }


    //Question Table
    public static void InsertQuestion(Question aQuestion)
    {
        // invoiceid should be auto-incrementing, so only need the other three fields
        string statement = "INSERT INTO Questions (FirstName, LastName, Email, Question) VALUES" +
            "(@FirstName, @LastName, @Email, @Question)";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand insCmd = new SqlCommand(statement, dbCon);

        insCmd.Parameters.AddWithValue("FirstName", aQuestion.FristName);
        insCmd.Parameters.AddWithValue("LastName", aQuestion.LastName);
        insCmd.Parameters.AddWithValue("Email", aQuestion.Email);
        insCmd.Parameters.AddWithValue("Question", aQuestion.theQuestion);

        try
        {
            dbCon.Open();

            insCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            dbCon.Close();
        }
    }

    public static List<Question> GetQuestions()
    {
        List<Question> items = new List<Question>();
        string get = "select * from Questions";
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand getCmd = new SqlCommand(get, dbCon);

        try
        {
            dbCon.Open();
            SqlDataReader reader = getCmd.ExecuteReader();

            while (reader.Read())
            {
                Question aQuestion = new Question();
                aQuestion.QuestionId = (int)reader[0];
                aQuestion.FristName = reader[1].ToString();
                aQuestion.LastName = reader[2].ToString();
                aQuestion.Email = reader[3].ToString();
                aQuestion.theQuestion = reader[4].ToString();

                items.Add(aQuestion);
            }

        }
        catch (Exception err)
        {
            //todo
        }
        finally
        {
            dbCon.Close();
        }
        return items;
    }

    public static void DeleteQuestion(Question aQuestion)
    {
        string del = "delete from Questions where Id = " + aQuestion.QuestionId;
        SqlConnection dbCon = new SqlConnection(FrontBoardDA.GetDBConnectionString());
        SqlCommand delCmd = new SqlCommand(del, dbCon);

        try
        {
            dbCon.Open();

            delCmd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            //todo
        }
        finally
        {
            dbCon.Close();
        }

    }
}
