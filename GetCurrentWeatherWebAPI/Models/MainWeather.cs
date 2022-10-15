using Newtonsoft.Json;

namespace GetCurrentWeatherWebAPI.Models
{
    public class MainWeather
    {
        [JsonProperty("temp")]
        public double? Temperature { get; set; }

        [JsonProperty("feels_like")]
        public double? Feels_Like { get; set; }

        [JsonProperty("temp_min")]
        public double? Minimum_Temperature { get; set; }

        [JsonProperty("temp_max")]
        public double? Maximum_Temperature { get; set; }

        [JsonProperty("pressure")]
        public int? Pressure { get; set; }

        [JsonProperty("humidity")]
        public int? Humidity { get; set; }
    }
}
