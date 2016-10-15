namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Foo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.notifications", "OriginalDateTime", c => c.DateTime());
            AlterColumn("dbo.notifications", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.notifications", "DateTime", c => c.DateTime());
            DropColumn("dbo.notifications", "OriginalDateTime");
        }
    }
}
