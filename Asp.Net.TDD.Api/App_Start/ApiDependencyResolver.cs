using Asp.Net.TDD.Api.Controllers;
using Asp.Net.TDD.Api.Registries;
using AspNetTDD.Services.Interfaces;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace Asp.Net.TDD.Api.App_Start
{
    public class ApiDependencyResolver : IDependencyResolver
    {
        private IContainer _apiContainer;
        public ApiDependencyResolver(IContainer apiContainer)
        {
            _apiContainer = apiContainer;
        }
        public IDependencyScope BeginScope()
        {
            return this;
        }

        public void Dispose()
        {

        }

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(OrderController))
            {
                return new OrderController(_apiContainer.GetInstance<IOrderService>());
            }
            if (serviceType == typeof(ProductsController))
            {
                return new ProductsController(_apiContainer.GetInstance<IProductService>());
            }
            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new Object[] { };
        }
    }
}