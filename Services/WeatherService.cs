﻿using Models;
using ServiceContracts;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        private List<CityWeather> _cities = new List<CityWeather>() {
    new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00"), TemperatureFahrenheit = 33 },

    new CityWeather() { CityUniqueCode = "NYC", CityName = "New York", DateAndTime = Convert.ToDateTime("2030-01-01 3:00"), TemperatureFahrenheit = 60 },

    new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"), TemperatureFahrenheit = 82 }
   };


        public CityWeather? GetWeatherByCityCode(string CityCode)
        {
            CityWeather? city = _cities.Where(c => c.CityUniqueCode == CityCode).FirstOrDefault();
            return city;
        }

        public List<CityWeather> GetWeatherDetails()
        {
            return _cities;
        }
    }
}