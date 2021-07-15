using SoccerApp.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.Bll.Abstract
{
    public interface IAwayTeamService
    {
        List<AwayTeamDto> GetAll();
    }
}
