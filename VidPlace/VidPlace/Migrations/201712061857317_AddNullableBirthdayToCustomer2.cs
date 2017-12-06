namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullableBirthdayToCustomer2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime());
            DropColumn("dbo.Customers", "DoB");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DoB", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthday");
        }
    }
}
