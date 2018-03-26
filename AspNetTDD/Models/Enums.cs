using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetTDD.Models
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