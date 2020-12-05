namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixAddSomeForeignKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TeamColors");
            AlterColumn("dbo.TeamColors", "TeamId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.TeamColors", "TeamId");
            CreateIndex("dbo.TeamColors", "TeamId");
            AddForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams");
            DropIndex("dbo.TeamColors", new[] { "TeamId" });
            DropPrimaryKey("dbo.TeamColors");
            AlterColumn("dbo.TeamColors", "TeamId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TeamColors", "TeamId");
        }
    }
}
