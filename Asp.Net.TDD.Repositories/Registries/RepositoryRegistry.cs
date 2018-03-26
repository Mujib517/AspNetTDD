using Asp.Net.TDD.Repositories.Repositories;
using Asp.Net.TDD.Repositories.Repositories.Interfaces;
using StructureMap;

namespace Asp.Net.TDD.Repositories.Registries
{
    class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            For<IOrderRepository>().Use<OrderRepository>();
            For<IProductRepository>().Use<ProductRepository>();
        }
    }
}
