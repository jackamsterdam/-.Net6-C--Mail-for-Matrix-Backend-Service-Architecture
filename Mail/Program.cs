using JackMailForMatrix.Services.Mails;

// for dependecy injection and configuration: use the builder 
var builder = WebApplication.CreateBuilder(args);

{
    // Add services to the container.
    builder.Services.AddControllers();

    //tells framework that everytime instantiates an object to act like Singleton
    builder.Services.AddScoped<IMailService, MailService>();
}



var app = builder.Build();
{
    app.UseExceptionHandler("/error");

    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}

