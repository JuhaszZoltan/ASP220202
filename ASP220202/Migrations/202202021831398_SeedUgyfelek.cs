namespace ASP220202.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUgyfelek : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Ugyfels (Nev) VALUES ('Cserepes Vir�g');");
            Sql("INSERT INTO Ugyfels (Nev) VALUES ('Lapos Elem�r');");
        }

        public override void Down()
        {
        }
    }
}
