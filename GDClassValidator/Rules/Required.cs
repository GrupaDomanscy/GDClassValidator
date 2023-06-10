using System.ComponentModel.DataAnnotations;

namespace GDClassValidator.Rules;

public class Required : RequiredAttribute
{
    public Required()
    {
        this.ErrorMessage = "REQUIRED";
    }
}