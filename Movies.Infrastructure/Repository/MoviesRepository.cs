using Microsoft.EntityFrameworkCore;
using Movies.Application.AbstarctRepository;
using Movies.Domain.Entities;

namespace Movies.Infrastructure.Repository;
public class MoviesRepository(MoviesDataBaseContext moviesDataBaseContext) 
	: IMovieRepository
{
	private readonly MoviesDataBaseContext moviesDataBaseContext = moviesDataBaseContext ;
	public async Task DeleteDate(int Id, CancellationToken cancellationToken)
	{
		var movie = await GetById(Id , cancellationToken);
		 moviesDataBaseContext.Movies.Remove(movie);
		await moviesDataBaseContext.SaveChangesAsync();
	}
	public async Task<Movie> GetById(int Id, CancellationToken cancellationToken)
	{
		var movie = await moviesDataBaseContext.Movies
						.Where(x => x.Id == Id)
						.FirstOrDefaultAsync();

	  return movie ?? throw new KeyNotFoundException($"Movie with ID {Id} not found."); ;
	}
	public async Task<List<Movie>> GetData(CancellationToken cancellationToken)
	{
		return await moviesDataBaseContext.Movies
				  .ToListAsync(cancellationToken);
	}
	public async Task<int> SaveData(Movie entity, CancellationToken cancellationToken)
	{
		await moviesDataBaseContext.Movies.AddAsync(entity, cancellationToken);
		await moviesDataBaseContext.SaveChangesAsync(cancellationToken);
		return entity.Id; 
	}
	public async Task UpdateData(int Id, Movie entity, CancellationToken cancellationToken)
	{
		var existingMovie = await GetById(Id, cancellationToken);
		if (existingMovie != null)
		{
			// Update the properties of the existing movie with the new values
			moviesDataBaseContext.Entry(existingMovie).CurrentValues.SetValues(entity);
			await moviesDataBaseContext.SaveChangesAsync(cancellationToken);
		}
	}
}