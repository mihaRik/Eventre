namespace Eventre.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSpeakerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Speakers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fullname = c.String(nullable: false, maxLength: 100),
                        Profession = c.String(nullable: false, maxLength: 100),
                        Image = c.String(nullable: false, maxLength: 100),
                        Facebook = c.String(nullable: false, maxLength: 100),
                        Twitter = c.String(nullable: false, maxLength: 100),
                        LinkedIn = c.String(nullable: false, maxLength: 100),
                        Pinterest = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Speakers");
        }
    }
}
