var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/hola", () => "Saludos!");

app.MapGet("/prueba", (HttpContext data) => $"DATA: {data.Request.QueryString.Value}");
// app.MapGet("/view", (HttpContext context) => context.Response);

app.Run();
