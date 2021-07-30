using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.ViewModels
{
    public class MemberRegisterModel
    {
        [Required]
        [StringLength(maximumLength: 30)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 30)]
        public string Surname { get; set; }

        [Required]
        [StringLength(maximumLength: 20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
