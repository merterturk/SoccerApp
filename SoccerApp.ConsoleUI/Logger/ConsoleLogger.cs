using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.ConsoleUI.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string information)
        {
            Console.WriteLine(information);
        }
    }
}
