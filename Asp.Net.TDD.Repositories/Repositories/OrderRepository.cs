using Asp.Net.TDD.Repositories.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asp.Net.TDD.Repositories.Entities;

namespace Asp.Net.TDD.Repositories.Repositories
{
    public class OrderRepository : IOrderRepository, IDisposable
    {
        private ProductContext _db;

        public OrderRepository()
        {
            _db = new ProductContext();
        }

        public IEnumerable<OrderEntity> Get()
        {
            return _db
                .Orders
                .Include("Product")
                .ToList();
        }

        public OrderEntity Get(string id)
        {
            return _db.Orders.Where(i => i.Id == id).FirstOrDefault();
        }

        public void Save(OrderEntity order)
        {
            _db.Orders.Add(order);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
                _db.Dispose();
        }

    }
}
