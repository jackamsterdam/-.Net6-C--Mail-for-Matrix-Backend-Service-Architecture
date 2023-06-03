namespace Mail.Models;
//creating a Model class for our Mail
public class Mail 
{
    public Guid Id {get;}  
    public string Name {get;}
    public string Description {get;}
    public string Message {get;}
    public DateTime StartDateTime {get;}
    public DateTime EndDateTime {get;}
    public DateTime LastModifiedDateTime {get;}
    public List<string> Meal {get;}


    public Mail(Guid id, string name, string description, string message, DateTime startDateTime, DateTime endDatetime, DateTime lastModifiedDateTime, List<string> meal)
    {
    //    TODO: enforce invariants
        Id = id;
        Name = name; 
        Description = description;
        Message = message;
        StartDateTime = startDateTime;
        EndDateTime = endDatetime;
        LastModifiedDateTime = lastModifiedDateTime;
        Meal = meal;
    }
}