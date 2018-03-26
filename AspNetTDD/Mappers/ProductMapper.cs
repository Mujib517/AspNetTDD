using Asp.Net.TDD.Repositories.Entities;
using Asp.Net.TDD.Services.Models;
using System;
using System.Collections.Generic;

namespace AspNetTDD.Mappers
{
    internal class ProductMapper
    {
        public static ProductEntity MapToEntiy(Product model)
        {
            var entity = new ProductEntity
            {
                Brand = model.Brand,
                Id = model.Id.ToString(),
                InStock = model.InStock,
                Price = model.Price,
                Model = model.Model,
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "Mujib"
            };

            return entity;
        }

        public static IEnumerable<Product> MapToModels(IEnumerable<ProductEntity> entities)
        {
            var models = new List<Product>();

            foreach (var entity in entities)
            {
                models.Add(MapToModel(entity));
            }

            return models;
        }

        public static Product MapToModel(ProductEntity entity)
        {
            if (entity == null) return null;
            return new Product
            {
                Brand = entity.Brand,
                InStock = entity.InStock,
                Id = Guid.Parse(entity.Id),
                Model = entity.Model,
                Price = entity.Price
            };
        }
    }
}