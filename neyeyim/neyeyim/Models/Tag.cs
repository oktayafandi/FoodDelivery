using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class Tag : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 30)]
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public List<PlaceTag> PlaceTags { get; set; }
    }
}
