using GetCurrentWeatherWebAPI.Models;

namespace GetCurrentWeatherWebAPI.Services
{
    public static class WeatherOutputService
    {
        /// <summary>
        /// Create Weather Output for the city from open-weather-map API input
        /// </summary>
        /// <param name="resultWeatherMap"></param>
        /// <returns></returns>
        public static CityWeatherOutputModel CreateCityWeatherOutput(RootWeatherInputModel resultWeatherMap)
        {

            CityWeatherOutputModel cityWeather = new CityWeatherOutputModel
            {
                CityName = resultWeatherMap.CityName,
                Timezone = resultWeatherMap.Timezone,
                CountryName = resultWeatherMap.WeatherSystem.Country,
                Latitude = resultWeatherMap.Coordinate.Latitude,
                Longitude = resultWeatherMap.Coordinate.Longitude,
                Sunrise = resultWeatherMap.WeatherSystem.Sunrise,
                Sunset = resultWeatherMap.WeatherSystem.Sunset,
                MainWeather = resultWeatherMap.Weather.Count != 0 ? resultWeatherMap.Weather[0].MainWeather : string.Empty,
                Description = resultWeatherMap.Weather.Count != 0 ? resultWeatherMap.Weather[0].Description : string.Empty,
                WindSpeed = resultWeatherMap.Wind.Speed,
                WindDirection = resultWeatherMap.Wind.Direction,
                Temperature = resultWeatherMap.MainWeather.Temperature,
                Feels_Like = resultWeatherMap.MainWeather.Feels_Like,
                Minimum_Temperature = resultWeatherMap.MainWeather.Minimum_Temperature,
                Maximum_Temperature = resultWeatherMap.MainWeather.Maximum_Temperature,
                Pressure = resultWeatherMap.MainWeather.Pressure,
                Humidity = resultWeatherMap.MainWeather.Humidity,
            };
            return cityWeather;
        }
    }
}
