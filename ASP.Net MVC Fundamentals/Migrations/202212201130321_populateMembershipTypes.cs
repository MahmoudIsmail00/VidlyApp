namespace ASP.Net_MVC_Fundamentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes (Id, SignUpFee, DurationInMonths, Discount) Values(1,0,0,0)");
            Sql("Insert Into MembershipTypes (Id, SignUpFee, DurationInMonths, Discount) Values(2,30,1,10)");
            Sql("Insert Into MembershipTypes (Id, SignUpFee, DurationInMonths, Discount) Values(3,90,3,15)");
            Sql("Insert Into MembershipTypes (Id, SignUpFee, DurationInMonths, Discount) Values(4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
