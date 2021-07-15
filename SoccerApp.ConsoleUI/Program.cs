using Newtonsoft.Json;
using SoccerApp.ConsoleUI.Logger;
using SoccerApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SoccerApp.ConsoleUI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ApiHelper helper = new ApiHelper();

            await helper.GetSoccers();
        }
       
    }

}

