using SoccerApp.Entities.Abstract;

namespace SoccerApp.Entities.Concrete
{
    public class Round:BaseEntity
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
