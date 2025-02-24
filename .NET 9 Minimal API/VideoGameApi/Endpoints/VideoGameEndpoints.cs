using Microsoft.EntityFrameworkCore;
using VideoGameApi.Data;
using VideoGameApi.Models;

namespace VideoGameApi.Endpoints
{
    public static class VideoGameEndpoints
    {
        public static RouteGroupBuilder MapVideoGameEndpoints(this RouteGroupBuilder group)
        {
            group.MapGet("/", async (VideoGameDbContext context) =>
                await context.VideoGames.ToListAsync());

            group.MapGet("/{id:int}", async (VideoGameDbContext context, int id) =>
            {
                var game = await context.VideoGames.FindAsync(id);
                return game is not null ? Results.Ok(game) : Results.NotFound();
            });

            group.MapPost("/", async (VideoGameDbContext context, VideoGame newGame) =>
            {
                if (newGame is null)
                    return Results.BadRequest();

                context.VideoGames.Add(newGame);
                await context.SaveChangesAsync();

                return Results.Created($"/api/videogames/{newGame.Id}", newGame);
            });

            group.MapPut("/{id:int}", async (VideoGameDbContext context, int id, VideoGame updatedGame) =>
            {
                var game = await context.VideoGames.FindAsync(id);
                if (game is null)
                    return Results.NotFound();

                game.Title = updatedGame.Title;
                game.Platform = updatedGame.Platform;
                game.Developer = updatedGame.Developer;
                game.Publisher = updatedGame.Publisher;

                await context.SaveChangesAsync();

                return Results.NoContent();
            });

            group.MapDelete("/{id:int}", async (VideoGameDbContext context, int id) =>
            {
                var game = await context.VideoGames.FindAsync(id);
                if (game is null)
                    return Results.NotFound();

                context.VideoGames.Remove(game);
                await context.SaveChangesAsync();

                return Results.NoContent();
            });

            return group;
        }
    }
}
