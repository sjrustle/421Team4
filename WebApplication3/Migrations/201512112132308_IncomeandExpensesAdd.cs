namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncomeandExpensesAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpenseName = c.String(),
                        ExpenseAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseType = c.String(),
                        ApplicationUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IncomeName = c.String(nullable: false),
                        IncomeAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IncomeType = c.String(),
                        ApplicationUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Incomes", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Expenses", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Incomes", new[] { "ApplicationUserId" });
            DropIndex("dbo.Expenses", new[] { "ApplicationUserId" });
            DropTable("dbo.Incomes");
            DropTable("dbo.Expenses");
        }
    }
}
