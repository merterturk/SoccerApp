using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.Entities.Concrete
{
    public class Score
    {
        public Score()
        {
            AwayTeams = new List<AwayTeam>();
            HomeTeams = new List<HomeTeam>();
        }
        public int Id { get; set; }
        public int Regular { get; set; }
        public int HalfTime { get; set; }
        public int Current { get; set; }

        public ICollection<AwayTeam> AwayTeams { get; set; }
        public ICollection<HomeTeam> HomeTeams { get; set; }
    }
}
