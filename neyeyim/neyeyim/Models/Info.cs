using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Models
{
    public class Info:BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 1500)]
        public string Team { get; set; }

        [Required]
        [StringLength(maximumLength: 1500)]
        public string WhatFor { get; set; }

        public bool? IsDeleted { get; set; }

        [Required]
        [StringLength(maximumLength: 1500)]
        public string HowUsed { get; set; }
    }
}