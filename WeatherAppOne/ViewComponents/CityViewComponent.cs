using Microsoft.AspNetCore.Mvc;
using Models;

namespace WeatherAppOne.ViewComponents
{
    public class CityViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather city)
        {
            return View("Default", city);
        }
    }
}
