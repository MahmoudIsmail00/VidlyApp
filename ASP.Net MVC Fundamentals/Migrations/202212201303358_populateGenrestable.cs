namespace ASP.Net_MVC_Fundamentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenrestable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Name) Values('Comedy')");
            Sql("Insert into Genres (Name) Values('Action')");
            Sql("Insert into Genres (Name) Values('Horror')");
            Sql("Insert into Genres (Name) Values('Thriller')");
            Sql("Insert into Genres (Name) Values('Family')");
            Sql("Insert into Genres (Name) Values('Romance')");
            Sql("Insert into Genres (Name) Values('Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
