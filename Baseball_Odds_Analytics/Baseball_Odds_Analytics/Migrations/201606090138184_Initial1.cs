namespace Baseball_Odds_Analytics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Odds", "HomeOdds", c => c.Double(nullable: false));
            AddColumn("dbo.Odds", "AwayOdds", c => c.Double(nullable: false));
            DropColumn("dbo.Odds", "BestOdds");
            DropColumn("dbo.Odds", "WorseOdds");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Odds", "WorseOdds", c => c.Double(nullable: false));
            AddColumn("dbo.Odds", "BestOdds", c => c.Double(nullable: false));
            DropColumn("dbo.Odds", "AwayOdds");
            DropColumn("dbo.Odds", "HomeOdds");
        }
    }
}
