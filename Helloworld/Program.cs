var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (ILogger<Program> logger) =>
{
    logger.LogInformation("Hello World endpoint was called at {Time}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
    return "Hello World!";
});

app.Logger.LogInformation("Starting the application...");

app.Run();
