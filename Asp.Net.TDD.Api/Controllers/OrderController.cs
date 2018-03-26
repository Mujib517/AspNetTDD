using Asp.Net.TDD.Api.Mappers;
using Asp.Net.TDD.Api.ViewModels;
using AspNetTDD.Services;
using AspNetTDD.Services.Interfaces;
using System;
using System.Web.Http;

namespace Asp.Net.TDD.Api.Controllers
{

    public class OrderController : ApiController
    {
        private IOrderService _orderService;

        public OrderController()
        {
            _orderService = new OrderService();
        }
        [Route("api/orders")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            var data = _orderService.Get();
            var vms = OrderMapper.MapToViewModels(data);

            return Ok(vms);
        }

        [Route("api/orders")]
        [HttpPost]
        public IHttpActionResult Save(Order order)
        {
            order.Id = Guid.NewGuid();
            var model = OrderMapper.MapToModel(order);
            _orderService.Save(model);

            return Created(new Uri(Request.RequestUri + order.Id.ToString()), order);
        }
    }
}
