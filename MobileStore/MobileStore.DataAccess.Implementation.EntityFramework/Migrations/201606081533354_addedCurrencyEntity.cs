namespace MobileStore.DataAccess.Implementation.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCurrencyEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currency",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Symbol = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Currency");
        }
    }
}
