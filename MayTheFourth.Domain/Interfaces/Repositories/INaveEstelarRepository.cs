using MayTheFourth.Domain.Entities;

namespace MayTheFourth.Domain.Interfaces.Repositories
{
    public interface INaveEstelarRepository : IRepositoryBase<NaveEstelar>
    {
        Task<IEnumerable<NaveEstelar>> GetAllWithData();
        Task<NaveEstelar?> GetByIdWithData(int id);
    }
}
