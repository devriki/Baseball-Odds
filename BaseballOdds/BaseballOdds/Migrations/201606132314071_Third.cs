namespace BaseballOdds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teams", "Games");
            DropColumn("dbo.Teams", "Wins");
            DropColumn("dbo.Teams", "Losses");
            DropColumn("dbo.Teams", "RunsScored");
            DropColumn("dbo.Teams", "RunsAgainst");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "RunsAgainst", c => c.Double(nullable: false));
            AddColumn("dbo.Teams", "RunsScored", c => c.Double(nullable: false));
            AddColumn("dbo.Teams", "Losses", c => c.Double(nullable: false));
            AddColumn("dbo.Teams", "Wins", c => c.Double(nullable: false));
            AddColumn("dbo.Teams", "Games", c => c.Double(nullable: false));
        }
    }
}
