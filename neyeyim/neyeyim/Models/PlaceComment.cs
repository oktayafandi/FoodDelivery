using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class PlaceComment : BaseEntity
    {
        public int PlaceId { get; set; }
        public string AppUserId { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rate { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public Place Place { get; set; }
        public AppUser AppUser { get; set; }
    }
}
