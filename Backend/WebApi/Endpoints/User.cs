using Carter;
namespace WebApi.Endpoints
{
    public class User : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost()
        }
    }
}
