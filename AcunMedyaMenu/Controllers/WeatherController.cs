using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace AcunMedyaMenu.Controllers
{
    public class WeatherController : Controller
    {

        public async Task<IActionResult> Index()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weather-api-by-any-city.p.rapidapi.com/weather/Ankara"),
                Headers =
    {
        { "x-rapidapi-key", "174ad316f9mshbf0d4051db01287p106cc5jsnf5c065333357" },
        { "x-rapidapi-host", "weather-api-by-any-city.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
            return View();
        }
    }
}