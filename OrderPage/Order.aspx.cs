using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class OrderPage_Order : System.Web.UI.Page
{
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

        HtmlInputButton input = new HtmlInputButton();
        input.ID = "Button1";
        input.Value = "Purchase";

        HtmlTable tableContent = new HtmlTable();
        HtmlTableRow rowHeader = new HtmlTableRow();
        HtmlTableCell cell1Header = new HtmlTableCell();
        cell1Header.InnerText = "Name";
        rowHeader.Cells.Add(cell1Header);
        HtmlTableCell cell2Header = new HtmlTableCell();
        cell2Header.InnerText = "Description";
        rowHeader.Cells.Add(cell2Header);
        HtmlTableCell cell3Header = new HtmlTableCell();
        cell3Header.InnerText = "Price";
        rowHeader.Cells.Add(cell3Header);
        HtmlTableCell cell4Header = new HtmlTableCell();
        cell4Header.InnerText = "Purchase";
        rowHeader.Cells.Add(cell4Header);
        tableContent.Rows.Add(rowHeader);
        tableContent.Visible = true;

                List<Item> items = FrontBoardDA.GetItems();

        //foreach (Item i in items)
        //{
        //    HtmlTableRow row = new HtmlTableRow();
        //    HtmlTableCell cell1 = new HtmlTableCell();
        //    cell1.InnerText = i.artName;
        //    row.Cells.Add(cell1);
        //    HtmlTableCell cell2 = new HtmlTableCell();
        //    cell2.InnerText = i.description;
        //    row.Cells.Add(cell2);
        //    HtmlTableCell cell3 = new HtmlTableCell();
        //    cell3.InnerText = i.price.ToString();
        //    row.Cells.Add(cell3);
        //    HtmlTableCell cell5 = new HtmlTableCell();
        //    cell5.Controls.Add(input);
        //    row.Cells.Add(cell5);
        //    tableContent.Rows.Add(row);
        //}
    }

    private void orderItem(int itemID)
    {
        int userID = 1;
        Invoice newInvoice = new Invoice(itemID, userID);
        Session.Add("Order", newInvoice);

        // SEND AN EMAIL TO OURSELVES / CREATE AN ORDER IN THE DB

        Response.Redirect("~/OrderPage/Thanks.aspx");
    }
    protected void btnOrder1_Click(object sender, EventArgs e)
    {
        int itemID = 123;
        orderItem(itemID);
    }
    protected void btnOrder2_Click(object sender, EventArgs e)
    {
        int itemID = 234;
        orderItem(itemID);
    }
    protected void btnOrder3_Click(object sender, EventArgs e)
    {
        int itemID = 345;
        orderItem(itemID);
    }
    protected void btnOrder4_Click(object sender, EventArgs e)
    {
        int itemID = 456;
        orderItem(itemID);
    }
}