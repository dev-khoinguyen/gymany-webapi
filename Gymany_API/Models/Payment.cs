using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany_API.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        public int? Quantity { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}