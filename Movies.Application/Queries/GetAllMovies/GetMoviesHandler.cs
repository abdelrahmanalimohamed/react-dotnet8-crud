using MediatR;
using Movies.Application.AbstarctRepository;
using Movies.Domain.Entities;

namespace Movies.Application.Queries.GetAllMovies;
public class GetMoviesHandler(IMovieRepository movieRepository)
	: IRequestHandler<GetMoviesQuery, IReadOnlyList<Movie>>
{
	private readonly IMovieRepository movieRepository = movieRepository;
	public async Task<IReadOnlyList<Movie>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
	{
		return await movieRepository.GetData(cancellationToken);
	}
}