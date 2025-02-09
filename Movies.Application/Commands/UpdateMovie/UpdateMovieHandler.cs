using MediatR;
using Movies.Application.AbstarctRepository;
using Movies.Domain.Entities;

namespace Movies.Application.Commands.UpdateMovie;
public class UpdateMovieHandler(IMovieRepository movieRepository)
	: IRequestHandler<UpdateMovieCommand, Unit>
{
	private readonly IMovieRepository movieRepository = movieRepository;
	public async Task<Unit> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
	{
		var movie = new Movie
		{
			Category = request.Category,
			Description = request.Description,
			Title = request.Title,
			UpdateDate = DateTime.Now.ToUniversalTime()
		};

		await movieRepository.UpdateData(request.Id, movie, cancellationToken);
		return Unit.Value;
	}
}