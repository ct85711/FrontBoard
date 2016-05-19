using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Question
/// </summary>
public class Question
{
    public int QuestionId { get; set; }
    public string FristName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public String theQuestion { get; set; }
	public Question()
	{
    }

    public Question(int id, string first, string last, string email, string quest)
    {
        this.QuestionId = id;
        this.FristName = first;
        this.LastName = last;
        this.Email = email;
        this.theQuestion = quest;
    }

    public Question(string first, string last, string email, string quest)
    {
        this.FristName = first;
        this.LastName = last;
        this.Email = email;
        this.theQuestion = quest;
    }

        
}