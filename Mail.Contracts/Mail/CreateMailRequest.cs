namespace Mail.Contracts.Mail;

//this comes from client - goes into request.body
public record CreateMailRequest(
    string Name,
    string Description,
    string Message,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Meal
    );


