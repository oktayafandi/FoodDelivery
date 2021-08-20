using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class OrderItem : BaseEntity
    {
        public int OrderId { get; set; }
        public int? PlaceMenuId { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public Order Order { get; set; }
        public PlaceMenu PlaceMenu { get; set; }
    }
}