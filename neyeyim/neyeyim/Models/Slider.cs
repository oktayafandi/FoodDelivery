using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class Slider: BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }

        [StringLength(maximumLength: 500)]
        public string RedirectUrl { get; set; }

        public int Order { get; set; }
    }
}
