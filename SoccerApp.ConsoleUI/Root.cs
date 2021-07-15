using SoccerApp.Entities.Abstract;

namespace SoccerApp.Entities.Concrete
{
    public class Root:BaseEntity
    {
        public HomeTeam HomeTeam { get; set; }
        public AwayTeam AwayTeam { get; set; }
        public Status Status { get; set; }
        public string Date { get; set; }
        public Tournament Tournament { get; set; }
        public Stage Stage { get; set; }
        public Round Round { get; set; }
    }
}
