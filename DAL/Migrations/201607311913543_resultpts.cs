namespace DAL2try.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resultpts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Results", "ResultPoints", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Results", "ResultPoints");
        }
    }
}
