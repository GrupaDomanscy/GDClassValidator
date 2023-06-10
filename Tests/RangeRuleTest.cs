using GDClassValidator;
using GDClassValidator.Rules;
using Xunit;

namespace Tests;

public class RangeRuleTest
{
    private class Payload : CanValidate
    {
        [Required, GDClassValidator.Rules.Range(1, int.MaxValue)]
        public int? SomeInt { get; set; }
    }
    
    [Fact]
    public void RangeRule_ReturnsValidMessageAfterValidation()
    {
        Payload payload = new Payload();
        payload.SomeInt = -1;

        var errors = payload.Validate();

        Assert.True(errors.Count == 1);
        Assert.True(errors[0].MemberNames.ToArray().Length == 1);
        Assert.True(errors[0].MemberNames.ToArray()[0] == "SomeInt");
        Assert.True(errors[0].ErrorMessage == "RANGE__1__" + int.MaxValue);
    }
    
    [Fact]
    public void RangeRule_DoesNotTriggerIfValueIsValid()
    {
        Payload payload = new Payload();
        payload.SomeInt = 1;

        var errors = payload.Validate();

        Assert.True(errors.Count == 0);
    }
}