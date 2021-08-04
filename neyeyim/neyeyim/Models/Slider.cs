using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class Slider: BaseEntity
    {
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [StringLength(maximumLength: 500)]
        public string RedirectUrl { get; set; }
        public bool? IsDeleted { get; set; }
        public int Order { get; set; }
    }
}
