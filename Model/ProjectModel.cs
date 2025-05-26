using System.ComponentModel.DataAnnotations;

namespace luna.gameworks.data.Model;

public class Project : IValidatableObject
{
    public string UUID {get;}
    public string ProjectName {get; set;}
    public ProjectType Type {get; set;}
    public Collective Author {get; set;}

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        throw new NotImplementedException();
    }
}