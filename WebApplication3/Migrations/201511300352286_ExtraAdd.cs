namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtraAdd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CheckingAccounts", "CheckingName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CheckingAccounts", "CheckingName", c => c.String());
        }
    }
}
