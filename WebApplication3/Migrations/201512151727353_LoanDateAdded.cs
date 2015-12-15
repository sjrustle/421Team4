namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoanDateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loans", "LoanDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Loans", "LoanDate");
        }
    }
}
