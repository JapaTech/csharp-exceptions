using Adopet.Api.Dto;
using Adopet.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Adopet.Models;

public class Tutor
{
    [Key]
    [CustomRequiredAttribute]
    public long Id { get; set; }
    [CustomRequiredAttribute]
    public string Nome { get; set; }
    [CustomRequiredAttribute]
    public string Email { get; set; }

    public virtual List<Adocao> Adocoes { get; set; }

    public Tutor()
    {
    }

    public Tutor(CadastroTutorDto dados)
    {
        Nome = dados.Nome;
        Email = dados.Email;
    }
}
