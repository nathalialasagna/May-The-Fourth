using System.ComponentModel.DataAnnotations;

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

    public IList<Personagem> Personagens { get; set; }
    public IList<Planeta> Planetas { get; set; }
    public IList<Veiculo> Veiculos { get; set; }
    public IList<NaveEstelar> Naves { get; set; }
}
