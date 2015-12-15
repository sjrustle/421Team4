namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoanAmountAdded : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Loans",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            LoanName = c.String(),
            //            LoanAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            LoanInterestRate = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ApplicationUserId = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
            //    .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Loans", "ApplicationUserId", "dbo.AspNetUsers");
            //DropIndex("dbo.Loans", new[] { "ApplicationUserId" });
            //DropTable("dbo.Loans");
        }
    }
}
