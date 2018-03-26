using Asp.Net.TDD.Services.Models;
using System;
using static AspNetTDD.Models.Enums;

namespace AspNetTDD.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public OrderStatus Status { get; set; }
        public double DeliveryCharges { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
    }
}