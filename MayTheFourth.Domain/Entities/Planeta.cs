using System.ComponentModel.DataAnnotations;

namespace MayTheFourth.Domain.Entities;

public class Planeta
{
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    public string PeriodoRotacao { get; set; }

    [Required]
    public string PeriodoOrbital { get; set; }

    [Required]
    public string Diametro { get; set; }

    [Required]
    public string Clima { get; set; }

    [Required]
    public string Gravidade { get; set; }

    [Required]
    public string Terreno { get; set; }

    [Required]
    public string SuperficieAquatica { get; set; }

    [Required]
    public string Populacao { get; set; }

    public IList<Personagem> Personagens { get; set; }

    public IList<Filme> Filmes { get; set; }
}
