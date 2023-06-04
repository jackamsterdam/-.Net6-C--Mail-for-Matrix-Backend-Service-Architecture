using Mail.Contracts.Mail;
using Microsoft.AspNetCore.Mvc;
using Mail.Services.Mails;
using Mail.Models;

namespace Mail.Controllers;


[ApiController]
[Route("[controller]")]

public class MailsController : ControllerBase
{

    private readonly IMailsService _mailService;

    //Dependency injection of the service
    public MailsController(IMailService mailService)
    {
        _mailService = mailService;
    }


    //Explanation of what is going on here: 
    //1. Map the data we get in request with the model from Model folder
    //2.Taking the data from system and connecting it back to the api definition using the data (from Mail.Contracts)
    //3. Returning reponse 201 - created
    //4. Service implements the logic that would normally go to DAL which goes to database but here we are using a dictionary in memory.

    [HttpPost]

    //POST
    public IActionResult CreateMail(CreateMailRequest request)
    {

        var mail = new Mail(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.Message,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Meal
        );

        // save mail to database (in memory for now - dictionary)
        _mailService.CreateMail(mail);


        var response = new MailResponse(
           mail.Id,
           mail.Name,
           mail.Description,
           mail.Message,
           mail.StartDateTime,
           mail.EndDateTime,
           mail.LastModifiedDateTime,
           mail.Meal
        );

        return CreatedAtAction(

            actionName: nameof(GetMail),
            routeValues: new { id = mail.Id },
            value: response);
    }

    //GET

    [HttpGet("{id:guid}")]
    public IActionResult GetMail(Guid id)
    {
        Mail mail = _mailService.GetMail(id);

        var response = new MailResponse(
        mail.Id,
        mail.Name,
        mail.Description,
        mail.Message,
        mail.StartDateTime,
        mail.EndDateTime,
        mail.LastModifiedDateTime,
        mail.Meal
        );

        return Ok(response);
    }

    // PUT

    [HttpPut("{id:guid}")]
    public IActionResult UpsertMail(Guid id, UpsertMailRequest request)
    {
        //REST arch protocol is to take id from route not body
        var mail = new Mail(
           id,
           request.Name,
           request.Description,
           request.Message,
           request.StartDateTime,
           request.EndDateTime,
           DateTime.UtcNow,
           request.Meal
        );

        //using instance of our dependecy injected service:
        _mailService.UpsertMail(mail);

        return NoContent();  //if id exists

        // TODO: reutrn 201 if a new valid mail was created
    }

    // DELETE

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteMail(Guid id)
    {
        _mailService.DeleteMail(id);

        return NoContent();
    }
}


