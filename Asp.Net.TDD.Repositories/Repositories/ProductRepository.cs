using Asp.Net.TDD.Repositories.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asp.Net.TDD.Repositories.Entities;

namespace Asp.Net.TDD.Repositories.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext _db;

        public ProductRepository()
        {
            _db = new ProductContext();
        }

        public void Add(ProductEntity product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }

        public IEnumerable<ProductEntity> Get()
        {
            return _db.Products.ToList();
        }

        public ProductEntity Get(string id)
        {
            return _db.Products.Where(i => i.Id == id).FirstOrDefault();
        }

        public void Update(ProductEntity product)
        {

        }
    }
}
