using Adopet.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adopet.Dtos;

public record ReprovarAdocaoDto
{
    [CustomRequiredAttribute]
    [JsonPropertyName("idAdocao")]
    public long IdAdocao { get; init; }

    [CustomRequiredAttribute]
    [StringLength(int.MaxValue, MinimumLength = 1)]
    [JsonPropertyName("justificativa")]
    public string Justificativa { get; init; }
}
