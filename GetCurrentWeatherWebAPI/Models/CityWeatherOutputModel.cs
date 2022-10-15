using Newtonsoft.Json;

namespace GetCurrentWeatherWebAPI.Models
{
    public class CityWeatherOutputModel
    {
        [JsonProperty("CityName")]
        public string? CityName { get; set; }


        [JsonProperty("Timezone")]
        public int? Timezone { get; set; }


        [JsonProperty("CountryName")]
        public string? CountryName { get; set; }


        [JsonProperty("Longitude")]
        public double? Longitude { get; set; }


        [JsonProperty("Latitude")]
        public double? Latitude { get; set; }


        [JsonProperty("Sunrise")]
        public int? Sunrise { get; set; }


        [JsonProperty("Sunset")]
        public int? Sunset { get; set; }


        [JsonProperty("MainWeather")]
        public string? MainWeather { get; set; }


        [JsonProperty("Description")]
        public string? Description { get; set; }


        [JsonProperty("WindSpeed")]
        public double? WindSpeed { get; set; }


        [JsonProperty("WindDirection")]
        public int? WindDirection { get; set; }


        [JsonProperty("Temperature")]
        public double? Temperature { get; set; }


        [JsonProperty("Feels_Like")]
        public double? Feels_Like { get; set; }


        [JsonProperty("Minimum_Temperature")]
        public double? Minimum_Temperature { get; set; }


        [JsonProperty("Maximum_Temperature")]
        public double? Maximum_Temperature { get; set; }


        [JsonProperty("Pressure")]
        public int? Pressure { get; set; }


        [JsonProperty("Humidity")]
        public int? Humidity { get; set; }
    }
}
