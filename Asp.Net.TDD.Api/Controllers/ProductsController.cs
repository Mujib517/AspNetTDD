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
        public IEnumerable<string> Get()
        {
            return new[] { "Value 1", "Value 2" };
        }
    }
}
