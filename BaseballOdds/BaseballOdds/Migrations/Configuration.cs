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

            context.Teams.AddOrUpdate(s => s.Name,
                new Teams
                {
                    TeamId = 111,
                    Name = "Boston Red Sox",
                }, new Teams
                {
                    TeamId = 134,
                    Name = "Pittsburg Pirates",
                }, new Teams
                {
                    TeamId = 115,
                    Name = "Colorado Rockies",
                }, new Teams
                {
                    TeamId = 146,
                    Name = "Miami Marlins",
                }, new Teams
                {
                    TeamId = 116,
                    Name = "Detroit Tigers",
                }, new Teams
                {
                    TeamId = 138,
                    Name = "St. Louis Cardinals",
                }, new Teams
                {
                    TeamId = 118,
                    Name = "Kansas City Royals",
                }, new Teams
                {
                    TeamId = 140,
                    Name = "Texas Rangers",
                }, new Teams
                {
                    TeamId = 136,
                    Name = "Seattle Mariners",
                }, new Teams
                {
                    TeamId = 109,
                    Name = "Arizona Diamondbacks",
                }, new Teams
                {
                    TeamId = 110,
                    Name = "Baltimore Orioles",
                }, new Teams
                {
                    TeamId = 108,
                    Name = "Los Angeles Angels",
                }, new Teams
                {
                    TeamId = 112,
                    Name = "Chicago Cubs",
                }, new Teams
                {
                    TeamId = 114,
                    Name = "Cleveland Indians",
                }, new Teams
                {
                    TeamId = 137,
                    Name = "San Francisco Giants",
                }, new Teams
                {
                    TeamId = 120,
                    Name = "Washington Nationals",
                }, new Teams
                {
                    TeamId = 133,
                    Name = "Oakland Athletics",
                }, new Teams
                {
                    TeamId = 158,
                    Name = "Milwaukee Brewers",
                }, new Teams
                {
                    TeamId = 142,
                    Name = "Minnesota Twins",
                }, new Teams
                {
                    TeamId = 147,
                    Name = "New York Yankees",
                }, new Teams
                {
                    TeamId = 113,
                    Name = "Cincinnati Reds",
                }, new Teams
                {
                    TeamId = 145,
                    Name = "Chicago White Sox",
                }, new Teams
                {
                    TeamId = 139,
                    Name = "Tampa Bay Rays",
                }, new Teams
                {
                    TeamId = 117,
                    Name = "Houston Astros",
                }, new Teams
                {
                    TeamId = 135,
                    Name = "San Diego Padres",
                }, new Teams
                {
                    TeamId = 141,
                    Name = "Toronto Blue Jays",
                }, new Teams
                {
                    TeamId = 121,
                    Name = "New York Mets",
                }, new Teams
                {
                    TeamId = 119,
                    Name = "Los Angeles Dodgers",
                }, new Teams
                {
                    TeamId = 143,
                    Name = "Philadelphia Phillies",
                }, new Teams
                {
                    TeamId = 144,
                    Name = "Atlanta Braves",
                }
                );
        }



    }
}