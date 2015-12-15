using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Income
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Income Name")]
        public string IncomeName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Income Amount")]
        public decimal IncomeAmount { get; set; }

        [Display(Name = "Income Type")]
        public string IncomeType { get; set; }

        public virtual ApplicationUser User { get; set; }
       public string ApplicationUserId { get; set; }
    }
}