using Mapster;
using MediatR;
using Movies.Application.AbstarctRepository;

namespace Movies.Application.Queries.GetAllMovies;
public class GetMoviesHandler(IMovieRepository movieRepository)
    : IRequestHandler<GetMoviesQuery, IReadOnlyList<MovieDto>>
{
    public async Task<IReadOnlyList<MovieDto>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
    {
        var movies =  await movieRepository.GetData(cancellationToken);
        return movies.Adapt<IReadOnlyList<MovieDto>>();
    }
}