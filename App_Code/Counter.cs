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
        
        try
        {
            counter = FrontBoardDA.GetCounter("MainPage");
        }
        catch (Exception e )
        {
            counter = 1;
        }
        return counter;
    }

    public static void addView(int counter)
    {
        try
        {
            FrontBoardDA.UpdateCounter("MainPage",counter + 1);
        }
        catch (Exception e)
        {

        }
    }
}