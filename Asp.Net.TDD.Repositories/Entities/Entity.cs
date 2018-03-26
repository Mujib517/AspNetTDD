using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.Net.TDD.Repositories.Entities
{
    public class Entity
    {
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
