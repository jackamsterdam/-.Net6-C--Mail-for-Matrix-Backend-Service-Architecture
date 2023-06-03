namespace Mail.Contracts.Mail;

// Upsert - Update or Create if not exist
//this comes from client - goes into request.body

public record UpsertMailRequest (
   String Name, 
   String Description,
   String Message,
   DateTime StartDateTime,
   DateTime EndDateTime,
   List<string> Meal
);

