using System.ComponentModel.DataAnnotations;

namespace Adopet.Attributes;

public class CustomRequiredAttribute : RequiredAttribute
{
    public CustomRequiredAttribute()
    {
        ErrorMessage = "O campo é obrigatório!";
    }
}
