namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemepershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonth, DiscountPercentage) Values(1,0,0,0)");
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonth, DiscountPercentage) Values(2,30,1,10)");
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonth, DiscountPercentage) Values(3,90,3,15)");
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonth, DiscountPercentage) Values(4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
