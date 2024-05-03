using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MayTheFourth.Domain.Entities;
public class Filme
{
    public int Id { get; set; }

    [Required]
    public string Titulo { get; set; }

    [Required]
    public int Episodio { get; set; }
    [Required]
    public string TextoAbertura { get; set; }

    [Required]
    public string Diretor { get; set; }

    [Required]
    public string Produtor { get; set; }

    [Required]
    public DateTime DataLancamento { get; set; }

    public virtual IList<Personagem> Personagens { get; set; }
    public virtual IList<Planeta> Planetas { get; set; }
    public virtual IList<Veiculo> Veiculos { get; set; }
    public virtual IList<NavesEstelares> Naves { get; set; }
}
