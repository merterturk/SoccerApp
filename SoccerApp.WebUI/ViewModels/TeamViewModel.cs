using SoccerApp.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerApp.WebUI.ViewModels
{
    public class TeamViewModel
    {
        public List<AwayTeamDto> AwayTeams { get; set; }

        public List<HomeTeamDto> HomeTeams { get; set; }
    }
}
