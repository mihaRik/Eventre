namespace Eventre.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEventAddTalkTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Talks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Subject = c.String(),
                        Venue = c.String(),
                        EventDayId = c.Int(nullable: false),
                        SpeakerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventDays", t => t.EventDayId, cascadeDelete: true)
                .ForeignKey("dbo.Speakers", t => t.SpeakerId, cascadeDelete: true)
                .Index(t => t.EventDayId)
                .Index(t => t.SpeakerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Talks", "SpeakerId", "dbo.Speakers");
            DropForeignKey("dbo.Talks", "EventDayId", "dbo.EventDays");
            DropIndex("dbo.Talks", new[] { "SpeakerId" });
            DropIndex("dbo.Talks", new[] { "EventDayId" });
            DropTable("dbo.Talks");
            DropTable("dbo.EventDays");
        }
    }
}
