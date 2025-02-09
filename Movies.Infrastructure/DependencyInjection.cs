using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Movies.Application.AbstarctRepository;
using Movies.Infrastructure.Repository;

namespace Movies.Infrastructure;
public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services , IConfiguration Configuration)
	{
		services.AddDbContext<MoviesDataBaseContext>(opt =>
		{
			opt.UseSqlite(Configuration.GetConnectionString("DbConnectionString"));
		});

		services.AddScoped<IMovieRepository , MoviesRepository>();
		return services;
	}
}
