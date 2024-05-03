using MayTheFourth.Domain.Entities;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;
using Microsoft.EntityFrameworkCore;
namespace MayTheFourth.Infra.Repositories;

public class FilmeRepository : Repository<Filme>, IFilmeRepository
{
    private readonly MayTheFourthDataContext _context;
    public FilmeRepository(MayTheFourthDataContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Filme>> GetAllWithData()
    {
        return await _context.Filmes.AsNoTracking()
                                    .Include(f => f.Personagens)
                                    .Include(f => f.Planetas)
                                    .Include(f => f.Veiculos)
                                    .Include(f => f.Naves)
                                    .ToListAsync();
    }

    public async Task<Filme?> GetByIdWithData(int id)
    {
        return await _context.Filmes.AsNoTracking()
                                    .Include(f => f.Personagens)
                                    .Include(f => f.Planetas)
                                    .Include(f => f.Veiculos)
                                    .Include(f => f.Naves)
                                    .FirstOrDefaultAsync(f => f.Id == id);
    }
}
