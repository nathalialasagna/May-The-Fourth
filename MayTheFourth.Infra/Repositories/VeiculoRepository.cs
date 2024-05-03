using MayTheFourth.Domain.Entities;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Infra.Repositories;

public class VeiculoRepository : Repository<Veiculo>, IVeiculoRepository
{
    private readonly MayTheFourthDataContext _context;
    public VeiculoRepository(MayTheFourthDataContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Veiculo>> GetAllWithData()
    {
        return await _context.Veiculos.AsNoTracking()
                                      .Include(p => p.Filmes)
                                      .ToListAsync();
    }

    public async Task<Veiculo?> GetByIdWithData(int id)
    {
        return await _context.Veiculos.AsNoTracking()
                                      .Include(v => v.Filmes)
                                      .FirstOrDefaultAsync(v => v.Id == id);
    }
}
