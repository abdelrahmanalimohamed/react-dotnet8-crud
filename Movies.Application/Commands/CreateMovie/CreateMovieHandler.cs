using MediatR;
using Movies.Application.AbstarctRepository;
using Movies.Domain.Entities;

namespace Movies.Application.Commands.CreateMovie;
public class CreateMovieHandler(IMovieRepository movieRepository)
	: IRequestHandler<CreateMovieCommand, int>

{
	private readonly IMovieRepository movieRepository = movieRepository;
	public async Task<int> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
	{
		var movie = new Movie
		{
			Title = request.Title,
			Category = request.Category,
			Description = request.Description,
			CreateDate = DateTime.Now.ToUniversalTime()
		};

		await movieRepository.SaveData(movie, cancellationToken);
		return movie.Id;
	}
}