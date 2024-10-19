using System.ComponentModel.DataAnnotations;

public class MinimumYearValidatorAttribute : ValidationAttribute
{
    public int MinimumYear { get; set; } = 2000;
    public string DefaultErrorMessage { get; set; } = "Year should not be less than {0}";

    // ... (constructors) ...

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            DateTime date = (DateTime)value;
            if (date.Year >= MinimumYear)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Format(ErrorMessage ?? DefaultErrorMessage, MinimumYear)); // Use custom or default error message
            }
        }

        return null;
    }
}