using Adopet.Attributes;

namespace Adopet.Api.Dto;
public record CadastroTutorDto
{
    [CustomRequiredAttribute]
    public string Nome { get; init; }

    [CustomRequiredAttribute]
    public string Email { get; init; }
}
