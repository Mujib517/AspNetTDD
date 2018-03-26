

using System.ComponentModel.DataAnnotations;

namespace Asp.Net.TDD.Repositories.Entities
{
    public class OrderEntity : Entity
    {
        [Key]
        public string Id { get; set; }
        public ProductEntity Product { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public double DeliveryCharges { get; set; }
        public double Total { get; set; }
        public double Amount { get; set; }
    }
}
