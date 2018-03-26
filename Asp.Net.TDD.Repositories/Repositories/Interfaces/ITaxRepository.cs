using Asp.Net.TDD.Repositories.Entities;
using System.Collections.Generic;

namespace Asp.Net.TDD.Repositories.Repositories.Interfaces
{
    public interface ITaxRepository
    {
        IEnumerable<TaxEntity> Get();
        TaxEntity Get(int id);
    }
}
