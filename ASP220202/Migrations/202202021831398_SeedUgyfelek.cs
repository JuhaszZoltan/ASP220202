namespace ASP220202.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUgyfelek : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Ugyfels (Nev) VALUES ('Cserepes Virág');");
            Sql("INSERT INTO Ugyfels (Nev) VALUES ('Lapos Elemér');");
        }

        public override void Down()
        {
        }
    }
}
