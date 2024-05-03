﻿using System.ComponentModel.DataAnnotations;

namespace MayTheFourth.Domain.Entities;

public class NavesEstelares
{
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }

    [Required]
    public string Modelo { get; set; }

    [Required]
    public string Fabricante { get; set; }

    [Required]
    public string CustoEmCreditos { get; set; }

    [Required]
    public string Comprimento { get; set; }

    [Required]
    public string VelocidadeMaxima { get; set; }

    [Required]
    public string Tripulacao { get; set; }

    [Required]
    public string Passageiros { get; set; }

    [Required]
    public string CapacidadeCarga { get; set; }

    [Required]
    public string ClassificacaoHiperdrive { get; set; }

    [Required]
    public string Mglt { get; set; }

    [Required]
    public string Consumiveis { get; set; }

    [Required]
    public string Classe { get; set; }

    public virtual IList<Filme> Filmes { get; set; }
}
