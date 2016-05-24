using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class OrderPage_Order : System.Web.UI.Page
{
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["createAccount"] != null)
        {
            lblLogin.Visible = false;
            //TabelPanel.Visible = true;
        }
        else
        {
            //TabelPanel.Visible = false;
            lblLogin.Visible = true;
        }

        //HtmlTable tableContent = new HtmlTable();
        TableRow rowHeader = new TableRow();
        TableCell cell1Header = new TableCell();
        cell1Header.Text = "Name";
        rowHeader.Cells.Add(cell1Header);
        TableCell cell2Header = new TableCell();
        cell2Header.Text = "Description";
        rowHeader.Cells.Add(cell2Header);
        TableCell cell3Header = new TableCell();
        cell3Header.Text = "Price";
        rowHeader.Cells.Add(cell3Header);
        TableCell cell4Header = new TableCell();
        cell4Header.Text = "Purchase";
        rowHeader.Cells.Add(cell4Header);
        TableCell cell5Header = new TableCell();
        cell5Header.Text = "Image";
        rowHeader.Cells.Add(cell5Header);
        Table1.Rows.Add(rowHeader);

        List<Item> items = FrontBoardDA.GetItems();

        foreach (Item i in items)
        {
            Button btnPurchase = new Button();
            //input.ID = "Button1";
            btnPurchase.Text = "Purchase";
            btnPurchase.CommandName = "Purchase";
            btnPurchase.CommandArgument = i.artId.ToString();
            btnPurchase.Command += btnPurchase_Click;

            TableRow row = new TableRow();
            TableCell cell1 = new TableCell();
            cell1.Text = i.artName;
            row.Cells.Add(cell1);
            TableCell cell2 = new TableCell();
            cell2.Text = i.description;
            row.Cells.Add(cell2);
            TableCell cell3 = new TableCell();
            cell3.Text = i.price.ToString();
            row.Cells.Add(cell3);
            TableCell cell4 = new TableCell();
            cell4.Controls.Add(btnPurchase);
            row.Cells.Add(cell4);
            TableCell cell5 = new TableCell();
            if (i.imageFile != "")
            {
                ImageButton thumbnail = new ImageButton();
                thumbnail.ImageUrl = "~/Images/" + i.imageFile;
                thumbnail.Width = (Unit)75;
                thumbnail.Height = (Unit)75;
                thumbnail.OnClientClick = "window.open('../Images/"+i.imageFile + "')";
                cell5.Controls.Add(thumbnail);
            }
            else
            {
                cell5.Text = "";
            }
            row.Cells.Add(cell5);
            Table1.Rows.Add(row);
        }
    }

    private void btnPurchase_Click(Object sender, CommandEventArgs e)
    {
        int itemID = Convert.ToInt32(e.CommandArgument.ToString());
        var item = FrontBoardDA.GetItemById(itemID);

        var customer = Session["createAccount"] as Customer;

        if (customer == null)
            return;

        var invoice = new Invoice()
        {
            ItemId = itemID,
            UserId = customer.UserID
        };

        Session["order"] = invoice;
        
        // CREATE AN ORDER IN THE DB
        FrontBoardDA.InsertInvoice(invoice);

        Response.Redirect("~/OrderPage/Thanks.aspx");
    }
}