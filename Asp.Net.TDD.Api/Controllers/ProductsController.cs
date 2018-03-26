using Asp.Net.TDD.Api.Mappers;
using Asp.Net.TDD.Api.ViewModels;
using AspNetTDD.Services;
using AspNetTDD.Services.Interfaces;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Asp.Net.TDD.Api.Controllers
{
    public class ProductsController : ApiController
    {
        IProductService productSvc;

        public ProductsController(IProductService productSvc)
        {
            this.productSvc = productSvc;
        }

        [HttpGet]
        [Route("api/products")]
        public HttpResponseMessage Get()
        {
            var products = productSvc.Get();

            var response = Mappers.ProductMapper.MapToViewModel(products);
            return Request.CreateResponse(HttpStatusCode.OK, products);
        }

        [HttpGet]
        [Route("api/products/{id}")]
        public HttpResponseMessage Get(string id)
        {
            var product = productSvc.GetById(id);
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        [HttpPost]
        [Route("api/products")]
        public HttpResponseMessage Post([FromBody]Product product)
        {
            var productModel = ProductMapper.MapToModel(product);
            productSvc.Save(productModel);

            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}
