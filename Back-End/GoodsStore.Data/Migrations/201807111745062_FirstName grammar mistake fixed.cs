namespace GoodsStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstNamegrammarmistakefixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Users", "FisrstName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "FisrstName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Users", "FirstName");
        }
    }
}
