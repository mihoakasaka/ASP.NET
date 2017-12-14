namespace SurveyOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSurveyClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Surveys", "SurveyQuestion", c => c.String(nullable: false));
            AlterColumn("dbo.Surveys", "Autohor", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Surveys", "Autohor", c => c.String(nullable: false));
            AlterColumn("dbo.Surveys", "SurveyQuestion", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
