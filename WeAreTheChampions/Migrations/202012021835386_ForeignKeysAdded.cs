namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeysAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams");
            DropIndex("dbo.TeamColors", new[] { "TeamId" });
            DropPrimaryKey("dbo.TeamColors");
            AlterColumn("dbo.TeamColors", "TeamId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TeamColors", "TeamId");
            CreateIndex("dbo.Players", "TeamId");
            CreateIndex("dbo.TeamColors", "ColorId");
            AddForeignKey("dbo.Players", "TeamId", "dbo.Teams", "Id");
            AddForeignKey("dbo.TeamColors", "ColorId", "dbo.Colors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamColors", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropIndex("dbo.TeamColors", new[] { "ColorId" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropPrimaryKey("dbo.TeamColors");
            AlterColumn("dbo.TeamColors", "TeamId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.TeamColors", "TeamId");
            CreateIndex("dbo.TeamColors", "TeamId");
            AddForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams", "Id");
        }
    }
}
