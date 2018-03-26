using AspNetTDD.Services;
using AspNetTDD.Services.Interfaces;
using StructureMap;

namespace AspNetTDD.Registries
{
    public class ServiceRegistry : Registry
    {
        public ServiceRegistry()
        {
            For<IOrderService>().Use<OrderService>();
            For<IProductService>().Use<ProductService>();
        }
    }
}