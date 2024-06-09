using Adopet.Attributes;
using Adopet.Models.Enums;

namespace Adopet.Dtos;

public record CadastroPetDto
{
    [CustomRequiredAttribute]
    public string Nome { get; set; }
    [CustomRequiredAttribute]
    public int Idade { get; set; }
    [CustomRequiredAttribute]
    public TipoPet Tipo { get; set; }
    [CustomRequiredAttribute]
    public IFormFile Imagem { get; set; }
}
