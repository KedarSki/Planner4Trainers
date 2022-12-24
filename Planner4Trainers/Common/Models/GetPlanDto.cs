using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Common.Dtos
{
    public class GetPlanDto
    {
        [Required]
        [Display(Name = "Id")]
        public int Id {get; set;}

        public string Text { get; set; }
    }
}