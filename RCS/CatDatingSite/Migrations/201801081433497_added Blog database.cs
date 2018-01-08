namespace CatDatingSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBlogdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.BlogProfiles",
               c => new
               {
                   BlogID = c.Int(nullable: false, identity: true),
                   BlogName = c.String(),
                   BlogAuthor = c.String(),
                   BlogImage = c.String(),
               })
               .PrimaryKey(t => t.BlogID);

        }

        public override void Down()
        {
            DropTable("dbo.BlogProfiles");
        }
    }
}
