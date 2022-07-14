using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.Models
{
    public class TagName
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tag Name")]
        public string TagNames { get; set; }
    }
}
