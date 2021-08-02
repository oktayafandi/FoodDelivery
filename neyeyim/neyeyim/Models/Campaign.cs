using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class Campaign:BaseEntity
    {
        public int? PlaceId { get; set; }

        [Required]
        [StringLength(maximumLength: 30)]
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
 
        [Required]
        [StringLength(maximumLength: 1000)]
        public string Content { get; set; }

        [Required]
        public decimal Price { get; set; }

        [StringLength(maximumLength: 500)]
        public string RedirectUrl { get; set; }

        public Place Place { get; set; }
    }
}