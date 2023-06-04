namespace JackMailForMatrix.Contracts.Mail;

//Using this for both GET and POST because they are identical
//We will be using this as the response to the client
public record MailResponse(
    Guid Id,  //We added this
    string Name,
    string Description,
    string Message,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime, //this was added in response
    List<string> Meal

);

