using MediatR;
using Movies.Domain.Entities;

namespace Movies.Application.Queries.GetAllMovies;
public record GetMoviesQuery : IRequest<IReadOnlyList<Movie>>
{
}
