using MayTheFourth.Domain.Entities;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;

namespace MayTheFourth.Infra.Repositories;

public class NaveEstelarRepository : Repository<NaveEstelar>, INaveEstelarRepository
{
    public NaveEstelarRepository(MayTheFourthDataContext context) : base(context)
    {
    }
}
