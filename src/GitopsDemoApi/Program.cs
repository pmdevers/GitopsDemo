var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/gitopsdemo", () => "GitOps Demo Response. Updated 5");

app.Run();
