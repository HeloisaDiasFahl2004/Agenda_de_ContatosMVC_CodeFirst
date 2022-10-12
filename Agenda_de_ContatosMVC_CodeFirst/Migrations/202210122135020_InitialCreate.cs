namespace Agenda_de_ContatosMVC_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Mail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mobile = c.String(),
                        Landline = c.String(),
                        IdPerson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.IdPerson, cascadeDelete: true)
                .Index(t => t.IdPerson);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "IdPerson", "dbo.People");
            DropIndex("dbo.Phones", new[] { "IdPerson" });
            DropTable("dbo.Phones");
            DropTable("dbo.People");
        }
    }
}
