var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/SeconEndPoint", () => "This is the second endpoint!");

app.Run();
