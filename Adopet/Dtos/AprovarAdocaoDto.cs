using Adopet.Attributes;

namespace Adopet.Dtos;

public record AprovarAdocaoDto
{
    [CustomRequiredAttribute]
    public long IdAdocao { get; init; }
}
