namespace MobileStore.DataAccess.Implementation.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedCurrencyPropName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mobile", "CurrencyId", c => c.Int(nullable: false));
            DropColumn("dbo.Mobile", "Currency");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mobile", "Currency", c => c.Int(nullable: false));
            DropColumn("dbo.Mobile", "CurrencyId");
        }
    }
}
