using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetTDD.Models
{
    public class Tax
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }
}