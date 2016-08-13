using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_p1.Models
{
    public class CartViewModel
    {

        public virtual List<Cart> CartItems { get; set; }
        public virtual decimal CartTotal { get; set; }

    }
}