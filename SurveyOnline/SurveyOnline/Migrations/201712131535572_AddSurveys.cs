namespace SurveyOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSurveys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        SurveyQuestion = c.String(nullable: false, maxLength: 255),
                        TopicId = c.Byte(nullable: false),
                        Autohor = c.String(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                        Topic_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Topics", t => t.Topic_ID, cascadeDelete: true)
                .Index(t => t.Topic_ID);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Surveys", "Topic_ID", "dbo.Topics");
            DropIndex("dbo.Surveys", new[] { "Topic_ID" });
            DropTable("dbo.Topics");
            DropTable("dbo.Surveys");
        }
    }
}
