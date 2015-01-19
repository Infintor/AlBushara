using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlBhushara.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public string Reference { get; set; }
        public int DeliveryNoteNo { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public Customer()
        {
            CustomerName = "Customer_" + CustomerID + "_" + DateTime.Now;
        }
    }
}