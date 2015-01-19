using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlBhushara.Models
{
    public class Invoice
    {
        [Key,ForeignKey("User")]
        public int InvoiceID { get; set; }
        public int InvoiceNo { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public double GrandTotal { get; set; }
       
        public ICollection<Product> Products { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual User User { get; set; }
        
    }
}