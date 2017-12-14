namespace SurveyOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserClass2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FName = c.String(nullable: false, maxLength: 255),
                        LName = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        AnnualIncome = c.String(nullable: false),
                        Survey = c.String(),
                        SurveyId = c.Byte(nullable: false),
                        SurveyAnswer = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
