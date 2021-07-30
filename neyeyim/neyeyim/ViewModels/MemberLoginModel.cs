using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.ViewModels
{
    public class MemberLoginModel
    {
        [Required]
        [StringLength(maximumLength: 20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}