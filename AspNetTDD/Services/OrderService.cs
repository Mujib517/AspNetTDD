using AspNetTDD.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetTDD.Models;
using AspNetTDD.Mappers;
using Asp.Net.TDD.Repositories.Entities;
using Asp.Net.TDD.Repositories.Repositories.Interfaces;
using Asp.Net.TDD.Repositories.Repositories;

namespace AspNetTDD.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }
        public IEnumerable<Order> Get()
        {
            IEnumerable<OrderEntity> entities = _orderRepository.Get();
            return OrderMapper.MapToModels(entities);
        }

        public Order Get(string id)
        {
            OrderEntity order = _orderRepository.Get(id);
            return OrderMapper.MapToModel(order);
        }

        public void Save(Order order)
        {
            order.Amount = CalculateAmount(order);
            order.DeliveryCharges = CalculateDeliveryCharge(order);
            order.Total = CalculateTotal(order);

            var entity = OrderMapper.MapToEntity(order);
            _orderRepository.Save(entity);
        }

        private double CalculateTotal(Order order)
        {
            return order.Amount + order.DeliveryCharges;
        }

        private double CalculateAmount(Order order)
        {
            return order.Quantity * 100;
        }
        private double CalculateDeliveryCharge(Order order)
        {
            return order.Amount >= 500 ? 0 : 50;
        }
    }
}