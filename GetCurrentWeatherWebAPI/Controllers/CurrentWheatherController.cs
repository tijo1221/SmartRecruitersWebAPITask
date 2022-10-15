using GetCurrentWeatherWebAPI.Models;
using GetCurrentWeatherWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GetCurrentWeatherWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentWheatherController : ControllerBase
    {
        private readonly string APIKEY;

        public CurrentWheatherController(IConfiguration iConfig)
        {            
            APIKEY = iConfig.GetValue<string>("APIKey");
        }

        /// <summary>
        /// Get Current Weather data by city name
        /// URL https://localhost:7199/api/CurrentWheather?cityName=''
        /// </summary>
        /// <param name="cityName"></param>
        /// <returns></returns>
        
        [HttpGet]       
        public ActionResult GetCurrentCityWheather([FromQuery]string cityName)
        {
            HttpClient http = new HttpClient();
            
            try
            {
                string openweathermapURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={APIKEY}";

                var data = http.GetAsync(openweathermapURL).Result.Content.ReadAsStringAsync().Result;

                if (data.Contains("message"))
                {
                    return NotFound();
                }

                var resultWeatherMap = JsonConvert.DeserializeObject<RootWeatherInputModel>(data);

                if(resultWeatherMap != null)
                {
                    var cityWeather = WeatherOutputService.CreateCityWeatherOutput(resultWeatherMap);

                    var cityWeatherResult = JsonConvert.SerializeObject(cityWeather, Formatting.Indented);

                    return Ok(cityWeatherResult);
                }
                else
                {
                    return NotFound();
                }
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
