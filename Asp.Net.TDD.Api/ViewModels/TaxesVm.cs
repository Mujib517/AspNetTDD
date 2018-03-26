using System.Collections.Generic;
using System.Linq;

namespace Asp.Net.TDD.Api.ViewModels
{
    public class TaxesVm
    {
        public IEnumerable<Tax> Taxes { get; set; }

        public double Total
        {
            get
            {
                return Taxes.Sum(i => i.Value);
            }
        }
    }
}