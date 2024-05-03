
using MayTheFourth.Domain.Entities;

namespace MayTheFourth.Domain.Interfaces.Repositories;

public interface IFilmeRepository : IRepositoryBase<Filme>
{
    Task<IEnumerable<Filme>> GetAllWithData();
    Task<Filme?> GetByIdWithData(int id);
}
