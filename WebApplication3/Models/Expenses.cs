using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplication3.Models
{
    public class Expenses
    {
        public int Id { get; set; }

        //[Required]
        [Display(Name = "Expense Name")]
        public string ExpenseName { get; set; }

       // [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Expense Amount")]
        public decimal ExpenseAmount { get; set; }

        [Display(Name = "Expense Type")]
        public string ExpenseType { get; set; }

        public virtual ApplicationUser User { get; set; }
        public string ApplicationUserId { get; set; }
    }
}