using Newtonsoft.Json;
using SoccerApp.ConsoleUI.Logger;
using SoccerApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp.ConsoleUI
{
    public class ApiHelper
    {
        private readonly ILogger _logger = new ConsoleLogger();
        private readonly Uri mainUrl = new Uri(ApiOptions.BaseUrl);
        public async Task GetSoccers()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = mainUrl;
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", ApiOptions.Token);
                client.DefaultRequestHeaders.Add("languageId", ApiOptions.LanguageId.ToString());
                HttpResponseMessage response = await client.GetAsync(ApiOptions.BaseUrl);
                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var dataResponse = readTask.GetAwaiter().GetResult();
                    var root = JsonConvert.DeserializeObject<List<Root>>(dataResponse);

                    foreach (var item in root)
                    {
                        Console.WriteLine($"Id:{item.Id}/Date:{item.Date}");
                        Console.WriteLine($"AwayTeamId:{item.AwayTeam.Id}/ AwayTeamName:{item.AwayTeam.Name}/ AwayTeamMediumName:{item.AwayTeam.MediumName}/ AwayTeamShortName:{item.AwayTeam.ShortName}");
                        Console.WriteLine($"HomeTeamId:{item.HomeTeam.Id}/ HomeTeamName:{item.HomeTeam.Name}/ HomeTeamMediumName:{item.HomeTeam.MiddleName}/ HomeTeamShortName:{item.HomeTeam.ShortName}");
                     //Dataları Database'e yazdır.
                    }
                }
                else
                {
                    _logger.Log($"{DateTime.Now} Api Error: {response.StatusCode}");
                }

            }
        }
    }
}
