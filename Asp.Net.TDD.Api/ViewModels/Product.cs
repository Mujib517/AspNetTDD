using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.Net.TDD.Api.ViewModels
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        public bool InStock { get; set; }
    }
}