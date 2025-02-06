using Application.User.Create;
using Carter;
using MediatR;
namespace WebApi.Endpoints
{
    public class User : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("users", async (CreateUserCommand command, ISender sender) =>
            {
                await sender.Send(command);

                return Results.Ok();
            });
        }
    }
}
