namespace MobileStore.DataAccess.Implementation.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullDateTimeUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.User", "DeletedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.User", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
