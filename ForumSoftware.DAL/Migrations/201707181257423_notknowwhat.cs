namespace ForumSoftware.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notknowwhat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserProfiles", "JoinDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserProfiles", "JoinDate", c => c.DateTime());
        }
    }
}
