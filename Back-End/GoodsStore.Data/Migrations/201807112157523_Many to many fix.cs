namespace GoodsStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Manytomanyfix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Order_Id", c => c.Guid());
            AddColumn("dbo.Users", "Order_Id", c => c.Guid());
            CreateIndex("dbo.Products", "Order_Id");
            CreateIndex("dbo.Users", "Order_Id");
            AddForeignKey("dbo.Products", "Order_Id", "dbo.Orders", "Id");
            AddForeignKey("dbo.Users", "Order_Id", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Products", "Order_Id", "dbo.Orders");
            DropIndex("dbo.Users", new[] { "Order_Id" });
            DropIndex("dbo.Products", new[] { "Order_Id" });
            DropColumn("dbo.Users", "Order_Id");
            DropColumn("dbo.Products", "Order_Id");
        }
    }
}
