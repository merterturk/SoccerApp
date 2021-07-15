using Microsoft.EntityFrameworkCore;
using SoccerApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.Dal.Concrete.EntityFramework
{
    public class SoccerContext:DbContext
    {
        
        public SoccerContext(DbContextOptions<SoccerContext> options):base(options)
        {

        }
        public DbSet<AwayTeam> AwayTeams { get; set; }
        public DbSet<HomeTeam> HomeTeams { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
    }
}
