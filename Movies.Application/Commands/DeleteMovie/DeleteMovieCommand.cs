using MediatR;

namespace Movies.Application.Commands.DeleteMovie;
public record DeleteMovieCommand(int Id) : IRequest<Unit>;