var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/gitopsdemo", () => "GitOps Demo Response. Updated 3");

app.Run();
