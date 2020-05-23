namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class controlador : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.orders", "quantity", c => c.Int(nullable: false));
            AddColumn("dbo.orders", "total", c => c.Int(nullable: false));
            AddColumn("dbo.orders", "Coment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.orders", "Coment");
            DropColumn("dbo.orders", "total");
            DropColumn("dbo.orders", "quantity");
        }
    }
}
