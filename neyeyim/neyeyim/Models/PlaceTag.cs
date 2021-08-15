using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class PlaceTag : BaseEntity
    {
        public int PlaceId { get; set; }
        public int TagId { get; set; }
        public bool? IsDeleted { get; set; }
        public Place Place { get; set; }
        public Tag Tag { get; set; }
    }
}