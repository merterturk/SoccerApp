using SoccerApp.Dal.Abstract;
using SoccerApp.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoccerApp.Dal.Concrete.EntityFramework
{
    public class EfHomeTeamDal : IHomeTeamDal
    {
        private readonly SoccerContext _context;

        public EfHomeTeamDal(SoccerContext context)
        {
            _context = context;
        }
        public List<HomeTeamDto> GetAll()
        {
            var result = from h in _context.HomeTeams
                         join s in _context.Scores
                         on h.ScoreId equals s.Id
                         select new HomeTeamDto
                         {
                             Name = h.Name,
                             Current = s.Current,
                             ImageUrl = h.ImageUrl
                         };
            return result.ToList();
        }
    }
}
