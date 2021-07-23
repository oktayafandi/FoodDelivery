using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class PlaceImage : BaseEntity
    {
        public int PlaceId { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Logo { get; set; }

        public Place Place { get; set; }
    }
}
