using Asp.Net.TDD.Repositories.Entities;
using AspNetTDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

            return new OrderEntity
            {
                Id = order.Id.ToString(),
                Quantity = order.Quantity,
                Status = (int)order.Status,
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "Mujib",
                Total = order.Total,
                DeliveryCharges = order.DeliveryCharges,
                Amount = order.Amount
            };
        }
    }
}