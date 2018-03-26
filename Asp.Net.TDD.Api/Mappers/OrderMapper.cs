using Asp.Net.TDD.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Asp.Net.TDD.Api.Mappers.Enums;

namespace Asp.Net.TDD.Api.Mappers
{
    public class OrderMapper
    {
        public static IEnumerable<Order> MapToViewModels(IEnumerable<AspNetTDD.Models.Order> orders)
        {
            var list = new List<ViewModels.Order>();

            foreach (var order in orders)
            {
                list.Add(MapToViewModel(order));
            }

            return list;
        }

        public static Order MapToViewModel(AspNetTDD.Models.Order order)
        {
            if (order == null) return null;

            return new Order
            {
                Id = order.Id,
                Quantity = order.Quantity,
                Status = (OrderStatus)order.Status
            };
        }

        public static AspNetTDD.Models.Order MapToModel(Order order)
        {
            if (order == null) return null;

            return new AspNetTDD.Models.Order
            {
                Id = order.Id,
                Quantity = order.Quantity,
                Status = (AspNetTDD.Models.Enums.OrderStatus)order.Status,
                DeliveryCharges = order.DeliveryCharges,
                Amount = order.Amount,
                Total = order.Total
            };
        }
    }
}