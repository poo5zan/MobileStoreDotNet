namespace MobileStore.DataAccess.Implementation.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDataTypeOfMobileCurrency : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mobile", "Currency", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mobile", "Currency", c => c.String());
        }
    }
}
