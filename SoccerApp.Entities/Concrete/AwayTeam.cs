using SoccerApp.Entities.Abstract;
using System.Collections.Generic;

namespace SoccerApp.Entities.Concrete
{
    public class AwayTeam:BaseEntity
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string MediumName { get; set; }
        public int ScoreId { get; set; }
        public string ImageUrl { get; set; }
        public Score Score { get; set; }
    }

    

   
}
