using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }

        [Required(ErrorMessage = "Please provide a date.")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Please provide content.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Please provide a title.")]
        [StringLength(100, ErrorMessage = "Title length cannot exceed 100 characters.")]
        public string Title { get; set; }

        [StringLength(100, ErrorMessage = "Image URL length cannot exceed 100 characters.")]
        public string Image { get; set; }

        [ForeignKey("PersonalTrainer")]
        public int PTID { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }

        [ForeignKey("Staff")]
        public int StaffID { get; set; }
        public Staff Staff { get; set; }
    }
}