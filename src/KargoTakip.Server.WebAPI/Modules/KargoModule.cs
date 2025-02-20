using KargoTakip.Server.Application.Kargolar;
using MediatR;
using TS.Result;

namespace KargoTakip.Server.WebAPI.Modules;

public static class KargoModule
{
    public static void RegisterKargoRoutes(this IEndpointRouteBuilder app)
    {
        RouteGroupBuilder group = app.MapGroup("/kargolarim").WithTags("Kargolarim").RequireAuthorization();
        group.MapPost(string.Empty, async (ISender sender, KargoCreateCommand request, CancellationToken cancellationToken) =>
        {
            var response = await sender.Send(request, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }).Produces<Result<string>>().WithName("KargoCreate");

        //group.MapGet(string.Empty, async (ISender sender, Guid id, CancellationToken cancellationToken) =>
        //{
        //    var response = await sender.Send(new EmployeeGetQuery(id), cancellationToken);
        //    return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        //})
        //   .Produces<Result<Employee>>();
    }
}
