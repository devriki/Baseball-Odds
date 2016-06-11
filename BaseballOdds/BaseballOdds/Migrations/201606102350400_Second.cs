namespace BaseballOdds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Games = c.Double(nullable: false),
                    Wins = c.Double(nullable: false),
                    Losses = c.Double(nullable: false),
                    RunsScored = c.Double(nullable: false),
                    RunsAgainst = c.Double(nullable: false),
                    TeamId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
        }
    }
}
