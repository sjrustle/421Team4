namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoanTermAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loans", "LoanTerm", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Loans", "LoanTerm");
        }
    }
}
