using MediatR;
using Movies.Application.Commands.CreateMovie;
using Movies.Application.Commands.DeleteMovie;
using Movies.Application.Commands.UpdateMovie;
using Movies.Application.Queries.GetAllMovies;
using Movies.Contractor.Requests;

namespace Movies.Presentation.Modules;
public static class MoviesModule
{
	public static void MoviesEndpoints(this IEndpointRouteBuilder app)
	{
		app.MapGet("/api/movies", async (IMediator mediator, CancellationToken ct) =>
		{
			var movie = await mediator.Send(new GetMoviesQuery(), ct);
			return Results.Ok(movie);
		}).WithTags("Movies");

		app.MapPost("/api/movies", async (IMediator mediator, CreateMovieRequestt createMovieRequest,
			CancellationToken ct) =>
		{
			var command = new CreateMovieCommand(createMovieRequest.Title, createMovieRequest.Description,
				createMovieRequest.Category);
			var result = await mediator.Send(command, ct);
			return Results.Ok(result);
		}).WithTags("Movies");

		app.MapPut("/api/movies/{id}", async (IMediator mediator, int id,
			UpdateMovieRequest updateMovieRequest, CancellationToken ct) =>
		{
			var command = new UpdateMovieCommand(id, updateMovieRequest.Title, updateMovieRequest.Description,
				updateMovieRequest.Category);
			var result = await mediator.Send(command, ct);
			return Results.Ok(result);
		}).WithTags("Movies");

		app.MapDelete("/api/movies/{id}", async (IMediator mediator, int id, CancellationToken ct) =>
		{
			var command = new DeleteMovieCommand(id);
			var result = await mediator.Send(command, ct);
			return Results.Ok(result);
		}).WithTags("Movies");
	}
}