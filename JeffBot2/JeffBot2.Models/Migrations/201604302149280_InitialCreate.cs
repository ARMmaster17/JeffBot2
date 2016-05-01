namespace JeffBot2.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ncs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        A = c.String(),
                        B = c.String(),
                        C = c.String(),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ncs");
        }
    }
}
