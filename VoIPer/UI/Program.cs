using UI.Controllers;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.RegisterControllers();

app.Run();