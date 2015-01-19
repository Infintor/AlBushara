using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlBhushara.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string MobileNo { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Status { get; set; }
        public virtual Invoice Invoice { get; set; }
        
    }
}