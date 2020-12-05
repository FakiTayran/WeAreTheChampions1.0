namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamColors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamColors",
                c => new
                    {
                        TeamId = c.Int(nullable: false),
                        ColorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams");
            DropIndex("dbo.TeamColors", new[] { "TeamId" });
            DropTable("dbo.TeamColors");
        }
    }
}
