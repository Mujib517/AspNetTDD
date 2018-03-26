using Asp.Net.TDD.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.Net.TDD.Api.Mappers
{
    public class ProductMapper
    {
        public static Product MapToModel(ViewModels.Product vm)
        {
            var product = new Product
            {
                Id = vm.Id,
                Brand = vm.Brand,
                InStock = vm.InStock,
                Model = vm.Model,
                Price = vm.Price
            };

            return product;
        }

        public static IEnumerable<Product> MapToModel(IEnumerable<ViewModels.Product> viewModels)
        {
            var products = new List<Product>();

            foreach (var vm in viewModels)
            {
                var product = new Product
                {
                    Id = vm.Id,
                    Brand = vm.Brand,
                    InStock = vm.InStock,
                    Model = vm.Model,
                    Price = vm.Price
                };

                products.Add(product);
            }

            return products;
        }

        public static ViewModels.Product MapToViewModel(Product model)
        {
            var product = new ViewModels.Product
            {
                Id = model.Id,
                Brand = model.Brand,
                InStock = model.InStock,
                Model = model.Model,
                Price = model.Price
            };

            return product;
        }

        public static IEnumerable<ViewModels.Product> MapToViewModel(IEnumerable<Product> models)
        {
            var products = new List<ViewModels.Product>();

            foreach (var model in models)
            {
                var product = new ViewModels.Product
                {
                    Id = model.Id,
                    Brand = model.Brand,
                    InStock = model.InStock,
                    Model = model.Model,
                    Price = model.Price
                };

                products.Add(product);
            }

            return products;
        }
    }
}