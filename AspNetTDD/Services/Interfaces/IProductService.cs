using Asp.Net.TDD.Services.Models;
using System.Collections.Generic;


namespace AspNetTDD.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> Get();

        Product GetById(string id);

        void Save(Product product);
    }
}
