using AspNetTDD.Models;
using System.Collections.Generic;


namespace AspNetTDD.Services.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> Get();
        Order Get(string id);
        void Save(Order order);
    }
}
