using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_p1.Models
{
    public class Product
    {
        /// <summary>
        /// overloaded constructor
        /// </summary>
        /// <param name="Name"></param>
        public Product(string Name)
        {
            this.Name = Name;
        }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public Type Type { get; set; }
    }
}