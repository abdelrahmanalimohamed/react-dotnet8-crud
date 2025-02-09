using MediatR;

namespace Movies.Application.Commands.CreateMovie;
public record CreateMovieCommand(
	string Title, 
	string Description, 
	string Category) 
	: IRequest<int>;