using System.ComponentModel.DataAnnotations;
using Adopet.Attributes;
using Adopet.Models.Enums;

namespace Adopet.Models;

public class Adocao
{
    [Key]
    [CustomRequiredAttribute]
    public long Id { get; set; }
    [CustomRequiredAttribute]
    public long TutorId { get; set; }
    public virtual Tutor Tutor { get; set; }
    [CustomRequiredAttribute]
    public long PetId { get; set; }
    public virtual Pet Pet { get; set; }
    public string Motivo { get; set; }
    public StatusAdocao Status { get; set; }
    public string? Justificativa { get; set; }

    public Adocao()
    {
    }

    public Adocao(Tutor tutor, Pet pet, string motivo)
    {
        Tutor = tutor;
        Pet = pet;
        Motivo = motivo;
        Status = StatusAdocao.AGUARDANDO_AVALIACAO;
    }

    public void MarcarComoAprovada()
    {
        Status = StatusAdocao.APROVADO;
    }

    public void MarcarComoReprovada(string justificativa)
    {
        Status = StatusAdocao.REPROVADO;
        Justificativa = justificativa;
    }
}
