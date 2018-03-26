using AspNetTDD.Services.Interfaces;
using System;
using System.Collections.Generic;
using Asp.Net.TDD.Services.Models;
using AspNetTDD.Mappers;
using Asp.Net.TDD.Repositories.Repositories.Interfaces;


namespace AspNetTDD.Services
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Get()
        {
            var entities = _productRepository.Get();
            return ProductMapper.MapToModels(entities);
        }

        public Product GetById(string id)
        {
            var entity = _productRepository.Get(id);
            return ProductMapper.MapToModel(entity);
        }

        public void Save(Product product)
        {
            product.Id = Guid.NewGuid();
            var entity = ProductMapper.MapToEntiy(product);

            _productRepository.Add(entity);
        }
    }
}