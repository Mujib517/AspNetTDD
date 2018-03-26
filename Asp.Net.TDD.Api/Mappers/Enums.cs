using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.Net.TDD.Api.Mappers
{
    public class Enums
    {
        public enum OrderStatus
        {
            Placed,
            Approved,
            Dispatched,
            Delivered,
            Rejected
        }
    }
}