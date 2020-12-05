namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColorConvertInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Colors", "Red", c => c.Int(nullable: false));
            AlterColumn("dbo.Colors", "Green", c => c.Int(nullable: false));
            AlterColumn("dbo.Colors", "Blue", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Colors", "Blue", c => c.Byte(nullable: false));
            AlterColumn("dbo.Colors", "Green", c => c.Byte(nullable: false));
            AlterColumn("dbo.Colors", "Red", c => c.Byte(nullable: false));
        }
    }
}
