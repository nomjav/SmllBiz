using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMLBIZZ.Models
{
	public class ContactUsModel
	{
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string name { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        public string message { get; set; }
	}

    public class ReuestModel
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string name { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string message { get; set; }
        [Required]
        public string scheduleDate { get; set; }
    }

   
}