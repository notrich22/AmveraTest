var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (context) =>await context.Response.WriteAsJsonAsync($"Server is running. Current date/time: {DateTime.Now}" ));
app.MapGet("/ping", async (context) =>await context.Response.WriteAsJsonAsync($"Pong: {DateTime.Now}!" ));

app.Run();
