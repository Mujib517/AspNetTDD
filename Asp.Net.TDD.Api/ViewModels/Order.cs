using System;
using static Asp.Net.TDD.Api.Mappers.Enums;

namespace Asp.Net.TDD.Api.ViewModels
{
    public class Order
    {
        public Guid Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public OrderStatus Status { get; set; }
        public double Amount { get; set; }
        public double DeliveryCharges { get; set; }
        public double Total { get; set; }
        public Product Product { get; set; }
    }
}