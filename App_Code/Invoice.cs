using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Invoice
/// </summary>
public class Invoice
{
	public Invoice(int orderId, int itemId, int userId, DateTime orderDate)
	{
        OrderId = orderId;
        ItemId = itemId;
        UserId = userId;
        OrderDate = orderDate;
	}

    public Invoice() { }

    private int orderId;
    public int OrderId
    {
        get { return orderId; }
        set { orderId = value; }
    }

    private int itemId;
    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    private int userId;
    public int UserId
    {
        get { return userId; }
        set { userId = value; }
    }

    private DateTime orderDate;
    public DateTime OrderDate
    {
        get { return orderDate; }
        set { orderDate = value; }
    }
}