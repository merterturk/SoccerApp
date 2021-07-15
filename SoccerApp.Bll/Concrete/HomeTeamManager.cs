using SoccerApp.Bll.Abstract;
using SoccerApp.Dal.Abstract;
using SoccerApp.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.Bll.Concrete
{
    public class HomeTeamManager : IHomeTeamService
    {
        private readonly IHomeTeamDal _homeTeamDal;

        public HomeTeamManager(IHomeTeamDal homeTeamDal)
        {
            _homeTeamDal = homeTeamDal;
        }
        public List<HomeTeamDto> GetAll()
        {
            return _homeTeamDal.GetAll();
        }
    }
}
