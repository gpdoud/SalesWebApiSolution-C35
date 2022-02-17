using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SalesWebApi.Models {

    public class Orderline {

        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Product { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(7,2)")]
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        [JsonIgnore]
        public virtual Order Order { get; set; }

        public Orderline() { }
    }
}
