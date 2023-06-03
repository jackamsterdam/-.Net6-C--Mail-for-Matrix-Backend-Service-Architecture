using Mail.Models;

namespace Mail.Services.Mails;

//We will Dependency Inject this into constructor in Controller
public class MailService : IMailService
//lets implement the interface 
{

    //Instead of database like MYSQL we will store in memory in a dictionary:
    //static casue we dont want it being created every request
    private static readonly Dictionary<Guid, Mail> _mails = new();
    public void CreateMail(Mail mail)
    {
        _mails.Add(mail.Id, mail);  //hashmap - id is key , value is the mail
    }

    public Mail GetMail(Guid id)
    {
        return _mails[id];
    }

    public void UpsertMail(Mail mail)
    {
        _mails[mail.Id] = mail;
    }

    public void DeleteMail(Guid id)
    {
        _mails.Remove(id);
    }
}