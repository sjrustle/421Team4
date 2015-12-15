namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoanDateAddedMadeNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Loans", "LoanDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Loans", "LoanDate", c => c.DateTime(nullable: false));
        }
    }
}
