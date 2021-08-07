using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class Setting:BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string ContactPhone { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string InfoPhone { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Logo { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string ContactMail { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string InfoMail { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Adress { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string WorkTime { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string InstagramUrl { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string FacebookUrl { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string TwitterUrl { get; set; }
    }
}