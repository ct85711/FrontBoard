using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Item
/// </summary>
public class Item
{
    public int artId { get; set; }
    public int supplierId { get; set; }
    public string artName { get; set; }
    public string artType { get; set; }
    public decimal price { get; set; }
    public string description { get; set; }
    //this property will hold the file name for the image associated with the product
    public string imageFile { get; set; }


	public Item()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public Item (int artId, int supplierId, string artType, decimal price, string description, string imageFile)
    {
        this.artId = artId;
        this.supplierId = supplierId;
        this.artName = artName;
        this.price = price;
        this.description = description;
        this.imageFile = imageFile;


    }
}