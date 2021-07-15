using SoccerApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.Entities.Concrete
{
    public class HomeTeam : BaseEntity
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string MiddleName { get; set; }
        public int ScoreId { get; set; }
        public string ImageUrl { get; set; }
        public Score Score { get; set; }

    }
}
