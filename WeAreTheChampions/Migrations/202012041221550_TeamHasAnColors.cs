namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamHasAnColors : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teams", "ColorId", "dbo.Colors");
            DropIndex("dbo.Teams", new[] { "ColorId" });
            CreateTable(
                "dbo.TeamColors",
                c => new
                    {
                        Team_Id = c.Int(nullable: false),
                        Color_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Team_Id, t.Color_Id })
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .ForeignKey("dbo.Colors", t => t.Color_Id, cascadeDelete: true)
                .Index(t => t.Team_Id)
                .Index(t => t.Color_Id);
            
            DropColumn("dbo.Teams", "ColorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "ColorId", c => c.Int());
            DropForeignKey("dbo.TeamColors", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.TeamColors", "Team_Id", "dbo.Teams");
            DropIndex("dbo.TeamColors", new[] { "Color_Id" });
            DropIndex("dbo.TeamColors", new[] { "Team_Id" });
            DropTable("dbo.TeamColors");
            CreateIndex("dbo.Teams", "ColorId");
            AddForeignKey("dbo.Teams", "ColorId", "dbo.Colors", "Id");
        }
    }
}
