using MediatR;
using Movies.Application.AbstarctRepository;

namespace Movies.Application.Commands.DeleteMovie;
public class DeleteMovieHandler(IMovieRepository movieRepository)
	: IRequestHandler<DeleteMovieCommand, Unit>
{
	private readonly IMovieRepository movieRepository = movieRepository;
	public async Task<Unit> Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
	{
		await movieRepository.DeleteDate(request.Id, cancellationToken);
		return Unit.Value;
	}
}