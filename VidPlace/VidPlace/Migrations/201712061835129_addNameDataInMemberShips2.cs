namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNameDataInMemberShips2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes Set Name='Pay as You Go' WHERE ID='1'");
            Sql("UPDATE MemberShipTypes Set Name='Monthly' WHERE ID='2'");
            Sql("UPDATE MemberShipTypes Set Name='Quaterly' WHERE ID='3'");
            Sql("UPDATE MemberShipTypes Set Name='Annual' WHERE ID='4'");
        }
        
        public override void Down()
        {
        }
    }
}
