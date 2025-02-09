using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Movies.Application.Behaviors;
using System.Reflection;

namespace Movies.Application;
public static class DependencyInjection 
{
	public static IServiceCollection AddApplication(this IServiceCollection services)
	{
		services.AddMediatR(cf =>
		{
			cf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
			cf.AddOpenBehavior(typeof(ValidationBehavior<,>));
		});

		services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

		return services;
	}
}