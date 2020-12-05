using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public class WeAreTheChampionsContext : DbContext
    {
        public WeAreTheChampionsContext() : base("name=WeAreTheChampionsContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasRequired(x => x.HomeTeam)
                .WithMany(x => x.HomeMatches)
                .HasForeignKey(x => x.HomeTeamId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Match>()
                .HasRequired(x => x.GuestTeam)
                .WithMany(x => x.AwayMatches)
                .HasForeignKey(x => x.GuestTeamId)
                .WillCascadeOnDelete(false);
         
    }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Match> Matches { get; set; }

}
}
