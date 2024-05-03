using MayTheFourth.Domain.Entities;

namespace MayTheFourth.Domain.Interfaces.Repositories
{
    public interface IPersonagemRepository : IRepositoryBase<Personagem>
    {
        Task<IEnumerable<Personagem>> GetAllWithData();
        Task<Personagem?> GetByIdWithData(int id);
    }
}
