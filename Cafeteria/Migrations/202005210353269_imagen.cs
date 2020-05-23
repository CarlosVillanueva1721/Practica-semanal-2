namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imagen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.orders", "Status", c => c.String());
            AddColumn("dbo.Products", "imagen", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "imagen");
            DropColumn("dbo.orders", "Status");
        }
    }
}
