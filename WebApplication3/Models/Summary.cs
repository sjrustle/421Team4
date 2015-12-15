using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class Summary
    {
        public int ID { get; set; }
        public int Income { get; set; }
        public int Expense { get; set; }
        public int Loan { get; set; }

    }
    
    public class SummaryDBContext : DbContext
    {
        public DbSet<Summary> Summarys { get; set; }
    }
}