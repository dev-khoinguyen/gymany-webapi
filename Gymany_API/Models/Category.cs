using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Type is required.")]
        [StringLength(50, ErrorMessage = "Type length cannot exceed 50 characters.")]
        public string Type { get; set; }
        [StringLength(200)]
        public string Image { get; set; }

        public string Description { get; set; }
    }
}