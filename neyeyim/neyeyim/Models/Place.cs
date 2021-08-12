using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class Place : BaseEntity
    {
        public int CategoryId { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Adress { get; set; }
        [Required]
        public DateTime OpenTime { get; set; }
        [Required]
        public DateTime CloseTime { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Servisfee { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Image { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Logo { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        public bool IsSelected { get; set; }
        [Required]
        public string Deposit { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string ContactPhone { get; set; }
        public double Rate { get; set; }
        public Category Category { get; set; }
        public List<PlaceImage> PlaceImages { get; set; }
        public List<PlaceTag> PlaceTags { get; set; }
        public List<Jobad> Jobads { get; set; }
        public List<Campaign> Campaigns { get; set; }
        public List<PlaceMenu> PlaceMenus { get; set; }
        public List<PlaceComment> PlaceComments { get; set; }
    }
}