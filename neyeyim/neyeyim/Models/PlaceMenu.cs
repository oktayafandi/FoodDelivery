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
        public int? MenuCategoryId { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string FoodName { get; set; }
        [Required]
        public decimal FoodPrice { get; set; }
        public bool? IsDeleted { get; set; }
        [StringLength(maximumLength: 500)]
        public string FoodContent { get; set; }
        public Place Place { get; set; }
        public MenuCategory MenuCategory { get; set; }
    }
}