using SoccerApp.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.Dal.Abstract
{
    public interface IAwayTeamDal
    {
        List<AwayTeamDto> GetAll();
    }
}
