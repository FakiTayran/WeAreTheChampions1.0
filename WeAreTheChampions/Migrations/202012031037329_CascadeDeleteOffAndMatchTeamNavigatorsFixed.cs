namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CascadeDeleteOffAndMatchTeamNavigatorsFixed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchTime = c.DateTime(),
                        HomeTeamId = c.Int(nullable: false),
                        GuestTeamId = c.Int(nullable: false),
                        HomePoints = c.Int(),
                        GuestPoints = c.Int(),
                        Result = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.GuestTeamId)
                .ForeignKey("dbo.Teams", t => t.HomeTeamId)
                .Index(t => t.HomeTeamId)
                .Index(t => t.GuestTeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "HomeTeamId", "dbo.Teams");
            DropForeignKey("dbo.Matches", "GuestTeamId", "dbo.Teams");
            DropIndex("dbo.Matches", new[] { "GuestTeamId" });
            DropIndex("dbo.Matches", new[] { "HomeTeamId" });
            DropTable("dbo.Matches");
        }
    }
}
