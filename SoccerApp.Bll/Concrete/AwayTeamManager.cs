using SoccerApp.Bll.Abstract;
using SoccerApp.Dal.Abstract;
using SoccerApp.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.Bll.Concrete
{
    public class AwayTeamManager : IAwayTeamService
    {
        private readonly IAwayTeamDal _awayTeamDal;

        public AwayTeamManager(IAwayTeamDal awayTeamDal)
        {
            _awayTeamDal = awayTeamDal;
        }
        public List<AwayTeamDto> GetAll()
        {
            return _awayTeamDal.GetAll();
        }
    }
}
