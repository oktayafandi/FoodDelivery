using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName = "decimal(18,2)")]
        public decimal FoodPrice { get; set; }
        public bool? IsDeleted { get; set; }
        [StringLength(maximumLength: 500)]
        public string FoodContent { get; set; }
        public Place Place { get; set; }
        public MenuCategory MenuCategory { get; set; }
    }
}