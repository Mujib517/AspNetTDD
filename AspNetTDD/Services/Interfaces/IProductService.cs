using Asp.Net.TDD.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetTDD.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> Get();

        Product GetById(string id);

        void Save(Product product);
    }
}
