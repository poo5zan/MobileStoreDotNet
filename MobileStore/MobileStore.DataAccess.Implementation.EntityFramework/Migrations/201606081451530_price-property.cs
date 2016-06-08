namespace MobileStore.DataAccess.Implementation.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class priceproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mobile", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mobile", "Price");
        }
    }
}
