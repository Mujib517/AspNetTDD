using Asp.Net.TDD.Api.ViewModels;
using AspNetTDD.Services;
using AspNetTDD.Services.Interfaces;
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
        public HttpResponseMessage Get()
        {
            IProductService productSvc = new ProductService();
            var products = productSvc.Get();

            return Request.CreateResponse(HttpStatusCode.OK, products);
        }
    }
}
