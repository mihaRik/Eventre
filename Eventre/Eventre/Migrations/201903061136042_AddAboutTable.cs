namespace Eventre.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAboutTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        ContentUp = c.String(nullable: false, maxLength: 500),
                        ContentDown = c.String(nullable: false, maxLength: 500),
                        Image = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abouts");
        }
    }
}
