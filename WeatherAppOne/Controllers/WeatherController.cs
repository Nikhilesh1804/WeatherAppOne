using Microsoft.AspNetCore.Mvc;
using Models;
using ServiceContracts;
using Services;

namespace WeatherAppOne.Controllers
{
    public class WeatherController : Controller
    {
        //     private List<CityWeather> cities = new List<CityWeather>() {
        // new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00"), TemperatureFahrenheit = 33 },

        // new CityWeather() { CityUniqueCode = "NYC", CityName = "New York", DateAndTime = Convert.ToDateTime("2030-01-01 3:00"), TemperatureFahrenheit = 60 },

        // new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"), TemperatureFahrenheit = 82 }
        //};
        private readonly IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }


        [Route("/")]
        [Route("/index")]
        public IActionResult Index()
        {
            List<CityWeather> cityWeathers = _weatherService.GetWeatherDetails();
            return View(cityWeathers);
        }

        [Route("weather/{cityCode}")]
        public IActionResult City(string cityCode)
        {

            if (string.IsNullOrEmpty(cityCode))
            {
                return View();
            }

            CityWeather? city = _weatherService.GetWeatherByCityCode(cityCode);
            return View(city);
        }
    }
}
