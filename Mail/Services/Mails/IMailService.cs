using JackMailForMatrix.Models;
namespace JackMailForMatrix.Services.Mails;

//the business logic happens here

public interface IMailService
{

    void CreateMail(Mail mail);

    Mail GetMail(Guid id);

    void UpsertMail(Mail mail);

    void DeleteMail(Guid id);

}
