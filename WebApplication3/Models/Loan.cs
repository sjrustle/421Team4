using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Loan
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Loan Name")]
        public string LoanName { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Loan Amount")]
        public decimal LoanAmount { get; set; }

        [Display(Name = "Interest Rate")]
        public decimal LoanInterestRate { get; set; }

        [Display(Name = "Loan Term")]
        public int LoanTerm { get; set; }

        [Display(Name = "Date Created")]
        public DateTime? LoanDate { get; set; }

        public virtual ApplicationUser User { get; set; }
        public string ApplicationUserId { get; set; }


    }
}