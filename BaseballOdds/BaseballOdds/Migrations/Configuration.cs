namespace BaseballOdds.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BaseballOdds.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        protected override void Seed(ApplicationDbContext context)
        {
            context.Odds.AddOrUpdate(p => p.HomeTeam,
                new Odds
                {
                    HomeTeam = "Baltimore Orioles",
                    AwayTeam = "Kansas City Royals",
                    Date = DateTime.Today,
                    HomeOdds = 1.58,
                    AwayOdds = 2.63,
                }, new Odds
                {
                    HomeTeam = "New York Yankees",
                    AwayTeam = "Los Angeles Angels",
                    Date = DateTime.Today,
                    HomeOdds = 1.67,
                    AwayOdds = 2.35,
                }, new Odds
                {
                    HomeTeam = "Pittsburg Pirates",
                    AwayTeam = "New York Mets",
                    Date = DateTime.Today,
                    HomeOdds = 1.40,
                    AwayOdds = 3.50,
                }, new Odds
                {
                    HomeTeam = "Cincinnati Reds",
                    AwayTeam = "St Louis Cardinals",
                    Date = DateTime.Today,
                    HomeOdds = 3.40,
                    AwayOdds = 1.64,
                }, new Odds
                {
                    HomeTeam = "Texas Rangers",
                    AwayTeam = "Houston Astros",
                    Date = DateTime.Today,
                    HomeOdds = 1.96,
                    AwayOdds = 2.55,
                }, new Odds
                {
                    HomeTeam = "Minnesota Twins",
                    AwayTeam = "Miami Marlins",
                    Date = DateTime.Today,
                    HomeOdds = 1.95,
                    AwayOdds = 2.05,
                }, new Odds
                {
                    HomeTeam = "Milwaukee Brewers",
                    AwayTeam = "Oakland Athletics",
                    Date = DateTime.Today,
                    HomeOdds = 1.81,
                    AwayOdds = 2.25,
                }, new Odds
                {
                    HomeTeam = "Chicago White Sox",
                    AwayTeam = "Washington Nationals",
                    Date = DateTime.Today,
                    HomeOdds = 2.60,
                    AwayOdds = 1.67,
                }, new Odds
                {
                    HomeTeam = "Seattle Mariners",
                    AwayTeam = "Cleveland Indians",
                    Date = DateTime.Today,
                    HomeOdds = 1.92,
                    AwayOdds = 2.05,
                }, new Odds
                {
                    HomeTeam = "Los Angeles Dodgers",
                    AwayTeam = "Colorado Rockies",
                    Date = DateTime.Today,
                    HomeOdds = 1.57,
                    AwayOdds = 2.65,
                }, new Odds
                {
                    HomeTeam = "San Francisco Giants",
                    AwayTeam = "Boston Red Sox",
                    Date = DateTime.Today,
                    HomeOdds = 2.15,
                    AwayOdds = 1.83,
                }

                );


            );

        }



    }
}