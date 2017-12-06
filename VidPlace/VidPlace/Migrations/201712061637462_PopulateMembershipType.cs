namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (ID, SignUpFee,DurationInMonth,DiscountRate) VALUES (1,0,0,0)" );
            Sql("INSERT INTO MembershipTypes (ID, SignUpFee,DurationInMonth,DiscountRate) VALUES (2,10,1,10)");
            Sql("INSERT INTO MembershipTypes (ID, SignUpFee,DurationInMonth,DiscountRate) VALUES (3,30,3,15)");
            Sql("INSERT INTO MembershipTypes (ID, SignUpFee,DurationInMonth,DiscountRate) VALUES (4,100,12,20)");

        }
        
        public override void Down()
        {
        }
    }
}
