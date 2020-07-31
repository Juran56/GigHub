namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres (Id,Name) values(1,'Jazz')");
            Sql("insert into Genres (Id,Name) values(2,'Blues')");
            Sql("insert into Genres (Id,Name) values(3,'Classical')");
            Sql("insert into Genres (Id,Name) values(4,'60s')");
            Sql("insert into Genres (Id,Name) values(5,'Rock')");
            Sql("insert into Genres (Id,Name) values(6,'Country')");
        }
        
        public override void Down()
        {
            Sql("delete from genres where Id in(1,2,3,4,5,6)");
        }
    }
}
