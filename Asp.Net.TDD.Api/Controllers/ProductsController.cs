using Asp.Net.TDD.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Asp.Net.TDD.Api.Controllers
{
    public class ProductsController : ApiController
    {
        public IEnumerable<Product> Get()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Id = Guid.NewGuid(), Brand = "Nokia", Model = "8", Price = 200, InStock = true });

            return products;
        }
    }
}
