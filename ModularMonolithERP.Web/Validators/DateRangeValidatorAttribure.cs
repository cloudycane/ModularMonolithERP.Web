using System.ComponentModel.DataAnnotations;

public class DateRangeValidatorAttribute : ValidationAttribute
{
    public string OtherPropertyName { get; set; }

    // Constructor
    public DateRangeValidatorAttribute(string otherPropertyName)
    {
        OtherPropertyName = otherPropertyName;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            // Get the "to_date"
            DateTime toDate = Convert.ToDateTime(value);

            // Get the "from_date"
            var otherProperty = validationContext.ObjectType.GetProperty(OtherPropertyName);

            if (otherProperty != null)
            {
                DateTime fromDate = Convert.ToDateTime(otherProperty.GetValue(validationContext.ObjectInstance));

                if (fromDate > toDate)
                {
                    return new ValidationResult(ErrorMessage, new string[] { OtherPropertyName, validationContext.MemberName }); // Indicate the specific properties involved in the error
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            return null; // Return null if otherProperty is null
        }
        return null;  // Return null if value is null
    }
}