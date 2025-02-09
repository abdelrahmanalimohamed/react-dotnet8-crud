using Microsoft.EntityFrameworkCore;
using Movies.Domain.Entities;

namespace Movies.Infrastructure;
public class MoviesDataBaseContext : DbContext
{
	public MoviesDataBaseContext(DbContextOptions options) : base(options)
	{
	}
	public DbSet<Movie> Movies { get; set; }
}