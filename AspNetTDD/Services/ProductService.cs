using AspNetTDD.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Asp.Net.TDD.Services.Models;
using AspNetTDD.Mappers;
using Asp.Net.TDD.Repositories.Repositories.Interfaces;
using Asp.Net.TDD.Repositories.Repositories;

namespace AspNetTDD.Services
{
    public class ProductService : IProductService
    {
        List<Product> products;
        IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();

            products = new List<Product>();

            products.Add(new Product { Id = Guid.NewGuid(), Brand = "Nokia", Model = "8", Price = 200, InStock = true });
            products.Add(new Product { Id = Guid.NewGuid(), Brand = "Nokia", Model = "7", Price = 150, InStock = false });
            products.Add(new Product { Id = Guid.NewGuid(), Brand = "Nokia", Model = "6", Price = 250, InStock = false });
        }

        public IEnumerable<Product> Get()
        {
            var abc = _productRepository.Get();
            return products;
        }

        public Product GetById(string id)
        {
            var product = products.Where(i => i.Id.ToString() == id).FirstOrDefault();

            return product;
        }

        public void Save(Product product)
        {
            product.Id = Guid.NewGuid();
            var entity = ProductMapper.MapToEntiy(product);

            _productRepository.Add(entity);
        }
    }
}