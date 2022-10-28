using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class User
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email adress")]
        public string EmailAdress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(80, ErrorMessage ="Your password must be between {2} and {1} characters.", MinimumLength = 6)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public int Id { get; set; }
    }
}
