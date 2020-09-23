using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace OVERS.Models
{
    public class Customer
    {
         [Key]
         [Required(ErrorMessage ="Please Enter Customer ID")]
        [Display(Name ="Customer ID")]
        public int cid { get; set; }
        [Display(Name ="First Name")]
        public string fname { get; set; }
        [Display(Name = "Last Name")]
        public string lname { get; set; }
        [Display(Name = "Current Address")]
        public string currentaddress { get; set; }
        [Display(Name = "Country")]
        public string country { get; set; }

    }
}
