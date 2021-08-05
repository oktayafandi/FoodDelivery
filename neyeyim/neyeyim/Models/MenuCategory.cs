using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class MenuCategory : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 100)]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public List<PlaceMenu> PlaceMenus { get; set; }
    }
}