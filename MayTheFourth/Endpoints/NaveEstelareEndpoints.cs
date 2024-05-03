using Carter;
using MayTheFourth.Domain.Interfaces.Repositories;

namespace MayTheFourth.API.Endpoints;

public class NaveEstelareEndpoints : CarterModule
{
    public NaveEstelareEndpoints() : base("/navesEstelares")
    {
        WithTags("navesEstelares");
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (INaveEstelarRepository navesEstelaresRepository) =>
        {
            var naves = await navesEstelaresRepository.GetAllWithData();
            return Results.Ok(naves);
        });

        app.MapGet("/{idNave:int}", async (int idNave, INaveEstelarRepository navesEstelaresRepository) =>
        {
            var nave = await navesEstelaresRepository.GetByIdWithData(idNave);

            if(nave == null) return Results.NotFound();

            return Results.Ok(nave);
        });
    }
}
