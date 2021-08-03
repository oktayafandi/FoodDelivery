using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class MenuCategory : BaseEntity
    {
        public int PlaceMenuId { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        public PlaceMenu PlaceMenu { get; set; }
    }
}