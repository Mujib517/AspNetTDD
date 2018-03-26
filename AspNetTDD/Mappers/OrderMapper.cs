using Asp.Net.TDD.Repositories.Entities;
using AspNetTDD.Models;
using System;
using System.Collections.Generic;
using static AspNetTDD.Models.Enums;

namespace AspNetTDD.Mappers
{
    public class OrderMapper
    {
        public static IEnumerable<Order> MapToModels(IEnumerable<OrderEntity> entities)
        {
            var list = new List<Order>();

            foreach (var entity in entities)
            {
                list.Add(MapToModel(entity));
            }

            return list;
        }
        public static Order MapToModel(OrderEntity entity)
        {
            if (entity == null) return null;

            return new Order
            {
                Id = Guid.Parse(entity.Id),
                Quantity = entity.Quantity,
                Status = (OrderStatus)entity.Status,
                Amount = entity.Amount,
                DeliveryCharges = entity.DeliveryCharges,
                Total = entity.Total
            };
        }
        public static OrderEntity MapToEntity(Order order)
        {
            if (order == null) return null;

            order.Amount = CalculateAmount(order);
            order.DeliveryCharges = CalculateDeliveryCharge(order);
            order.Total = CalculateTotal(order);

            return new OrderEntity
            {
                Id = order.Id.ToString(),
                Quantity = order.Quantity,
                Status = (int)order.Status,
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "Mujib",
                Amount = order.Amount,
                Total = order.Total,
                DeliveryCharges = order.DeliveryCharges
            };

        }

        private static double CalculateTotal(Order order)
        {
            return order.Amount + order.DeliveryCharges;
        }
        private static double CalculateAmount(Order order)
        {
            return order.Quantity * order.Product.Price;
        }
        private static double CalculateDeliveryCharge(Order order)
        {
            return order.Amount >= 500 ? 0 : 50;
        }
    }
}