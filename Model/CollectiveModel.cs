using System.ComponentModel.DataAnnotations;

namespace luna.gameworks.data.Model;

public class Collective : IValidatableObject
{
    public string UUID {get;}
    public string CollectiveName {get; set;}

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        throw new NotImplementedException();
    }
}