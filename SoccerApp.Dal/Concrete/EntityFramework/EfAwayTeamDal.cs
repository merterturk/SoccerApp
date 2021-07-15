using SoccerApp.Dal.Abstract;
using SoccerApp.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoccerApp.Dal.Concrete.EntityFramework
{
    public class EfAwayTeamDal : IAwayTeamDal
    {
        private readonly SoccerContext _context;

        public EfAwayTeamDal(SoccerContext context)
        {
            _context = context;
        }
        public List<AwayTeamDto> GetAll()
        {
            var result = from a in _context.AwayTeams
                         join s in _context.Scores
                         on a.ScoreId equals s.Id
                         select new AwayTeamDto
                         {
                             Name = a.Name,
                             Current = s.Current,
                             ImageUrl = a.ImageUrl
                         };
            return result.ToList();
        }
    }
}

