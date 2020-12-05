namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamsColorTableDeleted : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TeamColors", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams");
            DropIndex("dbo.TeamColors", new[] { "TeamId" });
            DropIndex("dbo.TeamColors", new[] { "ColorId" });
            AddColumn("dbo.Teams", "ColorId", c => c.Int());
            CreateIndex("dbo.Teams", "ColorId");
            AddForeignKey("dbo.Teams", "ColorId", "dbo.Colors", "Id");
            DropTable("dbo.TeamColors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TeamColors",
                c => new
                    {
                        TeamId = c.Int(nullable: false),
                        ColorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId);
            
            DropForeignKey("dbo.Teams", "ColorId", "dbo.Colors");
            DropIndex("dbo.Teams", new[] { "ColorId" });
            DropColumn("dbo.Teams", "ColorId");
            CreateIndex("dbo.TeamColors", "ColorId");
            CreateIndex("dbo.TeamColors", "TeamId");
            AddForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams", "Id");
            AddForeignKey("dbo.TeamColors", "ColorId", "dbo.Colors", "Id", cascadeDelete: true);
        }
    }
}
