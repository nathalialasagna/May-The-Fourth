﻿using MayTheFourth.Domain.Entities;

namespace MayTheFourth.Domain.Interfaces.Repositories;
public interface IVeiculoRepository : IRepositoryBase<Veiculo>
{
    Task<IEnumerable<Veiculo>> GetAllWithData();
    Task<Veiculo?> GetByIdWithData(int id);
}
