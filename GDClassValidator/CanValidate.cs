using System.ComponentModel.DataAnnotations;

namespace GDClassValidator;

public abstract class CanValidate
{
    public List<ValidationResult> Validate()
    {
        ValidationContext validationContext = new ValidationContext(this);
        List<ValidationResult> results = new List<ValidationResult>();
        Validator.TryValidateObject(this, validationContext, results, true);

        return results;
    }
}