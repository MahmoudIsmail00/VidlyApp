namespace ASP.Net_MVC_Fundamentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingTypeofIsSubscribedToNewsLetter : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Byte(nullable: false));
        }
    }
}
