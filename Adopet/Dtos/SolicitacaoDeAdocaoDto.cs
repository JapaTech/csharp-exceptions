using Adopet.Attributes;

namespace Adopet.Dtos;

public record SolicitacaoDeAdocaoDto
{
    [CustomRequiredAttribute]
    public long IdPet { get; init; }

    [CustomRequiredAttribute]
    public long IdTutor { get; init; }

    [CustomRequiredAttribute]
    public string Motivo { get; init; }
}
