using System.ComponentModel.DataAnnotations;

namespace MayTheFourth.Domain.Entities;

public class Personagem
{
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    public string Altura { get; set; }

    [Required]
    public string Peso { get; set; }

    [Required]
    public string CorCabelo { get; set; }

    [Required]
    public string CorPele { get; set; }

    [Required]
    public string CorOlhos { get; set; }

    [Required]
    public string AnoNascimento { get; set; }

    [Required]
    public string Genero { get; set; }

    [Required]
    public virtual Planeta Planeta { get; set; }

    public virtual IList<Filme> Filmes { get; set; }
}
