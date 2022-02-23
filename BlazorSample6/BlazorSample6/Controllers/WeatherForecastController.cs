using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using BlazorSample.Data;

namespace BlazorSample.Controllers
{
    [Authorize("App")]
    [Route("Weather")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastService weatherForecastService;

        public WeatherForecastController(WeatherForecastService service)
        {
            weatherForecastService = service;
        }
        [HttpGet]
        public async Task<WeatherForecast[]> GetWeatherForecast()
        {
            return await weatherForecastService.GetForecastAsync(System.DateTime.Now);
        }
    }
}
