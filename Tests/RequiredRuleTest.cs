using GDClassValidator;
using GDClassValidator.Rules;
using Xunit;

namespace Tests;

public class RequiredRuleTest
{
    private class Payload : CanValidate
    {
        [Required]
        public int? SomeInt { get; set; }
    }
    
    [Fact]
    public void RequiredRule_ReturnsValidMessageAfterValidation()
    {
        Payload payload = new Payload();

        var errors = payload.Validate();

        Assert.True(errors.Count == 1);
        Assert.True(errors[0].MemberNames.ToArray().Length == 1);
        Assert.True(errors[0].MemberNames.ToArray()[0] == "SomeInt");
        Assert.True(errors[0].ErrorMessage == "REQUIRED");
    }
}