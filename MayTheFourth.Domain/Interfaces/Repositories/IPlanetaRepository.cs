using MayTheFourth.Domain.Entities;

namespace MayTheFourth.Domain.Interfaces.Repositories;

public interface IPlanetaRepository : IRepositoryBase<Planeta>
{
    Task<IEnumerable<Planeta>> GetAllWithData();
    Task<Planeta?> GetByIdWithData(int id);
}
