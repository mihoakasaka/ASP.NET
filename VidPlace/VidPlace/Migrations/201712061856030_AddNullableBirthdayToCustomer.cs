namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullableBirthdayToCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DoB", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DoB", c => c.DateTime(nullable: false));
        }
    }
}
