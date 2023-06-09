using Microsoft.AspNetCore.Mvc; 

name BuberBreakfast.Conrollers;

public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error() 
    {
       return Problem();
    }
}