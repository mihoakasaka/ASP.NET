namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BrandId = c.Byte(nullable: false),
                        ScreenSize = c.String(),
                        PhoneTypeId = c.Byte(nullable: false),
                        Brand_ID = c.Int(),
                        PhoneType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brands", t => t.Brand_ID)
                .ForeignKey("dbo.PhoneTypes", t => t.PhoneType_ID)
                .Index(t => t.Brand_ID)
                .Index(t => t.PhoneType_ID);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        CountryOfOrigin = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PhoneTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        OS = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "PhoneType_ID", "dbo.PhoneTypes");
            DropForeignKey("dbo.Phones", "Brand_ID", "dbo.Brands");
            DropIndex("dbo.Phones", new[] { "PhoneType_ID" });
            DropIndex("dbo.Phones", new[] { "Brand_ID" });
            DropTable("dbo.PhoneTypes");
            DropTable("dbo.Brands");
            DropTable("dbo.Phones");
        }
    }
}
