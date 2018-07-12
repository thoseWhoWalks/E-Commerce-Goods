namespace GoodsStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HashPasswordLengthrestricmentfixed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "HashPassword", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "HashPassword", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
