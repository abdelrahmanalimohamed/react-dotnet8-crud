namespace Movies.Contractor.Responses;

public record GetMoviesResponse(IReadOnlyList<MovieDto> Results);
