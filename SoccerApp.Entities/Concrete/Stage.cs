using SoccerApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.Entities.Concrete
{
    public class Stage:BaseEntity
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
