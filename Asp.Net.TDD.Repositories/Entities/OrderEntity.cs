

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp.Net.TDD.Repositories.Entities
{
    public class OrderEntity : Entity
    {
        [Key]
        public string Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public double DeliveryCharges { get; set; }
        public double Total { get; set; }
        public double Amount { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual ProductEntity Product { get; set; }
    }
}
