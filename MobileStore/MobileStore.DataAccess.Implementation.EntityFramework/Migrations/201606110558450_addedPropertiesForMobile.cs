namespace MobileStore.DataAccess.Implementation.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPropertiesForMobile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mobile", "Currency", c => c.String());
            AddColumn("dbo.Mobile", "NetworkTechnology", c => c.String());
            AddColumn("dbo.Mobile", "LaunchDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Mobile", "LaunchStatus", c => c.String());
            AddColumn("dbo.Mobile", "DimensionLength", c => c.Double(nullable: false));
            AddColumn("dbo.Mobile", "DimensionBreadth", c => c.Double(nullable: false));
            AddColumn("dbo.Mobile", "DimensionHeight", c => c.Double(nullable: false));
            AddColumn("dbo.Mobile", "DimensionUnit", c => c.Double(nullable: false));
            AddColumn("dbo.Mobile", "WeightValue", c => c.Double(nullable: false));
            AddColumn("dbo.Mobile", "WeightUnit", c => c.String());
            AddColumn("dbo.Mobile", "DisplayType", c => c.String());
            AddColumn("dbo.Mobile", "ScreenToBodyRatio", c => c.Double(nullable: false));
            AddColumn("dbo.Mobile", "PpiPixelDensity", c => c.Double(nullable: false));
            AddColumn("dbo.Mobile", "ResolutionLength", c => c.Double(nullable: false));
            AddColumn("dbo.Mobile", "ResolutionBreadth", c => c.Double(nullable: false));
            AddColumn("dbo.Mobile", "ResolutionUnit", c => c.String());
            AddColumn("dbo.Mobile", "MultiTouch", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mobile", "MultiTouchNumberOfFingers", c => c.Int(nullable: false));
            AddColumn("dbo.Mobile", "DisplaySize", c => c.Double(nullable: false));
            AddColumn("dbo.Mobile", "DisplaySizeUnit", c => c.String());
            AddColumn("dbo.Mobile", "PlatformOS", c => c.String());
            AddColumn("dbo.Mobile", "PlatformChipset", c => c.String());
            AddColumn("dbo.Mobile", "PlatformCpu", c => c.String());
            AddColumn("dbo.Mobile", "PlatformGpu", c => c.String());
            AddColumn("dbo.Mobile", "MemoryCardSlot", c => c.String());
            AddColumn("dbo.Mobile", "MemoryInternal", c => c.String());
            AddColumn("dbo.Mobile", "CameraPrimary", c => c.String());
            AddColumn("dbo.Mobile", "CameraFeatures", c => c.String());
            AddColumn("dbo.Mobile", "CameraVideo", c => c.String());
            AddColumn("dbo.Mobile", "CameraSecondary", c => c.String());
            AddColumn("dbo.Mobile", "SoundAlertTypes", c => c.String());
            AddColumn("dbo.Mobile", "SoundLoudSpeaker", c => c.String());
            AddColumn("dbo.Mobile", "SoundThreePointFivemmJack", c => c.String());
            AddColumn("dbo.Mobile", "CommunicationWlan", c => c.String());
            AddColumn("dbo.Mobile", "CommunicationBluetooth", c => c.String());
            AddColumn("dbo.Mobile", "CommunicationGps", c => c.String());
            AddColumn("dbo.Mobile", "CommunicationNfc", c => c.String());
            AddColumn("dbo.Mobile", "CommunicationRadio", c => c.String());
            AddColumn("dbo.Mobile", "CommunicationUsb", c => c.String());
            AddColumn("dbo.Mobile", "Sensors", c => c.String());
            AddColumn("dbo.Mobile", "Messaging", c => c.String());
            AddColumn("dbo.Mobile", "Browser", c => c.String());
            AddColumn("dbo.Mobile", "Java", c => c.String());
            AddColumn("dbo.Mobile", "Battery", c => c.String());
            AddColumn("dbo.Mobile", "Color", c => c.String());
            AddColumn("dbo.Mobile", "SarEu", c => c.String());
            AddColumn("dbo.Mobile", "PriceGroup", c => c.String());
            DropColumn("dbo.Mobile", "CurrencyId");
            DropTable("dbo.Currency");
        }
        
        public override void Down()
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
            
            AddColumn("dbo.Mobile", "CurrencyId", c => c.Int(nullable: false));
            DropColumn("dbo.Mobile", "PriceGroup");
            DropColumn("dbo.Mobile", "SarEu");
            DropColumn("dbo.Mobile", "Color");
            DropColumn("dbo.Mobile", "Battery");
            DropColumn("dbo.Mobile", "Java");
            DropColumn("dbo.Mobile", "Browser");
            DropColumn("dbo.Mobile", "Messaging");
            DropColumn("dbo.Mobile", "Sensors");
            DropColumn("dbo.Mobile", "CommunicationUsb");
            DropColumn("dbo.Mobile", "CommunicationRadio");
            DropColumn("dbo.Mobile", "CommunicationNfc");
            DropColumn("dbo.Mobile", "CommunicationGps");
            DropColumn("dbo.Mobile", "CommunicationBluetooth");
            DropColumn("dbo.Mobile", "CommunicationWlan");
            DropColumn("dbo.Mobile", "SoundThreePointFivemmJack");
            DropColumn("dbo.Mobile", "SoundLoudSpeaker");
            DropColumn("dbo.Mobile", "SoundAlertTypes");
            DropColumn("dbo.Mobile", "CameraSecondary");
            DropColumn("dbo.Mobile", "CameraVideo");
            DropColumn("dbo.Mobile", "CameraFeatures");
            DropColumn("dbo.Mobile", "CameraPrimary");
            DropColumn("dbo.Mobile", "MemoryInternal");
            DropColumn("dbo.Mobile", "MemoryCardSlot");
            DropColumn("dbo.Mobile", "PlatformGpu");
            DropColumn("dbo.Mobile", "PlatformCpu");
            DropColumn("dbo.Mobile", "PlatformChipset");
            DropColumn("dbo.Mobile", "PlatformOS");
            DropColumn("dbo.Mobile", "DisplaySizeUnit");
            DropColumn("dbo.Mobile", "DisplaySize");
            DropColumn("dbo.Mobile", "MultiTouchNumberOfFingers");
            DropColumn("dbo.Mobile", "MultiTouch");
            DropColumn("dbo.Mobile", "ResolutionUnit");
            DropColumn("dbo.Mobile", "ResolutionBreadth");
            DropColumn("dbo.Mobile", "ResolutionLength");
            DropColumn("dbo.Mobile", "PpiPixelDensity");
            DropColumn("dbo.Mobile", "ScreenToBodyRatio");
            DropColumn("dbo.Mobile", "DisplayType");
            DropColumn("dbo.Mobile", "WeightUnit");
            DropColumn("dbo.Mobile", "WeightValue");
            DropColumn("dbo.Mobile", "DimensionUnit");
            DropColumn("dbo.Mobile", "DimensionHeight");
            DropColumn("dbo.Mobile", "DimensionBreadth");
            DropColumn("dbo.Mobile", "DimensionLength");
            DropColumn("dbo.Mobile", "LaunchStatus");
            DropColumn("dbo.Mobile", "LaunchDate");
            DropColumn("dbo.Mobile", "NetworkTechnology");
            DropColumn("dbo.Mobile", "Currency");
        }
    }
}
