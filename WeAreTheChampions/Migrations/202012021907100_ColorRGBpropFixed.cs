namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColorRGBpropFixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Colors", "Red", c => c.Byte(nullable: false));
            AddColumn("dbo.Colors", "Green", c => c.Byte(nullable: false));
            AddColumn("dbo.Colors", "Blue", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Colors", "Blue");
            DropColumn("dbo.Colors", "Green");
            DropColumn("dbo.Colors", "Red");
        }
    }
}
