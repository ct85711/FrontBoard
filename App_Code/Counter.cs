using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;


/// <summary>
/// Summary description for Counter
/// </summary>
public class Counter
{
	public Counter()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static int getCount()
    {
        int counter = 0;
        string text;
        var fileStream = new FileStream(HttpContext.Current.Server.MapPath("/Counter.txt"), FileMode.Open, FileAccess.Read);
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
        {
            text = streamReader.ReadToEnd();
        }
        try
        {
            counter = Int16.Parse(text);
        }
        catch (Exception e )
        {
            counter = 1;
        }
        return counter;
    }

    public static void addView()
    {
        int counter = getCount() + 1;
        string text = counter.ToString();
        try
        {
            File.WriteAllText(HttpContext.Current.Server.MapPath("/Counter.txt"), text);
        }
        catch (Exception e)
        {

        }
    }
}