using MayTheFourth.Domain.Entities;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Infra.Repositories;

public class PersonagemRepository : Repository<Personagem>, IPersonagemRepository
{
    private readonly MayTheFourthDataContext _context;
    public PersonagemRepository(MayTheFourthDataContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Personagem>> GetAllWithData()
    {
        return await _context.Personagens.AsNoTracking()
                                        .Include(p => p.Planeta)
                                        .Include(p => p.Filmes)
                                        .ToListAsync();
    }

    public async Task<Personagem?> GetByIdWithData(int id)
    {
        return await _context.Personagens.AsNoTracking()
                                         .Include(p => p.Planeta)
                                         .Include(p => p.Filmes)
                                         .FirstOrDefaultAsync(p => p.Id == id);
    }
}
