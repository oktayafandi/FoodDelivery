using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class Jobad : BaseEntity
    {
        public int? PlaceId { get; set; }
        public int? CategoryId { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Position { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string City { get; set; }
        public bool? IsDeleted { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Age { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Experience { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Education { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string GeneralInfo { get; set; }
        [Required]
        public DateTime Deadline { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string ContactPhone { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string ContactMail { get; set; }
        public Place Place { get; set; }
        public Category Category { get; set; }
    }
}