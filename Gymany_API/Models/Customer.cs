using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Username is required and not null.")]
        [StringLength(50, ErrorMessage = "Username length cannot exceed 50 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required and not null.")]
        [StringLength(50, ErrorMessage = "Password length cannot exceed 50 characters.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Name is required and not null.")]
        [StringLength(50, ErrorMessage = "Name length cannot exceed 50 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required and not null.")]
        [StringLength(50, ErrorMessage = "Address length cannot exceed 50 characters.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Age is required and not null.")]
        [DataType(DataType.Date)]
        public DateTime? Age { get; set; }

        [StringLength(200, ErrorMessage = "Image URL length cannot exceed 200 characters.")]
        public string Image { get; set; }

        [StringLength(20, ErrorMessage = "Phone number length cannot exceed 20 characters.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(50, ErrorMessage = "Email length cannot exceed 50 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
    }
}