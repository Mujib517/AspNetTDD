using Asp.Net.TDD.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.Net.TDD.Repositories.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void Save(OrderEntity order);

        IEnumerable<OrderEntity> Get();

        OrderEntity Get(string id);
    }
}
