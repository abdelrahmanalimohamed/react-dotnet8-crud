using FluentValidation;
using Movies.Domain.Entities;

namespace Movies.Application.Commands.DeleteMovie;
public class DeleteMovieCommandValidator : AbstractValidator<DeleteMovieCommand>
{
	public DeleteMovieCommandValidator()
	{
		RuleFor(x => x.Id).NotEmpty()
			.WithMessage($"{nameof(Movie.Id)} cannot be empty");

		RuleFor(x => x.Id).NotEqual(0)
			.WithMessage("Id cannot equal or be zero");
	}
}