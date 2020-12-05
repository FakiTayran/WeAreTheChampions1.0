namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WeAreTheChampions.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WeAreTheChampions.Models.WeAreTheChampionsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WeAreTheChampions.Models.WeAreTheChampionsContext context)
        {
            if (!context.Teams.Any())
            {
                context.Teams.Add(new Team()
                {
                    TeamName = "ArıduruSport",
                });
                context.Teams.Add(new Team()
                {
                    TeamName = "OpponentSport",
                });
            }

            if (!context.Players.Any())
            {
                context.Players.Add(new Player()
                {
                    TeamId = 1,
                    PlayerName = "Tayran",
                });

                context.Players.Add(new Player()
                {
                    TeamId = 2,
                    PlayerName = "OppenentGamer",
                });
            }
            if (!context.Matches.Any())
            {
                context.Matches.Add(new Match()
                {
                    HomeTeamId = 1,
                    GuestTeamId = 2,
                    MatchTime = new DateTime(2020,12,03,19,00,00),
                    HomePoints = 1,
                    GuestPoints = 1,
                    Result = 0
                });
            }
            if (!context.Colors.Any())
            {
                context.Colors.Add(new Color()
                {
                    ColorName = "Kırmızı",
                    Red = 255,
                    Green = 0,
                    Blue = 0
                });
                context.Colors.Add(new Color()
                {
                    ColorName = "Yeşil",
                    Red = 0,
                    Green = 255,
                    Blue = 0
                });
            }
        }
    }
}
