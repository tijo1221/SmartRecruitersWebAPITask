using Newtonsoft.Json;

namespace GetCurrentWeatherWebAPI.Models
{
    public class Weather
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("main")]
        public string? MainWeather { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("icon")]
        public string? Icon { get; set; }
    }
}
