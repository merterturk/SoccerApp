using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SoccerApp.Bll.Abstract;
using SoccerApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAwayTeamService _awayTeamService;
        private readonly IHomeTeamService _homeTeamService;

        public HomeController(ILogger<HomeController> logger, IAwayTeamService awayTeamService, IHomeTeamService homeTeamService)
        {
            _logger = logger;
            _awayTeamService = awayTeamService;
            _homeTeamService = homeTeamService;

        }

        public IActionResult Index()
        {
            var model = new TeamViewModel
            {
                AwayTeams = _awayTeamService.GetAll(),
                HomeTeams = _homeTeamService.GetAll()
            };
            return View(model);
        }
    }
}
