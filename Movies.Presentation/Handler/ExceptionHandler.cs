﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Movies.Contractor.Exceptions;

namespace Movies.Presentation.Handler
{
	public class ExceptionHandler : IExceptionHandler
	{
		public async ValueTask<bool> TryHandleAsync(
			HttpContext httpContext, 
			Exception exception, 
			CancellationToken cancellationToken)
		{
			var problemDetails = CreateProblemDetails(exception);

			httpContext.Response.StatusCode = problemDetails.Status ?? StatusCodes.Status500InternalServerError;
			await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);
			return true;
		}
		private static ProblemDetails CreateProblemDetails(Exception exception)
		{
			ProblemDetails problemDetails = exception switch
			{
				NotFoundException => CreateProblemDetails(StatusCodes.Status404NotFound,
					"Not Found", exception.Message),
				CustomValidationException => CreateProblemDetails(StatusCodes.Status400BadRequest,
					"Validation error", exception.Message),
				_ => CreateProblemDetails(StatusCodes.Status500InternalServerError,
					"Internal Server Error", exception.Message)
			};

			if (exception is CustomValidationException customValidationException)
			{
				problemDetails.Extensions["errors"] = customValidationException.ValidationErrors;
			}

			return problemDetails;
		}
		private static ProblemDetails CreateProblemDetails(int status, string title, string detail)
		{
			return new ProblemDetails
			{
				Status = status,
				Title = title,
				Detail = detail
			};
		}
	}
}