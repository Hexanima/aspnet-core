using Microsoft.AspNetCore.Components.Routing;

namespace Pruebas.routers;

public static class ApiRouter
{
    public static void RegisterRoutes(IEndpointRouteBuilder app)
    {
        RouteGroupBuilder api = app.MapGroup("/api");

        api.MapGet("/tasks", () => "OLA");
    }
}