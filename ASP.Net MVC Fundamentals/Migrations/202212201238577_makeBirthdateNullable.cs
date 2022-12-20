namespace ASP.Net_MVC_Fundamentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeBirthdateNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "birthdate", c => c.DateTime(nullable: false));
        }
    }
}
