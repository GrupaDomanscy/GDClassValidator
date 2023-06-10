using System.ComponentModel.DataAnnotations;

namespace GDClassValidator.Rules;

public class Range : RangeAttribute
{
    public Range(double min, double max) : base(min, max)
    {
        this.ErrorMessage = "RANGE__" + min + "__" + max;
    }
    
    public Range(int min, int max) : base(min, max)
    {
        this.ErrorMessage = "RANGE__" + min + "__" + max;
    }
}