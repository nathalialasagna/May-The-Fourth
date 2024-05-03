using MayTheFourth.Domain.Entities;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Infra.Repositories;

public class NaveEstelarRepository : Repository<NaveEstelar>, INaveEstelarRepository
{
    private readonly MayTheFourthDataContext _context;
    public NaveEstelarRepository(MayTheFourthDataContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<NaveEstelar>> GetAllWithData()
    {
        return await _context.NavesEstelares.AsNoTracking()
                                    .Include(n => n.Filmes)
                                    .ToListAsync();
    }

    public async Task<NaveEstelar?> GetByIdWithData(int id)
    {
        return await _context.NavesEstelares.AsNoTracking()
                                    .Include(n => n.Filmes)
                                     .FirstOrDefaultAsync(n => n.Id == id);
    }
}
