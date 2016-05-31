using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Admin_Admin : System.Web.UI.Page
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
        if (Session["createAccount"] == null)
        {
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "refresh";
            meta.Content = "5;url=../Default.aspx";
            this.Page.Controls.Add(meta);
            lblMsg.Text = "You must login before accessing this page. Redirecting you in 5 seconds.";
            btnQuestions.Visible = false;
        }
        else
        {
            Customer login = (Customer)Session["createAccount"];
            if (login.UserName.Equals("Admin") && login.Password.Equals("Admin"))
            {
                lblMsg.Visible = false;
                btnCustomers.Visible = true;
                btnQuestions.Visible = true;
                btnOrders.Visible = true;
                btnProducts.Visible = true;
                btnReload.Visible = true;
            }
            else
            {
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "refresh";
                meta.Content = "5;url=../Default.aspx";
                this.Page.Controls.Add(meta);
                lblMsg.Text = "You must login before accessing this page. Redirecting you in 5 seconds";
            }
        }
    }
    protected void btnCustomers_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        DataList1.Visible = false;
        ListView1.Visible = false;
        DetailsView1.Visible = false;
    }
    protected void btnQuestions_Click(object sender, EventArgs e)
    {
        DataList1.Visible = true;
        GridView1.Visible = false;
        ListView1.Visible = false;
        DetailsView1.Visible = false;
    }
    protected void btnOrders_Click(object sender, EventArgs e)
    {
        DataList1.Visible = false;
        GridView1.Visible = false;
        ListView1.Visible = true;
        DetailsView1.Visible = false;
    }
    protected void btnProducts_Click(object sender, EventArgs e)
    {
        DataList1.Visible = false;
        GridView1.Visible = false;
        ListView1.Visible = false;
        DetailsView1.Visible = true;
    }
    protected void btnReload_Click(object sender, EventArgs e)
    {
          List<Item> items = FrontBoardDA.GetItems();
          foreach (Item i in items){
              FrontBoardDA.DeleteItem(i);
          } 
            Item item = new Item(1, 1, "Prince", "Painting", 15000, "'Miley Bieber' by the Artist Prince", "miley-bieber.jpg");
            FrontBoardDA.InsertItem(item);
            Item item2 = new Item(1, 1, "John Schmidt", "Drawing", 15000, "'Nightime Vista' by John Schmidt", "JohnSchmidtArt.png");
            FrontBoardDA.InsertItem(item2);
            Item item3 = new Item(1, 1, "John Buhrmann", "Drawing", 25000, "'Evil Stick Man' by John Buhrmann", "ASP_Evil_stick_man_JDB.jpg");
            FrontBoardDA.InsertItem(item3);
            Item item4 = new Item(1, 1, "Craig Pounds", "Painting", 15000, "'Sum Fire' by Craig Pounds", "sum-fire.jpg");
            FrontBoardDA.InsertItem(item4);
            Item item5 = new Item(1, 1, "Chris Torske", "Painting", 35000, "'Country Night' by Chris Torske", "CountryNightcmt.jpg");
            FrontBoardDA.InsertItem(item5);
            Item item6 = new Item(1, 1, "Nathan Jochum", "Painting", 45000, "'Self Portrait' by Sir Nathan Jochum", "SelfPortrait.png");
            FrontBoardDA.InsertItem(item6);
            Item item7 = new Item(1, 1, "Brandon Welch", "Drawing", 18000, "'Tre Art' by Brandon Welch", "art-trees.png");
            FrontBoardDA.InsertItem(item7);
            Response.Redirect(Request.RawUrl);
          
    }
}