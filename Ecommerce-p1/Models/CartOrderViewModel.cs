using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_p1.Models
{
    public class CartOrderViewModel : CartViewModel
    {

        public int OrderId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Apt { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postal { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string PaymentMethod { get; set; }

    }
}