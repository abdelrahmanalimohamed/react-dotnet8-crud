using Movies.Application;
using Movies.Infrastructure;
using Movies.Presentation.Handler;
using Movies.Presentation.Modules;

namespace Movies.Presentation;
public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddAuthorization();
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

		builder.Services
			.AddApplication()
			.AddInfrastructure(builder.Configuration);

		builder.Services.AddExceptionHandler<ExceptionHandler>();

		builder.Services.AddCors(opt =>
		{
			opt.AddPolicy("CorsPolicy", policyBuilder =>
			{
				policyBuilder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:5173");
			});
		});

		var app = builder.Build();

		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}
		app.UseExceptionHandler(_ => { });
		app.UseCors("CorsPolicy");
		app.UseHttpsRedirection();
		app.MoviesEndpoints();
		app.Run();
	}
}