namespace MobileStore.DataAccess.Implementation.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCurrencyProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mobile", "Currency", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mobile", "Currency");
        }
    }
}
