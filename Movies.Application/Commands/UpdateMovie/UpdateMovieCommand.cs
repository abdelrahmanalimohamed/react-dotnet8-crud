using MediatR;

namespace Movies.Application.Commands.UpdateMovie;

public record UpdateMovieCommand(
	int Id, 
	string Title, 
	string Description, 
	string Category) : IRequest<Unit>;