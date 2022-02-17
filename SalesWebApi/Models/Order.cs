using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebApi.Models {

    public class Order {

        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Description { get; set; }
        public bool Shipped { get; set; }
        [Column(TypeName = "decimal(7,2)")]
        public decimal Total { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual IEnumerable<Orderline> Orderlines { get; set; }

        public Order() {}
    }
}
