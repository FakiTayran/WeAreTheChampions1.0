namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
        }
    }
}
