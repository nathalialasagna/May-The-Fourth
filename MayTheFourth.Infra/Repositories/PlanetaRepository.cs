using MayTheFourth.Domain.Entities;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Infra.Repositories;

public class PlanetaRepository : Repository<Planeta>, IPlanetaRepository
{
    private readonly MayTheFourthDataContext _context;
    public PlanetaRepository(MayTheFourthDataContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Planeta>> GetAllWithData()
    {
        return await _context.Planetas.AsNoTracking()
                                      .Include(p => p.Personagens)
                                      .Include(p => p.Filmes)
                                      .ToListAsync();
    }

    public async Task<Planeta?> GetByIdWithData(int id)
    {
        return await _context.Planetas.AsNoTracking()
                                      .Include(p => p.Personagens)
                                      .Include(p => p.Filmes)
                                      .FirstOrDefaultAsync(p => p.Id == id);
    }
}
