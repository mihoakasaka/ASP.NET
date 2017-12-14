namespace SurveyOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSurveyClass3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Surveys", "Topic_ID", "dbo.Topics");
            DropIndex("dbo.Surveys", new[] { "Topic_ID" });
            AlterColumn("dbo.Surveys", "Deadline", c => c.DateTime());
            AlterColumn("dbo.Surveys", "Topic_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Surveys", "Topic_ID");
            AddForeignKey("dbo.Surveys", "Topic_ID", "dbo.Topics", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Surveys", "Topic_ID", "dbo.Topics");
            DropIndex("dbo.Surveys", new[] { "Topic_ID" });
            AlterColumn("dbo.Surveys", "Topic_ID", c => c.Int());
            AlterColumn("dbo.Surveys", "Deadline", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Surveys", "Topic_ID");
            AddForeignKey("dbo.Surveys", "Topic_ID", "dbo.Topics", "ID");
        }
    }
}
