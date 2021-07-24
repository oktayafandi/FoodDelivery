using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class PlaceMenu:BaseEntity
    {
        public int? PlaceId { get; set; }

        [Required]
        [StringLength(maximumLength: 30)]
        public string MenuCategory { get; set; }

        [Required]
        [StringLength(maximumLength: 30)]
        public string FoodName { get; set; }

        [Required]
        public decimal FoodPrice { get; set; }

        [Required]
        [StringLength(maximumLength: 30)]
        public string FoodContent { get; set; }

        public Place Place { get; set; }
    }
}
