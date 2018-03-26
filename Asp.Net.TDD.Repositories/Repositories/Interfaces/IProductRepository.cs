using Asp.Net.TDD.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.Net.TDD.Repositories.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<ProductEntity> Get();

        ProductEntity Get(string id);

        void Add(ProductEntity product);

        void Update(ProductEntity product);
    }
}
