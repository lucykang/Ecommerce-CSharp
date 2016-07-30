using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_p1.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string UserID { get; set; }
        public int CartID { get; set; } //not sure if this will be necessary for displaying products that they ordered. If there's better way, we could always modify.
        public double Total { get; set; }
        public string PaymentMethod { get; set; }
    }
}