using Asp.Net.TDD.Repositories.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asp.Net.TDD.Repositories.Entities;

namespace Asp.Net.TDD.Repositories.Repositories
{
    public class TaxRepository : ITaxRepository, IDisposable
    {
        private ProductContext _db;
        public TaxRepository()
        {
            _db = new ProductContext();
        }
        public IEnumerable<TaxEntity> Get()
        {
            return _db.Taxes.ToList();
        }
        public TaxEntity Get(int id)
        {
            return _db.Taxes.Where(tax => tax.Id == id).FirstOrDefault();
        }
        public void Dispose()
        {
            if (_db != null) _db.Dispose();
        }
    }
}
 