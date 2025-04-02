using Pruebas.routers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/hola", () => "Saludos!");

app.MapGet("/prueba/", (HttpContext data) => $"DATA: {data.Request.QueryString.Value}");
// app.MapGet("/view", (HttpContext context) => context.Response);
app.MapGet("/ruta/{id?}", (string? id) => id ?? "falta data");
app.MapGet("/otro/{id:int?}/{alo?}", Handler);

string Handler(HttpContext context, int? id = 2, string? alo = "faltan datos")
{
    return id + alo + context.Request.QueryString.Value;
}

ApiRouter.RegisterRoutes(app);

app.Run();