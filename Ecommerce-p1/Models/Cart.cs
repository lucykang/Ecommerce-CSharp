namespace Ecommerce_p1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cart
    {
        [Key]
        public int RecordId { get; set; }

        //[Required]
        //[StringLength(10)]
        public string CartId { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
