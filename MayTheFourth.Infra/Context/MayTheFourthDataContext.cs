using MayTheFourth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Infra.Context;

public class MayTheFourthDataContext : DbContext
{
    public MayTheFourthDataContext(DbContextOptions<MayTheFourthDataContext> options) : base(options) { }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<NaveEstelar> NavesEstelares { get; set; }
    public DbSet<Personagem> Personagens { get; set; }
    public DbSet<Planeta> Planetas { get; set; }
    public DbSet<Veiculo> Veiculos { get; set; }
}