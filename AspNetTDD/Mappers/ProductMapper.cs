using Asp.Net.TDD.Repositories.Entities;
using Asp.Net.TDD.Services.Models;
using System;

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
    }
}