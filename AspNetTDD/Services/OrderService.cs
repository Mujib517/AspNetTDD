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
        private IProductRepository _productRepository;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
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
            var productEntity = _productRepository.Get(order.Product.Id.ToString());
            var productModel = ProductMapper.MapToModel(productEntity);
            order.Product = productModel;
            var entity = OrderMapper.MapToEntity(order);
            _orderRepository.Save(entity);
        }
    }
}