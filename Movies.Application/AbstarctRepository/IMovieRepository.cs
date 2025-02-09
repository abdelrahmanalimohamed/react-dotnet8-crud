using Movies.Domain.Entities;

namespace Movies.Application.AbstarctRepository;
public interface IMovieRepository
{
	Task<int> SaveData(Movie entity ,CancellationToken cancellationToken);
	Task<List<Movie>> GetData(CancellationToken cancellationToken);
	Task<Movie> GetById(int Id , CancellationToken cancellationToken);
	Task DeleteDate(int Id , CancellationToken cancellationToken);
	Task UpdateData(int Id ,  Movie entity , CancellationToken cancellationToken);
}
