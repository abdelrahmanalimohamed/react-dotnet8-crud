using Movies.Contractor.Errors;

namespace Movies.Contractor.Exceptions;
public class CustomValidationException : Exception
{
	public CustomValidationException(List<ValidationError> validationErrors)
	{
		ValidationErrors = validationErrors;
	}
	public List<ValidationError> ValidationErrors { get; set; }
}
