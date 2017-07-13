namespace ForumSoftware.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClosedPropertyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Threads", "Closed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Threads", "Closed");
        }
    }
}
