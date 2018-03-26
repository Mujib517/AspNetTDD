using System.ComponentModel.DataAnnotations;

namespace Asp.Net.TDD.Repositories.Entities
{
    public class ProductEntity : Entity
    {
        [Key]
        public string Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        public bool InStock { get; set; }

        public int Quantity { get; set; }
    }
}
