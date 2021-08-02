using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class Category : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 25)]
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public List<Place> Places { get; set; }
        public List<Jobad> Jobads { get; set; }
    }
}