using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_p1.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public string UserID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
    }
}