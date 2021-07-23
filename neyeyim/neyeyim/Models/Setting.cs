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
        [Column(TypeName = "decimal(18,2)")]
        public decimal ContactPhone { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal InfoPhone { get; set; }

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
