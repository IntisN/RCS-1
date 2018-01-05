namespace CatDatingSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CatProfiles",
                c => new
                    {
                        CatID = c.Int(nullable: false, identity: true),
                        CatName = c.String(),
                        CatAge = c.Int(nullable: false),
                        CatImage = c.String(),
                    })
                .PrimaryKey(t => t.CatID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CatProfiles");
        }
    }
}
